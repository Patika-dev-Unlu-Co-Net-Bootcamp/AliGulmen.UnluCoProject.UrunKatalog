using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.PurchaseHistoryResources
{
    public class SavePurchaseHistoryResource
    {
        public int? ProductId { get; set; }
         public string SellerId { get; set; }
        public string BuyerId { get; set; }
        public int SoldPrice { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
