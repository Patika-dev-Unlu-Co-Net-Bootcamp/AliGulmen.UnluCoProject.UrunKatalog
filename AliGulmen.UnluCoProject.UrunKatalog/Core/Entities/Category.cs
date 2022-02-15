using System;
using System.Collections.Generic;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public ICollection<Product> Products { get; set; }
    }
}
