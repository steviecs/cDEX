#pragma checksum "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1a649dd98bcc2c5bd20e9adede3e0030947e4ac"
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
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\r\n                ");
            __builder.AddMarkupContent(7, "<th><span class=\"sort-link\">#</span></th>\r\n                ");
            __builder.OpenElement(8, "th");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                e => SortTable("symbol")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<span class=\"sort-link\">name</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "th");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                e => SortTable("price")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "<span class=\"sort-link\">price</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "th");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                e => SortTable("market_cap")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "<span class=\"sort-link\">market cap</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "th");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                e => SortTable("volume_24h")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "<span class=\"sort-link\">volume (24h)</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "th");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                e => SortTable("percent_change_1h")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(26, "<span class=\"sort-link\">change (1h)</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "th");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                e => SortTable("percent_change_24h")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "<span class=\"sort-link\">change (24h)</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "th");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                e => SortTable("percent_change_7d")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(34, "<span class=\"sort-link\">change (7d)</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "tbody");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 19 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
             foreach (var metric in Coins.Data)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                ");
            __builder.OpenElement(41, "tr");
            __builder.AddAttribute(42, "class", "table-rows");
            __builder.AddAttribute(43, "onclick", "location.href=\'/chart/" + (
#nullable restore
#line 21 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                                                       metric.Symbol.ToString()

#line default
#line hidden
#nullable disable
            ) + "\'");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, "<td>></td>\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 23 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                         metric.Symbol.ToString().ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, "$");
            __builder.AddContent(51, 
#nullable restore
#line 24 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                          metric.Quote.USD.Price.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, "$");
            __builder.AddContent(55, 
#nullable restore
#line 25 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                          metric.Quote.USD.Market_Cap.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, "$");
            __builder.AddContent(59, 
#nullable restore
#line 26 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                          metric.Quote.USD.Volume_24h.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                     if (@metric.Quote.USD.Percent_Change_1h.ToString().Contains("-") ||
                      @metric.Quote.USD.Percent_Change_24h.ToString().Contains("-") ||
                      @metric.Quote.USD.Percent_Change_7d.ToString().Contains("-"))
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(61, "                        ");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "class", "negative");
            __builder.AddContent(64, 
#nullable restore
#line 32 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                              metric.Quote.USD.Percent_Change_1h.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
            __builder.AddAttribute(67, "class", "negative");
            __builder.AddContent(68, 
#nullable restore
#line 33 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                              metric.Quote.USD.Percent_Change_24h.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "td");
            __builder.AddAttribute(71, "class", "negative");
            __builder.AddContent(72, 
#nullable restore
#line 34 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                              metric.Quote.USD.Percent_Change_7d.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 35 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                        ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "class", "positive");
            __builder.AddContent(77, 
#nullable restore
#line 38 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                              metric.Quote.USD.Percent_Change_1h.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                        ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "class", "positive");
            __builder.AddContent(81, 
#nullable restore
#line 39 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                              metric.Quote.USD.Percent_Change_24h.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                        ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "class", "positive");
            __builder.AddContent(85, 
#nullable restore
#line 40 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                                              metric.Quote.USD.Percent_Change_7d.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#nullable restore
#line 41 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(87, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
#nullable restore
#line 43 "C:\Users\Stevie\source\repos\blazor-crypto-marketcap\blazor-crypto-marketcap\Pages\Table.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(89, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    ");
            __builder.CloseElement();
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