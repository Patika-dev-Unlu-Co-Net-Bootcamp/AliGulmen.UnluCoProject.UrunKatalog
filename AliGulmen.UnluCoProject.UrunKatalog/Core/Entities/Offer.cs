using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{
    public class Offer
    {
        public int Id { get; set; }
        public User User { get; set;}
        public int UserId { get; set; }
        public Product Product { get; set;}
        public int ProductId { get; set; }
        public int OfferedPrice { get; set;}
        public bool IsAccepted { get; set; } = false;
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
