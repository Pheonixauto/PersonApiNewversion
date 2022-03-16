using PersonApi.Controllers.HttpClient;
using System.Net;
using System.Net.Http.Headers;

namespace PersonApi.Services.HttpClientService
{
    public class ClientService : IClientService
    {
        public ClientService()
        {

        }
        public async Task<string> Test()
        {

            // Create a client
            //HttpClient httpClient = new HttpClient();

            //// Assign the authentication headers
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("");

            //// Call out to the site
            //HttpResponseMessage response = await httpClient.GetAsync("https://automationtechnologysolution.atlassian.net/rest/api/2/myself");

            //// Just as an example I'm turning the response into a string here
            //string responseAsString = await response.Content.ReadAsStringAsync();
            //return responseAsString;

            var url = "https://automationtechnologysolution.atlassian.net/rest/api/2/myself";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);

            httpRequest.Headers["Authorization"] = "Basic 4ymFi38BYn3GWoLXPw2O7964";


            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                return result;
            }
        }

      

    }
}
