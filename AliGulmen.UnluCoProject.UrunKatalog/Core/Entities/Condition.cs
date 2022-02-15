using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{
    public class Condition
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationDate { get; set; } = DateTime.Now;

    }
}
