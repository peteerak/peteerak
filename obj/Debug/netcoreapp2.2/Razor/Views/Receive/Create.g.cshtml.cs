#pragma checksum "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac555a3e0f079dc1800a0d773db80651cf1c760c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Receive_Create), @"mvc.1.0.view", @"/Views/Receive/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Receive/Create.cshtml", typeof(AspNetCore.Views_Receive_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac555a3e0f079dc1800a0d773db80651cf1c760c", @"/Views/Receive/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f597968a71fe0965886cf747df1e859bf957b674", @"/Views/_ViewImports.cshtml")]
    public class Views_Receive_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kafer_house.Models.Receive>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-format", "{0:dd-MM-yyyy}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("productLot_Date"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 1130, true);
            WriteLiteral(@"

   <!-- Hero -->
   <div class=""bg-body-light"">
    <div class=""content content-full"">
      <div
        class=""d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center""
      >
        <h1 class=""flex-sm-fill font-size-h2 font-w400 mt-2 mb-0 mb-sm-2"">
            Receive
        </h1>
        <nav class=""flex-sm-00-auto ml-sm-3"" aria-label=""breadcrumb"">
          <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">Tables</li>
            <li class=""breadcrumb-item active"" aria-current=""page"">
              Responsive
            </li>
          </ol>
        </nav>
      </div>
    </div>
  </div>
  <!-- END Hero -->

<div class=""row"">
    <div class=""col-md-6"">
        
    </div>
</div>


<!-- Page Content -->
<div class=""content"">
    <!-- Full Table -->
    <div class=""block block-rounded block-bordered"">
      <div class=""block-header block-header-default"">
        <h3 class=""block-title"">Create</h3>
      </div>
    
      <di");
            WriteLiteral("v class=\"block-content\">\r\n        <div class=\"col-md-4\">\r\n          <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1165, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac555a3e0f079dc1800a0d773db80651cf1c760c6681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 44 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.productLotDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1227, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1241, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ac555a3e0f079dc1800a0d773db80651cf1c760c8314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 45 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.productLotDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Format = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1357, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1371, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac555a3e0f079dc1800a0d773db80651cf1c760c10432", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 46 "c:\Users\karn_\Documents\kafer\kafer_house\Views\Receive\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.productLotDate);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1440, 1838, true);
            WriteLiteral(@"
        </div>
         
            <div class=""form-group"">
                <label for=""shoppingMall_names"">Select Shopping Mall:</label>
                <select class=""form-control"" id=""shoppingMall_names""></select>
            </div>
            <div class=""form-group"">
              <label for=""branch_names"">Select Branch:</label>
              <select class=""form-control"" id=""branch_names""></select>
          </div>
            <div class=""form-group"">
                <label for=""product_names"">Select Product:</label>
                <select class=""form-control"" id=""product_names""></select>
            </div>
             <div class=""form-group"">
                <label class=""control-label"" for=""txt_qty"">Quantity: 
                    <button type=""button"" id=""cmd_inc"" class=""btn btn-outline-primary"">+</button>
                    <button id=""cmd_dec"" class=""btn btn-outline-primary"">-</button>
                </label>
                <input class=""form-control"" id=""txt_qty""></input>");
            WriteLiteral(@"
            </div>
            <div class=""form-group"">
                    <button class=""btn btn-primary"" id=""cmd_add"">Add</button>
            </div>
        </div>
      </div>

      <!------------------>
        <div class=""block-content"">
            <div class=""table-responsive"">
                <table class=""table table-bordered table-striped table-vcenter"" id=""table1"">
                        <tr>
                            <th>name</th>
                            <th>qty</th>
                            <th>operation</th>
                        </tr>
                </table>
            </div>
            <div class=""form-group"">
                    <button class=""btn btn-primary"" id=""cmd_confirm"">confirm</button>
                </div>
        </div>
  </div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3295, 6889, true);
                WriteLiteral(@"
 
<script>
  var productList               = [];
  var shoppingMallList          = [];
  var cart                      = [];
  var cmb_shoppingMall_names    = $('#shoppingMall_names');
  var cmb_branch_names          = $('#branch_names');
  var cmb_product_names         = $('#product_names');
  var txt_qty                   = $('#txt_qty');
//   var txt_price                 = $('#txt_price');
  var tbl_table1                = $('#table1');
  var cmd_inc                   = $('#cmd_inc');
  var cmd_dec                   = $('#cmd_dec');
  var cmd_add                   = $('#cmd_add');
  var cmd_confirm               = $('#cmd_confirm');
  var cmb_date_sold             = $('#date_sold');
  var cmb_productLotDate        = $('#productLot_Date')

  $(document).ready(cb);

  function cb() {
    console.log(""ready"");
    // register combobox event

    cmb_product_names.change(cb_change);
    cmd_inc.click(cb_inc_clicked);
    cmd_dec.click(cb_dec_clicked);
    cmd_add.click(cb_add_clic");
                WriteLiteral(@"ked);
    cmd_confirm.click(cb_confirm_clicked);

    $.get(""/product/products"", product_data_arrived);
    $.get(""/shoppingmall/shoppingMalls"", shoppingMall_data_arrived);
    // $.get(""/branch/branchs"", branch_data_arrived);



  }//end cb

  function shoppingMall_data_arrived(data) {
    console.log(data, ""data"")
    shoppingMallList = data;
    $.each(data, function (key, item) {
      cmb_shoppingMall_names.append('<option value=' + item.id + '>' + item.name + '</option>');
    });

    txt_qty.val(""1"");

    populateBranch();
  }

  function populateBranch() {

    $.ajax({
      type: 'GET',
      data: { items: $('#shoppingMall_names').val() },
      url: '/branch/branchs',
      success: render_branch,
      error: function (err) { console.log('error', err); }

    });

  }


  function cb_date_change(data) {
    console.log($('#productLot_Date').val())
  }

  function product_data_arrived(data) {
    productList = data;
    $.each(data, function (key, item)");
                WriteLiteral(@" {
      cmb_product_names.append('<option value=' + item.id + '>' + item.name + '</option>');
    });

    // txt_price.val(productList[0].price);
    txt_qty.val(""1"");

  }//ef

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

  

  function render_branch(data) {

    if (data) {
      cmb_branch_names.empty();
    }
    $.each(data, function (key, item) {
      cmb_branch_names.append('<option value=' + item.branchId + '>' + item.branchName + '</option>');
    });
  }


  function cb_change() {

    //get selection value
    var product_id = cmb_product_names.val();

    //search object in the productList by product_id
    var found = productList.find((a) =");
                WriteLiteral(@"> {
      return a.id == product_id
    });

    //update product price in txt price textbox
    // if (found != null) {
    //   txt_price.val(found.price);

    // }

  }

  function cb_inc_clicked() {

    var value = parseInt(txt_qty.val());
    value++;
    txt_qty.val(value.toString());
  }

  function cb_dec_clicked() {

    var value = parseInt(txt_qty.val());
    value--;
    if (value == 0) { value = 1; }
    txt_qty.val(value.toString());
  }

  function cb_add_clicked() {
    console.log(cmb_date_sold.val(), ""date"");
    var product_id = cmb_product_names.val(); //get selection value
    // var price = parseFloat(txt_price.val());
    var qty = parseInt(txt_qty.val());
    var shoppingMallId = cmb_shoppingMall_names.val();

    var found = productList.find((a) => {
      return a.id == product_id
    });


    var row = {
      id: product_id,
      name: found.name,
    //   price: price,
      qty: qty,
    //   total: price * qty,

    };


    c");
                WriteLiteral(@"onst productExist = cart.some(el => el.id === product_id);

    if (!productExist) {
      cart.push(row);
      updateTable();
    } else {
      alert(""product already exist"")
    }



  }

  function tr(data) { return '<tr>' + data + '</tr>'; }
  function td(data) { return '<td>' + data + '</td>'; }
  function button(id, data) { return '<button  onclick=""cb_removes_clicked(this)"" data-id=""' + id + '"">' + data + '</button>'; }

  function cb_removes_clicked(obj) {
    //console.log($(this).val());
    var product_id = $(obj).attr('data-id');
    cart = cart.filter((a) => {
      return a.id != product_id
    });
    updateTable();
  }

//   var totalRev = 0;
  function updateTable() {
    //remove all rows except the header row
    tbl_table1.find(""tr:gt(0)"").remove();
    // var total = 0;
    for (var i = 0; i < cart.length; i++) {
      var row = tr(td(cart[i].name) + td(cart[i].qty) + td(button(cart[i].id, ""remove"")));
      tbl_table1.append(row);
    //   totalRev += ");
                WriteLiteral(@"cart[i].price * cart[i].qty;
    }
    // var summary = tr(td('total') + td('') + td('') + td(totalRev));

    // tbl_table1.append(summary);
    // //remove all rows except the header row
    // tbl_table1.find(""tr:gt(0)"").remove();
    // var total = 0;
    // for(var i = 0; i< cart.length;i++){
    //     var row = tr(td(cart[i].name)+td(cart[i].qty)+td(cart[i].price)+td(cart[i].total)+td(button(cart[i].id,""remove"")));
    //     tbl_table1.append(row);
    //     total += cart[i].price* cart[i].qty;
    // }
    // var summary = tr(td('total')+td('')+td('')+td(total));

    // var shoppingMallFound = shoppingMallList.find((mall) => {
    //   return mall.id == shoppingMallId
    // })
    // var mallSummary = tr(td('total')+td('')+td('')+td(shoppingMallFound.name));
    // tbl_table1.append(summary);
    // tbl_table1.append(mallSummary);


  }


  function cb_confirm_clicked() {

    var result = [];
    for (var i = 0; i < cart.length; i++) {
      result.push({
        pr");
                WriteLiteral(@"oductId: cart[i].id,
        productName: cart[i].name,
        productQty: cart[i].qty


      });
    }


    //step30: post operation
    option = {
      // dataType: ""json"",
      data: {
        items: result,
        shoppingMallId: cmb_shoppingMall_names.val(),
        branchId: cmb_branch_names.val(),
        productLotDate: cmb_productLotDate.val()
        // totalRev: totalRev,
      },
      url: '/receive/addcart',
      success: addcart_done,
      error: function (err) { console.log('error', err); }
    };
    $.post(option);
  }
  //step33: data return from the server side
  function addcart_done(data) {
    window.location.replace(data.newUrl); //redirect to Index Action
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kafer_house.Models.Receive> Html { get; private set; }
    }
}
#pragma warning restore 1591
