﻿using System.ComponentModel.DataAnnotations;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities
{
    public class Color : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

    }
}