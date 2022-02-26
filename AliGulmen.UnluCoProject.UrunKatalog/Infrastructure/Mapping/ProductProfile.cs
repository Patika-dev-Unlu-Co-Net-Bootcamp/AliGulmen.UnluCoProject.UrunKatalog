using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ProductResources;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class ProductProfile :Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductResource>()
              .ForMember(x => x.ColorName, opt => opt.MapFrom(x => x.Color.Name))
              .ForMember(x => x.ConditionStatus, opt => opt.MapFrom(x => x.Condition.Status))
              .ForMember(x => x.Owner, opt => opt.MapFrom(x => x.User.UserName))
              .ForMember(x => x.BrandName, opt => opt.MapFrom(x => x.Brand.Name))
              .ForMember(x => x.CategoryName, opt => opt.MapFrom(x => x.Category.Name))
              ;
            CreateMap<SaveProductResource, Product>();


            CreateMap<PaginatedResult<Product>, PaginatedResult<ProductResource>>();

         
        }
    }
}
