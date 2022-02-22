using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
