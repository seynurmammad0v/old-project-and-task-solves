#pragma checksum "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_SearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "406a66c7f92800b49af29446ba60aa5ffdeee055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SearchPartial), @"mvc.1.0.view", @"/Views/Shared/_SearchPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SearchPartial.cshtml", typeof(AspNetCore.Views_Shared__SearchPartial))]
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
#line 2 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\_ViewImports.cshtml"
using EvTapsiriqiFrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406a66c7f92800b49af29446ba60aa5ffdeee055", @"/Views/Shared/_SearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd23c9517ddcadd1a074bf0d4d8ceaaf4626f90", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_SearchPartial.cshtml"
 foreach (Product pro in Model)
{

#line default
#line hidden
            BeginContext(65, 43, true);
            WriteLiteral("    <div class=\"p-3 pt-4 d-flex \" data-id=\"");
            EndContext();
            BeginContext(109, 6, false);
#line 4 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_SearchPartial.cshtml"
                                      Write(pro.Id);

#line default
#line hidden
            EndContext();
            BeginContext(115, 38, true);
            WriteLiteral("\">\r\n        <div class=\"cart-img\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 153, "\"", 183, 2);
            WriteAttributeValue("", 159, "/img/products/", 159, 14, true);
#line 5 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_SearchPartial.cshtml"
WriteAttributeValue("", 173, pro.Image, 173, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(184, 104, true);
            WriteLiteral(" alt=\"\"> </div>\r\n        <div class=\"pl-4\">\r\n            <p class=\"cart-product-name\">\r\n                ");
            EndContext();
            BeginContext(289, 8, false);
#line 8 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_SearchPartial.cshtml"
           Write(pro.Name);

#line default
#line hidden
            EndContext();
            BeginContext(297, 73, true);
            WriteLiteral("\r\n            </p>\r\n            <p class=\"cart-price\">\r\n                $");
            EndContext();
            BeginContext(371, 9, false);
#line 11 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_SearchPartial.cshtml"
            Write(pro.Price);

#line default
#line hidden
            EndContext();
            BeginContext(380, 48, true);
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Views\Shared\_SearchPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
