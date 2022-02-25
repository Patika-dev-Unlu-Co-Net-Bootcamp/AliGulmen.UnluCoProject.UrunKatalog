
namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities
{
    public class Product : BaseEntity
    {
      
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int BuyItNowPrice { get; set; }
        public bool IsOfferable { get; set; } = false;
        public bool IsSold { get; set; } = false;
        public Condition Condition { get; set; }
        public int ConditionId { get; set; }
        public AppUser User { get; set; }
        public string UserId { get; set; }
        public Color Color { get; set; }
        public int? ColorId { get; set; }
        public Brand Brand { get; set; }
        public int? BrandId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
