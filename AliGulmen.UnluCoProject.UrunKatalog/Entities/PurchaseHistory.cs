using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Entities
{
    public class PurchaseHistory : BaseEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public User Seller { get; set; }
        public int SellerId { get; set; }
        public User Buyer { get; set; }
        public int BuyerId { get; set; }
        public int SoldPrice { get; set; }
        public DateTime PurchasedDate { get; set; }
       
       
    }
}
