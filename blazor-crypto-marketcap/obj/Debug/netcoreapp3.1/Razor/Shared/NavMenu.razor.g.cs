#pragma checksum "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb3f4c5e76f79a1fd3735d8506047b18adc7d950"
// <auto-generated/>
#pragma warning disable 1591
namespace blazor_crypto_marketcap.Shared
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div style=\"background-color: #63C9B8;\" class=\"top-row pl-4 navbar\">\n        <h4 style=\"color: #24374A\">cdex</h4>\n</div>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 5 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Shared/NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Shared/NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "ul");
            __builder.AddAttribute(6, "class", "nav flex-column");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.OpenElement(8, "li");
            __builder.AddAttribute(9, "class", "nav-item px-3");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
            __builder.AddAttribute(12, "class", "nav-link");
            __builder.AddAttribute(13, "href", "");
            __builder.AddAttribute(14, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Shared/NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(16, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> home\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n        ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", "nav-item px-3");
            __builder.AddMarkupContent(21, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "class", "nav-link");
            __builder.AddAttribute(24, "href", "rss");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\n                <span class=\"oi oi-rss\" aria-hidden=\"true\"></span> rss\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n        ");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "nav-item px-3");
            __builder.AddMarkupContent(31, "\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "nav-link");
            __builder.AddAttribute(34, "href", "metrics");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\n                <span class=\"oi oi-bar-chart\" aria-hidden=\"true\"></span> metrics / charts\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Shared/NavMenu.razor"
       
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
