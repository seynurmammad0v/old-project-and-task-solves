#pragma checksum "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "495afb907101d756f63dc9f2cf65aceabdc074c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ProductPartial.cshtml", typeof(AspNetCore.Views_Shared__ProductPartial))]
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
#line 1 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\_ViewImports.cshtml"
using EvTapsiriqiFrontToBack.Models;

#line default
#line hidden
#line 1 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
using EvTapsiriqiFrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"495afb907101d756f63dc9f2cf65aceabdc074c6", @"/Views/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd23c9517ddcadd1a074bf0d4d8ceaaf4626f90", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
 foreach (Product pro in Model.Products)
{

#line default
#line hidden
            BeginContext(106, 65, true);
            WriteLiteral("    <div class=\"col-lg-3 col-md-4 col-sm-6 col-12 mb-4\" data-id=\"");
            EndContext();
            BeginContext(172, 17, false);
#line 7 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
                                                            Write(pro.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(189, 43, true);
            WriteLiteral("\">\r\n        <div class=\"card\"  data-price=\"");
            EndContext();
            BeginContext(233, 9, false);
#line 8 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
                                  Write(pro.Price);

#line default
#line hidden
            EndContext();
            BeginContext(242, 51, true);
            WriteLiteral("\">\r\n            <div class=\"img\">\r\n                ");
            EndContext();
            BeginContext(293, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "34ffdd407c644b00a2d089c54ed77a7e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 325, "~/img/products/", 325, 15, true);
#line 10 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
AddHtmlAttributeValue("", 340, pro.Image, 340, 10, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(395, 95, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <p class=\"text-img\">");
            EndContext();
            BeginContext(491, 8, false);
#line 14 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
                               Write(pro.Name);

#line default
#line hidden
            EndContext();
            BeginContext(499, 133, true);
            WriteLiteral("</p>\r\n                <div class=\"bottom\">\r\n                    <p class=\"card-foot add-to-card buy-btn a\">\r\n                        ");
            EndContext();
            BeginContext(632, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c882b1c2ac1341718eb4944eb9ad4ec8", async() => {
                BeginContext(705, 12, true);
                WriteLiteral(" Add to cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
                                                                            WriteLiteral(pro.Id);

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
            BeginContext(721, 176, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"bottom bottom-last\">\r\n                    <p class=\"card-foot price\">\r\n                        $");
            EndContext();
            BeginContext(898, 9, false);
#line 22 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
                    Write(pro.Price);

#line default
#line hidden
            EndContext();
            BeginContext(907, 144, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <p class=\"card-foot d-lg-none d-md-block d-sm-block\">\r\n                    $");
            EndContext();
            BeginContext(1052, 9, false);
#line 26 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
                Write(pro.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1061, 72, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 31 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_ProductPartial.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591