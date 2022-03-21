using Atlassian.Jira;
using PersonApi.Services.Interfaces;

namespace PersonApi.Services
{
    public class JiraService : IJiraService
    {
        public JiraService()
        {
        }
        // create user
        public async Task<JiraUser> CreateUser(string account, string password, JiraUserCreationInfo jiraUserCreationInfo)
        {
            //string UserName = "jiratest";
            //string Password = "P@ss12345";
            string Url = "https://jira.aisolutions.com.vn/";
            var jira = Jira.CreateRestClient(Url, account, password);
            var cruser = await jira.Users.CreateUserAsync(jiraUserCreationInfo);
            return cruser;
        }
        public async Task<IEnumerable<Project>> GetProjects(string account, string password)
        {          
            string Url = "https://jira.aisolutions.com.vn/";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, account, password, settings);
            var result = await jira.Projects.GetProjectsAsync();
            var ji = JiraUserStatus.Inactive;
            return result;
        }
        public async Task<IEnumerable<JiraUser>> GetUsers(string account, string password, string member)
        {
            string Url = "https://jira.aisolutions.com.vn/";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, account, password, settings);
            var result = await jira.Users.SearchUsersAsync(member);
            return result;
        }
       
    }
}
