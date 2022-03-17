using Atlassian.Jira;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PersonApi.Controllers.HttpClient;
using PersonApi.DTO.Account;
using PersonApi.DTO.Jira;
using PersonApi.DTO.Login;
using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Encodings;

namespace PersonApi.Services.HttpClientService
{
    public class ClientService : IClientService
    {
        public ClientService()
        {
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

        public async Task<string> Logincompanyjira()
        {
            var urllogin = "https://jira.aisolutions.com.vn/rest/auth/1/session";

            using (var client = new HttpClient())
            {
                var newAcount = new CompanyAcount() { username = "jiratest", password = "P@ss12345" };
                var response = await client.PostAsJsonAsync(urllogin, newAcount);
                if (response.IsSuccessStatusCode)
                {
                    var id = await response.Content.ReadAsStringAsync();
                    return id;
                }
                return null;
            }
        }

        public async Task<string> Testmyjira()
        {
            var url = "https://localhost:7263/api/Account/login";
            using (var client = new HttpClient())
            {
                var newAcount = new MyAccount() { email = "user@example.com", passWord = "P@1string" };
                var response = await client.PostAsJsonAsync(url, newAcount);
                if (response.IsSuccessStatusCode)
                {
                    var id = await response.Content.ReadAsStringAsync();
                    return id;
                }
                return null;
            }
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
