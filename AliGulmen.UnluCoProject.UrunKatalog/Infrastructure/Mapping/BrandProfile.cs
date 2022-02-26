using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.BrandResources;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<Brand, BrandResource>();
            CreateMap<SaveBrandResource, Brand>();
            CreateMap<PaginatedResult<Brand>, PaginatedResult<BrandResource>>();

        }
    }
}
