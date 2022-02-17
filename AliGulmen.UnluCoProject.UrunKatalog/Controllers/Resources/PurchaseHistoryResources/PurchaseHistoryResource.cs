using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.PurchaseHistoryResources
{
    public class PurchaseHistoryResource
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int SellerId { get; set; }
         public int BuyerId { get; set; }
        public int SoldPrice { get; set; }
        public DateTime PurchasedDate { get; set; }
    }
}
