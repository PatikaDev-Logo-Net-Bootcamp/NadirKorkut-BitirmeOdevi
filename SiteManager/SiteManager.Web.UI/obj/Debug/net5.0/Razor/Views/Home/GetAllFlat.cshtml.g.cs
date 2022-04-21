#pragma checksum "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91e85264603d1febbf96285c5d439f7079bb22c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllFlat), @"mvc.1.0.view", @"/Views/Home/GetAllFlat.cshtml")]
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
#line 1 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\_ViewImports.cshtml"
using SiteManager.Web.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\_ViewImports.cshtml"
using SiteManager.Web.UI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\_ViewImports.cshtml"
using SiteManager.Business.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91e85264603d1febbf96285c5d439f7079bb22c5", @"/Views/Home/GetAllFlat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae95b3adee4d7e7d63b51b54f599c5536dc8248c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_GetAllFlat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FlatDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-dark table-hover"">
    <thead class=""thead-dark"">
        <tr>
            <th scope=""col"">Blok Bilgisi</th>
            <th scope=""col"">Daire Numarası</th>
            <th scope=""col"">Daire Sahibi</th>
            <th scope=""col"">Daire Tipi</th>
            <th scope=""col"">Daire Durumu</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
         foreach (var flat in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
               Write(flat.BuildingName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
               Write(flat.FlatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
               Write(flat.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
               Write(flat.TypeOfFlat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 22 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
                     if (flat.IsEmpty)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>Dolu</span>\r\n");
#nullable restore
#line 25 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <span>Boş</span> \r\n");
#nullable restore
#line 29 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\testinium\source\repos\SiteManager\SiteManager.Web.UI\Views\Home\GetAllFlat.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FlatDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
