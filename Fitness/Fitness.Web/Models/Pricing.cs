using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class Pricing : BaseEntity {
        [Key]
        public int Id { get; set; }
        
        [Required, StringLength(64)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime StopTime { get; set; }
        [Required]
        public int MonthCount { get; set; }

        public int? DiscountRate { get; set; }

    }
}
