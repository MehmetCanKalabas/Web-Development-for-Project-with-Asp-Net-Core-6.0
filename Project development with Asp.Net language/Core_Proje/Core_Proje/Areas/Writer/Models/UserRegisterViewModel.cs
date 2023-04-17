using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {

        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz.")]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Lütfen Resim Url Giriniz.")]
        public string ImageURL { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Şifreyi Giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz.")]
        [Compare("Password",ErrorMessage="Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Giriniz.")]
        public string Mail { get; set; }
    }
}
