using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.BrandResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.CategoryResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.ColorResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.ConditionResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.OfferResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.ProductResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.PurchaseHistoryResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.UserResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<Category, CategoryResource>();
            CreateMap<SaveCategoryResource, Category>();


            CreateMap<Brand, BrandResource>();
            CreateMap<SaveBrandResource, Brand>();


            CreateMap<Condition, ConditionResource>();
            CreateMap<SaveConditionResource, Condition>();

            CreateMap<AppUser, UserResource>()
                  .ForMember(x => x.Password, opt => opt.MapFrom(x => x.PasswordHash));
            CreateMap<SaveUserResource, AppUser>();

            CreateMap<Color, ColorResource>();
            CreateMap<SaveColorResource, Color>();

            CreateMap<Product, ProductResource>()
                .ForMember(x => x.ColorName, opt => opt.MapFrom(x => x.Color.Name))
                .ForMember(x => x.ConditionStatus, opt => opt.MapFrom(x => x.Condition.Status))
                .ForMember(x => x.Owner, opt => opt.MapFrom(x => x.User.UserName))
                .ForMember(x => x.BrandName, opt => opt.MapFrom(x => x.Brand.Name))
                .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
                ;
            CreateMap<SaveProductResource, Product>();

            CreateMap<PurchaseHistory, PurchaseHistoryResource>()
                 .ForMember(x => x.BuyerName, opt => opt.MapFrom(x => x.Buyer.UserName))
                 .ForMember(x => x.SellerName, opt => opt.MapFrom(x => x.Seller.UserName))
                .ForMember(x => x.ProductName, opt => opt.MapFrom(x => x.Product.Name));
            CreateMap<SavePurchaseHistoryResource, PurchaseHistory>();

            CreateMap<Offer, OfferResource>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.UserName))
                .ForMember(x => x.ProductName, opt => opt.MapFrom(x => x.Product.Name))
                ;
            CreateMap<SaveOfferResource, Offer>();

            CreateMap<FilterResource, Filter>();



        }
    }
}
