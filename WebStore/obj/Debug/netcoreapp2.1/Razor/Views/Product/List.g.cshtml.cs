#pragma checksum "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54eede54b20ad7fed64bc0852aeb48f7598d9af9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
#line 2 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\_ViewImports.cshtml"
using WebStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54eede54b20ad7fed64bc0852aeb48f7598d9af9", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f6168a3226a06b4a515c83980ff1f25d7b194b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("buttonmargin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WebStore.Infrastucrure.PageLinkTagHelper __WebStore_Infrastucrure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
  
    int i = 0;

#line default
#line hidden
            BeginContext(54, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
 foreach (var p in Model.Products)
{
    i++;
    if (i % 2 != 0)
    {

#line default
#line hidden
            BeginContext(135, 94, true);
            WriteLiteral("        <div class=\"col col_14 product_gallery no_margin_right\">\r\n            <a href=\"#\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 229, "\"", 244, 1);
#line 14 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
WriteAttributeValue("", 235, p.Images, 235, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(245, 42, true);
            WriteLiteral(" alt=\"Product 01\" /></a>\r\n            <h3>");
            EndContext();
            BeginContext(288, 6, false);
#line 15 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(294, 22, true);
            WriteLiteral("</h3>\r\n            <p>");
            EndContext();
            BeginContext(317, 13, false);
#line 16 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
          Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(330, 43, true);
            WriteLiteral("</p>\r\n            <p class=\"product_price\">");
            EndContext();
            BeginContext(374, 22, false);
#line 17 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
                                Write(p.Price.ToString("C0"));

#line default
#line hidden
            EndContext();
            BeginContext(396, 83, true);
            WriteLiteral("</p>\r\n            <a href=\"#\" class=\"add_to_cart\">Add to Cart</a>\r\n        </div>\r\n");
            EndContext();
#line 20 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(503, 78, true);
            WriteLiteral("        <div class=\"col col_14 product_gallery\">\r\n            <a href=\"#\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 581, "\"", 596, 1);
#line 24 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
WriteAttributeValue("", 587, p.Images, 587, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(597, 42, true);
            WriteLiteral(" alt=\"Product 01\" /></a>\r\n            <h3>");
            EndContext();
            BeginContext(640, 6, false);
#line 25 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
           Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(646, 22, true);
            WriteLiteral("</h3>\r\n            <p>");
            EndContext();
            BeginContext(669, 13, false);
#line 26 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
          Write(p.Description);

#line default
#line hidden
            EndContext();
            BeginContext(682, 43, true);
            WriteLiteral("</p>\r\n            <p class=\"product_price\">");
            EndContext();
            BeginContext(726, 22, false);
#line 27 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
                                Write(p.Price.ToString("C0"));

#line default
#line hidden
            EndContext();
            BeginContext(748, 83, true);
            WriteLiteral("</p>\r\n            <a href=\"#\" class=\"add_to_cart\">Add to Cart</a>\r\n        </div>\r\n");
            EndContext();
#line 30 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
    }
}

#line default
#line hidden
            BeginContext(841, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddd2d1da0bdc4ad79ed29db707a482e4", async() => {
            }
            );
            __WebStore_Infrastucrure_PageLinkTagHelper = CreateTagHelper<global::WebStore.Infrastucrure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__WebStore_Infrastucrure_PageLinkTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 32 "C:\Users\sulta\source\repos\WebStore\WebStore\Views\Product\List.cshtml"
__WebStore_Infrastucrure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __WebStore_Infrastucrure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __WebStore_Infrastucrure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(923, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
