#pragma checksum "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f0f00b722e62c173ab24758d7d3e986a49e8dfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Slider_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Slider/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\_ViewImports.cshtml"
using Mejuri_Back_end.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0f00b722e62c173ab24758d7d3e986a49e8dfb", @"/Areas/Manage/Views/Slider/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c347225f519b5b5613c442dd8c196970013dbc54", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Slider_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:6.5rem;border-radius:0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int order = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"" style=""min-height: 1604.71px;"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""container-fluid"">
            <div class=""row mb-2"">
                <div class=""col-sm-6"">
                    <h1>Projects</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                        <li class=""breadcrumb-item active"">Projects</li>
                    </ol>
                </div>
            </div>
        </div><!-- /.container-fluid -->
    </section>

    <!-- Main content -->
    <section class=""content"">

        <!-- Default box -->
        <div class=""card"">
            <div class=""card-head"">
                <h4>Products List</h4>
                <a href=""product-edit.html"">Add Slider</a>
            </div>
            
            <table class=""ta");
            WriteLiteral(@"ble table-striped projects"">
                <tbody>
                    <tr>
                        <th>#</th>
                        <th>Image</th>
                        <th>Title</th>
                        <th>SubTitle</th>
                        <th>Setting</th>
                    </tr>
");
#nullable restore
#line 44 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml"
                     foreach (var slider in Model)
                    {
                        order++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml"
                           Write(order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <ul class=\"list-inline\">\r\n                                    <li class=\"list-inline-item\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5f0f00b722e62c173ab24758d7d3e986a49e8dfb6676", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1879, "~/assets/images/", 1879, 16, true);
#nullable restore
#line 52 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml"
AddHtmlAttributeValue("", 1895, slider.Image, 1895, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </li>\r\n                                </ul>\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml"
                           Write(slider.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml"
                           Write(slider.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <button style=\"background:orange;\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 2258, "\"", 2266, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"pd-setting-ed\" data-original-title=\"Edit\"><i class=\"fas fa-edit\"></i></button>\r\n                                <button style=\"background:brown;\" data-toggle=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 2442, "\"", 2450, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"pd-setting-ed\" data-original-title=\"Trash\"><i class=\"fas fa-trash-alt\"></i></button>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Areas\Manage\Views\Slider\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <div class=""card-tools"">
                <ul class=""pagination pagination-sm"">
                    <li class=""page-item""><a href=""#"" class=""page-link"">«</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">1</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">2</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">3</a></li>
                    <li class=""page-item""><a href=""#"" class=""page-link"">»</a></li>
                </ul>
            </div>
        </div>
        
        <!-- /.card -->

    </section>
    <!-- /.content -->
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
