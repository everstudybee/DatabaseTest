using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class Name
    {
        [Key]
        public int NameId { get; set; }

        public string? PersonName { get; set; }
    }
}
