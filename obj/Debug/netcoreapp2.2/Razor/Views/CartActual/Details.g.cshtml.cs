#pragma checksum "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db8d1ca1116be235cee53a6e6b20397e20adef6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartActual_Details), @"mvc.1.0.view", @"/Views/CartActual/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CartActual/Details.cshtml", typeof(AspNetCore.Views_CartActual_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db8d1ca1116be235cee53a6e6b20397e20adef6c", @"/Views/CartActual/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_CartActual_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kafer_house.Models.CartActual>
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
            BeginContext(38, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(62, 117, true);
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n            $(\'#dataTable\').DataTable();\r\n        });</script>\r\n");
                EndContext();
            }
            );
            BeginContext(182, 782, true);
            WriteLiteral(@"
<div class=""bg-body-light"">
    <div class=""content content-full"">
        <div class=""d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center"">
            <h1 class=""flex-sm-fill font-size-h2 font-w400 mt-2 mb-0 mb-sm-2"">
                Oeder Detail
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
            BeginContext(965, 12, false);
#line 35 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                Write(Model.cartId);

#line default
#line hidden
            EndContext();
            BeginContext(977, 198, true);
            WriteLiteral("                \r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Date Sold\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1176, 39, false);
#line 41 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
               Write(Model.dateSold.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 186, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Shopping Mall\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1402, 23, false);
#line 47 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
               Write(Model.shoppingmall.name);

#line default
#line hidden
            EndContext();
            BeginContext(1425, 179, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class = \"col-sm-2\">\r\n                    Branch\r\n                </dt>\r\n                <dd class = \"col-sm-10\">\r\n                    ");
            EndContext();
            BeginContext(1605, 23, false);
#line 53 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
               Write(Model.branch.branchName);

#line default
#line hidden
            EndContext();
            BeginContext(1628, 725, true);
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
                                <td>Price</td>
                                <td>Quantity</td>
                                <td>Total</td>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 71 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                          
                        double gtotal = 0;
                        foreach(var item in @Model.cartItems){
                            double total = item.productPrice*item.productQty;
                            gtotal = gtotal + total;

#line default
#line hidden
            BeginContext(2622, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(2693, 14, false);
#line 77 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                               Write(item.productId);

#line default
#line hidden
            EndContext();
            BeginContext(2707, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2751, 16, false);
#line 78 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                               Write(item.productName);

#line default
#line hidden
            EndContext();
            BeginContext(2767, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2811, 17, false);
#line 79 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                               Write(item.productPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2828, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2872, 15, false);
#line 80 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                               Write(item.productQty);

#line default
#line hidden
            EndContext();
            BeginContext(2887, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(2931, 5, false);
#line 81 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                               Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(2936, 42, true);
            WriteLiteral("</td>\r\n                            </tr>\r\n");
            EndContext();
#line 83 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                        
                        }

#line default
#line hidden
            BeginContext(3031, 224, true);
            WriteLiteral("                        <tr>\r\n                            <td>Total:</td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td></td>\r\n                            <td>");
            EndContext();
            BeginContext(3256, 6, false);
#line 90 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Details.cshtml"
                           Write(gtotal);

#line default
#line hidden
            EndContext();
            BeginContext(3262, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
            BeginContext(3327, 134, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                    <div class=\"form-group\">\r\n                        ");
            EndContext();
            BeginContext(3461, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8d1ca1116be235cee53a6e6b20397e20adef6c11267", async() => {
                BeginContext(3507, 130, true);
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
            BeginContext(3641, 108, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kafer_house.Models.CartActual> Html { get; private set; }
    }
}
#pragma warning restore 1591
