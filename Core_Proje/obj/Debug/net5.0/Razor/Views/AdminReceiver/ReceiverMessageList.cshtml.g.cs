#pragma checksum "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "194c79a0dcc47e67052a9e4eda4b500b5fff1cfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminReceiver_ReceiverMessageList), @"mvc.1.0.view", @"/Views/AdminReceiver/ReceiverMessageList.cshtml")]
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
#line 1 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"194c79a0dcc47e67052a9e4eda4b500b5fff1cfc", @"/Views/AdminReceiver/ReceiverMessageList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminReceiver_ReceiverMessageList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
  
    ViewData["Title"] = "ReceiverMessageList";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Yazar-Admin Gelen Kutusu</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Gönderen</th>
                            <th>Konu</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Mesajı Gör</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
                         foreach (var item in Model)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
                               Write(item.WriterID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
                               Write(item.SenderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 33 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
                               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 34 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1223, "\"", 1278, 2);
            WriteAttributeValue("", 1230, "/AdminReceiver/AdminMessageDelete/", 1230, 34, true);
#nullable restore
#line 35 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
WriteAttributeValue("", 1264, item.WriterID, 1264, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1363, "\"", 1419, 2);
            WriteAttributeValue("", 1370, "/AdminReceiver/AdminMessageDetails/", 1370, 35, true);
#nullable restore
#line 36 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
WriteAttributeValue("", 1405, item.WriterID, 1405, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Mesajı Gör</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\AdminReceiver\ReceiverMessageList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \r\n                    </tbody>\r\n                </table>\r\n                <a href=\"/AdminReceiver/AddMessageSend/\" class=\"btn btn-primary\">Yeni Mesaj Oluştur</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
