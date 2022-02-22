using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Entities;
using System.Collections.Generic;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Configuration
{
    public class AuthResult
    {
        public Token Token { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
