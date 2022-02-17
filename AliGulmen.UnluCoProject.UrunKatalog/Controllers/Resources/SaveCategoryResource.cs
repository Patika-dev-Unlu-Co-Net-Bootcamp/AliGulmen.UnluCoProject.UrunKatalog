using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
