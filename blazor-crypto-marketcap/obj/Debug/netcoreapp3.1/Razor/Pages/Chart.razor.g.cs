#pragma checksum "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0c8e7a74a343b7b898ab6bf68ef3a73a0c6aff4"
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
#nullable restore
#line 2 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
using ChartJs.Blazor.ChartJS.Common.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart/{symbol}")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h4");
            __builder.AddContent(1, 
#nullable restore
#line 6 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
     Symbol.ToLower()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\n\n");
            __builder.AddMarkupContent(3, "<p>this component demonstrates charting data from an API response</p>\n\n");
#nullable restore
#line 10 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
 if (LineConfig == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.AddMarkupContent(5, "<p><em>loading...</em></p>\n");
#nullable restore
#line 13 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenComponent<ChartJs.Blazor.Charts.ChartJsLineChart>(7);
            __builder.AddAttribute(8, "Config", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ChartJs.Blazor.ChartJS.LineChart.LineConfig>(
#nullable restore
#line 16 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
                                                   LineConfig

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 16 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
                                                                      600

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Height", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32?>(
#nullable restore
#line 16 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
                                                                                   300

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(11, (__value) => {
#nullable restore
#line 16 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
                             LineChartJs = (ChartJs.Blazor.Charts.ChartJsLineChart)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 17 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "/Users/ssullivan/RiderProjects/cDEX-1/blazor-crypto-marketcap/Pages/Chart.razor"
       
    [Parameter]
    public string Symbol { get; set; }
    private LineConfig LineConfig { get; set; }
    private ChartJsLineChart LineChartJs { get; set; }
    private LineDataset<Point> PointDataset { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var historicalData = await CoinService.GetHistoricalChartData(Symbol);

        LineConfig = new LineConfig()
        {
            Options = new LineOptions()
            {
                Title = new OptionsTitle()
                {
                    Display = true,
                    Text = Symbol
                },
                Responsive = true,
                Tooltips = new Tooltips
                {
                    Mode = InteractionMode.Nearest,
                    Intersect = false
                },
                Scales = new Scales
                {
                    xAxes = new List<CartesianAxis>
                    {
                        new LinearCartesianAxis
                        {
                            ScaleLabel = new ScaleLabel
                            {
                                LabelString = "Time"
                            }
                        }
                    },
                    yAxes = new List<CartesianAxis>()
                    {
                        new LinearCartesianAxis
                        {
                            ScaleLabel = new ScaleLabel
                            {
                                LabelString = "Value"
                            }
                        }
                    }
                }
            }
        };

        PointDataset = new LineDataset<Point>()
        {
            BackgroundColor = "#24374A",
            BorderWidth = 0,
            BorderColor = "#438081",
        };
        
        PointDataset.AddRange(historicalData.Data.data.Select(i => new Point(i.Time, i.Close)));
        LineConfig.Data.Datasets.Add(PointDataset);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CoinMetricService CoinService { get; set; }
    }
}
#pragma warning restore 1591
