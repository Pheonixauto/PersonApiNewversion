using System.ComponentModel.DataAnnotations;

namespace PersonApi.ModelsDTO
{
    public class SkillDTO : CreateSkillDTO
    {
        public int Id { get; set; }

    }
    public class CreateSkillDTO
    {

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

    }
    public class UpdateSkillDTO : CreateSkillDTO
    {

    }
}
