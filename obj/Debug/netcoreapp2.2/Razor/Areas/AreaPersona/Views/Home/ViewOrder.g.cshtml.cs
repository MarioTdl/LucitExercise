#pragma checksum "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23b115b1523eed4d16610f78db3ff63902fa6d5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AreaPersona_Views_Home_ViewOrder), @"mvc.1.0.view", @"/Areas/AreaPersona/Views/Home/ViewOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AreaPersona/Views/Home/ViewOrder.cshtml", typeof(AspNetCore.Areas_AreaPersona_Views_Home_ViewOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23b115b1523eed4d16610f78db3ff63902fa6d5c", @"/Areas/AreaPersona/Views/Home/ViewOrder.cshtml")]
    public class Areas_AreaPersona_Views_Home_ViewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<esercizioUnikey.Areas.AreaPersona.Controllers.Resource.OrdineResourceView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AreaPersona", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(137, 74, true);
            WriteLiteral("\r\n<h1>Ordine Visualizzato</h1>\r\n\r\n\r\n  <div class=\"form-group\">\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 211, "\"", 237, 1);
#line 8 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 217, Model.DataCreazione, 217, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(238, 65, true);
            WriteLiteral(">Data Creazione</label>\r\n    <input class=\"form-control\" readonly");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 303, "\"", 331, 1);
#line 9 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 311, Model.DataCreazione, 311, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(332, 52, true);
            WriteLiteral(">\r\n  </div>\r\n  <br/>\r\n  <h1>Prodotti</h1>\r\n  <br/>\r\n");
            EndContext();
#line 14 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
   foreach (var p in Model.Prodotti)
  {
      

#line default
#line hidden
            BeginContext(435, 42, true);
            WriteLiteral("      <div class=\"form-group\">\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 477, "\"", 490, 1);
#line 18 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 483, p.Nome, 483, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(491, 56, true);
            WriteLiteral(">Nome:</label>\r\n    <input readonly class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", "value=\"", 547, "\"", 561, 1);
#line 19 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 554, p.Nome, 554, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(562, 53, true);
            WriteLiteral(">\r\n  </div>\r\n    <div class=\"form-group\">\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 615, "\"", 630, 1);
#line 22 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 621, p.Prezzo, 621, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(631, 58, true);
            WriteLiteral(">Prezzo:</label>\r\n    <input readonly class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", "value=\"", 689, "\"", 705, 1);
#line 23 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 696, p.Prezzo, 696, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(706, 51, true);
            WriteLiteral(">\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 757, "\"", 772, 1);
#line 26 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 763, p.Prezzo, 763, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(773, 53, true);
            WriteLiteral(">Id</label>\r\n    <input readonly class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("value", "value=\"", 826, "\"", 849, 1);
#line 27 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
WriteAttributeValue("", 833, Model.IdPersona, 833, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(850, 27, true);
            WriteLiteral(">\r\n  </div>\r\n  <br/><br/>\r\n");
            EndContext();
#line 30 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
  }

#line default
#line hidden
            BeginContext(882, 6, true);
            WriteLiteral("  \r\n  ");
            EndContext();
            BeginContext(888, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23b115b1523eed4d16610f78db3ff63902fa6d5c8453", async() => {
                BeginContext(1010, 56, true);
                WriteLiteral("\r\n<input type=\"submit\" value=\"Cancella Ordine\"></td>\r\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "c:\Users\mario\esercizioUnikey\Areas\AreaPersona\Views\Home\ViewOrder.cshtml"
                                                                                              WriteLiteral(Model.IdPersona);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1073, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<esercizioUnikey.Areas.AreaPersona.Controllers.Resource.OrdineResourceView> Html { get; private set; }
    }
}
#pragma warning restore 1591
