#pragma checksum "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e02453db2dc9adaa4af149a6daafd2c7357b49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\_ViewImports.cshtml"
using Mejuri_Back_end;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\_ViewImports.cshtml"
using Mejuri_Back_end.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\_ViewImports.cshtml"
using Mejuri_Back_end.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\_ViewImports.cshtml"
using Mejuri_Back_end.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e02453db2dc9adaa4af149a6daafd2c7357b49", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7222ccf4b11389339ddcb95f3e4018a84485339b", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Setting setting = service.GetSetting();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <section id=\"contact\">\r\n        <div class=\"contact-info\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b8e02453db2dc9adaa4af149a6daafd2c7357b494555", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 235, "~/uploads/setting/", 235, 18, true);
#nullable restore
#line 11 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
AddHtmlAttributeValue("", 253, setting.ContactImg, 253, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <h1>");
#nullable restore
#line 12 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
           Write(setting.ContactTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"contact-body\">\r\n            <div class=\"contact-body-info\">\r\n                <div class=\"container\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 18 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
                   Write(setting.ContactSubtitle1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <h5>\r\n                        ");
#nullable restore
#line 21 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
                   Write(setting.ContactSubtitle2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </h5>\r\n                </div>\r\n            </div>\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 28 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-md-4\">\r\n                            <div class=\"contact-content\">\r\n                                <i");
            BeginWriteAttribute("class", " class=\"", 1004, "\"", 1022, 1);
#nullable restore
#line 32 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1012, item.Icon, 1012, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                                <h5>");
#nullable restore
#line 33 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p data-isolate=\"true\">");
#nullable restore
#line 34 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
                                                  Write(item.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1194, "\"", 1218, 1);
#nullable restore
#line 35 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1201, item.RedirectUrl, 1201, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <span>");
#nullable restore
#line 36 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
                                     Write(item.RedirectUrlText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 40 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Contact\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</main>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LayoutService service { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
