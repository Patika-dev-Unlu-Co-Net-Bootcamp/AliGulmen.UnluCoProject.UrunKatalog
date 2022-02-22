using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.ProductResources
{
    public class SaveProductResource
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public string PictureUrl { get; set; }
        [Required]
        public int BuyItNowPrice { get; set; }
        public bool IsOfferable { get; set; } = false;
        public bool IsSold { get; set; } = false;
        [Required]
        public int ConditionId { get; set; }
        public string UserId { get; set; }
        public int? ColorId { get; set; }
        public int? BrandId { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
