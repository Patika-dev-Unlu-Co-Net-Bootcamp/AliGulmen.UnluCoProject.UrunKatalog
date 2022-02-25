using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources
{
    public class SaveOfferResource
    {
        public string UserId { get; set; }
        public int? ProductId { get; set; }
        public int OfferedPrice { get; set; }
      //  public bool IsAccepted { get; set; } = false;
        public OfferStatus OfferStatus { get; set; } = 0;
    }
}
