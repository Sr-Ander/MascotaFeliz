#pragma checksum "C:\EmpresaMascota\MascotaSaludable.App\MascotaSaludable.App.Frontend\Pages\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca4def1d2eb03b9030307cfe291d8eb17a765a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaSaludable.App.Frontend.Pages.Pages_Registro), @"mvc.1.0.razor-page", @"/Pages/Registro.cshtml")]
namespace MascotaSaludable.App.Frontend.Pages
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
#line 1 "C:\EmpresaMascota\MascotaSaludable.App\MascotaSaludable.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaSaludable.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca4def1d2eb03b9030307cfe291d8eb17a765a5", @"/Pages/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c0eaabe93e8002bcdea895a0785f007621921b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Registro : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleRegistro.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\EmpresaMascota\MascotaSaludable.App\MascotaSaludable.App.Frontend\Pages\Registro.cshtml"
  
    ViewData["Title"] = "Registro";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ca4def1d2eb03b9030307cfe291d8eb17a765a54497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"PrincipalUno\">\r\n    <div class=\"PrincipalRegistro\">\r\n        <div class=\"Formulario\">\r\n            <div class=\"Logo\">\r\n                <h1>Due??o mascota</h1>\r\n             <img src=\"Imagenes/Persona.png\"");
            BeginWriteAttribute("alt", " alt=\"", 346, "\"", 352, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"Uno\">\r\n            </div>\r\n            \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca4def1d2eb03b9030307cfe291d8eb17a765a56051", async() => {
                WriteLiteral("\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 454, "\"", 460, 0);
                EndWriteAttribute();
                WriteLiteral(@">nombres</label>
                <input type=""text"" id=""nombres"">
                <label for=""Apellidos"">Apellidos</label>
                <input type=""text"" id=""Apellidos"">
                <label for=""Identificacion"">Identificacion</label>
                <input type=""text"" id=""Identificacion"">
                <label");
                BeginWriteAttribute("for", " for=\"", 786, "\"", 792, 0);
                EndWriteAttribute();
                WriteLiteral(@">Direccion</label>
                <input type=""text"" id=""Direccion"">
                <label for=""Telefono"" id=""Telefono"">Telefono</label>
                <input type=""number"" id=""Telefono""> 
                <label for=""Correo Electtronico"">Correo Electronico</label>
                <input type=""email""");
                BeginWriteAttribute("name", " name=\"", 1101, "\"", 1108, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1109, "\"", 1114, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"button\" value=\"Enviar\" class=\"Boton\"> <br>\r\n                <input type=\"reset\" value=\"Restablecer informacion\" class=\"Boton\"> \r\n        \r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    \r\n    \r\n    </div>\r\n    <div class=\"PrincipalRegistro\">\r\n        <div class=\"Formulario\">\r\n            <div class=\"Logo\">\r\n                <h1>Mascota</h1>\r\n             <img src=\"Imagenes/1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 1522, "\"", 1528, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"Dos\">\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca4def1d2eb03b9030307cfe291d8eb17a765a59248", async() => {
                WriteLiteral("\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 1616, "\"", 1622, 0);
                EndWriteAttribute();
                WriteLiteral(">Documento del due??o de la mascota</label>\r\n                <input");
                BeginWriteAttribute("for", " for=\"", 1689, "\"", 1695, 0);
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" >\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 1734, "\"", 1740, 0);
                EndWriteAttribute();
                WriteLiteral(">Nombre de Mascota</label>\r\n                <input type=\"text\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 1828, "\"", 1834, 0);
                EndWriteAttribute();
                WriteLiteral(">Fecha de Nacimineto</label>\r\n                <input type=\"date\">\r\n                \r\n                <div class=\"Opcion\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 1984, "\"", 1990, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"TipoMascota\">Tipo de Mascota</label>\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 2063, "\"", 2069, 0);
                EndWriteAttribute();
                WriteLiteral(">Gato</label> <input type=\"radio\" id=\"Gato\" name=\"opcion\" value=\"Gato\">\r\n                    <label");
                BeginWriteAttribute("for", " for=\"", 2169, "\"", 2175, 0);
                EndWriteAttribute();
                WriteLiteral(@">Perro</label> <input type=""radio"" id=""Gato"" name=""opcion"" value=""Perro"">

                </div>
                
                <input type=""button"" value=""Enviar"" class=""Boton""> <br>
                <input type=""reset"" value=""Restablecer informacion"" class=""Boton"">
    
    
    
    
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        

        </div>
        
    </div>
    </div>
    <div class=""Info"">
        <h1>Informacion sobre el funcionamiento de los registros</h1>
        <p>Para registrar cualquier tipo mascota, debe registrarse a nombre de un adulto, el cual tambien debera estar registrado previamente en la plataforma.</p>
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistroModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegistroModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RegistroModel>)PageContext?.ViewData;
        public RegistroModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
