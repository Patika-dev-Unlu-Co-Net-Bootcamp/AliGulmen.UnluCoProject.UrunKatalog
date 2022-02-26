using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.PurchaseHistoryResources;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class PurchaseProfile : Profile
    {
        public PurchaseProfile()
        {
            CreateMap<PurchaseHistory, PurchaseHistoryResource>()
                .ForMember(x => x.BuyerName, opt => opt.MapFrom(x => x.Buyer.UserName))
                .ForMember(x => x.SellerName, opt => opt.MapFrom(x => x.Seller.UserName))
               .ForMember(x => x.ProductName, opt => opt.MapFrom(x => x.Product.Name));
            CreateMap<SavePurchaseHistoryResource, PurchaseHistory>();
            CreateMap<PaginatedResult<PurchaseHistory>, PaginatedResult<PurchaseHistoryResource>>();
        }
    }
}
