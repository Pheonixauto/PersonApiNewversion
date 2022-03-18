using Atlassian.Jira;
using Newtonsoft.Json;
using PersonApi.DTO.Jira;

namespace PersonApi.Services.HttpClientService
{
    public class ClientService : IClientService
    {
        public ClientService()
        {
        }

        public async Task<List<string>> CheckInforProjectByUser(string userName, Dictionary<string, string> keyproject)
        {
            List<string> listproject = new List<string>();
            foreach (var key in keyproject)
            {
                var url = $"https://jira.aisolutions.com.vn/rest/api/2/user/permission/search?username={userName}&projectKey={key.Key}&permissions=BROWSE";
                using (var client = new HttpClient())
                {
                    using (var requestmessage = new HttpRequestMessage(HttpMethod.Get, url))
                    {
                        requestmessage.Headers.Add("Authorization", "Basic amlyYXRlc3Q6UEBzczEyMzQ1");
                        requestmessage.Method = HttpMethod.Get;
                        var response = await client.SendAsync(requestmessage);
                        if (response.IsSuccessStatusCode)
                        {
                            var result = await response.Content.ReadFromJsonAsync<List<JiraCheckInforPermission>>();
                            if (result.Count > 0)
                            {
                                listproject.Add(key.Value);
                            }
                        }
                    }
                }

            }
            return listproject;
        }
        public async Task<Dictionary<string, string>> GetAllKeysProjects()
        {
            var url = "https://jira.aisolutions.com.vn/rest/api/2/project";
            using (var client = new HttpClient())
            {
                using (var requestmessage = new HttpRequestMessage(HttpMethod.Get, url))
                {
                    requestmessage.Headers.Add("Authorization", "Basic amlyYXRlc3Q6UEBzczEyMzQ1");
                    requestmessage.Method = HttpMethod.Get;
                    var response = await client.SendAsync(requestmessage);
                    var result = await response.Content.ReadAsStringAsync();
                    var project = JsonConvert.DeserializeObject<List<ProjectJira>>(result);
                    var keys = project?.Select(x => new { Key = x.key, NameProject = x.name });

                    Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

                    foreach (var key in keys)
                    {
                        keyValuePairs.Add(key.Key, key.NameProject);
                    }
                    return keyValuePairs;
                }
            }
        }
        public async Task<JiraUser> Getmyselfcompanyjira()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Accept", "application/json");
            headers.Add("Authorization", "Basic amlyYXRlc3Q6UEBzczEyMzQ1");
            headers.Add("username", "nam");
            var urlgetmyself = "https://jira.aisolutions.com.vn/rest/api/2/user?username=nam";
            using (var client = new HttpClient())
            {
                using (var requestmessage = new HttpRequestMessage(HttpMethod.Get, urlgetmyself))
                {
                    requestmessage.Headers.Add("Authorization", "Basic amlyYXRlc3Q6UEBzczEyMzQ1");
                    var response = await client.SendAsync(requestmessage);
                    var result = await response.Content.ReadAsStringAsync();
                    return null;
                }
            }
            return null;
        }
        public async Task<dynamic> UpdateUser(string key, UpdateUserJira updateUserJira)
        {
            var urlgetmyself = $"https://jira.aisolutions.com.vn/rest/api/2/user?key={key}";
            using (var client = new HttpClient())
            {
                using (var requestmessage = new HttpRequestMessage(HttpMethod.Put, urlgetmyself))
                {
                    requestmessage.Headers.Add("Authorization", "Basic amlyYXRlc3Q6UEBzczEyMzQ1");
                    requestmessage.Method = HttpMethod.Put;
                    requestmessage.Content = new StringContent(JsonConvert.SerializeObject(updateUserJira), System.Text.Encoding.UTF8, "application/json");
                    var response = await client.SendAsync(requestmessage);
                    return response;
                }
            }
        }
    }
}
