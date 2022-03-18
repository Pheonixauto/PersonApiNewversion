using Atlassian.Jira;

namespace PersonApi.Services.Interfaces
{
    public interface IJiraService
    {
        Task<JiraUser> CreateUser(JiraUserCreationInfo jiraUserCreationInfo);
        Task<IEnumerable<JiraUser>> GetUsers();   
        Task<IEnumerable<Project>> GetProjects();
      

    }
}
