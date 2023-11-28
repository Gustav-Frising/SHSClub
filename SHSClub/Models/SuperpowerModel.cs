using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHSClub.Models
{
    public class SuperpowerModel
    {
        [Key]
        [Column("id")]
        public int SuperpowerId { get; set; }
        [Column("name")]
        public string Name { get; set; } = null!;
        [Column("description")]
        public string? Description { get; set; }
        public List<SuperheroModel> Superheroes { get; set; } = new();
    }
}
