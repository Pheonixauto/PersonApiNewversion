using Atlassian.Jira;

namespace PersonApi.Services.Interfaces
{
    public interface IJiraService
    {
        Task<JiraUser> CreateUser(string account, string password, JiraUserCreationInfo jiraUserCreationInfo);
        Task<IEnumerable<JiraUser>> GetUsers(string account, string password, string member);   
        Task<IEnumerable<Project>> GetProjects(string account, string password);    
    }
}
