#pragma checksum "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "736e0c3a1f194ea1b48bcc481f874b811dc617fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"736e0c3a1f194ea1b48bcc481f874b811dc617fb", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Yetenek Listesi Tablosu</h3>
</div>
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">

");
#nullable restore
#line 26 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
             foreach (var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <th>\r\n        ");
#nullable restore
#line 30 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
   Write(x.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </th>\r\n\r\n\r\n    <td class=\"budget\">\r\n        ");
#nullable restore
#line 35 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
   Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n\r\n\r\n    <td>\r\n        <div class=\"d-flex align-items-center\">\r\n            <span class=\"completion mr-2\">");
#nullable restore
#line 41 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
                                     Write(x.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n            <div>\r\n                <div class=\"progress\">\r\n                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1260, "\"", 1284, 1);
#nullable restore
#line 44 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1276, x.Value, 1276, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1323, "\"", 1348, 3);
            WriteAttributeValue("", 1331, "width:", 1331, 6, true);
#nullable restore
#line 44 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 1337, x.Value, 1338, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1346, "%;", 1346, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1439, "\"", 1475, 2);
            WriteAttributeValue("", 1446, "/Skill/DeleteSkill/", 1446, 19, true);
#nullable restore
#line 49 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1465, x.SkillID, 1465, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a> </td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 1525, "\"", 1559, 2);
            WriteAttributeValue("", 1532, "/Skill/EditSkill/", 1532, 17, true);
#nullable restore
#line 50 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1549, x.SkillID, 1549, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a> </td>\r\n</tr> \r\n");
#nullable restore
#line 52 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Skill\Index.cshtml"
            }          

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n   \r\n    <a href=\"/Skill/AddSkill\" class=\"btn btn-primary\">Yeni Yetenek Ekle</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
