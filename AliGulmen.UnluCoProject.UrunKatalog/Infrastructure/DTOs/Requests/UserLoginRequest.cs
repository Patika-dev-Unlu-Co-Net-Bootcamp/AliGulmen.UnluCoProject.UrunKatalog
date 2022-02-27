
using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.DTOs.Requests
{
    public class UserLoginRequest
    {
        [Required(ErrorMessage ="Lütfen Email Adresini Boş Bırakmayınız!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Şifre Alanını Boş Bırakmayınız!")]
        public string Password { get; set; }
    }
}
