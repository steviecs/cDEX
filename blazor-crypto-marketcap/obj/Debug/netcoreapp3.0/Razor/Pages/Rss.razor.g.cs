#pragma checksum "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0725b33bbff2516afcb0b607269a05525ac310c"
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
#line 2 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
using blazor_crypto_marketcap.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/rss")]
    public class Rss : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>latest crypto news</h4>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>this component demonstrates subscribing to an rss feed</p>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
 if (feeds == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
}
else
{
    counter = 0;

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 17 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
             foreach (var feed in feeds)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddAttribute(12, "class", "table-rows");
            __builder.AddAttribute(13, "id", "link");
            __builder.AddAttribute(14, "href", "/" + (
#nullable restore
#line 19 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
                                                         feed.Link2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n                    > ");
            __builder.AddContent(16, 
#nullable restore
#line 20 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
                       feed.Title.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n                    <br>\r\n                    ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, "  ");
            __builder.AddContent(20, 
#nullable restore
#line 22 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
                          feed.PubDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 24 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 27 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Rss.razor"
       
    IEnumerable<Item> feeds;
    int counter;

    protected override async Task OnInitializedAsync()
    {
        //feeds = null;
        feeds = FeedService.GetFeed();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591