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
#line 3 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ProductResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ConditionResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ColorResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.CategoryResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.BrandResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
using System.IdentityModel.Tokens.Jwt;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addProduct")]
    public partial class AddProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 162 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\AddProduct.razor"
       
    public SaveProductResource Product = new();
    public List<ConditionResource> Conditions = new();
    public List<ColorResource> Colors = new();
    public List<BrandResource> Brands = new();
    public List<CategoryResource> Categories = new();
    private int maxAllowedFiles = 1;
    private string _price;

    public string pictureUrl;
    private string _userId;
    private string _error;











    protected override async Task OnInitializedAsync()
    {
        _error = "";
        var client = ClientFactory.CreateClient();
        var token = await Storage.GetAsync<string>("token");

        if (!token.Success)
        {
            UriHelper.NavigateTo("login");
        }


        var request1 = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/conditions");
        var request2 = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/colors");
        var request3 = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/brands");
        var request4 = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/categories");




        request1.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);
        request2.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);
        request3.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);
        request4.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);


        var response1 = await client.SendAsync(request1);
        var response2 = await client.SendAsync(request2);
        var response3 = await client.SendAsync(request3);
        var response4 = await client.SendAsync(request4);

        if (response1.IsSuccessStatusCode)
        {
            var json = await response1.Content.ReadAsStringAsync();
            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<ConditionResource>>(json);
            Conditions = paginatedResult.Data;
        }
        else
        {
            UriHelper.NavigateTo("login");
        }

        if (response2.IsSuccessStatusCode)
        {
            var json = await response2.Content.ReadAsStringAsync();
            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<ColorResource>>(json);
            Colors = paginatedResult.Data;
        }
        else
        {
            UriHelper.NavigateTo("login");
        }


        if (response3.IsSuccessStatusCode)
        {
            var json = await response3.Content.ReadAsStringAsync();
            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<BrandResource>>(json);
            Brands = paginatedResult.Data;
        }
        else
        {
            UriHelper.NavigateTo("login");
        }


        if (response4.IsSuccessStatusCode)
        {
            var json = await response4.Content.ReadAsStringAsync();
            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<CategoryResource>>(json);
            Categories = paginatedResult.Data;
        }
        else
        {
            UriHelper.NavigateTo("login");
        }


    }




    private async Task AddNewProduct()
    {
        if(Product.CategoryId == 0 || Product.ConditionId== 0)
        {
            _error = "Lütfen Kategori ve Kullanım Durumları Alanlarını Doldurunuz!";
        }
        else
        {
            _error = "";
            var client = ClientFactory.CreateClient();


        var token = await Storage.GetAsync<string>("token");
        var handler = new JwtSecurityTokenHandler();
        _userId = handler.ReadJwtToken(token.Value).Claims.First().Value;
        Product.UserId = _userId;
        Product.BuyItNowPrice = Int32.Parse(_price);

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Value);
        var response = await client.PostAsJsonAsync("http://localhost:3000/api/products", Product);


        if (response.StatusCode == System.Net.HttpStatusCode.Created)
        {
            UriHelper.NavigateTo("home");
        }
        }
       

    }








    private async Task LoadFiles(InputFileChangeEventArgs e)
    {

        foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
        {
            try
            {

                var path = Path.Combine("wwwroot/Images", file.Name);
                pictureUrl =  file.Name;

                await using FileStream fs = new(pictureUrl, FileMode.Create);
                await file.OpenReadStream().CopyToAsync(fs);
                Product.PictureUrl = pictureUrl;
            }
            catch (Exception)
            {

            }
        }


       
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IWebHostEnvironment Environment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedLocalStorage Storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
