using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities
{
    public class Condition : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
     

    }
}
