using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.Shared;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ConditionResources;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class ConditionProfile : Profile
    {
        public ConditionProfile()
        {
            CreateMap<Condition, ConditionResource>();
            CreateMap<SaveConditionResource, Condition>();
            CreateMap<PaginatedResult<Condition>, PaginatedResult<ConditionResource>>();
        }

        

    }
}
