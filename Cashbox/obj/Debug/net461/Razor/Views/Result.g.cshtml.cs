#pragma checksum "D:\CSU\DS\Cashbox\Cashbox\Views\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bca5e114d69b30f610c334838147730214c331d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Result), @"mvc.1.0.view", @"/Views/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Result.cshtml", typeof(AspNetCore.Views_Result))]
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
#line 1 "D:\CSU\DS\Cashbox\Cashbox\Views\_ViewImports.cshtml"
using Cashbox;

#line default
#line hidden
#line 2 "D:\CSU\DS\Cashbox\Cashbox\Views\_ViewImports.cshtml"
using Cashbox.Models;

#line default
#line hidden
#line 7 "D:\CSU\DS\Cashbox\Cashbox\Views\Result.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bca5e114d69b30f610c334838147730214c331d", @"/Views/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06576f7bbc2457cc6094a5fefa9447a32b462419", @"/Views/_ViewImports.cshtml")]
    public class Views_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultModel>
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\CSU\DS\Cashbox\Cashbox\Views\Result.cshtml"
  
    ViewData["Title"] = "Result";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(148, 322, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "741ee6cc70274094881a062eccf33ff6", async() => {
                BeginContext(154, 79, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n        setTimeout(\'location.replace(\"");
                EndContext();
                BeginContext(234, 15, false);
#line 12 "D:\CSU\DS\Cashbox\Cashbox\Views\Result.cshtml"
                                 Write(Model.ReturnUrl);

#line default
#line hidden
                EndContext();
                BeginContext(249, 156, true);
                WriteLiteral("\")\', 5000);\r\n/*Изменить текущий адрес страницы через 3 секунды (3000 миллисекунд)*/\r\n\r\n    </script>\r\n\r\n    <noscript>\r\n\r\n        <meta http-equiv=\"refresh\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 405, "\"", 440, 4);
                WriteAttributeValue("", 415, "5;", 415, 2, true);
                WriteAttributeValue(" ", 417, "url=\'", 418, 6, true);
#line 19 "D:\CSU\DS\Cashbox\Cashbox\Views\Result.cshtml"
WriteAttributeValue("", 423, Model.ReturnUrl, 423, 16, false);

#line default
#line hidden
                WriteAttributeValue("", 439, "\'", 439, 1, true);
                EndWriteAttribute();
                BeginContext(441, 22, true);
                WriteLiteral(">\r\n\r\n    </noscript>\r\n");
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
            BeginContext(470, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(472, 222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e646e8d6240948d09eba9f7db3ec53a8", async() => {
                BeginContext(478, 147, true);
                WriteLiteral("\r\n    <div>\r\n        <h2>Оплата совершена.</h2>\r\n        <a>Возврат на страницу через </a>\r\n        <a id=\"timer\">5</a>\r\n        <br />\r\n        <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 625, "\"", 648, 1);
#line 29 "D:\CSU\DS\Cashbox\Cashbox\Views\Result.cshtml"
WriteAttributeValue("", 632, Model.ReturnUrl, 632, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(649, 38, true);
                WriteLiteral(">Вернуться в магазин</a>\r\n    </div>\r\n");
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
            BeginContext(694, 82, true);
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    setTimeout(timer, 1000);\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultModel> Html { get; private set; }
    }
}
#pragma warning restore 1591