#pragma checksum "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0385250e4055024fa3dccfd1c98f8bcc16575659"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
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
#line 3 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0385250e4055024fa3dccfd1c98f8bcc16575659", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14cc5c6a58e3d403c8bc86e45fe3db3aac6026c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 537, true);
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-dark fixed-top bg-dark"">
    <a class=""navbar-brand"" href=""/""> LojaVirtual</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
            aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">

        <ul class=""navbar-nav mr-auto"">
            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 561, "\"", 727, 3);
            WriteAttributeValue("", 569, "nav-item", 569, 8, true);
#line 11 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 577, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Index") ? "active" : "", 578, 148, false);

#line default
#line hidden
            WriteAttributeValue(" ", 726, "", 727, 1, true);
            EndWriteAttribute();
            BeginContext(728, 144, true);
            WriteLiteral(">\r\n                <a class=\"nav-link\" href=\"/\"><i class=\"fas fa-home\"></i> Home <span class=\"sr-only\">(current)</span></a>\r\n            </li>\r\n");
            EndContext();
#line 14 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
              
                var TodasCategorias = Model.ToList();
            

#line default
#line hidden
            BeginContext(958, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 17 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
             if (TodasCategorias != null && TodasCategorias.Count > 0)
            {

#line default
#line hidden
            BeginContext(1045, 62, true);
            WriteLiteral("                <div class=\"dropdown\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1107, "\"", 1293, 3);
            WriteAttributeValue("", 1115, "nav-link", 1115, 8, true);
            WriteAttributeValue(" ", 1123, "dropdown-toggle", 1124, 16, true);
#line 20 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 1139, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Categoria") ? "active" : "" , 1140, 153, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1294, 333, true);
            WriteLiteral(@" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"">
                       aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-list-ul""></i> Categorias
                    </a>
                    <ul class=""dropdown-menu multi-level"" role=""menu"" aria-labelledby=""dropdownMenu"">
");
            EndContext();
#line 25 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                          
                            var CategoriasPrincipais = TodasCategorias.Where(a => a.CategoriaPaiId == null).ToList();
                            ViewData["TodasCategorias"] = TodasCategorias;
                        

#line default
#line hidden
            BeginContext(1877, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 29 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                         foreach (var categoria in CategoriasPrincipais)
                        {
                            

#line default
#line hidden
            BeginContext(2007, 141, false);
#line 31 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                       Write(await Html.PartialAsync("~/Views/Shared/Components/Menu/_Submenu.cshtml", new ViewDataDictionary(ViewData) { { "CategoriaPai", categoria } }));

#line default
#line hidden
            EndContext();
#line 31 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
                                                                                                                                                                          
                        }

#line default
#line hidden
            BeginContext(2177, 51, true);
            WriteLiteral("                    </ul>\r\n                </div>\r\n");
            EndContext();
#line 35 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(2243, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2258, "\"", 2426, 3);
            WriteAttributeValue("", 2266, "nav-item", 2266, 8, true);
#line 36 "C:\X\.NET\ASPNETCoreMVCLojaVirtual\LojaVirtual\LojaVirtual\Views\Shared\Components\Menu\Default.cshtml"
WriteAttributeValue(" ", 2274, (ViewContext.RouteData.Values["controller"].ToString() == "Home" && ViewContext.RouteData.Values["action"].ToString() == "Contato") ? "active" : "", 2275, 150, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2425, "", 2426, 1, true);
            EndWriteAttribute();
            BeginContext(2427, 150, true);
            WriteLiteral(">\r\n                <a class=\"nav-link\" href=\"/Home/Contato\"><i class=\"far fa-address-book\"></i>Contato</a>\r\n            </li>\r\n        </ul>\r\n        ");
            EndContext();
            BeginContext(2577, 466, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0385250e4055024fa3dccfd1c98f8bcc165756599741", async() => {
                BeginContext(2616, 420, true);
                WriteLiteral(@"
            <input class=""form-control mr-sm-2"" type=""search"" placeholder=""palavra"" aria-label=""Search"">
            <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Pesquisa</button>
            <a class=""nav-link"" href=""/Home/Login""><i class=""fas fa-user-alt""></i> Login</a>
            <a class=""nav-link"" href=""/Home/CarrinhoCompras""><i class=""fas fa-shopping-cart""></i> Carrinho</a>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3043, 20, true);
            WriteLiteral("\r\n    </div>\r\n</nav>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
