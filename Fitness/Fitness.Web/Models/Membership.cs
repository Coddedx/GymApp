using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymApp.Web.Models {
    public class Membership : BaseEntity {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [Required]
        public int FranchiseId { get; set; }
        [ForeignKey("FranchiseId")]
        public virtual Franchise Franchise { get; set; }

        public decimal Price { get; set; }

        public int PricingId { get; set; }
        [ForeignKey("PricingId")]
        public virtual Pricing Pricing { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }

    }
}
