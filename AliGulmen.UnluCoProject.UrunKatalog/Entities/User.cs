

using AliGulmen.UnluCoProject.UrunKatalog.Common;

namespace AliGulmen.UnluCoProject.UrunKatalog.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public string EMail { get; set; }
     

    }
}
