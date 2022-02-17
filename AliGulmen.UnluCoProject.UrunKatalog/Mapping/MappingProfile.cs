using AliGulmen.UnluCoProject.UrunKatalog.Controllers.Resources;
using AliGulmen.UnluCoProject.UrunKatalog.Entities;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}
