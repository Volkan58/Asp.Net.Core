#pragma checksum "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfe0365c351a3fd63fac61db3cc346e80c14dd96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MessageList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/MessageList/Default.cshtml")]
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
#line 1 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfe0365c351a3fd63fac61db3cc346e80c14dd96", @"/Views/Shared/Components/MessageList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_MessageList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-md-6 col-xl-4 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <div class=""d-flex flex-row justify-content-between"">
                <h4 class=""card-title"">Mesajlar</h4>
                <p class=""text-muted mb-1 small""><a href=""/ContactSubPlace/Index/"">Tümünü Görüntüle</a></p>
            </div>
");
#nullable restore
#line 12 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
             foreach (var item in Model)
            {

            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"preview-list\">\r\n                <div class=\"preview-item border-bottom\">\r\n                    <div class=\"preview-thumbnail\">\r\n");
            WriteLiteral(@"                    </div>
                    <div class=""preview-item-content d-flex flex-grow"">
                        <div class=""flex-grow"">
                            <div class=""d-flex d-md-block d-xl-flex justify-content-between"">
                                <h6 class=""preview-subject"">");
#nullable restore
#line 24 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-muted text-small\">");
#nullable restore
#line 25 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
                                                            Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <p class=\"text-muted\">");
#nullable restore
#line 27 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
                                             Write(item.Content.Substring(0,30));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\MessageList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
