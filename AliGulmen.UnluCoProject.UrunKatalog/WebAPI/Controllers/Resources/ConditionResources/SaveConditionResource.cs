using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ConditionResources
{
    public class SaveConditionResource
    {
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
    }
}
