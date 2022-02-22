namespace AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.OfferResources
{
    public class SaveOfferResource
    {
        public int UserId { get; set; }
        public int? ProductId { get; set; }
        public int OfferedPrice { get; set; }
        public bool IsAccepted { get; set; } = false;
    }
}
