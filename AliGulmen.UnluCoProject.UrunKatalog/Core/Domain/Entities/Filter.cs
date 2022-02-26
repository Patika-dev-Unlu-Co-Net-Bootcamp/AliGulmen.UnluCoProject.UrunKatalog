namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities
{
    public class Filter
    {
        public int? CategoryId { get; set; }
        public int? ProductId { get; set; }
        public string UserId { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
