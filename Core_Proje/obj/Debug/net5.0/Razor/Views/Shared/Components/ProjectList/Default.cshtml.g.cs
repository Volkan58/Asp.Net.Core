#pragma checksum "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657d2c1f723d36462121394d22201b85676e80cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProjectList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
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
#line 1 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657d2c1f723d36462121394d22201b85676e80cc", @"/Views/Shared/Components/ProjectList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProjectList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""row "">
    <div class=""col-12 grid-margin"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Proje Listesi</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th>
                                    #
                                </th>
                                <th> Ana Görsel </th>
                                <th> Proje Adı </th>
                                <th> Url </th>
                                <th> Fiyat </th>
                                <th> Payment Mode </th>
                            
                                <th> Durum </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                             foreach (var item in Model)
                            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 33 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                               Write(item.PortfolioID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                   <img");
            BeginWriteAttribute("src", " src=\"", 1296, "\"", 1316, 1);
#nullable restore
#line 36 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1302, item.ImageUrl, 1302, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                                <td> ");
#nullable restore
#line 38 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 39 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.ProjectUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 40 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 41 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("% </td>\r\n                         \r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1693, "\"", 1743, 3);
            WriteAttributeValue("", 1700, "/Portfolio/EditPortfolio/", 1700, 25, true);
#nullable restore
#line 44 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
WriteAttributeValue("", 1725, item.PortfolioID, 1725, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1742, "/", 1742, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"badge badge-outline-success\">Detayları Gör</div>\r\n                                    </a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\ProjectList\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
