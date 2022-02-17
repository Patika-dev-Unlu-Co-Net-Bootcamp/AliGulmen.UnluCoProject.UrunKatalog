using AliGulmen.UnluCoProject.UrunKatalog.Common;
using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        [Required]
        [StringLength(100)]
        public string EMail { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
     

    }
}
