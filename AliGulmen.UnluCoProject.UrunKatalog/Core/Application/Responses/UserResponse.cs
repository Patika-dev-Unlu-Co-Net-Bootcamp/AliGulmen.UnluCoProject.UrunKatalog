using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Responses
{
    public class UserResponse
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
    }
}
