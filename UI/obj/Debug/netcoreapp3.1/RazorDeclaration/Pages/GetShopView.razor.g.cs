#pragma checksum "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2dae075e9d286e6dd7cc163d6f1f8c798b0cb20"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 2 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using UI.Pages.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using UI.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\_Imports.razor"
using UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using AutoDetailsFirmaBLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using AutoDetailsFirmaBLL.Services.EFServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using System.Net.Http.Formatting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using AutoDetailsFirmaBLL.Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using FluentValidation.Results;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/api/Shop")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/api/Shop/{id}")]
    public partial class GetShopView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 144 "D:\Универ\2 Курс 4 семестр\ООП\A project\AutoDetailsFirmaAPI\UI\Pages\GetShopView.razor"
                
        private List<AutoDetailsFirmaDAL.Entities.Shop> shopList = new List<AutoDetailsFirmaDAL.Entities.Shop>();

        protected override async Task OnInitializedAsync() => await GetShops();

        HttpClient httpClient = new HttpClient();


        private async Task GetShops() => shopList = await httpClient.GetJsonAsync<List<AutoDetailsFirmaDAL.Entities.Shop>>("https://localhost:44367/api/Shop/paged");
        private async void DeleteShop(int id)
        {
            string baseUrl = "https://localhost:44367";
            string endpoint = $"{baseUrl}/api/Shop/{id}";

            await httpClient.DeleteAsync(endpoint);
        }

        ShopDTO shopDTO { get; set; } = new ShopDTO();


        private async void HandleValidSubmit()
        {

            try
            {
                await shopService.AddShops(shopDTO);
            }
            catch
            {

            }
        }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEFShopService shopService { get; set; }
    }
}
#pragma warning restore 1591