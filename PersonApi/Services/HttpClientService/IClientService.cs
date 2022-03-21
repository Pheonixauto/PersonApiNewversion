using Atlassian.Jira;
using PersonApi.DTO.Jira;

namespace PersonApi.Services.HttpClientService
{
    public interface IClientService
    {
        Task<JiraUser> Getmyselfcompanyjira(string account, string password, string member);
        Task<dynamic> UpdateUser(string account, string password, string key, UpdateUserJira updateUserJira);
        Task<Dictionary<string, string>> GetAllKeysProjects(string account, string password);
        Task<List<string>> CheckInforProjectByUser(string account,
                                                   string password,
                                                   string member,
                                                   Dictionary<string, string> keyProject);
    }
}
