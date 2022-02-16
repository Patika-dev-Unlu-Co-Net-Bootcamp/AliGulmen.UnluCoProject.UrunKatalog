using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Entities
{
    public class Brand : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
       
    }
}
