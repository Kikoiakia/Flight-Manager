#pragma checksum "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55d15168be48bd0a964e83809eca57b763e8f1af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_FlightList_Info), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/FlightList/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55d15168be48bd0a964e83809eca57b763e8f1af", @"/Areas/Identity/Pages/FlightList/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"151750a327944764a26a230f2e5f1e944454f046", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_FlightList_Info : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <table id=""table001"" class=""Basic-Table"">
        <colgroup>
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
                    <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Plane Type</span></p>
                </td>
                <td class=""Basic-Table CellOverride-2"">
                    <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">From</span></p>
                </td>
                <td class=""Basic-Table CellOverride-2"">
   ");
            WriteLiteral(@"                 <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Destination</span></p>
                </td>
                <td class=""Basic-Table CellOverride-2"">
                    <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Departure</span></p>
                </td>
                <td class=""Basic-Table CellOverride-2"">
                    <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Arrival</span></p>
                </td>
                <td class=""Basic-Table CellOverride-2"">
                    <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Bussines Seats Left</span></p>
                </td>
                <td class=""Basic-Table CellOverride-2"">
                    <p class=""Basic-Paragraph ParaOverride-1""><span class=""CharOverride-2"">Economy Seats Left</span></p>
                </td>
                <td class=""Basic-Table CellOverride-3"">
                    <p class=""Basic-Paragra");
            WriteLiteral("ph ParaOverride-1\"><span class=\"CharOverride-2\">Pilot’s Name</span></p>\r\n                </td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            WriteLiteral("                        <tr class=\"Basic-Table _idGenTableRowColumn-2\">\r\n                            <td class=\"Basic-Table CellOverride-4\">");
#nullable restore
#line 47 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.PlaneModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 48 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.LocationFrom));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 49 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.LocationTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 50 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.FlightTakeOff));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 51 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.FlightLanding));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 52 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.CapacityBuisness));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"Basic-Table CellOverride-5\">");
#nullable restore
#line 53 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.CapacityNormal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td class=\"Basic-Table CellOverride-6\">");
#nullable restore
#line 54 "E:\work\Flight_site\Website\Flight-Manager\Flight Manager\Web\Flight-Manager.Web\Areas\Identity\Pages\FlightList\Info.cshtml"
                                                              Write(Html.DisplayFor(modelItem => Model.Flight.PilotName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            WriteLiteral(@"        </tbody>
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
");
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55d15168be48bd0a964e83809eca57b763e8f1af10610", async() => {
                WriteLiteral("Back to homepage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flight_Manager.Web.Areas.Identity.Pages.FlightList.InfoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Flight_Manager.Web.Areas.Identity.Pages.FlightList.InfoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Flight_Manager.Web.Areas.Identity.Pages.FlightList.InfoModel>)PageContext?.ViewData;
        public Flight_Manager.Web.Areas.Identity.Pages.FlightList.InfoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
