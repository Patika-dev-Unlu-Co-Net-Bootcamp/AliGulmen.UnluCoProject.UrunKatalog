using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.BrandResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.CategoryResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.ConditionResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.ProductResources;
using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources.UserResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Mapping
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

            CreateMap<User, UserResource>();
            CreateMap<SaveUserResource, User>();

            CreateMap<Product, ProductResource>();
            CreateMap<SaveProductResource, Product>();
        }
    }
}
