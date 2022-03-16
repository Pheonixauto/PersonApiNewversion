using Atlassian.Jira;
using PersonApi.Services.Interfaces;

namespace PersonApi.Services
{
    public class JiraService : IJiraService
    {
        public JiraService()
        {
        }
        public async Task<JiraUser> CreateUser(JiraUserCreationInfo jiraUserCreationInfo)
        {
            string UserName = "thanhthai2604@gmail.com";
            string Password = "YSSynVimGSPO4G8hKoYNE15A";
            string Url = "https://automationtechnologysolution.atlassian.net";
            var jira = Jira.CreateRestClient(Url, UserName, Password);
            var cruser = await jira.Users.CreateUserAsync(jiraUserCreationInfo);
            return cruser;
        }

        public async Task<IEnumerable<Project>> GetProjectInfor()
        {
            string UserName = "thanhthai2604@gmail.com";
            string Password = "YSSynVimGSPO4G8hKoYNE15A";
            string Url = "https://automationtechnologysolution.atlassian.net";
            var jira = Jira.CreateRestClient(Url, UserName, Password);
            var projiect = await jira.Projects.GetProjectsAsync();
            var r = projiect.Where(x => x.LeadUser.DisplayName == "Thai Thanh");
            return r;
        }
        public async Task<IEnumerable<Project>> GetProjects()
        {
            string UserName = "thanhthai2604@gmail.com";
            string Password = "YSSynVimGSPO4G8hKoYNE15A";
            string Url = "https://automationtechnologysolution.atlassian.net";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, UserName, Password, settings);
            var result = await jira.Projects.GetProjectsAsync();
                                     
            return result;
        }
        public async Task<JiraUser> GetUser()
        {
            string UserName = "thanhthai2604@gmail.com";
            string Password = "YSSynVimGSPO4G8hKoYNE15A";
            string Url = "https://automationtechnologysolution.atlassian.net";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, UserName, Password, settings);
            var result = await jira.Users.GetUserAsync("622dce7c75f257006a989b05");
            return result;
           
        }
        public async Task<IEnumerable<JiraUser>> GetUsers()
        {
            string UserName = "thanhthai2604@gmail.com";
            string Password = "YSSynVimGSPO4G8hKoYNE15A";
            string Url = "https://automationtechnologysolution.atlassian.net";
            var settings = new JiraRestClientSettings();
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:userpicker"] = new Atlassian.Jira.Remote.SingleObjectCustomFieldValueSerializer("displayName");
            settings.CustomFieldSerializers["com.atlassian.jira.plugin.system.customfieldtypes:multiuserpicker"] = new Atlassian.Jira.Remote.MultiObjectCustomFieldValueSerializer("displayName");
            var jira = Jira.CreateRestClient(Url, UserName, Password, settings);
            var result = await jira.Users.SearchUsersAsync("thanhthai2604@gmail.com");
            return result;
        }
        public async Task<IEnumerable<JiraUser>> GetUsersByGroups()
        {
            string UserName = "thanhthai2604@gmail.com";
            string Password = "YSSynVimGSPO4G8hKoYNE15A";
            string Url = "https://automationtechnologysolution.atlassian.net";
            var jira = Jira.CreateRestClient(Url, UserName, Password);
            var result = await jira.Groups.GetUsersAsync("administrators");
            return result;
        }
    }
}
