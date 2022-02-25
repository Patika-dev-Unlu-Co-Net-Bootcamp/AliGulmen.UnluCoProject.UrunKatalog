
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities
{
    public class Offer : BaseEntity
    {
         public AppUser User { get; set;}
        public string UserId { get; set; }
        public Product Product { get; set;}
        public int? ProductId { get; set; }
        public int OfferedPrice { get; set;}
        public OfferStatus OfferStatus { get; set; } = 0;

    }
}
