using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymApp.Web.Models {
    public class Course : BaseEntity {
        [Key]
        public int Id { get; set; }

        [Required]
        public int TrainerId { get; set; }
        [ForeignKey("TrainerId")]
        public virtual Trainer? Trainer { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }

        public DateTime StartTime { get; set; }
        
        public DateTime EndTime { get; set; }

        public int UserCount { get; set; }

    }
}
