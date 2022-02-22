using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.UserResources
{
    public class SaveUserResource
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public string Gender { get; set; }
        [Required]
        [StringLength(100)]
        public string EMail { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}
