#pragma checksum "C:\Users\_psTALENTFOUR\source\repos\StackedChartwithCoreMVCDemo\StackedChartwithCoreMVCDemo\Views\StackedChart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af7b649ac64016068b5c357664d32364e56dcb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StackedChart_Index), @"mvc.1.0.razor-page", @"/Views/StackedChart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/StackedChart/Index.cshtml", typeof(AspNetCore.Views_StackedChart_Index), null)]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\_psTALENTFOUR\source\repos\StackedChartwithCoreMVCDemo\StackedChartwithCoreMVCDemo\Views\_ViewImports.cshtml"
using StackedChartwithCoreMVCDemo;

#line default
#line hidden
#line 2 "C:\Users\_psTALENTFOUR\source\repos\StackedChartwithCoreMVCDemo\StackedChartwithCoreMVCDemo\Views\_ViewImports.cshtml"
using StackedChartwithCoreMVCDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af7b649ac64016068b5c357664d32364e56dcb3", @"/Views/StackedChart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b81376a2b7e27e2c28d18c485283a29ea71ebf", @"/Views/_ViewImports.cshtml")]
    public class Views_StackedChart_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(80, 9, true);
            WriteLiteral("\r\n<title>");
            EndContext();
            BeginContext(90, 17, false);
#line 6 "C:\Users\_psTALENTFOUR\source\repos\StackedChartwithCoreMVCDemo\StackedChartwithCoreMVCDemo\Views\StackedChart\Index.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(107, 1917, true);
            WriteLiteral(@" - DemoGoogleChart</title>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<div id=""chart_div""></div>
<script type=""text/javascript"">


    google.charts.load('current', {
        packages: ['corechart', 'bar']
    });
    google.charts.setOnLoadCallback(LoadData);

    function LoadData() {
        $.ajax({

            url: 'StackedChart/PopulationChart',
            dataType: ""json"",
            type: ""GET"",
            error: function(xhr, status, error) {
                var err = eval(""("" + xhr.responseText + "")"");
                toastr.error(err.message);
            },
            success: function(data) {
                PopulationChart(data);
                return false;
            }
        });
        return false;
    }

    function PopulationChart(data) {
        var dataArray = [
            ['City', '2020 Population', '2010 Population', '2000 Population', '1990 Population']
        ];
        $.each(data, function(i");
            WriteLiteral(@", item) {
            dataArray.push([item.cityName, item.populationYear2020, item.populationYear2010, item.populationYear2000, item.populationYear1990]);
        });
        var data = google.visualization.arrayToDataTable(dataArray);
        var options = {
            title: 'Population of Largest Cities of Odisha ',

            is3D: true,
            isStacked: true,

            chartArea: {
                width: '50%'
            },
            colors: ['#b0120a', '#7b1fa2', '#ffab91', '#d95f02'],
            hAxis: {
                title: 'City',
                minValue: 0
            },
            vAxis: {
                title: 'Total Population'
            }
        };
        var chart = new google.visualization.ColumnChart(document.getElementById('chart_div'));

        chart.draw(data, options);
        return false;
    }
</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StackedChartwithCoreMVCDemo.Views.StackedChart.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StackedChartwithCoreMVCDemo.Views.StackedChart.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StackedChartwithCoreMVCDemo.Views.StackedChart.IndexModel>)PageContext?.ViewData;
        public StackedChartwithCoreMVCDemo.Views.StackedChart.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
