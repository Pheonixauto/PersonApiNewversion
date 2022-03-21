﻿using Atlassian.Jira;
using Newtonsoft.Json;
using PersonApi.DTO.Jira;
using System.Text;

namespace PersonApi.Services.HttpClientService
{
    public class ClientService : IClientService
    {
        public ClientService() { } 
        public async Task<List<string>> CheckInforProjectByUser(string account,
                                                                string password,
                                                                string member,
                                                                Dictionary<string, string> keyproject)
        {
            var byteArray = new UTF8Encoding().GetBytes($"{account}:{password}");
            List<string> listproject = new List<string>();
            foreach (var key in keyproject)
            {
                var url = $"https://jira.aisolutions.com.vn/rest/api/2/user/permission/search?username={member}&projectKey={key.Key}&permissions=BROWSE";
                using (var client = new HttpClient())
                {
                    using (var requestmessage = new HttpRequestMessage(HttpMethod.Get, url))
                    {
                        requestmessage.Headers.Add("Authorization",
                                                   $"Basic {Convert.ToBase64String(byteArray)}");
                        requestmessage.Method = HttpMethod.Get;
                        var response = await client.SendAsync(requestmessage);
                        if (response.IsSuccessStatusCode)
                        {
                            var result = await response.Content
                                                       .ReadFromJsonAsync
                                                        <List<JiraCheckInforPermission>>();
                            if (result!.Count > 0)
                            {
                                listproject.Add(key.Value);
                            }
                        }
                    }
                }
            }
            return listproject;
        }
        public async Task<Dictionary<string, string>> GetAllKeysProjects(string account,
                                                                         string password)
        {
            var url = "https://jira.aisolutions.com.vn/rest/api/2/project";
            var byteArray = new UTF8Encoding().GetBytes($"{account}:{password}");
            using (var client = new HttpClient())
            {
                using (var requestmessage = new HttpRequestMessage(HttpMethod.Get, url))
                {
                    requestmessage.Headers.Add("Authorization",
                                                $"Basic {Convert.ToBase64String(byteArray)}");
                    requestmessage.Method = HttpMethod.Get;
                    var response = await client.SendAsync(requestmessage);
                    var result = await response.Content.ReadAsStringAsync();
                    var project = JsonConvert.DeserializeObject<List<ProjectJira>>(result);
                    var keys = project?.Select(x => new { Key = x.key, NameProject = x.name });
                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
                    foreach (var key in keys!)
                    {
                        keyValuePairs.Add(key.Key, key.NameProject);
                    }
                    return keyValuePairs;
                }
            }
        }
        public async Task<JiraUser> Getmyselfcompanyjira(string account,
                                                         string password, string member)
        {
            var byteArray = new UTF8Encoding().GetBytes($"{account}:{password}");
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Accept", "application/json");
            var urlgetmyself = $"https://jira.aisolutions.com.vn/rest/api/2/user?username={member}";
            using (var client = new HttpClient())
            {
                using (var requestmessage = new HttpRequestMessage(HttpMethod.Get, urlgetmyself))
                {
                    requestmessage.Headers.Add("Authorization",
                                                $"Basic {Convert.ToBase64String(byteArray)}");
                    var response = await client.SendAsync(requestmessage);
                    var result = await response.Content.ReadAsStringAsync();
                    return null;
                }
            }
            return null;
        }
        public async Task<dynamic> UpdateUser(string account, string password,string userKey, UpdateUserJira updateUserJira)
        {
            var byteArray = new UTF8Encoding().GetBytes($"{account}:{password}");
            var urlgetmyself = $"https://jira.aisolutions.com.vn/rest/api/2/user?key={userKey}";
            using (var client = new HttpClient())
            {
                using (var requestmessage = new HttpRequestMessage(HttpMethod.Put, urlgetmyself))
                {
                    requestmessage.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(byteArray)}");
                    requestmessage.Method = HttpMethod.Put;
                    requestmessage.Content = new StringContent(
                                                   JsonConvert.SerializeObject(updateUserJira),
                                                   System.Text.Encoding.UTF8, "application/json");
                    var response = await client.SendAsync(requestmessage);
                    return response;
                }
            }
        }
    }
}
