#pragma checksum "/Users/ssullivan/cDEX/blazor-crypto-marketcap/Pages/Rss.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b9a15887d5e0729b117baf1832a8a557987c5f0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/rss")]
    public partial class Rss : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "/Users/ssullivan/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
       
    IEnumerable<Item> Feeds;
    int counter;

    protected override void OnInitialized()
    {
        Feeds = FeedService.GetFeed();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591