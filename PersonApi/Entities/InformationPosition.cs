using PersonApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonApi.Entities
{
    public class InformationPosition
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual InformationEmployee InformationEmployee { get; set; }
    }
}
