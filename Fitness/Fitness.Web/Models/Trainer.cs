using System.ComponentModel.DataAnnotations;

namespace GymApp.Web.Models {
    public class Trainer : BaseEntity {
        [Key]
        public int Id { get; set; }


        //sayfada ingilizce yazıyo hata mesajı onu değiştirmek için
        [Required(ErrorMessage = "Adı soyadı alanını doldurunuz")
        ,StringLength(64, ErrorMessage = "Bu alan en fazla 64 karakter içermelidir.")
        ,MinLength(3 , ErrorMessage = "Bu alan en az 3 karakter içermelidir.")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Adı soyadı alanını doldurunuz")
        , StringLength(64, ErrorMessage = "Bu alan en fazla 64 karakter içermelidir.")
        , MinLength(3, ErrorMessage = "Bu alan en az 3 karakter içermelidir.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon alanını doldurunuz")
        , StringLength(64, ErrorMessage = "Bu alan en fazla 64 karakter içermelidir.")
        , MinLength(3, ErrorMessage = "Bu alan en az 3 karakter içermelidir.")]
        public string Phone { get; set; }

        
    }
}
