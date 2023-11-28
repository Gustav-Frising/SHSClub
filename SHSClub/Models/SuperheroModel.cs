using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHSClub.Models
{
    public class SuperheroModel
    {
        [Key]
        [Column("id")]
        public int SuperheroId { get; set; }
        [Column("name")]
        public string Name { get; set; } = null!;
        [Column("secret_identity")]
        public string? SecretIdentity { get; set; }
        [Column("superpower_id")]
        public int? SuperpowerId { get; set; }
        public SuperpowerModel? Superpower { get; set; }
        [Column("image_url")]
        public string? ImageUrl { get; set; }
    }
}
