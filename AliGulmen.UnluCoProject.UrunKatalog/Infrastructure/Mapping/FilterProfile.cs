using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class FilterProfile :Profile
    {
      
        public FilterProfile()
        {
            CreateMap<FilterResource, Filter>();

        }
    }
}
