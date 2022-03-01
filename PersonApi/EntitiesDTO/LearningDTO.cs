using PersonApi.Models;
using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class LearningDTO : CreateLearningDTO
    {
        public int Id { get; set; }
        public virtual ICollection<InformationEmployeeLearning> ThongTinNhanVien_HocVans { get; set; }
    }
    public class CreateLearningDTO
    {
        [Required]
        [StringLength(50, ErrorMessage = "University Name cannot be longer than 50 characters.")]
        public string UniversityName { get; set; }

   
    }
    public class UpdateLearningDTO : CreateLearningDTO
    {

    }
}
