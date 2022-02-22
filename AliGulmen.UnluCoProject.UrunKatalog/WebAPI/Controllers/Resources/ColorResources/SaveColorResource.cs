using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.ColorResources
{
    public class SaveColorResource
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
