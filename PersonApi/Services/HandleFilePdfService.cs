using PersonApi.Models;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using System.Text;

namespace PersonApi.Services
{
    public class HandleFilePdfService : IHandleFilePdfService
    {
        private readonly IUnitOfWork _unitOfWork;
        public HandleFilePdfService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<string> GetHtmlStringOfFileSalary(int id)
        {
            var salary = await _unitOfWork.SalaryRepository.Get(id);
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                  <div class='header'>
                                       <h1>This is the Generated PDF Report </h1>
                                  </div>
                                  <table align='center'>
                                        <tr>
                                            <th> Id </th>
                                            <th> Salary </th>
                                            <th> DateTime </th>
                                            <th> Tax </th>
                                            <th> EmployeeId </th>                                            
                                        </tr>
                       
                      ");
            //foreach (var salary in salaries)
            //{
                sb.AppendFormat(@"
                                <tr>
                                   <td>{0}</td>
                                   <td>{1}</td>
                                   <td>{2}</td>
                                   <td>{3}</td>
                                   <td>{4}</td>
                                </tr>
                                ", salary.Id, salary.Salary, salary.DateTime, salary.Tax, salary.EmployeeId);
            //}
            sb.Append(@"           </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
