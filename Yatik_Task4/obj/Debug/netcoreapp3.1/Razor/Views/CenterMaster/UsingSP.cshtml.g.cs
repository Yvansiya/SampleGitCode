#pragma checksum "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fbe4fc3e0c67d3a4360cbac858ef9a662700265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CenterMaster_UsingSP), @"mvc.1.0.view", @"/Views/CenterMaster/UsingSP.cshtml")]
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
#line 1 "E:\Yatik\Yatik_Task4\Views\_ViewImports.cshtml"
using Yatik_Task4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Yatik\Yatik_Task4\Views\_ViewImports.cshtml"
using Yatik_Task4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbe4fc3e0c67d3a4360cbac858ef9a662700265", @"/Views/CenterMaster/UsingSP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6fa6778f682193ea2dcdc63b20db833674a3794", @"/Views/_ViewImports.cshtml")]
    public class Views_CenterMaster_UsingSP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Center_Master>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" <h1>Using SP</h1>\r\n<div class=\"text-center\">\r\n    Total Records ");
#nullable restore
#line 4 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
             Write(ViewBag.cntcount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <table class=\"table table-border\">\r\n     <tr>\r\n         <th>Center Id</th>\r\n         <th>Center Name</th>\r\n         <th>Sort </th>\r\n         <th>Is Active</th>\r\n     </tr>\r\n \r\n");
#nullable restore
#line 13 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
 foreach(var Master in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 16 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
       Write(Master.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
       Write(Master.CenterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
       Write(Master.SortOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 19 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
         if(Master.IsActive)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>Yes</td>\r\n");
#nullable restore
#line 22 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>No</td>\r\n");
#nullable restore
#line 26 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n");
#nullable restore
#line 28 "E:\Yatik\Yatik_Task4\Views\CenterMaster\UsingSP.cshtml"
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Center_Master>> Html { get; private set; }
    }
}
#pragma warning restore 1591