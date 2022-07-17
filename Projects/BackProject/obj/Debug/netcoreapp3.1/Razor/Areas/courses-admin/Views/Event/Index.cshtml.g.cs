#pragma checksum "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a00292a7c29ad1d3fc21b30170fe46ae3c97e46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_courses_admin_Views_Event_Index), @"mvc.1.0.view", @"/Areas/courses-admin/Views/Event/Index.cshtml")]
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
#line 1 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\_ViewImports.cshtml"
using BackProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\_ViewImports.cshtml"
using BackProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a00292a7c29ad1d3fc21b30170fe46ae3c97e46", @"/Areas/courses-admin/Views/Event/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eddc7a407ccd33b9c5b140008f03f87a0dfb251", @"/Areas/courses-admin/Views/_ViewImports.cshtml")]
    public class Areas_courses_admin_Views_Event_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-icons-item text-primary-600"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/global_assets/js/plugins/tables/datatables/datatables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/global_assets/js/plugins/notifications/sweet_alert.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
  
    ViewData["Title"] = "Admin Panel - Events List ";
    ViewData["TitleNavbar"] = " Events List ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""card"">
    <div class=""card-header header-elements-inline"">
        <h5 class=""card-title"">Events List</h5>
    </div>
    <table class=""table category-datatable"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Moderators</th>
                <th>Categories</th>
                <th>Start time</th>
                <th>End time</th>
                <th>Create time</th>
                <th>Status</th>
                <th class=""text-center"">Change Status</th>
                <th class=""text-right"">Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
             foreach (Event item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-capitalize\">");
#nullable restore
#line 28 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td class=\"text-capitalize\">\r\n");
#nullable restore
#line 31 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                         foreach (EventModerator moderatorName in @item.EventModerators)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-capitalize\">");
#nullable restore
#line 33 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                                  Write(moderatorName.Moderator.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 34 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td class=\"text-capitalize\">\r\n                        <ol class=\"pl-3  \">\r\n");
#nullable restore
#line 39 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                             foreach (EventCategory categoryName in @item.EventCategories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"text-capitalize\"> ");
#nullable restore
#line 41 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                                        Write(categoryName.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 42 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ol>\r\n                    </td>\r\n                    <td class=\"text-capitalize\">");
#nullable restore
#line 45 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                           Write(item.StartTime.ToString("dd MMMM HH:mm "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-capitalize\">");
#nullable restore
#line 46 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                           Write(item.EndTime.ToString("dd MMMM HH:mm "));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-capitalize\">");
#nullable restore
#line 47 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                           Write(item.Created_at.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 49 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                     if (item.Activeted)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\" text-capitalize text-success status-text\">Active</td>\r\n");
#nullable restore
#line 52 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-capitalize text-danger status-text\">Disable</td>\r\n");
#nullable restore
#line 56 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-center \">\r\n");
#nullable restore
#line 58 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                         if (!item.Activeted)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"text-capitalize text-white btn btn-success status \" data-id=\"");
#nullable restore
#line 60 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Active</a>\r\n");
#nullable restore
#line 61 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"text-capitalize text-white btn btn-danger status\" data-id=\"");
#nullable restore
#line 64 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Disable</a>\r\n");
#nullable restore
#line 65 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td class=\"text-right\">\r\n                        <div class=\"list-icons\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a00292a7c29ad1d3fc21b30170fe46ae3c97e4612730", async() => {
                WriteLiteral("<i class=\"icon-pencil7\"></i>");
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
#nullable restore
#line 70 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a class=\"list-icons-item text-danger-600 delete\" data-id=\"");
#nullable restore
#line 71 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
                                                                                  Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"icon-trash\"></i></a>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 75 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Event\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            DefineSection("ThemeScript", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a00292a7c29ad1d3fc21b30170fe46ae3c97e4615943", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a00292a7c29ad1d3fc21b30170fe46ae3c97e4617043", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
