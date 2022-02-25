using System;

namespace AliGulmen.UnluCoProject.UrunKatalog.Core.Application.Responses
{
    public class TokenResponse
    {
        public string AccessToken { get; set; } //user infos will be here
        public DateTime Expiration { get; set; } //valid until
        public string RefreshToken { get; set; }
    }
}
