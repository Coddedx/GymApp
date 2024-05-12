using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class About : BaseEntity {
        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        public string? ImageUrl { get; set; }
        [Required, StringLength(128)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
