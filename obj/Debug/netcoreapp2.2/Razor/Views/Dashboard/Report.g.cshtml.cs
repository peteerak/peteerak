#pragma checksum "c:\Users\Pete pc\Desktop\kafer\Views\Dashboard\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "186556afafbad149e2cc2f946fd4fad2c139a40e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Report), @"mvc.1.0.view", @"/Views/Dashboard/Report.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Report.cshtml", typeof(AspNetCore.Views_Dashboard_Report))]
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
#line 1 "c:\Users\Pete pc\Desktop\kafer\Views\_ViewImports.cshtml"
using kafer_house;

#line default
#line hidden
#line 2 "c:\Users\Pete pc\Desktop\kafer\Views\_ViewImports.cshtml"
using kafer_house.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186556afafbad149e2cc2f946fd4fad2c139a40e", @"/Views/Dashboard/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 3773, true);
            WriteLiteral(@"
<div class=""card mb-3"">
    <div class=""card-header bg-warning text-dark"">
        <i class=""fa fa-thumbs-o-up"" aria-hidden=""true""></i>
        Project Chance of Success</div>
    <div class=""card-body"">
        <canvas id=""chart1"" class=""chartjs-render-monitor"" style=""display: block; ""></canvas>
    </div>
    <div class=""card-footer small text-muted"" style=""background-color:#ffd6cc;"">Updated yesterday at 11:59 PM</div>
</div>

    <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.6.0/Chart.min.js"" type=""text/javascript""></script>  
    <script src =""https://cdn.jsdelivr.net/gh/emn178/chartjs-plugin-labels/src/chartjs-plugin-labels.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
    <script>

// var sexy = ""nothing"";
	// $(document).ready(setup);

// 	function setup(){
// 		var url = 'https://jsonplaceholder.typicode.com/todos';
// 		$.get(url,done);
// 	}
	 
// 	function done(data){
// 		sexy = data;
// 		con");
            WriteLiteral(@"sole.log('inside done:', sexy[0]);
// 	}
// 	console.log('outside done:',sexy); // still outputed nothing
    $(document).ready(setup);
    function setup(){
        console.log(""ready"")
        var option = {
            type: ""Get"",  
              url: ""/Dashboard/data"",  
              contentType: ""application/json; charset=utf-8"",  
              dataType: ""json"",  
              success: data_arrived 
        };
        $.ajax(option);

    } //end setup
    function data_arrived(data){
        console.log(data, 'h')
            var a_data = data;
            var x_data = a_data[0];
            var y_data = a_data[1];
            var max    = a_data[2];
            var graph_data = {
                labels:x_data,
                datasets:[{
                label:""test"",
                data:y_data,
                fill: true,
                backgroundColor:['rgba(255,0,0,0.2)','rgba(0,255,0,0.2)','rgba(0,0,255,0.2)'],
                 borderColor: [""rgb(250,250,0,0.2)"", ");
            WriteLiteral(@"
                                ""rgb(255, 159, 64)"",
                                ""rgb(255, 99, 132)"",
                                ""rgba(0,255,0, 0.2)""
                                
                            ],
                borderWidth:2
            }]
            }

            var panel1 = $('#chart1').get(0).getContext(""2d"");
            var chart1 = new Chart(panel1,{
                        type:'pie',
                        data:graph_data,
                        options:{
                            maintainAspectRatio:false
                        }
            });

        }//ef


    var panel1 = $('#chart1').get(0).getContext(""2d"");
    var myChart = new Chart(panel1, {
    type: 'bar',
    data: {
        labels: x_data,
        datasets: [{
            label: '# of Votes',
            data: y_data,
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86");
            WriteLiteral(@", 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    }
});

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
