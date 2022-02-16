using System.Collections.Generic;

namespace AliGulmen.UnluCoProject.UrunKatalog.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
