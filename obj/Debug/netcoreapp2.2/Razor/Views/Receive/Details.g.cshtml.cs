#pragma checksum "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "320212aa86fa49e6445908dae78866d9e3ff31a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receive_Details), @"mvc.1.0.view", @"/Views/Receive/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receive/Details.cshtml", typeof(AspNetCore.Views_Receive_Details))]
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
#line 1 "c:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
using kafer_house;

#line default
#line hidden
#line 2 "c:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
using kafer_house.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"320212aa86fa49e6445908dae78866d9e3ff31a4", @"/Views/Receive/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Receive_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kafer_house.Models.Receive>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(61, 117, true);
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n            $(\'#dataTable\').DataTable();\r\n        });</script>\r\n");
                EndContext();
            }
            );
            BeginContext(181, 783, true);
            WriteLiteral(@"
<div class=""bg-body-light"">
    <div class=""content content-full"">
        <div class=""d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center"">
            <h1 class=""flex-sm-fill font-size-h2 font-w400 mt-2 mb-0 mb-sm-2"">
                Return Detail
            </h1>
        </div>
    </div>
</div>

<div class=""content"">
    <div class=""block block-rounded block-bordered"">
        <div class=""block-header block-header-default"">
            <h3 class=""block-title"">Detail</h3>
            
        </div>
        
        <div class=""block-content"">
            <dl class=""row"">
                <dt class = ""col-sm-2"">
                    Id
                </dt>
                <dd class = ""col-sm-10"">
                     ");
            EndContext();
            BeginContext(965, 15, false);
#line 36 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
                Write(Model.receiveId);

#line default
#line hidden
            EndContext();
            BeginContext(980, 201, true);
            WriteLiteral("                \r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Receive Date\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1182, 42, false);
#line 42 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
               Write(Model.receiveDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 182, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Lot Date\r\n                </dt> \r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1407, 45, false);
#line 48 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
               Write(Model.productLotDate.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 186, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Shopping Mall\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1639, 23, false);
#line 54 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
               Write(Model.shoppingmall.name);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 179, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Branch\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1842, 23, false);
#line 60 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
               Write(Model.branch.branchName);

#line default
#line hidden
            EndContext();
            BeginContext(1865, 629, true);
            WriteLiteral(@"
                </dd>
               
            </dl>

            <div class=""block-content block-content-full"">
                <div class=""table-responsive"">
                    <table id=""dataTable"" class=""table table-hover table-bordered table-striped table-vcenter js-dataTable-full"">
                        <thead>
                            <tr>
                                <td>Product ID</td>
                                <td>ProductName</td>
                                <td>Quantity</td>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 76 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
                          
                        double gtotal = 0;
                        foreach(var item in @Model.receiveItem){
                            double total = item.productPrice*item.productQty;
                            gtotal = gtotal + total;

#line default
#line hidden
            BeginContext(2765, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2836, 14, false);
#line 82 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
                               Write(item.productId);

#line default
#line hidden
            EndContext();
            BeginContext(2850, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2894, 16, false);
#line 83 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
                               Write(item.productName);

#line default
#line hidden
            EndContext();
            BeginContext(2910, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2954, 15, false);
#line 84 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
                               Write(item.productQty);

#line default
#line hidden
            EndContext();
            BeginContext(2969, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 86 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Details.cshtml"
                        
                        }
                
                        

#line default
#line hidden
            BeginContext(3109, 134, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(3243, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "320212aa86fa49e6445908dae78866d9e3ff31a410433", async() => {
                BeginContext(3289, 130, true);
                WriteLiteral("\r\n                            <i class=\"si si-arrow-left\"></i>\r\n                            Back to List\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3423, 108, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kafer_house.Models.Receive> Html { get; private set; }
    }
}
#pragma warning restore 1591
