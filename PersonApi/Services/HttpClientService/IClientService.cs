using Atlassian.Jira;
using PersonApi.DTO.Jira;
using System.Net.Http.Headers;

namespace PersonApi.Services.HttpClientService
{
    public interface IClientService
    {
    
        Task<string> Testmyjira();
        Task<string>Logincompanyjira();
        Task<JiraUser> Getmyselfcompanyjira();
        Task<dynamic> UpdateUser(string key, UpdateUserJira updateUserJira);



        Task<Dictionary<string, string>> GetAllKeysProjects();


        Task<List<string>> CheckInforProjectByUser(string userName, Dictionary<string, string> keyproject);


    }
}
