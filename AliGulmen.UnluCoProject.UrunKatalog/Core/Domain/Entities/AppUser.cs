using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
     
       
     

    }
}
