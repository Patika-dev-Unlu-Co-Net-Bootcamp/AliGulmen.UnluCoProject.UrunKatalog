// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AliGulmen.UnluCoProject.UrunKatalogIU.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using AliGulmen.UnluCoProject.UrunKatalogIU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\_Imports.razor"
using AliGulmen.UnluCoProject.UrunKatalogIU.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using AliGulmen.UnluCoProject.UrunKatalog.Core.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.PurchaseHistoryResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.CategoryResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
using System.IdentityModel.Tokens.Jwt;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/purchases")]
    public partial class Purchases : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Purchases.razor"
       
    public List<PurchaseHistoryResource> MyPurchases { get; set; }
    public List<PurchaseHistoryResource> MySold { get; set; }
    private string _userId;



    
    protected override async Task OnInitializedAsync()
    {
     var client = ClientFactory.CreateClient();


        var token = await Storage.GetAsync<string>("token");
        var handler = new JwtSecurityTokenHandler();
        _userId = handler.ReadJwtToken(token.Value).Claims.First().Value;

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);

        var response1 = await client.PostAsJsonAsync("http://localhost:3000/api/PurchaseHistories/purchased",_userId);

        if (response1.IsSuccessStatusCode)
        {
            var json = await response1.Content.ReadAsStringAsync();

            MyPurchases = JsonConvert.DeserializeObject<List<PurchaseHistoryResource>>(json);


        }
        else
        {
            UriHelper.NavigateTo("login");
        }


         var response2 = await client.PostAsJsonAsync("http://localhost:3000/api/PurchaseHistories/sold",_userId);

        if (response2.IsSuccessStatusCode)
        {
            var json = await response2.Content.ReadAsStringAsync();

            MySold = JsonConvert.DeserializeObject<List<PurchaseHistoryResource>>(json);


        }
        else
        {
            UriHelper.NavigateTo("login");
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591