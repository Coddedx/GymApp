using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class BaseEntity {
        [Required, DefaultValue(true)]
        public bool Status { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? Deleted { get; set; }
    }
}
