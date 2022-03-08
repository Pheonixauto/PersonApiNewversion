namespace PersonApi.Services.Interfaces
{
    public interface ISearchService
    {
        // Search Information from Employee Name
        Task<object> GetInforEmployee(string name);
    }
}
