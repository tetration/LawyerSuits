#pragma checksum "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17b32e4edec7b54642e4ede2062927dfaaa563c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lawsuits_Index), @"mvc.1.0.view", @"/Views/Lawsuits/Index.cshtml")]
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
#line 1 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\_ViewImports.cshtml"
using LawyerSuits.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\_ViewImports.cshtml"
using LawyerSuits.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\_ViewImports.cshtml"
using LawyerSuits.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\_ViewImports.cshtml"
using LawyerSuits.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b32e4edec7b54642e4ede2062927dfaaa563c5", @"/Views/Lawsuits/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b2c4a0c24c252dc60294b8afda2fa0f2b0f00a", @"/Views/_ViewImports.cshtml")]
    public class Views_Lawsuits_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SuitItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
  
    ViewData["Title"] = "Lawsuits/Processos";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        ");
#nullable restore
#line 7 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
   Write(Html.ActionLink("Criar Novo Processo", "Create", "Lawsuits", null, new { @class="btn btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Create New Lawsuit-->
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <table class=""table table-striped table-bordered"">
            <thead>
                <tr>
                    <td>Nome do Processo</td><!-- Lawsuit Name-->
                    <td>Processo Finalizado?</td><!-- Is Lawsuit finished? -->
                    <td>Processo Criado em</td><!-- Suit Created-->
                    <td>Processo Modificado em</td><!-- Suit Created-->
                    <td></td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                 if(Model.Count() > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                     foreach (var suit in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                   Write(suit.SuitName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>\r\n");
#nullable restore
#line 30 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                         if (@suit.IsCompleted==true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>Sim</div>\r\n");
#nullable restore
#line 33 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                        }
                        else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>Não</div>\r\n");
#nullable restore
#line 36 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 41 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                   Write(suit.DateCreated.ToLocalTime());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td>");
#nullable restore
#line 42 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                   Write(suit.LastModified.ToLocalTime());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 43 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                                       Write(Html.ActionLink("Editar", "Edit", "Lawsuits", new { Id = suit.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 43 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                                                                                                              Write(Html.ActionLink("Deletar", "Delete", "Lawsuits", new { Id = suit.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                </tr>\r\n");
#nullable restore
#line 45 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" class=\"text-center\">\r\n                           Nenhum Processo Encontrado no Banco de Dados <!-- No Records Founds -->\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 54 "D:\Git\LawyerSuits\LawyerSuits\LawyerSuit.Web\Views\Lawsuits\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SuitItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
