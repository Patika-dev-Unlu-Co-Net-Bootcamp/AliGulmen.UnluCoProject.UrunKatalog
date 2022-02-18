using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Entities
{
    public class Color : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}
