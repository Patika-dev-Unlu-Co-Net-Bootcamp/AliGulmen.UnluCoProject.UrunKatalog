#pragma checksum "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "938c6ad3876e7a439156cd248be500ed8126aa18"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class Categories : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 13 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
 if (MyCategories == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Id</th>\r\n                <th>Category Name</th>\r\n                <th>Category Description</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 28 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
             foreach (var category in MyCategories)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 31 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
__builder.AddContent(7, category.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n                    ");
            __builder.OpenElement(9, "td");
#nullable restore
#line 32 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
__builder.AddContent(10, category.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
#nullable restore
#line 33 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
__builder.AddContent(13, category.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
                                            () => { showModal = true; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, "Yeni Kategori Ekle");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n<br><br>\r\n");
            __builder.OpenElement(19, "p");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
                                              SignOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "Çıkış Yap");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
 if (showModal)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "modal fade show");
            __builder.AddAttribute(26, "tabindex", "-1");
            __builder.AddAttribute(27, "role", "dialog");
            __builder.AddAttribute(28, "style", "display: block;");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-dialog");
            __builder.AddAttribute(31, "role", "document");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-content");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "modal-header");
            __builder.AddMarkupContent(36, "<h5 class=\"modal-title\">Modal title</h5>\r\n                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "close");
            __builder.AddAttribute(40, "data-dismiss", "modal");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
                                                                                     () => { showModal = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "aria-label", "Close");
            __builder.AddMarkupContent(43, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<div class=\"modal-body\"><p>Modal body text goes here.</p></div>\r\n            ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-footer");
            __builder.AddMarkupContent(48, "<button type=\"button\" class=\"btn btn-primary\">Save changes</button>\r\n                ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-secondary");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
                                                                            () => { showModal = false; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "data-dismiss", "modal");
            __builder.AddContent(54, "Close");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
 



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\aligu\Desktop\patika\Tasks\BitirmeProjesi\AliGulmen.UnluCoProject.UrunKatalog\AliGulmen.UnluCoProject.UrunKatalogIU\Pages\Categories.razor"
       

    public List<AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.CategoryResources.CategoryResource> MyCategories { get; set; }
     bool showModal = false;

    public async Task SignOut()
    {
        await Storage.DeleteAsync("token");
         UriHelper.NavigateTo("login");
    }

     public async Task AddCategory()
    {
         UriHelper.NavigateTo("login");
    }

    protected override async Task OnInitializedAsync()
    {

        var client = ClientFactory.CreateClient();

        var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:3000/api/categories");


        var token =  await Storage.GetAsync<string>("token");


        request.Headers.Authorization =
            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Value);


        var response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            MyCategories = JsonConvert.DeserializeObject<List<AliGulmen.UnluCoProject.UrunKatalog.Controllers.WebAPI.Resources.CategoryResources.CategoryResource>>(json);


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
