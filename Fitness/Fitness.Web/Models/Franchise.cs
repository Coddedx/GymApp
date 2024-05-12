using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class Franchise : BaseEntity {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        public string WorkingTime { get; set; }

    }
}
