using PersonApi.Models;
using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class LearningDTO : CreateLearningDTO
    {
        public int Id { get; set; }
        public virtual ICollection<InforEmployeeLearning> ThongTinNhanVien_HocVans { get; set; }
    }
    public class CreateLearningDTO
    {
        public string? UniversityName { get; set; }

    }
    public class UpdateLearningDTO : CreateLearningDTO
    {

    }
}
