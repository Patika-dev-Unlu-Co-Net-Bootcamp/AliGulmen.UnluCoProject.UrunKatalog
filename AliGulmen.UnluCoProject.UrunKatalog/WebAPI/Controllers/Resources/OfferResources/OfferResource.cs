using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources
{
    public class OfferResource
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public string OwnerId { get; set; }
        public string ProductName { get; set; }
        public int OfferedPrice { get; set; }
        public int CurrentPrice { get; set; }
      //  public bool IsAccepted { get; set; }
        public OfferStatus OfferStatus { get; set; }
    }
}
