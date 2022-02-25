namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Requests
{
    public abstract class PagedRequest
    {
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
