using Atlassian.Jira;

namespace PersonApi.Services.Interfaces
{
    public interface IJiraService
    {
        Task<JiraUser> CreateUser(JiraUserCreationInfo jiraUserCreationInfo);
        Task<IEnumerable<JiraUser>> GetUsers();
        Task<IEnumerable<Project>> GetProjectInfor();
        Task<IEnumerable<Project>> GetProjects();
        Task<JiraUser> GetUser();
        Task<IEnumerable<JiraUser>> GetUsersByGroups();
    }
}
