#pragma checksum "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1a649dd98bcc2c5bd20e9adede3e0030947e4ac"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazor_crypto_marketcap.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using blazor_crypto_marketcap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using blazor_crypto_marketcap.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using ChartJs.Blazor.ChartJS.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using ChartJs.Blazor.ChartJS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using blazor_crypto_marketcap.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    public class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
       
    public static RootObject Coins;

    public static int Index = 1;
    public static string? SortType { get; set; }
    public static int CurrentCount { get; set; }

    public async void SortTable(string columnName)
    {
        CurrentCount++;
        SortType = columnName;

        await ProtectedSessionStore.SetAsync("clickCount", CurrentCount);
        await ProtectedSessionStore.SetAsync("sortType", columnName);

        this.StateHasChanged();

        SortType = await ProtectedSessionStore.GetAsync<string>("sortType");
        Coins = await CoinService.GetTopOneHundredCoinsByMarketCap(Table.SortType);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage ProtectedSessionStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CoinMetricService CoinService { get; set; }
    }
}
#pragma warning restore 1591