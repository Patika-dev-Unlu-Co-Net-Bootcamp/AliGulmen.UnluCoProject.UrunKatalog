using AliGulmen.UnluCoProject.UrunKatalog.Core.Entities;
using System.Collections.Generic;

namespace AliGulmen.UnluCoProject.UrunKatalog.Configuration
{
    public class AuthResult
    {
        public Token Token { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
