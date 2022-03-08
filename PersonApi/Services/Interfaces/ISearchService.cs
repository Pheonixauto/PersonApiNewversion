namespace PersonApi.Services.Interfaces
{
    public interface ISearchService
    {
        // Get By Search something
        Task<object> GetInforEmployee(string name);
    }
}
