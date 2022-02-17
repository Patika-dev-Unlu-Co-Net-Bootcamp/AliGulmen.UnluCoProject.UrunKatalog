namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.OfferResources
{
    public class OfferResource
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int OfferedPrice { get; set; }
        public bool IsAccepted { get; set; }
    }
}
