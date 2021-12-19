#pragma checksum "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a99c394c9df21b27a975739accaa9650746e1736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a99c394c9df21b27a975739accaa9650746e1736", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7222ccf4b11389339ddcb95f3e4018a84485339b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int index = 0;
    int orderItemIndex = 0;
    AppUser member = User.Identity.IsAuthenticated ? userManager.Users.FirstOrDefault(x => x.UserName == User.Identity.Name && !x.IsAdmin) : null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""container order-container"">
        <div class=""row d-flex align-items-center"">
            <div class=""col-md-3 profile-left"">
                <aside class=""left-aside"">
                    <div class=""sidebar"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""sidebar-items"">
                                    <div class=""sidebar-item"">
                                        <ul>
                                            <li><a href=""./profile.html"">My Profile</a></li>
                                            <li><a href=""./order.html"">My Orders</a></li>
                                            <li><a href=""./wish-list.html"">My Wish List</a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
   ");
            WriteLiteral(@"             </aside>
            </div>
            <!--Order-->
            <div class=""col-lg-9 col-md-12 col-order"">
                <div class=""container"">
                    <div class=""col-md-12"">
                        <div class=""panel panel-default"">
                            <div class=""order-info"">
                                <h1>Thanks for your Order,<span>");
#nullable restore
#line 38 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                           Write(member.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> !</h1>
                                <div class=""order-info-mejuri"">
                                    <i class=""far fa-gem""></i>
                                    <p>Jewellery For Everyone</p>
                                </div>
                            </div>
                            <div class=""panel-body"">
                                <table>
                                    <tbody>
                                        <tr class=""table-info"">
                                            <td>#</td>
                                            <td></td>
                                            <td>Total count</td>
                                            <td>Total Amount</td>
                                            <td>Date</td>
                                            <td>Status</td>
                                        </tr>

");
#nullable restore
#line 56 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                         foreach (var order in Model)
                                        {
                                            index++;
                                            orderItemIndex = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <tr class=""table-img"">
                                                <td>1</td>
                                                <td>
                                                    <i class=""fas fa-caret-down order-drop""></i>
                                                </td>
                                                <td>");
#nullable restore
#line 65 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                               Write(order.OrderItems.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 66 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                               Write(order.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n                                                <td>");
#nullable restore
#line 67 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                               Write(order.CreatedAt.AddHours(4).ToString("HH:mm dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n");
#nullable restore
#line 69 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                     if (order.Status == Mejuri_Back_end.Models.Enums.OrderStatus.Accepted)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i style=\"color: green;\" class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 72 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                    }
                                                    else if (order.Status == Mejuri_Back_end.Models.Enums.OrderStatus.Rejected)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i style=\"color:brown\" class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 76 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"

                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <i style=\"color: wheat;\" class=\"fas fa-pause-circle\"></i>\r\n");
#nullable restore
#line 81 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </td>
                                            </tr>
                                            <tr class=""order-open"">
                                                <td colspan=""7"">
                                                    <div class=""fold-content"">
                                                        <table style=""width: 100%;"">
                                                            <thead>
                                                                <tr class=""table-info"">
                                                                    <td>#</td>
                                                                    <td>Product name</td>
                                                                    <td>Color name</td>
                                                                    <td>Count</td>
                                                                    <td>Price</td>
                               ");
            WriteLiteral("                                 </tr>\r\n                                                            </thead>\r\n                                                            <tbody>\r\n");
#nullable restore
#line 98 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                                 foreach (var orderItem in order.OrderItems)
                                                                {
                                                                    orderItemIndex++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <tr>\r\n                                                                    <td>");
#nullable restore
#line 102 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                                   Write(orderItemIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 103 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                                   Write(orderItem.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 104 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                                   Write(orderItem.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 105 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                                   Write(orderItem.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                                    <td>");
#nullable restore
#line 106 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                                    Write(orderItem.SalePrice-orderItem.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\r\n                                                                </tr>\r\n");
#nullable restore
#line 108 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                            </tbody>
                                                        </table>
                                                    </div>
                                                </td>
                                            </tr>
");
#nullable restore
#line 114 "C:\Users\LENOVO\Desktop\Final-Back-end-project\Mejuri-Back-end\Mejuri-Back-end\Views\Order\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591