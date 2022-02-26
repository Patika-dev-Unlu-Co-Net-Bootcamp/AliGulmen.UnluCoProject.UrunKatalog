using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class OfferProfile :Profile
    {
      
        public OfferProfile()
        {
            CreateMap<Offer, OfferResource>()
                           .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.UserName))
                           .ForMember(x => x.ProductName, opt => opt.MapFrom(x => x.Product.Name))
                           .ForMember(x => x.CurrentPrice, opt => opt.MapFrom(x => x.Product.BuyItNowPrice))
                           .ForMember(x => x.OwnerId, opt => opt.MapFrom(x => x.Product.UserId))
                           ;
            CreateMap<SaveOfferResource, Offer>();
            CreateMap<UpdateOfferResource, Offer>();
            CreateMap<PaginatedResult<Offer>, PaginatedResult<OfferResource>>();
        }
    }
}
