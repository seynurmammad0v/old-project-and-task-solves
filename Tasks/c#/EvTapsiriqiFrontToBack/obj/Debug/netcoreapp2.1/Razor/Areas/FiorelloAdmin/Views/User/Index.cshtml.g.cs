#pragma checksum "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1941be62a06c771a09c06786961e8b204a92b6e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_FiorelloAdmin_Views_User_Index), @"mvc.1.0.view", @"/Areas/FiorelloAdmin/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/FiorelloAdmin/Views/User/Index.cshtml", typeof(AspNetCore.Areas_FiorelloAdmin_Views_User_Index))]
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
#line 1 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\_ViewImports.cshtml"
using EvTapsiriqiFrontToBack.Models;

#line default
#line hidden
#line 2 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\_ViewImports.cshtml"
using EvTapsiriqiFrontToBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1941be62a06c771a09c06786961e8b204a92b6e0", @"/Areas/FiorelloAdmin/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd23c9517ddcadd1a074bf0d4d8ceaaf4626f90", @"/Areas/FiorelloAdmin/Views/_ViewImports.cshtml")]
    public class Areas_FiorelloAdmin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-capitalize text-white btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "changerole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-capitalize text-white btn btn-info "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "resetpassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/global_assets/js/plugins/tables/datatables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/global_assets/js/plugins/notifications/sweet_alert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "User";

#line default
#line hidden
            BeginContext(61, 768, true);
            WriteLiteral(@"<!-- State saving -->
<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Category</h5>
        <div class=""header-elements"">
            <div class=""list-icons"">
                <a class=""list-icons-item"" data-action=""collapse""></a>
                <a class=""list-icons-item"" data-action=""reload""></a>
            </div>
        </div>
    </div>
    <table class=""table category-datatable"">
        <thead>
            <tr>
                <th>FullName</th>
                <th>Email</th>
                <th>UserName</th>
                <th>Role</th>
                <th>Activated</th>
                <th class=""text-center"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 28 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
             foreach (UserVM item in Model)
            {

#line default
#line hidden
            BeginContext(889, 62, true);
            WriteLiteral("            <tr>\r\n                <td class=\"text-capitalize\">");
            EndContext();
            BeginContext(952, 13, false);
#line 31 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                                       Write(item.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(965, 51, true);
            WriteLiteral("</td>\r\n                <td class=\"text-capitalize\">");
            EndContext();
            BeginContext(1017, 10, false);
#line 32 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 51, true);
            WriteLiteral("</td>\r\n                <td class=\"text-capitalize\">");
            EndContext();
            BeginContext(1079, 13, false);
#line 33 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                                       Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 51, true);
            WriteLiteral("</td>\r\n                <td class=\"text-capitalize\">");
            EndContext();
            BeginContext(1144, 9, false);
#line 34 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                                       Write(item.Role);

#line default
#line hidden
            EndContext();
            BeginContext(1153, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 35 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                 if (item.Activeted)
                {

#line default
#line hidden
            BeginContext(1217, 74, true);
            WriteLiteral("                    <td class=\"text-capitalize text-success\">Active</td>\r\n");
            EndContext();
#line 38 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1353, 74, true);
            WriteLiteral("                    <td class=\"text-capitalize text-danger\">Disable</td>\r\n");
            EndContext();
#line 43 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1446, 87, true);
            WriteLiteral("                <td class=\"text-right\">\r\n                    <div class=\"list-icons\">\r\n");
            EndContext();
#line 46 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                         if (User.Identity.Name != item.UserName)
                        {
                            

#line default
#line hidden
#line 48 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                             if (!item.Activeted)
                            {

#line default
#line hidden
            BeginContext(1709, 109, true);
            WriteLiteral("                                <a class=\"text-capitalize text-white btn btn-success accountStatus\" data-id=\"");
            EndContext();
            BeginContext(1819, 7, false);
#line 50 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                                                                                                        Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1826, 14, true);
            WriteLiteral("\">Active</a>\r\n");
            EndContext();
#line 51 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1936, 108, true);
            WriteLiteral("                                <a class=\"text-capitalize text-white btn btn-danger accountStatus\" data-id=\"");
            EndContext();
            BeginContext(2045, 7, false);
#line 54 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                                                                                                       Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2052, 15, true);
            WriteLiteral("\">Disable</a>\r\n");
            EndContext();
#line 55 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2098, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2126, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17aa1ee081d941a29f38a1397f255680", async() => {
                BeginContext(2229, 11, true);
                WriteLiteral("Change Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
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
            BeginContext(2244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2273, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2297, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a627b3a4a0d34012b5fdca30ca538bde", async() => {
                BeginContext(2400, 14, true);
                WriteLiteral("Reset Password");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
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
            BeginContext(2418, 82, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 63 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\EvTapsiriqiFrontToBack\Areas\FiorelloAdmin\Views\User\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2515, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("ThemeScript", async() => {
                BeginContext(2578, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2584, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d74ea7ca8cd4ad1b4843c9657ffda18", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2676, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2682, 89, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78b58fbb1860487bbb86d8a9d883ea6f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2771, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(2776, 24, true);
            WriteLiteral("<!-- /state saving -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
