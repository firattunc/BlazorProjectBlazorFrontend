#pragma checksum "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ab94bc1e885b64a085e08d234d23ad00caee2b5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProjectBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Northwİnd.Blazor.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
using Northwİnd.Blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/basket")]
    public partial class Basket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-lg-12");
            __builder.AddMarkupContent(8, "\n            \n            ");
            __builder.OpenElement(9, "nav");
            __builder.AddAttribute(10, "aria-label", "breadcrumb");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "ol");
            __builder.AddAttribute(13, "class", "breadcrumb");
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "breadcrumb-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(17);
            __builder.AddAttribute(18, "href", "/");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(20, "Home");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.AddMarkupContent(22, "<li aria-current=\"page\" class=\"breadcrumb-item active\">Shopping cart</li>\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "id", "basket");
            __builder.AddAttribute(28, "class", "col-lg-9");
            __builder.AddMarkupContent(29, "\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "box");
            __builder.AddMarkupContent(32, "\n                ");
            __builder.OpenElement(33, "form");
            __builder.AddAttribute(34, "method", "post");
            __builder.AddAttribute(35, "action", "checkout1.html");
            __builder.AddMarkupContent(36, "\n                    ");
            __builder.AddMarkupContent(37, "<h1>Shopping cart</h1>\n                    ");
            __builder.AddMarkupContent(38, "<p class=\"text-muted\">You currently have 3 item(s) in your cart.</p>\n                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "table-responsive");
            __builder.AddMarkupContent(41, "\n");
#nullable restore
#line 24 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                         if (basketModels != null)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "                            ");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table");
            __builder.AddMarkupContent(45, "\n                                ");
            __builder.AddMarkupContent(46, @"<thead>
                                    <tr>
                                        <th colspan=""2"">Product</th>
                                        <th>Quantity</th>
                                        <th>Unit price</th>
                                        <th>Discount</th>
                                        <th colspan=""2"">Total</th>
                                    </tr>
                                </thead>


                                ");
            __builder.OpenElement(47, "tbody");
            __builder.AddMarkupContent(48, "\n");
#nullable restore
#line 39 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                     foreach (var basketModel in basketModels)
                                    {

                                        decimal discountPrice = basketModel.Product.UnitPrice - (basketModel.Product.UnitPrice * ((decimal)basketModel.Product.Discount / 100));
                                        if (SubTotal == 0)
                                        {
                                            SubTotal += discountPrice * (decimal)basketModel.Quantity;
                                        }


#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                                        ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "\n\n\n                                            ");
            __builder.OpenElement(52, "td");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "href", "#");
            __builder.OpenElement(55, "img");
            __builder.AddAttribute(56, "src", 
#nullable restore
#line 51 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                                       basketModel.Product.ImgUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(57, "alt", 
#nullable restore
#line 51 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                                                                         basketModel.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                                            ");
            __builder.OpenElement(59, "td");
            __builder.OpenElement(60, "a");
            __builder.AddAttribute(61, "href", "#");
            __builder.AddContent(62, 
#nullable restore
#line 52 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                             basketModel.Product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n                                            ");
            __builder.OpenElement(64, "td");
            __builder.AddMarkupContent(65, "\n                                                ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                                  (value=>UpdateProduct(new BasketModel { Product=basketModel.Product,Quantity=Convert.ToInt32(value.Value)}))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "value", 
#nullable restore
#line 54 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                                                                                                                                                        basketModel.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(69, "type", "number");
            __builder.AddAttribute(70, "min", "1");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n                                            ");
            __builder.OpenElement(74, "td");
            __builder.AddContent(75, 
#nullable restore
#line 56 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                 basketModel.Product.UnitPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n                                            ");
            __builder.OpenElement(77, "td");
            __builder.AddContent(78, 
#nullable restore
#line 57 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                 basketModel.Product.Discount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n                                            ");
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 58 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                 discountPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n                                            ");
            __builder.AddMarkupContent(83, "<td><a href=\"#\"><i class=\"fa fa-trash-o\"></i></a></td>\n\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n");
#nullable restore
#line 62 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"

                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n\n                                ");
            __builder.OpenElement(87, "tfoot");
            __builder.AddMarkupContent(88, "\n                                    ");
            __builder.OpenElement(89, "tr");
            __builder.AddMarkupContent(90, "\n                                        ");
            __builder.AddMarkupContent(91, "<th colspan=\"5\">Total</th>\n                                        ");
            __builder.OpenElement(92, "th");
            __builder.AddAttribute(93, "colspan", "2");
            __builder.AddContent(94, "$");
            __builder.AddContent(95, 
#nullable restore
#line 69 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                                          SubTotal

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(96, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\n");
#nullable restore
#line 73 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                            Total = SubTotal + 10;

                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(101, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\n                    \n                    ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "box-footer d-flex justify-content-between flex-column flex-lg-row");
            __builder.AddMarkupContent(105, "\n                        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "left");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(108);
            __builder.AddAttribute(109, "href", "category");
            __builder.AddAttribute(110, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(112, "<i class=\"fa fa-chevron-left\"></i> Continue shopping");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\n                        ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "right");
            __builder.AddMarkupContent(116, "                            \n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(117);
            __builder.AddAttribute(118, "href", "checkout");
            __builder.AddAttribute(119, "class", "btn btn-primary");
            __builder.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(121, "Proceed to checkout <i class=\"fa fa-chevron-right\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(122, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\n        \n        ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "col-lg-3");
            __builder.AddMarkupContent(130, "\n            ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "id", "order-summary");
            __builder.AddAttribute(133, "class", "box");
            __builder.AddMarkupContent(134, "\n                ");
            __builder.AddMarkupContent(135, "<div class=\"box-header\">\n                    <h3 class=\"mb-0\">Order summary</h3>\n                </div>\n                ");
            __builder.AddMarkupContent(136, "<p class=\"text-muted\">Shipping and additional costs are calculated based on the values you have entered.</p>\n                ");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "table-responsive");
            __builder.AddMarkupContent(139, "\n                    ");
            __builder.OpenElement(140, "table");
            __builder.AddAttribute(141, "class", "table");
            __builder.AddMarkupContent(142, "\n                        ");
            __builder.OpenElement(143, "tbody");
            __builder.AddMarkupContent(144, "\n                            ");
            __builder.OpenElement(145, "tr");
            __builder.AddMarkupContent(146, "\n                                ");
            __builder.AddMarkupContent(147, "<td>Order subtotal</td>\n                                ");
            __builder.OpenElement(148, "th");
            __builder.AddContent(149, 
#nullable restore
#line 100 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                     SubTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\n                            ");
            __builder.AddMarkupContent(152, "<tr>\n                                <td>Cargo</td>\n                                <th>$10.00</th>\n                            </tr>\n                            ");
            __builder.OpenElement(153, "tr");
            __builder.AddAttribute(154, "class", "total");
            __builder.AddMarkupContent(155, "\n                                ");
            __builder.AddMarkupContent(156, "<td>Total</td>\n                                ");
            __builder.OpenElement(157, "th");
            __builder.AddContent(158, 
#nullable restore
#line 108 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
                                     Total

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(165, "\n        \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Basket.razor"
       

    public decimal SubTotal { get; set; } = 0;
    public decimal Total { get; set; }
    List<BasketModel> basketModels=new List<BasketModel>();
    protected override async Task OnInitializedAsync()
    {
        var basketSessionResult = await sessionStorage.GetItemAsync<List<BasketModel>>("basket");
        if (basketSessionResult!=null)
        {
            basketModels = basketSessionResult;
        }
        var resultTotal = TotalHesapla();
        await sessionStorage.SetItemAsync("subtotal", resultTotal);
        SubTotal = resultTotal;
    }
    async Task UpdateCart()
    {
        await sessionStorage.SetItemAsync("basket", basketModels);
        await sessionStorage.SetItemAsync("subtotal", SubTotal);
    }

    public async Task UpdateProduct(BasketModel basketModel)
    {
        basketModels.Find(x => x.Product.Id == basketModel.Product.Id).Quantity = basketModel.Quantity;
        var resultTotal = TotalHesapla();
        SubTotal = resultTotal;
        await sessionStorage.SetItemAsync("basket", basketModels);
        await sessionStorage.SetItemAsync("subtotal", SubTotal);
    }
    public decimal TotalHesapla()
    {
        decimal result = 0;
        foreach (var item in basketModels)
        {

            decimal discountPrice = item.Product.UnitPrice - (item.Product.UnitPrice * ((decimal)item.Product.Discount / 100));
            result += discountPrice * (Convert.ToDecimal(item.Quantity));
        }
        return result;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
