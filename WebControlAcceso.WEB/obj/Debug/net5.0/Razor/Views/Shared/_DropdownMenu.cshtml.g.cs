#pragma checksum "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbe0077686d66b8820628f36acd94cdc84f7af2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DropdownMenu), @"mvc.1.0.view", @"/Views/Shared/_DropdownMenu.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbe0077686d66b8820628f36acd94cdc84f7af2f", @"/Views/Shared/_DropdownMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf8d93ca39b33fa2d7f296f66d537b4d3ad0aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__DropdownMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml"
  
    string usser = Context.Session.GetString("Operator");
    var logo = Context.Session.GetString("Icon");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"dropdown-header bg-trans-gradient d-flex flex-row py-4 rounded-top\">\r\n    <div class=\"d-flex flex-row align-items-center mt-1 mb-1 color-white\">\r\n        <span class=\"mr-2\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 577, "\"", 588, 1);
#nullable restore
#line 16 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml"
WriteAttributeValue("", 583, logo, 583, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"rounded-circle profile-image\"");
            BeginWriteAttribute("alt", " alt=\"", 626, "\"", 638, 1);
#nullable restore
#line 16 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml"
WriteAttributeValue("", 632, usser, 632, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </span>\r\n        <div class=\"info-card-text\">\r\n            <div class=\"fs-lg text-truncate text-truncate-lg\">");
#nullable restore
#line 19 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\_DropdownMenu.cshtml"
                                                         Write(usser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<div class=\"dropdown-divider m-0\"></div>\r\n");
            WriteLiteral("<div class=\"dropdown-divider m-0\"></div>\r\n<a href=\"#\" class=\"dropdown-item\" data-action=\"app-fullscreen\">\r\n    <span data-i18n=\"drpdwn.fullscreen\">Fullscreen</span>\r\n    <i class=\"float-right text-muted fw-n\">F11</i>\r\n</a>\r\n");
            WriteLiteral("<div class=\"dropdown-divider m-0\"></div>\r\n<a class=\"dropdown-item fw-500 pt-3 pb-3\" href=\"/Login/Salir\" onclick=\"getLogo();\">\r\n    <span data-i18n=\"drpdwn.page-logout\">Logout</span>\r\n");
            WriteLiteral("</a>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
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
