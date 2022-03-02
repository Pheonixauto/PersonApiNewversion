using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class SalaryDTO : CreateSalaryDTO
    {
        public int Id { get; set; }

    }
    public class CreateSalaryDTO
    {
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [DataType(DataType.Currency)]
        public decimal Tax { get; set; }

        public int EmployeeId { get; set; }
    }
    public class UpdateSalaryDTO: CreateSalaryDTO
    {

    }
}
