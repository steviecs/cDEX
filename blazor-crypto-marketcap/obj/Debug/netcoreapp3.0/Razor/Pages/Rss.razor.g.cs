#pragma checksum "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0662326ae72c36aea65eaaea41e05cd184b380ff"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_crypto_marketcap.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rss")]
    public partial class Rss : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>latest crypto news</h4>\n\n");
            __builder.AddMarkupContent(1, "<p>this component demonstrates subscribing to an rss feed</p>\n\n");
#nullable restore
#line 7 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
 if (Feeds == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 10 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\n");
#nullable restore
#line 15 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
             foreach (var feed in Feeds)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddAttribute(12, "class", "table-rows");
            __builder.AddAttribute(13, "id", "link");
            __builder.AddAttribute(14, "target", "_blank");
            __builder.AddAttribute(15, "onclick", "location.href=\'" + (
#nullable restore
#line 17 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
                                                                                      feed.Link2

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddMarkupContent(16, "\n                > ");
            __builder.AddContent(17, 
#nullable restore
#line 18 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
                   feed.Title.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\n\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "style", "color: #FFAD30");
            __builder.AddContent(21, 
#nullable restore
#line 20 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
                                           feed.PubDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n");
#nullable restore
#line 22 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 25 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "/home/skrmzmtn/Downloads/cDEX/blazor-crypto-marketcap/Pages/Rss.razor"
       
    IEnumerable<Item> Feeds;

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
