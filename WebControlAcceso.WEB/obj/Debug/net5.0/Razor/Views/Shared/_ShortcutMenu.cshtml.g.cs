#pragma checksum "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_ShortcutMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ec3298a5e20f53904b5189772a7f06fa4e4183b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ShortcutMenu), @"mvc.1.0.view", @"/Views/Shared/_ShortcutMenu.cshtml")]
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
#line 1 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ec3298a5e20f53904b5189772a7f06fa4e4183b", @"/Views/Shared/_ShortcutMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf8d93ca39b33fa2d7f296f66d537b4d3ad0aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ShortcutMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_ShortcutMenu.cshtml"
 if (Settings.Features.ShortcutMenu)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<nav class=\"shortcut-menu d-none d-sm-block\">\n\t<input type=\"checkbox\" class=\"menu-open\" name=\"menu-open\" id=\"menu_open\"/>\n\t<label for=\"menu_open\" class=\"menu-open-button \">\n\t\t<span class=\"app-shortcut-icon d-block\"></span>\n\t</label>\n");
            WriteLiteral("\t<a href=\"/Login/Index\" class=\"menu-item btn\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Logout\">\n\t\t<i");
            BeginWriteAttribute("class", " class=\"", 550, "\"", 598, 2);
#nullable restore
#line 12 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_ShortcutMenu.cshtml"
WriteAttributeValue("", 558, Settings.Theme.IconPrefix, 558, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 586, "fa-sign-out", 587, 12, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n\t</a>\n\t<a href=\"#\" class=\"menu-item btn\" data-action=\"app-fullscreen\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Full Screen\">\n\t\t<i");
            BeginWriteAttribute("class", " class=\"", 744, "\"", 790, 2);
#nullable restore
#line 15 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_ShortcutMenu.cshtml"
WriteAttributeValue("", 752, Settings.Theme.IconPrefix, 752, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 780, "fa-expand", 781, 10, true);
            EndWriteAttribute();
            WriteLiteral("></i>\n\t</a>\n");
            WriteLiteral("</nav>\n");
#nullable restore
#line 24 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_ShortcutMenu.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SmartSettings Settings { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
