using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class User : BaseEntity {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IdentityNumber { get; set; }
        public string Password { get; set; }

        public ICollection<Membership> Memberships { get; set; }
        public ICollection<BodyIndex> BodyIndex { get; set; }
    }
}
