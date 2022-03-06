namespace PersonApi.Services.Interfaces
{
    public interface IEmployeeLearningService
    {
        Task<object> GetEmployeeBySchoolName(string schoolName);
    }
}
