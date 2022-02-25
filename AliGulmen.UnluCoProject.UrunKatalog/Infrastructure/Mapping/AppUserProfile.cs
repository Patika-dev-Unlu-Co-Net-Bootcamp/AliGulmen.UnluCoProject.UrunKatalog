using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.UserResources;
using AutoMapper;

namespace AliGulmen.UnluCoProject.UrunKatalog.Infrastructure.Mapping
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser, UserResource>()
         .ForMember(x => x.Password, opt => opt.MapFrom(x => x.PasswordHash));
            CreateMap<SaveUserResource, AppUser>();

        }
    }
}
