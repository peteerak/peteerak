<<<<<<< HEAD
#pragma checksum "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b78590dd2197978b87e014f052a4f85df681371"
=======
#pragma checksum "g:\My Drive\web app\fin\matong\kafer\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f94ff1a3d82aa07361e602e78fe193aef27eb323"
>>>>>>> f810f21cba4f11f9ad954aa49024b0c7ce940af1
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
<<<<<<< HEAD
#line 1 "c:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
=======
#line 1 "g:\My Drive\web app\fin\matong\kafer\Views\_ViewImports.cshtml"
>>>>>>> f810f21cba4f11f9ad954aa49024b0c7ce940af1
using kafer_house;

#line default
#line hidden
<<<<<<< HEAD
#line 2 "c:\Users\karn_\Documents\kafer\kafer_house\Views\_ViewImports.cshtml"
=======
#line 2 "g:\My Drive\web app\fin\matong\kafer\Views\_ViewImports.cshtml"
>>>>>>> f810f21cba4f11f9ad954aa49024b0c7ce940af1
using kafer_house.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f94ff1a3d82aa07361e602e78fe193aef27eb323", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kafer_house.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(35, 760, true);
            WriteLiteral(@"
<div class=""bg-body-light"">
  <div class=""content content-full"">
    <div
      class=""d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center""
    >
      <h1 class=""flex-sm-fill font-size-h2 font-w400 mt-2 mb-0 mb-sm-2"">
        Product
      </h1>
      <nav class=""flex-sm-00-auto ml-sm-3"" aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
          <li class=""breadcrumb-item"">Tables</li>
          <li class=""breadcrumb-item active"" aria-current=""page"">Responsive</li>
        </ol>
      </nav>
    </div>
  </div>
</div>

<div class=""content"">
  <div class=""block block-rounded block-bordered"">
    <div class=""block-header block-header-default"">
      <h3 class=""block-title"">Detail</h3>

      ");
            EndContext();
            BeginContext(795, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f94ff1a3d82aa07361e602e78fe193aef27eb3234259", async() => {
                BeginContext(817, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(833, 113, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"block-content\" style=\"margin-bottom: -30px\">\r\n      <h5 class=\"font-w300\">Name : ");
            EndContext();
<<<<<<< HEAD
            BeginContext(143, 831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b78590dd2197978b87e014f052a4f85df6813715349", async() => {
                BeginContext(149, 112, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(262, 40, false);
#line 15 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
                EndContext();
                BeginContext(302, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(366, 36, false);
#line 18 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
                EndContext();
                BeginContext(402, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(465, 40, false);
#line 21 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.code));

#line default
#line hidden
                EndContext();
                BeginContext(505, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(569, 36, false);
#line 24 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.code));

#line default
#line hidden
                EndContext();
                BeginContext(605, 62, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
                EndContext();
                BeginContext(668, 41, false);
#line 27 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
                EndContext();
                BeginContext(709, 63, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(773, 37, false);
#line 30 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
                EndContext();
                BeginContext(810, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(857, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b78590dd2197978b87e014f052a4f85df6813718430", async() => {
                    BeginContext(903, 4, true);
                    WriteLiteral("Edit");
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
#line 35 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Product\Details.cshtml"
                           WriteLiteral(Model.id);
=======
            BeginContext(947, 36, false);
#line 30 "g:\My Drive\web app\fin\matong\kafer\Views\Product\Details.cshtml"
                              Write(Html.DisplayFor(model => model.name));

#line default
#line hidden
            EndContext();
            BeginContext(983, 42, true);
            WriteLiteral("</h5>\r\n      <h5 class=\"font-w300\">Code : ");
            EndContext();
            BeginContext(1026, 36, false);
#line 31 "g:\My Drive\web app\fin\matong\kafer\Views\Product\Details.cshtml"
                              Write(Html.DisplayFor(model => model.code));

#line default
#line hidden
            EndContext();
            BeginContext(1062, 43, true);
            WriteLiteral("</h5>\r\n      <h5 class=\"font-w300\">Price : ");
            EndContext();
            BeginContext(1106, 37, false);
#line 32 "g:\My Drive\web app\fin\matong\kafer\Views\Product\Details.cshtml"
                               Write(Html.DisplayFor(model => model.price));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 372, true);
            WriteLiteral(@"</h5>

    </div>
    <div class=""block-content"">
      <div class=""table-responsive"">
        <table class=""table table-bordered table-striped table-vcenter"">
          <thead>
            <tr>
              <th class=""text-center"" style=""width: 50px;"">ID</th>

              <th>Name</th>

>>>>>>> f810f21cba4f11f9ad954aa49024b0c7ce940af1

      <!-- table-responsive-->
    </div>

  </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kafer_house.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
