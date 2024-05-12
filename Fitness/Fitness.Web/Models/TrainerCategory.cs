using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymApp.Web.Models {
    public class TrainerCategory : BaseEntity {
        [Required]
        public int TrainerId { get; set; }
        [ForeignKey("TrainerId")]
        public virtual Trainer Trainer { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
