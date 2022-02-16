using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Entities
{
    public class Color : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
      
    }
}
