#pragma checksum "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "214d595f39224ef67232ec605f46380e204a4a09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\_ViewImports.cshtml"
using SuperAppPet;

#line default
#line hidden
#line 2 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\_ViewImports.cshtml"
using SuperAppPet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"214d595f39224ef67232ec605f46380e204a4a09", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f6dc990a22771954a6fe36597dc1073e50f77d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group h2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(74, 221, true);
            WriteLiteral("\r\n<div id=\"main\" class=\"container-fluid\" style=\"margin-top: 50px;\">\r\n    <div id=\"top\" class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <h2>Users</h2>\r\n        </div>\r\n        <div class=\"col-sm-6\">\r\n            ");
            EndContext();
            BeginContext(295, 524, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e96bbd6617c4561b6c279b1b65423f9", async() => {
                BeginContext(377, 435, true);
                WriteLiteral(@"
                <input name=""phone"" class=""form-control"" id=""userPhone"" type=""text"" placeholder=""Type a phone"" onkeypress=""return somenteNumeros(event)"" maxlength=""12"" />
                <span class=""input-group-btn"">
                    <button type=""submit"" class=""btn btn-primary"" id=""searchPhone"">
                        <span class=""fa fa-search""></span>
                    </button>
                </span>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 13 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 309, Url.Action("Details", "User"), 309, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(819, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(834, 19, false);
#line 21 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(853, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-sm-3\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 917, "\'", 950, 1);
#line 24 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
WriteAttributeValue("", 924, Url.Action("Add", "User"), 924, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(951, 650, true);
            WriteLiteral(@" class=""btn btn-primary pull-right h2"">New User</a>
        </div>
    </div>
    <!-- /#top -->
    <hr />
    <div id=""list"" class=""row"">
        <div class=""table-responsive col-md-12"">
            <table id=""users-table"" class=""table table-striped"" cellspacing=""0"" cellpAdicionaring=""0"">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>E-mail</th>
                        <th>Phone</th>
                        <th>Created At</th>
                        <th class=""actions"">Ações</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 42 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
            BeginContext(1674, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1737, 9, false);
#line 45 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
                           Write(user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1746, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1786, 10, false);
#line 46 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
                           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1796, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1836, 10, false);
#line 47 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
                           Write(user.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1846, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1886, 14, false);
#line 48 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
                           Write(user.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1900, 122, true);
            WriteLiteral("</td>\r\n                            <td class=\"actions\">\r\n                                <a class=\"btn btn-success btn-xs\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2022, "\'", 2079, 1);
#line 50 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
WriteAttributeValue("", 2029, Url.Action("Details", "User", new { user.Phone }), 2029, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2080, 117, true);
            WriteLiteral("><i class=\"fa fa-info\" aria-hidden=\"true\"></i></a>\r\n                                <a class=\"btn btn-warning btn-xs\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2197, "\'", 2251, 1);
#line 51 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
WriteAttributeValue("", 2204, Url.Action("Edit", "User", new { user.Phone }), 2204, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2252, 88, true);
            WriteLiteral("><i class=\"fa fa-list-alt\" aria-hidden=\"true\"></i></a>\r\n                                ");
            EndContext();
            BeginContext(2340, 356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "365a0efcef4c4ad395e668dea95442bb", async() => {
                BeginContext(2399, 72, true);
                WriteLiteral("\r\n                                    <input type=\"text\" name=\"phoneDel\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2471, "\"", 2490, 1);
#line 53 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
WriteAttributeValue("", 2479, user.Phone, 2479, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2491, 198, true);
                WriteLiteral(" hidden/>\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-xs\" value=\"\"> <i class=\"fa fa-trash\" aria-hidden=\"true\"></i></button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 52 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
AddHtmlAttributeValue("", 2354, Url.Action("Delete", "User"), 2354, 29, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2696, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2787, 82, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
