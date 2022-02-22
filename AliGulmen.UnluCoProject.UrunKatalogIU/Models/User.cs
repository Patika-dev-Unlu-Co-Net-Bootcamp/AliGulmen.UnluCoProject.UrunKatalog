using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalogIU.Models
{
    public class User
    {
        [Required(ErrorMessage = "İsim gereklidir")]
        public string FirstName { get; set; }
        [Required, StringLength(8, ErrorMessage = "Min 10 karakter")]
        public string LastName { get; set; }
    }
}
