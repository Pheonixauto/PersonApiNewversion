using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class SalaryDTO : CreateSalaryDTO
    {
        public int Id { get; set; }

    }
    public class CreateSalaryDTO
    {
        [DataType(DataType.Currency)]
        //[Column(TypeName = "Currency")]
        public decimal Salary { get; set; }
    }
    public class UpdateSalaryDTO: CreateSalaryDTO
    {

    }
}
