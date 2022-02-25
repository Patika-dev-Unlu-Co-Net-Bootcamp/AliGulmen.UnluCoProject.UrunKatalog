using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources
{
    public class UpdateOfferResource
    {
        public int OfferedPrice { get; set; }
        public OfferStatus OfferStatus { get; set; } = 0;
    }
}
