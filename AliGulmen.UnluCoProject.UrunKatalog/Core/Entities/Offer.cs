
namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{
    public class Offer : BaseEntity
    {
         public User User { get; set;}
        public int UserId { get; set; }
        public Product Product { get; set;}
        public int? ProductId { get; set; }
        public int OfferedPrice { get; set;}
        public bool IsAccepted { get; set; } = false;

    }
}
