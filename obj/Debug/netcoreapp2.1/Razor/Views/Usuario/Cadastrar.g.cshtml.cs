#pragma checksum "C:\Users\38958595833\Documents\Projetos C#\C#\Senai.Check.Point.Mvc.Web\Views\Usuario\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001cdc05b97d6005915f98cbda271bffa0dbcaef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Cadastrar), @"mvc.1.0.view", @"/Views/Usuario/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Cadastrar.cshtml", typeof(AspNetCore.Views_Usuario_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001cdc05b97d6005915f98cbda271bffa0dbcaef", @"/Views/Usuario/Cadastrar.cshtml")]
    public class Views_Usuario_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(27, 469, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ea2e101682d4bb1b3c3366e81480ca8", async() => {
                BeginContext(33, 456, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Document</title>
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.2.0/css/all.css"" integrity=""sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ""
        crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""/css/estilo4.css"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(496, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(500, 5747, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f3d8f760c36145ed97affe1ab0d2d71e", async() => {
                BeginContext(506, 5734, true);
                WriteLiteral(@"
    <div class=""menu-geral"">
        <i id=""menuBotao"" class=""fas fa-bars""></i>
        <nav id=""menuTopo"" class=""menu escondido"">
            <ul>
                <li>
                    <a href=""index.html"">Home</a>
                </li>
                <li>
                    <a href=""pg2.html"">Sobre nós</a>
                </li>
                <li>
                    <a href=""pg3.html"">Fale conosco</a>
                </li>
                <li>
                    <a href=""http://localhost:5000/Usuario/Cadastrar"">Cadastrar Usuário</a>
                </li>
                <li>
                    <a href=""http://localhost:5000/Usuario/Login"">Efetuar Login</a>
                </li>
            </ul>
        </nav>
    </div>
    <div class=""cor-dois"">
        <div class=""pessoa-off"">
            <img src=""/imagens/ps.png"" alt=""foto-generica"">
        </div>
        <div class=""Cadastro"">

        <form action=""/Usuario/Cadastrar"" method=""POST"">

            <input type=""");
                WriteLiteral(@"text"" name=""nome"" placeholder=""Digite seu Nome"">
            <input type=""email"" name=""email"" placeholder=""Digite seu E-mail"">
            <input type=""password"" name=""senha"" placeholder=""Digite sau Senha"">
            <input type=""password"" name=""confirme"" placeholder=""Comfirme sau Senha"">
            <button type=""submit"">Cadastrar</button>
            <button><a href=""http://localhost:5000/Usuario/Login""> Ja é Cadastrado!</a></button>

        </form>
        </div>


    </div>

    <div class=""chat"">
        <img id=""chatBotao"" src=""imagens/Ativo 3.png"">
    </div>
    <div id=""chat"" class=""escondido"">
        <header>
            <nav class=""flex-container"">
                <div class=""perfil flex-container"">
                    <div class=""perfil-img"">
                        <img src=""/imagens/Ativo 20.jpg"" alt=""foto perfil"">
                    </div>
                    <div class=""perfil-dados"">
                        <span class=""perfil-nome"">Eryk Guilherme S. Campos</span");
                WriteLiteral(@">
                        <span class=""perfil-status"">Online</span>
                    </div>
                </div>
                <div class=""acoes flex-container"">
                    <a href=""#"">
                        <i class=""fas fa-search""></i>
                    </a>
                    <a href=""#"">
                        <i class=""fas fa-paperclip""></i>
                    </a>
                </div>
            </nav>
        </header>
        <main class=""flex-container"">
            <div class=""chat-msg chat-msg-enviada"">
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis ex quas consequatur, sunt
                    dignissimos omnis sequi ducimus
                    officia accusantium quos consectetur eaque, repellendus impedit dolor, quo quasi necessitatibus
                    molestias
                    voluptatum.
                </p>
                <samp class=""chat-msg-horario"">16:17</samp>
         ");
                WriteLiteral(@"   </div>
            <div class=""chat-msg chat-msg-recebida"">
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis ex quas consequatur, sunt
                    dignissimos omnis sequi ducimus
                    officia accusantium quos consectetur eaque, repellendus impedit dolor, quo quasi necessitatibus
                    molestias
                    voluptatum.
                </p>
                <samp class=""chat-msg-horario"">16:20</samp>
            </div>
            <div class=""chat-msg chat-msg-enviada"">
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis ex quas consequatur, sunt
                    dignissimos omnis sequi ducimus
                    officia accusantium quos consectetur eaque, repellendus impedit dolor, quo quasi necessitatibus
                    molestias
                    voluptatum.
                </p>
                <samp class=""chat-msg-hor");
                WriteLiteral(@"ario"">16:25</samp>
            </div>
            <div class=""chat-msg chat-msg-recebida"">
                <p>
                    Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis ex quas consequatur, sunt
                    dignissimos omnis sequi ducimus
                    officia accusantium quos consectetur eaque, repellendus impedit dolor, quo quasi necessitatibus
                    molestias
                    voluptatum.
                </p>
                <samp class=""chat-msg-horario"">16:30</samp>
            </div>
        </main>
        <footer class=""flex-container"">
            <i class=""fas fa-smile""></i>
            <form>
                <textarea></textarea>
            </form>
            <i class=""fas fa-microphone""></i>
        </footer>
    </div>

    <div class=""rodape"">
        <img src=""/imagens/local-icone.png"">
        <img src=""/imagens/fb_icon_325x325.png"">
        <img src=""/imagens/Viber-2-512.png"">
        <img src=""/imagens/su");
                WriteLiteral(@"per_imggmail-com_0.png"">
        <img src=""/imagens/social-instagram-new-circle-512.png"">
        <img src=""/imagens/TWITTER.png"">
    </div>
    <script>
        var botao = document.getElementById(""menuBotao"");
        var menu = document.getElementById(""menuTopo"")
        botao.onclick = function () {
            menu.classList.toggle(""escondido"");
        };
        var botaochat = document.getElementById(""chatBotao"");
        var chat = document.getElementById(""chat"");
        botaochat.onclick = function () {
            chat.classList.toggle(""escondido"");

        };
    </script>

");
                EndContext();
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
            EndContext();
            BeginContext(6247, 13, true);
            WriteLiteral("\r\n\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591