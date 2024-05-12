using GymApp.Web.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymApp.Web.Models
{
    public class ContactMessage : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        //[Required]
        //public int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User? User { get; set; }
       
        public string Title { get; set; }

        [Required]
        public string FirstName { get; set; }
      
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Mail { get; set; }


        [Required]
        public string Message { get; set; }


    }
}
