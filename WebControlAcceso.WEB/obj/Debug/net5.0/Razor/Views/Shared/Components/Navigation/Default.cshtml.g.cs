#pragma checksum "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "367a835bc57252684d7d9562fcb20ddb5d6ca986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Navigation_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Navigation/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"367a835bc57252684d7d9562fcb20ddb5d6ca986", @"/Views/Shared/Components/Navigation/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf8d93ca39b33fa2d7f296f66d537b4d3ad0aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Navigation_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartNavigation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
  
    var pageName = ViewData["PageName"]?.ToString().ToLower();

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul id=\"js-nav-menu\" class=\"nav-menu\">\r\n");
#nullable restore
#line 6 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
     foreach (var group in Model.Lists)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
         if (group.Items.Any())
        {
            var groups = group.Items.Select(x => x.Href.ToPage()).Where(x => !x.IsVoid()).ToList();

            group.Items.ForEach(item =>
            {
                var result = item.Items?.Select(x => x.Href.ToPage()).Where(x => !x.IsVoid()).ToList();
                if (result?.Any() == true)
                {
                    groups = groups.Concat(result).ToList();
                }
            });

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 667, "\"", 724, 1);
#nullable restore
#line 20 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 675, groups.Contains(pageName) ? "active open" : "", 675, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a href=\"#\"");
            BeginWriteAttribute("title", " title=\"", 755, "\"", 775, 1);
#nullable restore
#line 21 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 763, group.Title, 763, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 21 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                              Write(group.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 832, "\"", 851, 1);
#nullable restore
#line 22 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 840, group.Icon, 840, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                    <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 23 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                      Write(group.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 23 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                   Write(group.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 24 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                     if (group.Span.HasValue())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span");
            BeginWriteAttribute("class", " class=\"", 1060, "\"", 1085, 1);
#nullable restore
#line 26 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 1068, group.Span.Class, 1068, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                   Write(group.Span.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </a>\r\n                <ul>\r\n");
#nullable restore
#line 30 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                      
                        foreach (var item in group.Items)
                        {
                            var items = item.Items?.Select(x => x.Href.ToPage()).Where(x => !x.IsVoid()).ToList();

                            if (item.Disabled)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li class=\"disabled\">\r\n                                ");
#nullable restore
#line 39 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                       
                            }
                            else
                            {
                                if (items?.Any() == true)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li");
            BeginWriteAttribute("class", " class=\"", 1907, "\"", 1993, 1);
#nullable restore
#line 46 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 1915, items.Contains(pageName) || item.IsRelatedTo(pageName) ? "active open" : "", 1915, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 47 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                           
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <li");
            BeginWriteAttribute("class", " class=\"", 2233, "\"", 2290, 1);
#nullable restore
#line 52 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2241, pageName == item.Href.ToPage() ? "active" : "", 2241, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 53 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                           
                                }
                            }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2475, "\"", 2493, 1);
#nullable restore
#line 57 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2482, item.Route, 2482, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2494, "\"", 2513, 1);
#nullable restore
#line 57 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2502, item.Title, 2502, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 2514, "\"", 2535, 1);
#nullable restore
#line 57 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2523, item.Target, 2523, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 57 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                             Write(item.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                    <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 58 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                      Write(item.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 58 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                  Write(item.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                     if (item.Span.HasValue())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span");
            BeginWriteAttribute("class", " class=\"", 2831, "\"", 2855, 1);
#nullable restore
#line 61 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 2839, item.Span.Class, 2839, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                  Write(item.Span.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 62 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </a>\r\n                            ");
#nullable restore
#line 64 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                   
                            if (item.Items?.Any() == true)
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <ul>\r\n");
#nullable restore
#line 69 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                         foreach (var subItem in item.Items)
                                        {
                                            if (subItem.Disabled)
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                <li class=\"disabled\">\r\n                                ");
#nullable restore
#line 75 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                       
                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <li");
            BeginWriteAttribute("class", " class=\"", 3750, "\"", 3810, 1);
#nullable restore
#line 80 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 3758, pageName == subItem.Href.ToPage() ? "active" : "", 3758, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 81 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                       
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 3916, "\"", 3937, 1);
#nullable restore
#line 83 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 3923, subItem.Route, 3923, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 3938, "\"", 3960, 1);
#nullable restore
#line 83 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 3946, subItem.Title, 3946, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 3961, "\"", 3985, 1);
#nullable restore
#line 83 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 3970, subItem.Target, 3970, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 83 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                                  Write(subItem.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 84 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                  Write(subItem.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 84 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                 Write(subItem.Text.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </a>\r\n                        ");
            WriteLiteral("</li>\r\n");
#nullable restore
#line 87 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                    ");
#nullable restore
#line 89 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                           
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral("</li>\r\n");
#nullable restore
#line 92 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </li>\r\n");
#nullable restore
#line 96 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
        }
        else
        {
            if (group.Type == ItemType.Category)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-title\">");
#nullable restore
#line 101 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                 Write(group.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 102 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 4705, "\"", 4763, 1);
#nullable restore
#line 105 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4713, pageName == group.Href.ToPage() ? "active" : "", 4713, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4789, "\"", 4808, 1);
#nullable restore
#line 106 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4796, group.Route, 4796, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4809, "\"", 4829, 1);
#nullable restore
#line 106 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4817, group.Title, 4817, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 4830, "\"", 4852, 1);
#nullable restore
#line 106 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4839, group.Target, 4839, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-filter-tags=\"");
#nullable restore
#line 106 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                                                    Write(group.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 4913, "\"", 4932, 1);
#nullable restore
#line 107 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
WriteAttributeValue("", 4921, group.Icon, 4921, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        <span class=\"nav-link-text\" data-i18n=\"");
#nullable restore
#line 108 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                          Write(group.I18n);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 108 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
                                                                       Write(group.Title.AsRaw());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </a>\r\n                </li>\r\n");
#nullable restore
#line 111 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Maico\OneDrive\Documentos\GitHub\ApiControl\WebControlAcceso.WEB\Views\Shared\Components\Navigation\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartNavigation> Html { get; private set; }
    }
}
#pragma warning restore 1591
