#pragma checksum "C:\Users\Volka\Asp.Net.Core\Core_Proje\Views\Shared\Components\AdminNatificationNavbarList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b712d96d1a0d97d69a78ef629c039cb3c5cdcf97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AdminNatificationNavbarList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AdminNatificationNavbarList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b712d96d1a0d97d69a78ef629c039cb3c5cdcf97", @"/Views/Shared/Components/AdminNatificationNavbarList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AdminNatificationNavbarList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
    <h6 class=""p-3 mb-0"">Bildirimler</h6>
    <div class=""dropdown-divider""></div>
    <a class=""dropdown-item preview-item"">
        <div class=""preview-thumbnail"">
            <div class=""preview-icon bg-dark rounded-circle"">
                <i class=""mdi mdi-calendar text-success""></i>
            </div>
        </div>
        <div class=""preview-item-content"">
            <p class=""preview-subject mb-1"">Bu gün yapılacaklar</p>
            <p class=""text-muted ellipsis mb-0""> TodoList Üzerinde Yapman Gereken İşler </p>
        </div>
    </a>
    <div class=""dropdown-divider""></div>
    <a class=""dropdown-item preview-item"">
        <div class=""preview-thumbnail"">
            <div class=""preview-icon bg-dark rounded-circle"">
                <i class=""mdi mdi-settings text-danger""></i>
            </div>
        </div>
        <div class=""preview-item-content"">
        ");
            WriteLiteral(@"    <p class=""preview-subject mb-1"">Ayarlar</p>
            <p class=""text-muted ellipsis mb-0""> Dashboard Güncellendi </p>
        </div>
    </a>
    <div class=""dropdown-divider""></div>
    <a class=""dropdown-item preview-item"">
        <div class=""preview-thumbnail"">
            <div class=""preview-icon bg-dark rounded-circle"">
                <i class=""mdi mdi-link-variant text-warning""></i>
            </div>
        </div>
        <div class=""preview-item-content"">
            <p class=""preview-subject mb-1"">Duyuru Detayları</p>
            <p class=""text-muted ellipsis mb-0""> Duyuru Paneline Git </p>
        </div>
    </a>
    <div class=""dropdown-divider""></div>
    <p class=""p-3 mb-0 text-center"">Tüm Bildirimleri Gör.</p>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
