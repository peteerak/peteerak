#pragma checksum "c:\Users\Pete pc\Desktop\kafer\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b68683bc2fb1245d9d6d09a7569d5d0b78f7c5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b68683bc2fb1245d9d6d09a7569d5d0b78f7c5f", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 9786, true);
            WriteLiteral(@"  <!-- Page Content -->
  <div class=""content content-full"">
    <!-- Overview -->
    <!-- <div class=""d-flex justify-content-between align-items-center py-3"">
        <h2 class=""h3 font-w400 mb-0"">Overview</h2>
        <div class=""dropdown"">
            <button type=""button"" class=""btn btn-sm btn-light px-3"" id=""dropdown-analytics-overview"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                Last 30 days <i class=""fa fa-fw fa-angle-down""></i>
            </button>
            <div class=""dropdown-menu dropdown-menu-right font-size-sm"" aria-labelledby=""dropdown-analytics-overview"">
                <a class=""dropdown-item"" href=""javascript:void(0)"">This Week</a>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Week</a>
                <div class=""dropdown-divider""></div>
                <a class=""dropdown-item"" href=""javascript:void(0)"">This Month</a>
                <a class=""dropdown-item"" href=""javascript:void(0)"">Previous Month</a>
 ");
            WriteLiteral(@"           </div>
        </div>
    </div>
    <div class=""row row-deck"">
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"">
            <a class=""block block-rounded block-fx-pop text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-primary-lighter mx-auto my-3"">
                        <i class=""fa fa-users text-primary""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">35.8k</div>
                    <div class=""text-muted mt-1"">Visitors</div>
                    <div class=""py-3 font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        15.7%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""150"">
            <a class=""block block-rounded block-");
            WriteLiteral(@"fx-pop text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-xinspire-lighter mx-auto my-3"">
                        <i class=""fa fa-eye text-xinspire-dark""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">98.5k</div>
                    <div class=""text-muted mt-1"">Page views</div>
                    <div class=""py-3 font-size-h4 font-w700 text-danger"">
                        <i class=""fa fa-caret-down mr-1""></i>
                        2.4%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""300"">
            <a class=""block block-rounded block-fx-pop text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-xsmooth-lighter mx-auto my-3");
            WriteLiteral(@""">
                        <i class=""fa fa-columns text-xsmooth""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">25</div>
                    <div class=""text-muted mt-1"">Pages per visit</div>
                    <div class=""py-3 font-size-h4 font-w700 text-success"">
                        <i class=""fa fa-caret-up mr-1""></i>
                        52.5%
                    </div>
                </div>
            </a>
        </div>
        <div class=""col-sm-6 col-xl-3 invisible"" data-toggle=""appear"" data-timeout=""450"">
            <a class=""block block-rounded block-fx-pop text-center"" href=""javascript:void(0)"">
                <div class=""block-content block-content-full"">
                    <div class=""item item-circle bg-xplay-lighter mx-auto my-3"">
                        <i class=""fa fa-level-up-alt text-xplay""></i>
                    </div>
                    <div class=""text-black display-4 font-w700"">12.5%</div>
               ");
            WriteLiteral(@"     <div class=""text-muted mt-1"">Bounce Rate</div>
                    <div class=""py-3 font-size-h4 font-w700 text-danger"">
                        <i class=""fa fa-caret-down mr-1""></i>
                        5.7%
                    </div>
                </div>
            </a>
        </div>
    </div> -->
    <!-- END Overview -->




    <!-- Sales Report -->
    <div class=""d-flex justify-content-between align-items-center pt-5 pb-3"">
        <h2 class=""h3 font-w400 mb-0"">Sales Report</h2>
        
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <div class=""form-group"">
                <label for=""shoppingMall_names"">Shopping Mall:</label>
                <select class=""form-control"" id=""shoppingMall_names""></select>
            </div>
        </div>
        <div class=""col-md-3"">
            <div class=""form-group"">
                <label for=""branch_names"">Branch:</label>
                <select class=""form-control"" id=""branch_names""></select");
            WriteLiteral(@">
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label >Date Duration:</label>
                <div class=""input-daterange input-group"" data-date-format=""dd/mm/yyyy"" data-week-start=""1"" data-autoclose=""true"" data-today-highlight=""true"">
                    <input type=""text"" class=""form-control"" id=""example-daterange1"" name=""example-daterange1"" placeholder=""From"" data-week-start=""1"" data-autoclose=""true"" data-today-highlight=""true"">
                    <div class=""input-group-prepend input-group-append"">
                        <span class=""input-group-text font-w600"">
                            <i class=""fa fa-fw fa-arrow-right""></i>
                        </span>
                    </div>
                    <input type=""text"" class=""form-control"" id=""example-daterange2"" name=""example-daterange2"" placeholder=""To"" data-week-start=""1"" data-autoclose=""true"" data-today-highlight=""true"">
                </div>
            <");
            WriteLiteral(@"/div>
        </div>
        <div class=""col-md-2"">
            <label style=""color: #f4f6fa"">.</label>
            <button id=""confirm"" type=""button"" class=""btn btn-outline-primary btn-block"">Confirm</button>

        </div>
    </div>
 
   
    
    <div style=""margin-top: 10px"" class=""block block-rounded block-fx-pop invisible"" data-toggle=""appear"">
        <div class=""block-content block-content-full"">
            <div class=""row"">
               
                <div  class=""col-md-12 col-lg-12"">
                    <div class=""p-md-2 p-lg-3"">
                        <!-- Bars Chart Container -->
                        <!-- Chart.js Chart is initialized in js/pages/db_analytics.min.js which was auto compiled from _es6/pages/db_analytics.js -->
                        <!-- For more info and examples you can check out http://www.chartjs.org/docs/ -->
                        <canvas id=""myChart"" ></canvas>
                    </div>
                </div>
            </div>
        ");
            WriteLiteral(@"</div>
    </div>
    <!-- END Visitors Growth -->

    <!-- Quick Statistics -->
    <div class=""d-flex justify-content-between align-items-center pt-5 pb-3"">
        <h2 class=""h3 font-w400 mb-0"">Loss Products</h2>
    </div>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""form-group"">
                <label >Date Duration:</label>
                <div class=""input-daterange input-group"" data-date-format=""dd/mm/yyyy"" data-week-start=""1"" data-autoclose=""true"" data-today-highlight=""true"">
                    <input type=""text"" class=""form-control"" id=""date_loss_1"" name=""date_loss_1"" placeholder=""From"" data-week-start=""1"" data-autoclose=""true"" data-today-highlight=""true"">
                    <div class=""input-group-prepend input-group-append"">
                        <span class=""input-group-text font-w600"">
                            <i class=""fa fa-fw fa-arrow-right""></i>
                        </span>
                    </div>
                    <input typ");
            WriteLiteral(@"e=""text"" class=""form-control"" id=""date_loss_2"" name=""date_loss_2"" placeholder=""To"" data-week-start=""1"" data-autoclose=""true"" data-today-highlight=""true"">
                </div>
            </div>
        </div>
        <div class=""col-md-2"">
            <label style=""color: #f4f6fa"">.</label>
            <button id=""confirm_loss"" type=""button"" class=""btn btn-outline-primary btn-block"">Confirm</button>

        </div>
    </div>


      <div class=""content"">
            <div class=""block block-rounded block-bordered"" style=""min-height: 500px"">
              <div class=""block-header block-header-default"">
                <h3 class=""block-title"">Detail</h3>
          
              </div>
               <!-- Multiple Items -->
                   <div class=""col-lg-12 push"">
                       <div id=""accordion2"" role=""tablist"" aria-multiselectable=""true"">
                       </div>
                   </div>
               </div>
               <!-- END Multiple Items -->
        ");
            WriteLiteral(@"</div>
    </div>
</div>
<!-- END Page Content -->



<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>


<!-- Page JS Plugins -->
 <script src=""assets/js/plugins/easy-pie-chart/jquery.easypiechart.min.js""></script>
 <script src=""assets/js/plugins/chart.js/Chart.bundle.min.js""></script>

 <!-- Page JS Code -->
 <script src=""assets/js/pages/db_analytics.min.js""></script>

 <!-- Page JS Helpers (Easy Pie Chart Plugin) -->
 <!-- <script>jQuery(function(){ Dashmix.helpers('easy-pie-chart'); });</script> -->

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9804, 8935, true);
                WriteLiteral(@"
    <script>
        var cmb_shoppingMall_names = $('#shoppingMall_names'); 
        var cmb_branch_names       = $('#branch_names'); 
        var cmb_from_date          = $('#example-daterange1'); 
        var cmb_to_date            = $('#example-daterange2'); 
        var cmb_date_loss_1        = $('#date_loss_1');
        var cmb_date_loss_2        = $('#date_loss_2');
        var cmb_confirm            = $('#confirm');
        var cmb_confirm_loss       = $('#confirm_loss');
        var accordianTable         = $('#accordion2')
        $(document).ready(cb);
        function cb(){
           

           console.log(""ready"")
            cmb_confirm.click(cb_confirm_clicked);
            cmb_confirm_loss.click(cmb_confirm_loss_clicked);

            ctx = document.getElementById(""myChart"").getContext(""2d"");
            myChart = new Chart(ctx, config);

            $.get(""/shoppingmall/shoppingMalls"", shoppingMall_data_arrived);


        }

        function shoppingMall_data_ar");
                WriteLiteral(@"rived(data){
            shoppingMallList = data;
            $.each(data, function (key, item) {
            cmb_shoppingMall_names.append('<option value=' + item.id + '>' + item.name + '</option>');
            });

            populateBranch();
        }

        $(function () {
            $('#shoppingMall_names').change(function () {
            console.log($('#shoppingMall_names').val());
            $.ajax({
                type: 'GET',
                data: { items: $('#shoppingMall_names').val() },
                url: '/branch/branchs',
                success: render_branch,
                error: function (err) { console.log('error', err); }

            });
            });
        });



        function populateBranch(){
     
            $.ajax({
                type: 'GET',
                data: {items: $('#shoppingMall_names').val()},
                url:'/branch/branchs',
                success: render_branch,
                error: function(err){console.log(");
                WriteLiteral(@"'error',err);}

            });
        
        }

        function render_branch(data) {
            debugger
            if (data) {
                cmb_branch_names.empty();
            }
            $.each(data, function (key, item) {
                cmb_branch_names.append('<option value=' + item.branchId + '>' + item.branchName + '</option>');
            });
        }

        function cb_confirm_clicked() {
            option = {
            // dataType: ""json"",
            data: {
                dateFrom: cmb_from_date.val(),
                dateTo: cmb_to_date.val(),
                branchId: cmb_branch_names.val(),
                shoppingmallId: cmb_shoppingMall_names.val(),
            },
            url: '/dashboard/ActualSalesGraphData',
            success: confirm_done,
            error: function (err) { console.log('error', err); }
            };
            $.post(option);
        }

        function cmb_confirm_loss_clicked() {
            option = {
  ");
                WriteLiteral(@"          // dataType: ""json"",
            data: {
                dateFrom: cmb_date_loss_1.val(),
                dateTo: cmb_date_loss_2.val()
            },
            url: '/dashboard/productloss',
            success: loss_done,
            error: function (err) { console.log('error', err); }
            };
            $.post(option); 
        }

        function loss_done(data){
            var filtered = data.filter(function(x){
                accordianTable.empty();
                var count = 0;
                var actualcount = 0;
                $.each(x.allItems, function (key, item) {
                    
                    if(item.productLoss == 0){
                        count ++
                    }
                    if(item.productActual == 0){
                        actualcount ++
                    }
                })
               
                if((x.allItems.length == count) || (x.allItems.length == actualcount)){
                    return false");
                WriteLiteral(@";
                } else {
                    return true;
                }
            });
            console.log(filtered, ""filtered"")
            $.each(filtered, function (key, item) {
               
                console.log(item, ""item"")
                
                var contain = '<tbody>';
                $.each(item.allItems, function (key, item) {
                    var string = '<tr><td style=""width:200px; text-align: right"">' + item.productName + '</td><td style=""text-align: right"">' + item.productSent + '</td><td style=""text-align: right"">' + item.productReceived + '</td><td style=""text-align: right"">' + item.productActual + '</td><td style=""font-weight:bold; text-align: right"">' + item.productLoss + '</td></tr>'
                    contain += string;

                })
                contain +='</tbody>';

                var total = item.allItems.reduce(function(acc, curr){
                    
                    return {productLoss: acc.productLoss + curr.produ");
                WriteLiteral(@"ctLoss}
                });

                console.log(total, ""total"")
                accordianTable.append(
                    '<div class=""block block-rounded mb-1""><div  class=""block-header block-header-default"" role=""tab"" id=""accordion2_h1""><a class=""font-w600"" data-toggle=""collapse"" data-parent=""#accordion2"" href=""#' +  'key' + key  + '""' + 'aria-expanded=""true"" aria-controls=""accordion2_q1"">'
                        + item.shoppingMall + "" "" + item.branch + 
                        '</a><a class=""font-w600"" data-toggle=""collapse"" data-parent=""#accordion2"" href=""#' +  'key' + key  + '""' + 'aria-expanded=""true"" aria-controls=""accordion2_q1"">'
                            + 'Total loss:' + ' ' + total.productLoss + '</a></div>' +
                            '<div id=""' + 'key' + key  + '"" class=""collapse"" role=""tabpanel"" aria-labelledby=""accordion2_h1""><div class=""block-content""><div class=""table-responsive""><table id=""dataTable"" class=""table table-bordered table-striped table-vcenter""><thead><");
                WriteLiteral(@"tr>'
                                + '<th class=""text-center"" style=""width: 50px;"">Product Name</th><th class=""text-center"" >Delivered</th><th class=""text-center"" >Returned</th><th class=""text-center"" >Actual</th><th class=""text-center"" style=""font-weight: bold"">Loss</th></tr></thead>'
                                   + contain
                                        + '</table></div></div></div></div>'
                )
                                
            });
                   
        }

        

        function confirm_done(data){
            console.log(data, 'real data')
            var flatData = data.flat()

            var helper = {};
            var result = flatData.reduce(function(acc, curr) {
            var key = curr.productName;
            
            if(!helper[key]) {
                helper[key] = Object.assign({}, curr); // create a copy of o
                acc.push(helper[key]);
            } else {
                helper[key].productQty += curr.p");
                WriteLiteral(@"roductQty;
            }

            return acc;
            }, []);

            let x_data = result.map(a => a.productName);
            let y_data = result.map(a => a.productQty);

            console.log(result, ""result"");
            console.log(x_data, ""x_data"");
            console.log(y_data, ""y_data"");

            updateData(myChart, x_data, y_data)
        }

         function updateData(chart, x_data, y_data) {
            removeData(chart);
            chart.data.datasets[0].data = y_data;
            chart.data.labels = x_data;
            chart.update();
        };

        function removeData(chart) {
            // monthsRevenue = [];
            chart.data.labels = [];
            chart.data.datasets[0].data = [];
            chart.update();
        }
        var config = {
            type: 'bar',
            data: {
                labels: [],
                datasets: [{
                    label: 'Unit: ',
                    data: [],
               ");
                WriteLiteral(@"     fill: !0,
                            backgroundColor: ""rgba(103, 114, 229, .75)"",
                            borderColor: ""rgba(103, 114, 229, 1)"",
                            pointBackgroundColor: ""rgba(103, 114, 229, 1)"",
                            pointBorderColor: ""#fff"",
                            pointHoverBackgroundColor: ""#fff"",
                            pointHoverBorderColor: ""rgba(103, 114, 229, 1)"",
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
        }
    </script>
 ");
                EndContext();
            }
            );
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
