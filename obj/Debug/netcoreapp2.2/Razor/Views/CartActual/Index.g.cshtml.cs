#pragma checksum "c:\Users\karn_\Documents\kafer\kafer_house\Views\CartActual\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd21546726e7d163b0ea7f46df6cfc658c7882f6"
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
#line 1 "c:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
using kafer_house;

#line default
#line hidden
#line 2 "c:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
using kafer_house.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd21546726e7d163b0ea7f46df6cfc658c7882f6", @"/Views/CartActual/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_CartActual_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<kafer_house.Models.CartActualView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 1189, true);
            WriteLiteral(@"




     
    <h2>Shopping Cart</h2>

    <a href=""/cartactual/create"">new cart</a>     <!-- create a link to open view>cart>create.cshtml-->
    <hr>
    <div class=""container"">                 <!-- create a container to hold chart display -->
        <div id=""chart1""></div>
    </div>
    <div class=""container"">                 <!-- create a container to hold date time picker div-->   
        <div class=""row"">
            <div class=""col-4"">
                Start Date: <input id=""startDate"" width=""200"" />
            </div>
            <div class=""col-4"">
                End Date: <input id=""endDate"" width=""200"" />
            </div>
            <div class=""col-3"">
                <br>
                <button class=""btn btn-warning btn-block"" id=""cmd_select_date"">select</button>
            </div>
        </div>
        <br>
    </div>
    <table class=""table"">                  <!-- create a table tab -->
        <tr>
            <td>cart Id</td>
            <td>Date</td>
 ");
            WriteLiteral("           <td>Total</td>\r\n            <td></td>\r\n        </tr>\r\n\r\n        <!-- loop through item in the Model , the Model contains a list of cartView objects --> \r\n");
            EndContext();
#line 39 "c:\Users\karn_\Documents\kafer\kafer_house\Views\CartActual\Index.cshtml"
         foreach(var item in @Model){      

#line default
#line hidden
            BeginContext(1289, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1320, 7, false);
#line 41 "c:\Users\karn_\Documents\kafer\kafer_house\Views\CartActual\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1327, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1351, 9, false);
#line 42 "c:\Users\karn_\Documents\kafer\kafer_house\Views\CartActual\Index.cshtml"
           Write(item.date);

#line default
#line hidden
            EndContext();
            BeginContext(1360, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1384, 10, false);
#line 43 "c:\Users\karn_\Documents\kafer\kafer_house\Views\CartActual\Index.cshtml"
           Write(item.total);

#line default
#line hidden
            EndContext();
            BeginContext(1394, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1417, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd21546726e7d163b0ea7f46df6cfc658c7882f66097", async() => {
                BeginContext(1462, 4, true);
                WriteLiteral("view");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "c:\Users\karn_\Documents\kafer\kafer_house\Views\CartActual\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1470, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 46 "c:\Users\karn_\Documents\kafer\kafer_house\Views\CartActual\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1503, 14, true);
            WriteLiteral("\r\n    </table>");
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