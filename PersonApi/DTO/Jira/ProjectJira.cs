namespace PersonApi.DTO.Jira
{
    public class ProjectJira
    {
        public string expand { get; set; }
        public string self { get; set; }
        public int id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string projectTypeKey { get; set; }
        public bool archived { get; set; }
        public Dictionary<string, string> avatarUrls { get; set; }
    }
}
