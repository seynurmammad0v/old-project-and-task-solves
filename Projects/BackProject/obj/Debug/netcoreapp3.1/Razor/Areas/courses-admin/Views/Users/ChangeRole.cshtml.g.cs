#pragma checksum "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61fae0c28a1050428c96f5b8cad0d0e7237634a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_courses_admin_Views_Users_ChangeRole), @"mvc.1.0.view", @"/Areas/courses-admin/Views/Users/ChangeRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61fae0c28a1050428c96f5b8cad0d0e7237634a2", @"/Areas/courses-admin/Views/Users/ChangeRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eddc7a407ccd33b9c5b140008f03f87a0dfb251", @"/Areas/courses-admin/Views/_ViewImports.cshtml")]
    public class Areas_courses_admin_Views_Users_ChangeRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
  
    ViewData["Title"] = "Admin Panel - Change Role ";
    ViewData["TitleNavbar"] = " Change Role ";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"card-header header-elements-inline\">\r\n        <h5 class=\"card-title\">Change Role</h5>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <p class=\"text-capitalize\">Name: ");
#nullable restore
#line 11 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-capitalize\">Surname: ");
#nullable restore
#line 12 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                       Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-capitalize\">Phone Number: ");
#nullable restore
#line 13 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                            Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-capitalize\">Image: ");
#nullable restore
#line 14 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                     Write(Model.Image);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-capitalize\">Email: ");
#nullable restore
#line 15 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                     Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-capitalize\">Username: ");
#nullable restore
#line 16 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                        Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"text-capitalize\">Role: ");
#nullable restore
#line 17 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                    Write(Model.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
         if (TempData["error"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>");
#nullable restore
#line 20 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
            Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 21 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61fae0c28a1050428c96f5b8cad0d0e7237634a27359", async() => {
                WriteLiteral("\r\n            <div>\r\n");
#nullable restore
#line 25 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                 foreach (string item in Model.Roles)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                     if (Model.Role == item)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"radio\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 1084, "\"", 1097, 1);
#nullable restore
#line 29 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1092, item, 1092, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1098, "\"", 1108, 1);
#nullable restore
#line 29 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1103, item, 1103, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked />\r\n");
#nullable restore
#line 30 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"radio\" name=\"role\"");
                BeginWriteAttribute("value", " value=\"", 1249, "\"", 1262, 1);
#nullable restore
#line 33 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1257, item, 1257, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1263, "\"", 1273, 1);
#nullable restore
#line 33 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1268, item, 1268, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 34 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <label");
                BeginWriteAttribute("for", " for=\"", 1328, "\"", 1339, 1);
#nullable restore
#line 35 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
WriteAttributeValue("", 1334, item, 1334, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"text-capitalize\"> ");
#nullable restore
#line 35 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                                                           Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 36 "C:\Users\Seynur\Desktop\Projects\backendProject\BackProject\Areas\courses-admin\Views\Users\ChangeRole.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        <div class=\"card-footer d-flex flex-row-reverse mt-3\" >\r\n            <button type=\"submit\" class=\"btn btn-success\">Save</button>\r\n        </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
