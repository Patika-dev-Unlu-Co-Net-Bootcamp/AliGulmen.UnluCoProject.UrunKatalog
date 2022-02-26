namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources
{
    public class FilterResource
    {
        public int? CategoryId { get; set; }

        public int? ProductId { get; set; }
        public string UserId { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}
