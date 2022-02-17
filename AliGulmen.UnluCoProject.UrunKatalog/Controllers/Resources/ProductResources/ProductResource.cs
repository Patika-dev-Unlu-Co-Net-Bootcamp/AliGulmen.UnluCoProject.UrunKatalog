using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.ProductResources
{
    public class ProductResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }
        public int BuyItNowPrice { get; set; }
        public bool IsOfferable { get; set; } 
        public bool IsSold { get; set; } 
        public int ConditionId { get; set; }
        public int UserId { get; set; }
        public string ColorId { get; set; }
        public string ColorName { get; set; }
        public int? BrandId { get; set; }
        public int CategoryId { get; set; }
    }
}
