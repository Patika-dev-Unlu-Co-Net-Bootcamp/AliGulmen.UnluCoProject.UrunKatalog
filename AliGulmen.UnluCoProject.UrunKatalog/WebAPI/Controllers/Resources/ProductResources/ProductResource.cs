using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.ProductResources
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
        public string ConditionStatus { get; set; }
        public string Owner { get; set; }
        public string UserId { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
    }
}
