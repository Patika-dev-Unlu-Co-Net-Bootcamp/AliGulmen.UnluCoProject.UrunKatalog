using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.CategoryResources;
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AutoMapper;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {

            CreateMap<Category, CategoryResource>();
            CreateMap<SaveCategoryResource, Category>();
            CreateMap<PaginatedResult<Category>, PaginatedResult<CategoryResource>>();


        }
    }
}
