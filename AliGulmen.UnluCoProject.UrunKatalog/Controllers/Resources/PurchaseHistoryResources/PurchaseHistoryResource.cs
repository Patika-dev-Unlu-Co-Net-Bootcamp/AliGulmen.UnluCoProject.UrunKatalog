using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.PurchaseHistoryResources
{
    public class PurchaseHistoryResource
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string SellerName { get; set; }
         public string BuyerName { get; set; }
        public int SoldPrice { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
