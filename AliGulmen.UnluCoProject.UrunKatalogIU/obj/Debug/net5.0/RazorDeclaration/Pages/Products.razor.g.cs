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
#line 2 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using AliGulmen.UnluCoProject.UrunKatalog.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.ProductResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using AliGulmen.UnluCoProject.UrunKatalog.WebAPI.Controllers.Resources.CategoryResources;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 116 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Products.razor"
       

    public List<ProductResource> MyProducts { get; set; }
    public List<CategoryResource> Categories = new();
    public CategoryResource Category = new();
    public string selectedCategory;
    public bool hasNextPage;
    public bool hasPrevPage;
    public int currentPage;

   

    public void GoToDetailPage(int id)
 {
        AppData.ProductId = id;
        UriHelper.NavigateTo("ProductDetail");
    }
    public async Task FilterResults(ChangeEventArgs e)
    {
        HttpRequestMessage request;
        var selectedCategory = e.Value.ToString();
        var client = ClientFactory.CreateClient();

        if (selectedCategory == "")
        {
            request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/products?PageSize=10&&PageNumber=1");
        }
        else
        {
            request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/Products?CategoryId="+selectedCategory+"&&PageSize=10&&PageNumber=1");  
        }



        var token =  await Storage.GetAsync<string>("token");


        request.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);
        var response = await client.SendAsync(request);


        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<ProductResource>>(json);
            MyProducts = paginatedResult.Data;
            hasNextPage = paginatedResult.HasNextPage;
            hasPrevPage = paginatedResult.HasPreviousPage;
            currentPage = paginatedResult.CurrentPage;
        }

    }


    protected override async Task OnInitializedAsync()
    {

        var client = ClientFactory.CreateClient();

        var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/products?PageSize=3&&PageNumber=1");
        var request2 = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/categories");



          var token =  await Storage.GetAsync<string>("token");


        request.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);

        request2.Headers.Authorization =
      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);


        var response = await client.SendAsync(request);
        var response2 = await client.SendAsync(request2);

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<ProductResource>>(json);
            MyProducts = paginatedResult.Data;
            hasNextPage = paginatedResult.HasNextPage;
            hasPrevPage = paginatedResult.HasPreviousPage;
            currentPage = paginatedResult.CurrentPage;

        }
        else
        {
            UriHelper.NavigateTo("login");
        }

         if (response2.IsSuccessStatusCode)
        {
            var json = await response2.Content.ReadAsStringAsync();

            var paginatedResult = JsonConvert.DeserializeObject<PaginatedResult<CategoryResource>>(json);

            Categories = paginatedResult.Data;
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Models.AppData AppData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory ClientFactory { get; set; }
    }
}
#pragma warning restore 1591
