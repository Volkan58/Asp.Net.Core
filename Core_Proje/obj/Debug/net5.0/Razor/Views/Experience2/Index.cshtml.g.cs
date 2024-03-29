#pragma checksum "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Experience2\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af5c2b774fa9d9fb3f89e2244f1ef816176b99c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience2_Index), @"mvc.1.0.view", @"/Views/Experience2/Index.cshtml")]
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
#line 1 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Experience2\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af5c2b774fa9d9fb3f89e2244f1ef816176b99c3", @"/Views/Experience2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Experience2\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div class=""coll-md-6"">

    <div class=""p-2"">

        <button type=""button"" id=""getlistall"" class=""btn btn-primary"">Verileri Getir.</button>
        <button type=""button"" id=""btnAdd"" class=""btn btn-info"">Kaydet</button>
        <button type=""button"" id=""btnidget"" class=""btn btn-info"">id İle getir</button>
        <button type=""button"" id=""btndelete"" class=""btn btn-info"">Sil</button>
        <button type=""button"" id=""btnupdate"" class=""btn btn-info"">Güncelle</button>
    </div>
</div>


<div class=""p-2"" id=""ListExperience"">

    Buraya Veriler Gelecek.

</div>

<br />

<div class=""p-2"" id=""ListByidExperience"">

    Buraya Veriler Gelecek.

</div>
<br />

<div class=""col-md-12"">
    <h4>Ekleme Paneli</h4>
    <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Başlık"" /><br />
    <input type=""text"" class=""form-control"" id=""inpdate"" placeholder=""Tarih"" /><br />
</div>
<div class=""col-md-12"">
    <h4>İdye Göre Getirme Paneli</h4>
    <input type=""text"" class=""for");
            WriteLiteral(@"m-control"" id=""inpid"" placeholder=""İd"" /><br />


</div>
<br />
<div class=""col-md-12"">
    <h4>Silme Paneli</h4>
    <input type=""text"" class=""form-control"" id=""inpexid"" placeholder=""İd"" /><br />


</div>
<br />
</div>
<br />
<div class=""col-md-12"">
    <h4>Güncelleme Paneli</h4>
    <input type=""text"" class=""form-control"" id=""inpupdate"" placeholder=""İd"" /><br />


</div>
<br />

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#getlistall"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Experience2/ListExperience/"",
                success: function (funk) {
                    let values = jQuery.parseJSON(funk);
                    console.log(values);
                    //Table Yansıtma İşlemleri Script Json
                    let htmlst = ""<table class=table table-bordered> <tr> <th> ID </th> <th> Başlık </th> <th> Tarih </th> </tr>"";
                    $.each(values, (index, value) => {
                        htmlst += `<tr> <td>${value.ExperienceID}</td> <td>${value.Name}</td> <td>${value.Date}</td> </tr>`
                    });
                    htmlst += ""</table>"";
                    $(""#ListExperience"").html(htmlst);
                }
            });
        });


        $(""#btnAdd"").click(function () {
            let values = {
       ");
                WriteLiteral(@"         Name: $(""#inpname"").val(),
                Date: $(""#inpdate"").val()
            };

            $.ajax({
                type: ""Post"",
                url: ""/Experience2/AddExperience/"",
                data: values,
                success: function (funk1) {
                    let result = jQuery.parseJSON(funk1);
                    alert(""Başarılı bir şekilde eklendi"");
                }
            });
        });
        $(""#btnidget"").click(x => {

            let id = $(""#inpid"").val();
            $.ajax({

                contentType: ""application/json"",
                DataType: ""json"",
                type: ""get"",
                url: ""/Experience2/GetByID/"",
                data: { ExperienceID: id },
                success: function (funk2) {
                    let result = jQuery.parseJSON(funk2);
                    console.log(result);
                    let htmlstr = `<table class=table table-hover> <tr> <th>Deneyim ID</th> <td>${result.ExprerienceID}");
                WriteLiteral(@"</td></tr> <tr> <th> Deneyim Başlığı </th> <td> ${result.Name}</td> </tr> </table>`;
                    $(""#ListByidExperience"").html(htmlstr);

                }

            });

        });
        $(""#btndelete"").click(x => {
            let id = $(""#inpexid"").val();
            $.ajax({
                url: ""/Experience2/DeleteExperience/"" + id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (funk3) {
                    loadData();
                }
            });
        });
        $(""#btnupdate"").click(function () {
            let values = {
                ExprerienceID: $(""#inpeditexpid"").val(),
                Name: $(""#inpupdate"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/Experience2/UpdateExperience/"",
                data: values,
                success: function (func4) {
                    alert(""Güncellem");
                WriteLiteral("e işlemi yapıldı\");\r\n                }\r\n            });\r\n        });\r\n\r\n\r\n\r\n    </script>\r\n");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af5c2b774fa9d9fb3f89e2244f1ef816176b99c39012", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
