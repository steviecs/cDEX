#pragma checksum "/Users/ssullivan/cDEX/blazor-crypto-marketcap/Pages/Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab6040f82b5262a7ba88037203c41f7087f52c5a"
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
#line 1 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/Pages/Table.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    public partial class Table : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/Pages/Table.razor"
       
    public static Coins Coins;
    public static string? SortType { get; set; }
    public static int CurrentCount { get; set; }
    public static string className { get; set; }

    public string Format(decimal? d)
    {
        if (d.ToString().StartsWith("0.00"))
        {
            return d != null ? String.Format("{0:C8}", d).Replace("¤", "") : "";
        }

        return d != null ? String.Format("{0:C2}", d).Replace("¤", "") : "";
    }

    public string FormatPercentage(decimal? d)
    {
        return d != null ? d.ToString() : "";
    }

    public async void SortTable(string columnName)
    {
        CurrentCount++;
        SortType = columnName;

        await ProtectedSessionStore.SetAsync("clickCount", CurrentCount);
        await ProtectedSessionStore.SetAsync("sortType", columnName);

        SortType = await ProtectedSessionStore.GetAsync<string>("sortType");
        Coins = await CoinService.GetTopOneHundredCoinsByMarketCap(Table.SortType);

        this.StateHasChanged();
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
