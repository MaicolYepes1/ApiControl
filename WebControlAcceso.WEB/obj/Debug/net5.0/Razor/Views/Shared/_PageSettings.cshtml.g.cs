#pragma checksum "D:\Control de Acceso Visitantes Frontend\WebControlAcceso.WEB\Views\Shared\_PageSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a22e588daf1783dd4d3c6ac90e885a563bffb86d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PageSettings), @"mvc.1.0.view", @"/Views/Shared/_PageSettings.cshtml")]
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
#line 1 "D:\Control de Acceso Visitantes Frontend\WebControlAcceso.WEB\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Control de Acceso Visitantes Frontend\WebControlAcceso.WEB\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Control de Acceso Visitantes Frontend\WebControlAcceso.WEB\Views\_ViewImports.cshtml"
using SmartAdmin.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a22e588daf1783dd4d3c6ac90e885a563bffb86d", @"/Views/Shared/_PageSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbf8d93ca39b33fa2d7f296f66d537b4d3ad0aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PageSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TabSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Control de Acceso Visitantes Frontend\WebControlAcceso.WEB\Views\Shared\_PageSettings.cshtml"
 if (Settings.Features.LayoutSettings)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""modal fade js-modal-settings modal-backdrop-transparent"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
	<div class=""modal-dialog modal-dialog-right modal-md"">
		<div class=""modal-content"">
			<div class=""dropdown-header bg-trans-gradient d-flex justify-content-center align-items-center w-100"">
				<h4 class=""m-0 text-center color-white"">
					Layout Settings
					<small class=""mb-0 opacity-80"">User Interface Settings</small>
				</h4>
				<button type=""button"" class=""close text-white position-absolute pos-top pos-right p-2 m-1 mr-2"" data-dismiss=""modal"" aria-label=""Close"">
					<span aria-hidden=""true""><i");
            BeginWriteAttribute("class", " class=\"", 667, "\"", 712, 2);
#nullable restore
#line 12 "D:\Control de Acceso Visitantes Frontend\WebControlAcceso.WEB\Views\Shared\_PageSettings.cshtml"
WriteAttributeValue("", 675, Settings.Theme.IconPrefix, 675, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 703, "fa-times", 704, 9, true);
            EndWriteAttribute();
            WriteLiteral("></i></span>\n\t\t\t\t</button>\n\t\t\t</div>\n\t\t\t<div class=\"modal-body p-0\">\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a22e588daf1783dd4d3c6ac90e885a563bffb86d5076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t<span id=\"saving\"></span>\n\t\t\t</div>\n\t\t</div>\n\t</div>\n</div>\n");
#nullable restore
#line 22 "D:\Control de Acceso Visitantes Frontend\WebControlAcceso.WEB\Views\Shared\_PageSettings.cshtml"
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