#pragma checksum "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0ba11fa3285f083b77dfeee6026d5ab689b7be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_courses_admin_Views_Slider_Index), @"mvc.1.0.view", @"/Areas/courses-admin/Views/Slider/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\_ViewImports.cshtml"
using BackProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\_ViewImports.cshtml"
using BackProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ba11fa3285f083b77dfeee6026d5ab689b7be5", @"/Areas/courses-admin/Views/Slider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eddc7a407ccd33b9c5b140008f03f87a0dfb251", @"/Areas/courses-admin/Views/_ViewImports.cshtml")]
    public class Areas_courses_admin_Views_Slider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Sliders>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Alternate Text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-icons-item text-primary-600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/global_assets/js/plugins/tables/datatables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/global_assets/js/plugins/notifications/sweet_alert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
  
    ViewData["Title"] = "Admin Panel - Slides List ";
    ViewData["TitleNavbar"] = " Slides List ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- State saving -->
<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Slides List</h5>
    </div>
    <table class=""table category-datatable"">
        <thead>
            <tr>
                <th>Title</th>
                <th>Image</th>
                <th class=""text-center"">status</th>
                <th class=""text-center"">Change status</th>
                <th class=""text-right"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
             foreach (Sliders item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e0ba11fa3285f083b77dfeee6026d5ab689b7be57291", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 864, "~/site/img/slider/", 864, 18, true);
#nullable restore
#line 29 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
AddHtmlAttributeValue("", 882, item.Image, 882, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 31 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                 if (item.Activeted)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\" text-capitalize text-success status-text\">Active</td>\r\n");
#nullable restore
#line 34 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-capitalize text-danger status-text\">Disable</td>\r\n");
#nullable restore
#line 38 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"text-center \">\r\n");
#nullable restore
#line 40 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                     if (!item.Activeted)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"text-capitalize text-white btn btn-success status \" data-id=\"");
#nullable restore
#line 42 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Active</a>\r\n");
#nullable restore
#line 43 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"text-capitalize text-white btn btn-danger status\" data-id=\"");
#nullable restore
#line 46 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Disable</a>\r\n");
#nullable restore
#line 47 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td class=\"text-right\">\r\n                    <div class=\"list-icons\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0ba11fa3285f083b77dfeee6026d5ab689b7be512135", async() => {
                WriteLiteral("<i class=\"icon-pencil7\"></i>");
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
#nullable restore
#line 51 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <a class=\"list-icons-item text-danger-600 delete\" data-id=\"");
#nullable restore
#line 52 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"icon-trash\"></i></a>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\agase\OneDrive\Рабочий стол\Seynur\p314-asp-mvc-project-seynurmammadov\BackProject\Areas\courses-admin\Views\Slider\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("ThemeScript", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0ba11fa3285f083b77dfeee6026d5ab689b7be515423", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0ba11fa3285f083b77dfeee6026d5ab689b7be516523", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<!-- /state saving -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Sliders>> Html { get; private set; }
    }
}
#pragma warning restore 1591
