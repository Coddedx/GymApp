using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class MainPage : BaseEntity {
        [Key]
        public int Id { get; set; }

        [StringLength(128)]
        public string? ImageUrl { get; set; }
        [Required, StringLength(128)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        [Required, StringLength(64)]
        public string AboutTitle { get; set; }
        [Required]
        public string? AboutDescription { get; set; }
        [StringLength(128)]
        public string? AboutImageUrl1 { get; set; }
        [StringLength(128)]
        public string? AboutImageUrl2 { get; set; }
        [StringLength(128)]
        public string? AboutImageUrl3 { get; set; }
        [StringLength(128)]
        public string AboutRedirectUrl { get; set; }

        public string SliderImageUrl1 { get; set; }
        public string SliderImageUrl2 { get; set; }
        public string SliderImageUrl3 { get; set; }
        public string SliderRedirectUrl1 { get; set; }
        public string SliderRedirectUrl2 { get; set; }
        public string SliderRedirectUrl3 { get; set; }
        public string SliderTitle1 { get; set; }
        public string SliderTitle2 { get; set; }
        public string SliderTitle3 { get; set; }
        public string SliderSubtitle1 { get; set; }
        public string SliderSubtitle2 { get; set; }
        public string SliderSubtitle3 { get; set; }
    }
}
