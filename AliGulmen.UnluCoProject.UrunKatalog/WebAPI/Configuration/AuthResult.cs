using AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Responses;
using System.Collections.Generic;

namespace AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Configuration
{
    public class AuthResult
    {
        public TokenResponse Token { get; set; }
        public bool Success { get; set; }
        public List<string> Errors { get; set; }
    }
}
