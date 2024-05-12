using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class Contact : BaseEntity {
        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        public string? ImageUrl { get; set; }
        [Required, StringLength(128)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [StringLength(128)]
        public string InstagramRedirectUrl { get; set; }
        [StringLength(128)]
        public string LinkedinRedirectUrl { get; set; }
        [StringLength(128)]
        public string XRedirectUrl { get; set; }
    }
}
