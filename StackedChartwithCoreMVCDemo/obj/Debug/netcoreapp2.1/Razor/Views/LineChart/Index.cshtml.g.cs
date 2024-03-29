#pragma checksum "C:\Users\_psTALENTFOUR\source\repos\StackedChartwithCoreMVCDemo\StackedChartwithCoreMVCDemo\Views\LineChart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04750b0987e6ab3804f888b83c4c49e44dad550c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LineChart_Index), @"mvc.1.0.view", @"/Views/LineChart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LineChart/Index.cshtml", typeof(AspNetCore.Views_LineChart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04750b0987e6ab3804f888b83c4c49e44dad550c", @"/Views/LineChart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3b81376a2b7e27e2c28d18c485283a29ea71ebf", @"/Views/_ViewImports.cshtml")]
    public class Views_LineChart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 7, true);
            WriteLiteral("<title>");
            EndContext();
            BeginContext(8, 17, false);
#line 1 "C:\Users\_psTALENTFOUR\source\repos\StackedChartwithCoreMVCDemo\StackedChartwithCoreMVCDemo\Views\LineChart\Index.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(25, 1848, true);
            WriteLiteral(@" - Line Chart</title>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>

<div id=""chart_div""></div>
<script type=""text/javascript"">


    google.charts.load('current', {
        packages: ['corechart', 'bar']
    });
    google.charts.setOnLoadCallback(LoadData);

    function LoadData() {
        $.ajax({

            url: 'LineChart/PopulationChart',
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
        $.each(data, function(i, item) ");
            WriteLiteral(@"{
            dataArray.push([item.cityName, item.populationYear2020, item.populationYear2010, item.populationYear2000, item.populationYear1990]);
        });
        var data = google.visualization.arrayToDataTable(dataArray);
        var options = {
            title: 'Population of Largest Cities of Odisha ',
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
        var chart = new google.visualization.LineChart(document.getElementById('chart_div'));

        chart.draw(data, options);
        return false;
    }
</script>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
