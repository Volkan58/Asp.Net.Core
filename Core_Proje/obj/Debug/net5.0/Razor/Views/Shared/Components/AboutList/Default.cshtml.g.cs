#pragma checksum "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "345d165ea486cda47f9a6a1a19fb6ced939b7906"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"345d165ea486cda47f9a6a1a19fb6ced939b7906", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\r\n        <div class=\"container-narrow\">\r\n");
#nullable restore
#line 6 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
             foreach (var x in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <h2 class=\"h4 my-2\">");
#nullable restore
#line 9 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                   Write(x.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 10 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                  Write(x.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""row mt-3"">
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Yaş:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 16 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(x.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Email:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 22 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(x.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Telefon:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 28 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(x.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        
                            
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Address:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 36 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(x.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        
                        
                    </div>
                </div>
                <div class=""col-md-5 offset-md-1"" data-aos=""fade-left"" data-aos-delay=""100""><img class=""avatar img-fluid mt-2""");
            BeginWriteAttribute("src", " src=\"", 1861, "\"", 1878, 1);
#nullable restore
#line 42 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"
WriteAttributeValue("", 1867, x.ImageUrl, 1867, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400\" height=\"400\" alt=\"Walter Patterson\" /></div>\r\n            </div>\r\n");
#nullable restore
#line 44 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AboutList\Default.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
