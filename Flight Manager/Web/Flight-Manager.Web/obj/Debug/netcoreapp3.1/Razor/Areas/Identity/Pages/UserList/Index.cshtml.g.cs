#pragma checksum "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddad4370d5581c420348ae9d79c6b1a01ba5619c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_UserList_Index), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/UserList/Index.cshtml")]
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
#line 1 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Flight_Manager.Web.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Flight_Manager.Web.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Flight_Manager.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddad4370d5581c420348ae9d79c6b1a01ba5619c", @"/Areas/Identity/Pages/UserList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151750a327944764a26a230f2e5f1e944454f046", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_UserList_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/UserList/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
 if (this.User.IsInRole("Admin"))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Users</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad4370d5581c420348ae9d79c6b1a01ba5619c7127", async() => {
                WriteLiteral(@"
        <div id=""_idContainer003"" class=""Basic-Text-Frame"">
            <table id=""table001"" class=""Basic-Table"">
                <colgroup>
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                    <col class=""_idGenTableRowColumn-1"" />
                </colgroup>
                <thead>
                    <tr class=""Basic-Table _idGenTableRowColumn-2"">
                        <td class=""Basic-Table CellOverride-1"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Name</span></p>
                        </td>
   ");
                WriteLiteral(@"                     <td class=""Basic-Table CellOverride-2"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Surname</span></p>
                        </td>
                        <td class=""Basic-Table CellOverride-2"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Personal Id</span></p>
                        </td>
                        <td class=""Basic-Table CellOverride-2"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Address</span></p>
                        </td>
                        <td class=""Basic-Table CellOverride-2"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Phone Number</span></p>
                        </td>
                        <td class=""Basic-Table CellOverride-2"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverri");
                WriteLiteral(@"de-2"">Email</span></p>
                        </td>
                        <td class=""Basic-Table CellOverride-2"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Username</span></p>
                        </td>
                        <td class=""Basic-Table CellOverride-3"">
                            <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">CRUD</span></p>
                        </td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 50 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                      
                        var i = 0;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                         foreach (var item in Model.Users)
                        {
                            if (i % 2 == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr class=\"Basic-Table _idGenTableRowColumn-2\">\r\n                                    <td class=\"Basic-Table CellOverride-4\">");
#nullable restore
#line 57 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 58 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 59 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.PersonalId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 60 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 61 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 62 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 63 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-6\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad4370d5581c420348ae9d79c6b1a01ba5619c14178", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad4370d5581c420348ae9d79c6b1a01ba5619c16851", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 69 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                i++;
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr class=\"Basic-Table _idGenTableRowColumn-2\">\r\n                                    <td class=\"Basic-Table CellOverride-7\">");
#nullable restore
#line 74 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-8\">");
#nullable restore
#line 75 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-8\">");
#nullable restore
#line 76 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.PersonalId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-8\">");
#nullable restore
#line 77 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-8\">");
#nullable restore
#line 78 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-8\">");
#nullable restore
#line 79 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-8\">");
#nullable restore
#line 80 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                      Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td class=\"Basic-Table CellOverride-9\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad4370d5581c420348ae9d79c6b1a01ba5619c23199", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad4370d5581c420348ae9d79c6b1a01ba5619c25872", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 86 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
                                i++;
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </tbody>
                <!--
                <ul class=""pagination"">
                    for (var i = 1; i <= Model.Pager.PagesCount; i++)
                    {
                        <li class=""page-item (i == Model.Pager.CurrentPage ? ""active"" : """")"">
                            <a asp-route-Pager.CurrentPage=""i"" class=""page-link"">i</a>
                        </li>
                    }
                </ul>
                -->

            </table>
        </div>
        <div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad4370d5581c420348ae9d79c6b1a01ba5619c29381", async() => {
                    WriteLiteral("Back to homepage");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 108 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h1>You don\'t have premission to be here</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddad4370d5581c420348ae9d79c6b1a01ba5619c32134", async() => {
                WriteLiteral("Back to homepage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 115 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\UserList\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flight_Manager.Web.Areas.Identity.Pages.UserList.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Flight_Manager.Web.Areas.Identity.Pages.UserList.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Flight_Manager.Web.Areas.Identity.Pages.UserList.IndexModel>)PageContext?.ViewData;
        public Flight_Manager.Web.Areas.Identity.Pages.UserList.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
