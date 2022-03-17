using Atlassian.Jira;
using PersonApi.Services.Interfaces;
using System.Collections.Concurrent;

namespace PersonApi.Services
{
    public class JiraService : IJiraService
    {
        public JiraService()
        {
        }

        // create user
        public async Task<JiraUser> CreateUser(JiraUserCreationInfo jiraUserCreationInfo)
        {
            string UserName = "jiratest";
            string Password = "P@ss12345";
            string Url = "https://jira.aisolutions.com.vn/";
            var jira = Jira.CreateRestClient(Url, UserName, Password);
            var cruser = await jira.Users.CreateUserAsync(jiraUserCreationInfo);
            return cruser;
        }

        public async Task<IEnumerable<Project>> GetProjects()
        {
            string UserName = "jiratest";
            string Password = "P@ss12345";
            string Url = "https://jira.aisolutions.com.vn/";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, UserName, Password, settings);
            var result = await jira.Projects.GetProjectsAsync();
            var ji = JiraUserStatus.Inactive;
            return result;
        }
        public async Task<JiraUser> GetUser()
        {
            string UserName = "jiratest";
            string Password = "P@ss12345";
            string Url = "https://jira.aisolutions.com.vn/";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, UserName, Password, settings);
            var result = await jira.Users.GetUserAsync("JIRAUSER10101");
            return result;         
        }
        public async Task<IEnumerable<JiraUser>> GetUsers()
        {
            string UserName = "jiratest";
            string Password = "P@ss12345";
            string Url = "https://jira.aisolutions.com.vn/";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, UserName, Password, settings);
            var result = await jira.Users.SearchUsersAsync("thanhthai2604@gmail.com");
            return result;
        }
        public async Task<Project> GetProjiectInfor()
        {
            string UserName = "jiratest";
            string Password = "P@ss12345";
            string Url = "https://jira.aisolutions.com.vn/";
            var jira = Jira.CreateRestClient(Url, UserName, Password);
            var result = await jira.Projects.GetProjectAsync("FUL");
            return result;
        }     
    }
}
