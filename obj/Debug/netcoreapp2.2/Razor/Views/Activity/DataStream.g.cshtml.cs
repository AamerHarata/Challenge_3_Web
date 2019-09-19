#pragma checksum "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bd9b1685c1146ef45a8de0a8e0c3c4fbdca039b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activity_DataStream), @"mvc.1.0.view", @"/Views/Activity/DataStream.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Activity/DataStream.cshtml", typeof(AspNetCore.Views_Activity_DataStream))]
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
#line 1 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\_ViewImports.cshtml"
using Challenge_3_Web;

#line default
#line hidden
#line 2 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\_ViewImports.cshtml"
using Challenge_3_Web.Models;

#line default
#line hidden
#line 1 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
using Challenge_3_Web.Enum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bd9b1685c1146ef45a8de0a8e0c3c4fbdca039b", @"/Views/Activity/DataStream.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"190169446eebcf7dbf03da91d3a55e523e098006", @"/Views/_ViewImports.cshtml")]
    public class Views_Activity_DataStream : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RowData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(124, 172, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h4 class=\"display-4\">Data Stream</h4>\r\n    <div class=\"flex-column\">\r\n        <button class=\"btn btn-danger\" style=\"display: inline-block\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 296, "\"", 347, 3);
            WriteAttributeValue("", 306, "location.href=\'", 306, 15, true);
#line 13 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
WriteAttributeValue("", 321, Url.Action("DeleteData"), 321, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 346, "\'", 346, 1, true);
            EndWriteAttribute();
            BeginContext(348, 35, true);
            WriteLiteral(">Delete All Data</button>\r\n        ");
            EndContext();
            BeginContext(384, 210, false);
#line 14 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
   Write(Html.DropDownList(" " ,
            new SelectList(Enum.GetValues(typeof(Activity))), "All Data",
            new {@class = "form-control", @style="width: 40%; display:inline-block", @id="activity-selected"}));

#line default
#line hidden
            EndContext();
            BeginContext(594, 227, true);
            WriteLiteral("\r\n        <button class=\"btn btn-success\" id=\"download-btn\" style=\"display: inline-block\">Download Data</button>\r\n    </div>\r\n    <br/><hr/>\r\n    <table class=\"table table-success\">\r\n        <tr>\r\n            <th>Gr. Nr.</th>\r\n");
            EndContext();
            BeginContext(854, 398, true);
            WriteLiteral(@"            <th>xAco</th>
            <th>yAco</th>
            <th>xAco</th>
            <th>xGyro</th>
            <th>yGyro</th>
            <th>zGyro</th>
            <th>xLinAco</th>
            <th>yLinAco</th>
            <th>zLinAco</th>
            <th>xMag</th>
            <th>yMag</th>
            <th>zMag</th>
            <th>Activity</th>
        
        </tr>
    
");
            EndContext();
#line 40 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
         foreach (var rowData in Model)
        {

#line default
#line hidden
            BeginContext(1304, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1343, 19, false);
#line 43 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(rowData.GroupNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
            BeginContext(1446, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1467, 27, false);
#line 45 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.xAco, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1522, 27, false);
#line 46 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.yAco, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1577, 27, false);
#line 47 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.zAco, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1632, 28, false);
#line 48 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.xGyro, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1688, 28, false);
#line 49 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.yGyro, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1716, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1744, 28, false);
#line 50 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.zGyro, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1772, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1800, 30, false);
#line 51 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.xLinAco, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1858, 30, false);
#line 52 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.yLinAco, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1888, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1916, 30, false);
#line 53 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.zLinAco, 5));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1974, 27, false);
#line 54 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.xMag, 5));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2029, 27, false);
#line 55 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.yMag, 5));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2084, 27, false);
#line 56 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(Math.Round(rowData.zMag, 5));

#line default
#line hidden
            EndContext();
            BeginContext(2111, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(2139, 16, false);
#line 57 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
               Write(rowData.Activity);

#line default
#line hidden
            EndContext();
            BeginContext(2155, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 59 "D:\GitFolders\Programming\Twente\Challenge_3_Web\Views\Activity\DataStream.cshtml"
        }

#line default
#line hidden
            BeginContext(2192, 42, true);
            WriteLiteral("    \r\n    \r\n    \r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2253, 663, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function() {
            $(""#download-btn"").unbind().bind(""click"",
                function() {
                    var selected = $(""#activity-selected"").find("":selected"").val();

                    location.href = `/saveData/${selected}`;

                    $.ajax({
                        type: ""GET"",
                        url: ""/SaveData"",
                        data: { activity: selected },
                        success: function(response) {
                            console.log(response);
                        }
                    });

                });
    })
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RowData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
