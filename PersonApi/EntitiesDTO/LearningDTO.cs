using PersonApi.Models;
using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class LearningDTO : CreateLearningDTO
    {
        public int Id { get; set; }
        public virtual ICollection<InformationEmployee_Learning> ThongTinNhanVien_HocVans { get; set; }
    }
    public class CreateLearningDTO
    {
        [Required]
        [StringLength(50, ErrorMessage = "University Name cannot be longer than 50 characters.")]
        public string UniversityName { get; set; }

        [Required]
        [StringLength(20)]
        public string Level { get; set; }

        [StringLength(20)]
        public string Major { get; set; }
    }
    public class UpdateLearningDTO : CreateLearningDTO
    {

    }
}
