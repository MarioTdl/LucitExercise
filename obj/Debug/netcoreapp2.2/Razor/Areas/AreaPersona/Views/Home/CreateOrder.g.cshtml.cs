#pragma checksum "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62127932a01f732065b42b970a7b185626168342"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AreaPersona_Views_Home_CreateOrder), @"mvc.1.0.view", @"/Areas/AreaPersona/Views/Home/CreateOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AreaPersona/Views/Home/CreateOrder.cshtml", typeof(AspNetCore.Areas_AreaPersona_Views_Home_CreateOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62127932a01f732065b42b970a7b185626168342", @"/Areas/AreaPersona/Views/Home/CreateOrder.cshtml")]
    public class Areas_AreaPersona_Views_Home_CreateOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<esercizioUnikey.Areas.AreaPersona.Controllers.Resource.CreateOrderResource>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(143, 464, true);
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
<script src=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js""></script>
<link rel=""stylesheet"" href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap-theme.min.css"">
<link rel=""stylesheet"" href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"">

<h1>SELEZIONA I PRODOTTI DA AGGIUNGERE ALL'ORDINE</h1>  

   <table>
");
            EndContext();
#line 11 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml"
         using (@Html.BeginForm("CreateOrder", "Home", FormMethod.Post))
        {
            //for (int i = 0; i < Model.Count; i++)

            // quell giusta e quella sopra, perche mi sono scordato
            //di fare la tabella di mezzo tra prodotti e ordini
            for (int i = 0; i < 3; i++)
            {

#line default
#line hidden
            BeginContext(937, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(984, 74, false);
#line 20 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml"
                   Write(Html.TextBoxFor(m => Model[i].IdCliente, new { style = "display: none;" }));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
            BeginContext(1090, 82, true);
            WriteLiteral("                <tr>\r\n                    <td>Nome:</td>\r\n                    <td>");
            EndContext();
            BeginContext(1173, 39, false);
#line 25 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml"
                   Write(Html.TextBoxFor(model => Model[i].Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 114, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Prezzo:</td>\r\n                    <td>");
            EndContext();
            BeginContext(1327, 41, false);
#line 29 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml"
                   Write(Html.TextBoxFor(model => Model[i].Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 163, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Selezione per Aggiungere <br/>\r\n                <br/>   </td>\r\n                    <td>");
            EndContext();
            BeginContext(1532, 44, false);
#line 34 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml"
                   Write(Html.CheckBoxFor(model => Model[i].Selected));

#line default
#line hidden
            EndContext();
            BeginContext(1576, 64, true);
            WriteLiteral(" <br/>\r\n                <br/>   </td>\r\n                </tr>  \r\n");
            EndContext();
#line 37 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml"
                   
            }

#line default
#line hidden
            BeginContext(1676, 64, true);
            WriteLiteral("            <td><input type=\"submit\" value=\"Crea Ordine\"></td>\r\n");
            EndContext();
#line 40 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\CreateOrder.cshtml"
        }

#line default
#line hidden
            BeginContext(1751, 12, true);
            WriteLiteral("    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<esercizioUnikey.Areas.AreaPersona.Controllers.Resource.CreateOrderResource>> Html { get; private set; }
    }
}
#pragma warning restore 1591
