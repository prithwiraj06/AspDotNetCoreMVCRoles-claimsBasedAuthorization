#pragma checksum "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a863dc38f3979345acd135172d2aae5ed857d31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adminstration_ListOfRoles), @"mvc.1.0.view", @"/Views/Adminstration/ListOfRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Adminstration/ListOfRoles.cshtml", typeof(AspNetCore.Views_Adminstration_ListOfRoles))]
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
#line 1 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\_ViewImports.cshtml"
using MvcPractice.Models;

#line default
#line hidden
#line 2 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\_ViewImports.cshtml"
using MvcPractice.ViewModels;

#line default
#line hidden
#line 3 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\_ViewImports.cshtml"
using MvcPractice.Models.Enums;

#line default
#line hidden
#line 4 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a863dc38f3979345acd135172d2aae5ed857d31", @"/Views/Adminstration/ListOfRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b45d07af70071b399f8e5d5d38f9c4711b194d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Adminstration_ListOfRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Adminstration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
  
    ViewBag.Title = "List of roles";

#line default
#line hidden
            BeginContext(176, 20, true);
            WriteLiteral("<h2>All Roles</h2>\r\n");
            EndContext();
#line 8 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(218, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(222, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "097b2ded0eba4dab8dd153db2c95d627", async() => {
                BeginContext(323, 11, true);
                WriteLiteral("Create Role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(338, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
     foreach (var role in Model)
    {

#line default
#line hidden
            BeginContext(381, 96, true);
            WriteLiteral("        <div class=\"card m-3\">\r\n            <div class=\"card-header\">\r\n                Role Id: ");
            EndContext();
            BeginContext(478, 7, false);
#line 15 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                    Write(role.Id);

#line default
#line hidden
            EndContext();
            BeginContext(485, 98, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(584, 9, false);
#line 18 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                                  Write(role.Name);

#line default
#line hidden
            EndContext();
            BeginContext(593, 82, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                ");
            EndContext();
            BeginContext(675, 1227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5ce9b6bf3274118948884c145a39e26", async() => {
                BeginContext(774, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 22 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                     if ((await authorizationService.AuthorizeAsync(User, "EditRolePolicy")).Succeeded)
                    {

#line default
#line hidden
                BeginContext(904, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(928, 131, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f16b3a133ff4858a72e0e880be41285", async() => {
                    BeginContext(1051, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 24 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                                                                                                                             WriteLiteral(role.Id);

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
                BeginContext(1059, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 25 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                    }

#line default
#line hidden
                BeginContext(1084, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 27 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                     if ((await authorizationService.AuthorizeAsync(User, "DeleteRolePolicy")).Succeeded)
                    {

#line default
#line hidden
                BeginContext(1216, 29, true);
                WriteLiteral("                        <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1245, "\"", 1276, 2);
                WriteAttributeValue("", 1250, "confirmDeleteSpan_", 1250, 18, true);
#line 29 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
WriteAttributeValue("", 1268, role.Id, 1268, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1277, 268, true);
                WriteLiteral(@" style=""display:none"">
                            <span>Are you sure want to delete</span>
                            <button class=""btn btn-danger"" style=""width:auto"">Yes</button>
                            <a href=""#"" class=""btn btn-primary"" style=""width:auto""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1545, "\"", 1587, 4);
                WriteAttributeValue("", 1555, "confirmDelete(\'", 1555, 15, true);
#line 32 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
WriteAttributeValue("", 1570, role.Id, 1570, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1578, "\',", 1578, 2, true);
                WriteAttributeValue(" ", 1580, "false)", 1581, 7, true);
                EndWriteAttribute();
                BeginContext(1588, 71, true);
                WriteLiteral(">No</a>\r\n                        </span>\r\n                        <span");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1659, "\"", 1683, 2);
                WriteAttributeValue("", 1664, "deleteSpan_", 1664, 11, true);
#line 34 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
WriteAttributeValue("", 1675, role.Id, 1675, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1684, 84, true);
                WriteLiteral(">\r\n                            <a href=\"#\" class=\"btn btn-danger\" style=\"width:auto\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1768, "\"", 1809, 4);
                WriteAttributeValue("", 1778, "confirmDelete(\'", 1778, 15, true);
#line 35 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
WriteAttributeValue("", 1793, role.Id, 1793, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 1801, "\',", 1801, 2, true);
                WriteAttributeValue(" ", 1803, "true)", 1804, 6, true);
                EndWriteAttribute();
                BeginContext(1810, 46, true);
                WriteLiteral(">Delete</a>\r\n                        </span>\r\n");
                EndContext();
#line 37 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                    }

#line default
#line hidden
                BeginContext(1879, 16, true);
                WriteLiteral("                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
                                                                                             WriteLiteral(role.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1902, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
    }

#line default
#line hidden
#line 41 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
     

}
else
{

#line default
#line hidden
            BeginContext(1961, 237, true);
            WriteLiteral("    <div class=\"card m-3\">\r\n        <div class=\"card-header\">\r\n            No roles created yet\r\n        </div>\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">Use the button below to create a role</h5>\r\n            ");
            EndContext();
            BeginContext(2198, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9468a60150934a3d9e674be4afcc366a", async() => {
                BeginContext(2299, 11, true);
                WriteLiteral("Create role");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2314, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 55 "G:\Prithwi\Dotnet core Practice\MvcPractice\MvcPractice\Views\Adminstration\ListOfRoles.cshtml"
}

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(2364, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2370, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0511ee7c3324970ac84a5157ff4ddfc", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2419, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
