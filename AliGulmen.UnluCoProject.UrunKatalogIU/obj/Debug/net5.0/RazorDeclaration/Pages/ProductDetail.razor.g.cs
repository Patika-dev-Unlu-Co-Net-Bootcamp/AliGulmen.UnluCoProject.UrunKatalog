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
#line 2 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.OfferResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ProductResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
using System.IdentityModel.Tokens.Jwt;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ProductDetail")]
    public partial class ProductDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\ProductDetail.razor"
       
    private int ActualNumber { get; set; } = 70;
    private string NewOffer;
    public SaveOfferResource OffertoCreate = new();
    public OfferResource CurrentOffer = new();
    private string _userId;
    private int ProductIdToCreate;
    bool showUpdateModal = false;


    public ProductResource product { get; set; }
    public SaveProductResource productToBuy { get; set; }
    public int ProductId;

    public void CheckSliderRating()
    {
        NewOffer = (ActualNumber * product.BuyItNowPrice / 100).ToString();
    }


    public void Calc(string step)
    {
        ActualNumber = Convert.ToInt32(step);
    }







    protected override async Task OnInitializedAsync()
    {
        CurrentOffer = null;
        ProductId = (AppData.ProductId ==0) ? 1: AppData.ProductId;
        var client = ClientFactory.CreateClient();

        var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/products/"+ProductId);



        var token =  await Storage.GetAsync<string>("token");
        var handler = new JwtSecurityTokenHandler();
        if(token.Success)
            _userId = handler.ReadJwtToken(token.Value).Claims.First().Value;

        request.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);


        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            product = JsonConvert.DeserializeObject<ProductResource>(json);
            ProductId = product.Id;

        }
        else
        {
            UriHelper.NavigateTo("login");
        }




        request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/Offers?ProductId="+ProductId.ToString() + "&&UserId=" + _userId); 

        request.Headers.Authorization =
           new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);

        response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<OfferResource>>(json);
            CurrentOffer = paginatedResult.Data.FirstOrDefault();
        }
        else
        {

        }

    }




    public async Task DeleteOffer(int id)
    {

        var client = ClientFactory.CreateClient();

        var token =  await Storage.GetAsync<string>("token");


        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);

        var response = await client.DeleteAsync("http://localhost:3000/api/offers/"+id);


        if (response.StatusCode == System.Net.HttpStatusCode.NoContent || response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {

            await OnInitializedAsync();
        }
    }






    public async Task BuyProduct(int id)
    {

        var client = ClientFactory.CreateClient();

        var token =  await Storage.GetAsync<string>("token");
        var handler = new JwtSecurityTokenHandler();
        _userId = handler.ReadJwtToken(token.Value).Claims.First().Value;


        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);

        var response = await client.PutAsJsonAsync("http://localhost:3000/api/products/sell/"+id, _userId);


        if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
        {

            await OnInitializedAsync();
        }
    }









    public async Task CreateOffer()
    {
        showUpdateModal = false;

        var client = ClientFactory.CreateClient();


        var token =  await Storage.GetAsync<string>("token");
        var handler = new JwtSecurityTokenHandler();
        _userId = handler.ReadJwtToken(token.Value).Claims.First().Value;

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);
        OffertoCreate.OfferedPrice =Convert.ToInt32(NewOffer);
        OffertoCreate.OfferStatus = UrunKatalog.Core.Domain.Enums.OfferStatus.BEKLEMEDE;
        OffertoCreate.ProductId = ProductIdToCreate;
        OffertoCreate.UserId = _userId;


        var response = await client.PostAsJsonAsync("http://localhost:3000/api/offers/", OffertoCreate);


        if (response.StatusCode == System.Net.HttpStatusCode.Created)
        {

            await OnInitializedAsync();
        }


    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Models.AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
