#pragma checksum "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "294323113acc27f22631eaa6cfca409331252dee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CartActual_Index), @"mvc.1.0.view", @"/Views/CartActual/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CartActual/Index.cshtml", typeof(AspNetCore.Views_CartActual_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294323113acc27f22631eaa6cfca409331252dee", @"/Views/CartActual/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_CartActual_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<kafer_house.Models.CartActualView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(77, 117, true);
                WriteLiteral("\r\n    <script>\r\n    $(document).ready(function () {\r\n            $(\'#dataTable\').DataTable();\r\n        });</script>\r\n");
                EndContext();
            }
            );
            BeginContext(197, 587, true);
            WriteLiteral(@"
<div class=""bg-body-light"">
    <div class=""content content-full"">
        <div class=""d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center"">
            <h1 class=""flex-sm-fill font-size-h2 font-w400 mt-2 mb-0 mb-sm-2"">
                Actual Sold
            </h1>
        </div>
    </div>
</div>

<div class=""content"">
    <div class=""block block-rounded block-bordered"">
        <div class=""block-header block-header-default"">
            <h3 class=""block-title"">Index</h3>
        </div>
        <div class=""block-content"">
            ");
            EndContext();
            BeginContext(784, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "294323113acc27f22631eaa6cfca409331252dee5815", async() => {
                BeginContext(831, 6, true);
                WriteLiteral("Create");
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
            BeginContext(841, 696, true);
            WriteLiteral(@"
        </div>

        <div class=""block-content block-content-full"">
            <div class=""table-responsive"">
                <table id=""dataTable"" class=""table table-hover table-bordered table-striped table-vcenter"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Date Sold</th>
                            <th>Shopping Mall</th>
                            <th>Branch</th>
                            <th>Total</th>
                            <th class=""text-center"" style=""width: 100px;"">Actions</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 43 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                     foreach (var item in @Model)
                    {

#line default
#line hidden
            BeginContext(1611, 135, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\" style=\"width:50px\">\r\n                                ");
            EndContext();
            BeginContext(1747, 7, false);
#line 47 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1754, 130, true);
            WriteLiteral("\r\n                            </td>\r\n                        \r\n                            <td >\r\n                                ");
            EndContext();
            BeginContext(1885, 34, false);
#line 51 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                           Write(item.date.ToString("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1919, 101, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                              ");
            EndContext();
            BeginContext(2021, 21, false);
#line 54 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                         Write(item.shoppingMallName);

#line default
#line hidden
            EndContext();
            BeginContext(2042, 103, true);
            WriteLiteral("\r\n                          </td>\r\n                            <td > \r\n                                ");
            EndContext();
            BeginContext(2146, 15, false);
#line 57 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                           Write(item.branchName);

#line default
#line hidden
            EndContext();
            BeginContext(2161, 104, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td> \r\n                                ");
            EndContext();
            BeginContext(2266, 10, false);
#line 60 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                           Write(item.total);

#line default
#line hidden
            EndContext();
            BeginContext(2276, 230, true);
            WriteLiteral("\r\n                            </td>\r\n                             <td class=\"text-center\">\r\n                                <div class=\"btn-group\" role=\"group\" aria-label=\"Horizontal Primary\">\r\n                                    ");
            EndContext();
            BeginContext(2506, 380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "294323113acc27f22631eaa6cfca409331252dee10763", async() => {
                BeginContext(2776, 106, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-pencil-alt\"></i>\r\n                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2886, 36, true);
            WriteLiteral("\r\n                                  ");
            EndContext();
            BeginContext(2922, 374, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "294323113acc27f22631eaa6cfca409331252dee13382", async() => {
                BeginContext(3191, 101, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-times\"></i>\r\n                                  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 74 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                                      WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3296, 142, true);
            WriteLiteral("\r\n                                </div>\r\n                                \r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 84 "c:\Users\Pete pc\Desktop\kafer\Views\CartActual\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3461, 115, true);
            WriteLiteral("                     </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<kafer_house.Models.CartActualView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
