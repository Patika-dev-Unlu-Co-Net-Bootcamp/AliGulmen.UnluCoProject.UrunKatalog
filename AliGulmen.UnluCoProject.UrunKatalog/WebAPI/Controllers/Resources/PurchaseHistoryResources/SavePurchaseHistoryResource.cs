using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.PurchaseHistoryResources
{
    public class SavePurchaseHistoryResource
    {
        public int? ProductId { get; set; }
         public int? SellerId { get; set; }
        public int BuyerId { get; set; }
        public int SoldPrice { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
