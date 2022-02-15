using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
