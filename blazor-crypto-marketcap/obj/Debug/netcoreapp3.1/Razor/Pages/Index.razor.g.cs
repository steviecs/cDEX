#pragma checksum "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d36cbeff75c43c49ae68a9571e3b8f36f180670b"
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
#line 1 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.LineChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using ChartJs.Blazor.ChartJS.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using blazor_crypto_marketcap.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>stay awhile, and listen</h4>\n");
            __builder.AddMarkupContent(1, "<p>this is an ongoing project to familiarize myself with developing server-side blazor applications with azure</p>\n\n");
            __builder.AddMarkupContent(2, "<pre style=\"color:#F46957\">\n                              welcome\n                             _.--\"\"-._\n  .                         .\"         \".\n / \\    ,^.         /(     Y             |      )\\\n/   `---. |--\'\\    (  \\__..\'--   -   -- -\'\"\"-.-\'  )\n|        :|    `>   \'.     l_..-------.._l      .\'\n|      __l;__ .\'      \"-.__.||_.-\'v\'-._||`\"----\"\n \\  .-\' | |  `              l._       _.\'\n  \\/    | |                   l`^^\'^^\'j\n        | |                _   \\_____/     _\n        j |               l `--__)-\'(__.--\' |\n        | |               | /`---``-----\'\"1 |  ,-----.\n        | |               )/  `--\' \'---\'   \\\'-\'  ___  `-.\n        | |              //  `-\'  \'`----\'  /  ,-\'   I`.  \\\n      _ L |_            //  `-.-.\'`-----\' /  /  |   |  `. \\\n     \'._\' / \\         _/(   `/   )- ---\' ;  /__.J   L.__.\\ :\n      `._;/7(-.......\'  /        ) (     |  |            | |\n      `._;l _\'--------_/        )-\'/     :  |___.    _._./ ;\n        | |                 .__ )-\'\\  __  \\  \\  I   1   / /\n        `-\'                /   `-\\-(-\'   \\ \\  `.|   | ,\' /\n                           \\__  `-\'    __/  `-. `---\'\',-\'\n                              )-._.-- (        `-----\'\n                             )(  l\\ o (\'..-.\n                       _..--\' _\'-\' \'--\'.-. |\n                __,,-\'\' _,,-\'\'            \\ \\\n               f\'. _,,-\'                   \\ \\\n              ()--  |                       \\ \\\n                \\.  |                       /  \\\n                  \\ \\                      |._  |\n                   \\ \\                     |  ()|\n                    \\ \\                     \\  /\n                     ) `-.                   | |\n                    // .__)                  | |\n                 _.//7\'                      | |\n               \'---\'                         j_| `\n                                            (| |\n                                             |  \\\n                                             |lllj\n                                             |||||</pre>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591