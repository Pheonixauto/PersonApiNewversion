using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using System.ComponentModel;

namespace PersonApi.Services
{
    public class SearchService : ISearchService
    {
        public readonly IUnitOfWork _unitOfWork;
        public SearchService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<object> GetInfor(string something)
        {
            List<string> include = new List<string> { };
            var employee = await _unitOfWork.EmployeeRepository.GetAllAsync(null, null);
            if (something == null)
            {
                return null;
            }
            int id;
            DateTime dateTime;
            bool bid= Int32.TryParse(something, out id);
            bool bdatetime = DateTime.TryParse(something, out dateTime);
            if (bid == true)
            {
                var result = employee.Where(x => x.Id == id || x.IdentityNumber == id).Select(x => x.LastName);
                return result;
            }
            if(bdatetime== true)
            {
                var result = employee.Where(x=>x.BirthDay==dateTime).Select(x => x.LastName);
                return result;
            }
            return null;
            
        }
    }
}
