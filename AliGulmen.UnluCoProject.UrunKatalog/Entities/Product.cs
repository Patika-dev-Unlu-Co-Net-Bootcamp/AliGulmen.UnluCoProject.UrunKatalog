using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Entities
{
    public class Product : BaseEntity
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
        public Condition Condition { get; set; }
        [Required]
        public int ConditionId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Color Color { get; set; }
        public int? ColorId { get; set; }
        public Brand Brand { get; set; }
        public int? BrandId { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
