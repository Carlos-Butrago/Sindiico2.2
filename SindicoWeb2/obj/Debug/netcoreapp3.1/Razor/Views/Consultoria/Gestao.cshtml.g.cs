#pragma checksum "C:\Users\cadu_\Desktop\Sindico2.2\SindicoWeb2\Views\Consultoria\Gestao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a0ac771984dc0ff79fc2f25a60d5bd821f766e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultoria_Gestao), @"mvc.1.0.view", @"/Views/Consultoria/Gestao.cshtml")]
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
#line 1 "C:\Users\cadu_\Desktop\Sindico2.2\SindicoWeb2\Views\_ViewImports.cshtml"
using SindicoWeb2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cadu_\Desktop\Sindico2.2\SindicoWeb2\Views\_ViewImports.cshtml"
using SindicoWeb2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a0ac771984dc0ff79fc2f25a60d5bd821f766e6", @"/Views/Consultoria/Gestao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f796f56c51c7e6a9b7951c7946c08a8e553b2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultoria_Gestao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagem/cond1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("800"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\cadu_\Desktop\Sindico2.2\SindicoWeb2\Views\Consultoria\Gestao.cshtml"
  
    ViewData["Title"] = "Gestão Financeira e Orçamentária";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>


    body {
        background-color: white;
    }

    .breadcrumb {
        background-color: white;
        text-decoration: none;
        font-size: 15px;
        letter-spacing: 2px;
        height: 30px;
    }

    .breadcrumb-item {
        padding: 0px 5px;
    }



    .title-gest {
        font-size: 40px;
        font-family: Verdana;
        text-align: center;
        color: #37474F;
        font-weight: 500;
        margin-bottom: 20px;
        margin-top: 30px;
    }

    .container {
        width: 100vw;
        height: 40vw;
        display: flex;
        flex-direction: row;
        justify-content: center;
        align-items: center;
        margin-bottom: 20px;
    }

    .text-gest {
        margin-top: -70px;
        font-size: 25px;
        padding: 25px;
        background-color: white;
        width: 59vw;
        height: 75vw;
        flex-direction: row;
        justify-content: center;
        align-items: center;
  ");
            WriteLiteral("      margin-left: 270px;\r\n    }\r\n\r\n    .text-gest2 {\r\n        list-style-type: \'\\057B\';\r\n        margin-top: 20px;\r\n        font-size: 19px;\r\n        word-spacing: 8px;\r\n        text-indent: 5px;\r\n    }\r\n</style>\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a0ac771984dc0ff79fc2f25a60d5bd821f766e65815", async() => {
                WriteLiteral(@"
    <header>
        <nav arial-label=""breadcrumb"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item"">
                    Consultoria
                </li>
                <li class=""breadcrumb"" style=""color:#245A64; padding: 0px 2px"">/</li>
                <li class=""breadcrumb-item"">
                    Gestão Financeira e Orçamentária
                </li>
            </ol>
        </nav>
    </header>

    <main>
        <div class=""title-gest"">
            GESTÃO FINANCEIRA E ORÇAMENTÁRIA
        </div>
    </main>

    <div class=""container"">
        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2a0ac771984dc0ff79fc2f25a60d5bd821f766e66703", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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

    <article>
        <div class=""text-gest"">
            Mudança do valor da cota condominial, emissão de taxa extra, manutenções atrasadas ou mal
            feitas, aumento da inadimplência... tudo isso pode ser um grande problema para o síndico.

            Isso porque as finanças são uma parte crucial de uma boa gestão do condomínio, e a
            previsão orçamentária é o grande alicerce das finanças do empreendimento durante aquele
            período.

            E como não poderia deixar de ser, confira
            o passo-a-passo para você não deixar passar nenhum detalhe e fazer uma previsão
            orçamentária completa.

            Há também uma planilha que ajudará a fazer a sua previsão mais fácil também.

            <a style=""margin-top: 20px;"" href=""https://www.sindiconet.com.br/informese/como-fazer-a-previsao-orcamentaria-do-condominio-administracao-financas"">
                Confira!
            </a>

            <ol class=""text-gest2"">
        ");
                WriteLiteral(@"        <li> CONHEÇA O HISTÓRICO DE CONTAS DO SEU CONDOMÍNIO</li>
                <li> PEÇA AJUDA PARA A ADMINISTRADORA</li>
                <li>  DIVIDA AS CONTAS DO CONDOMÍNIO EM PEQUENOS GRUPOS E FAÇA UMA MÉDIA MENSAL</li>
                <li> PROJETE OS ÍNDICES PARA O PRÓXIMO ANO</li>
                <li> LEVE EM CONTA A INADIMPLÊNCIA</li>
                <li>  SEPARE BEM O QUE É BENFEITORIA DO QUE É MANUTENÇÃO</li>
                <li>  UMA “GORDURA” É IMPORTANTE</li>
                <li> APRESENTANDO A PREVISÃO EM ASSEMBLEIA</li>
                <li>  E SE A PREVISÃO ORÇAMENTÁRIA NÃO SE MOSTRAR SUFICIENTE NO DECORRER DO EXERCÍCIO?</li>
                <li>  O QUE FAZER CASO A PREVISÃO NÃO SEJA APROVADA EM ASSEMBLEIA?</li>
                <li>  PLANILHA DE PREVISÃO ORÇAMENTÁRIA</li>
                <li>  ERROS COMUNS AO FAZER A PREVISÃO ORÇAMENTÁRIA</li>
            </ol>
        </div>
    </article>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
