#pragma checksum "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7429badd20689d7e8823b4c2149e7a2062f8131b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cart), @"mvc.1.0.view", @"/Views/Product/Cart.cshtml")]
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
#line 2 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\_ViewImports.cshtml"
using NestWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\_ViewImports.cshtml"
using NestWeb.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\_ViewImports.cshtml"
using NestWeb.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7429badd20689d7e8823b4c2149e7a2062f8131b", @"/Views/Product/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c226a26236fd93394ec23f282070faf6f860645a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketItemVm>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeteleAllCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-muted"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeteleCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""page-header breadcrumb-wrap"">
            <div class=""container"">
                <div class=""breadcrumb"">
                    <a href=""index.html"" rel=""nofollow""><i class=""fi-rs-home mr-5""></i>Home</a>
                    <span></span> Shop
                    <span></span> Cart
                </div>
            </div>
        </div>
        <div class=""container mb-80 mt-50"">
            <div class=""row"">
                <div class=""col-lg-8 mb-40"">
                    <h1 class=""heading-2 mb-10"">Your Cart</h1>
                    <div class=""d-flex justify-content-between"">
                        <h6 class=""text-body"">There are <span class=""text-brand"">3</span> products in your cart</h6>

                        <h6 class=""text-body"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7429badd20689d7e8823b4c2149e7a2062f8131b6458", async() => {
                WriteLiteral("<i class=\"fi-rs-trash mr-5\"></i>Clear Cart");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h6>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-8\">\r\n");
#nullable restore
#line 26 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
             if (Model.Count > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                 <div class=""table-responsive shopping-summery"">
                        <table class=""table table-wishlist"">
                            <thead>
                                <tr class=""main-heading"">
                                    <th class=""custome-checkbox start pl-30"">
                                        <input class=""form-check-input"" type=""checkbox"" name=""checkbox"" id=""exampleCheckbox11""");
            BeginWriteAttribute("value", " value=\"", 1565, "\"", 1573, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <label class=""form-check-label"" for=""exampleCheckbox11""></label>
                                    </th>
                                    <th scope=""col"" colspan=""2"">Product</th>
                                    <th scope=""col"">Unit Price</th>
                                    <th scope=""col"">Quantity</th>
                                    <th scope=""col"">Total for 1 product</th>
                                    <th scope=""col"" class=""end"">Remove</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 44 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                 foreach (BasketItemVm item in Model)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  <tr ");
#nullable restore
#line 46 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                  Write(item.IsAviable==false?"disabled class=bg-danger":"");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                    <td class=\"custome-checkbox pl-30\">\r\n                                        <input class=\"form-check-input\" type=\"checkbox\" name=\"checkbox\" id=\"exampleCheckbox1\"");
            BeginWriteAttribute("value", " value=\"", 2607, "\"", 2615, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <label class=\"form-check-label\" for=\"exampleCheckbox1\"></label>\r\n                                    </td>\r\n                                    <td class=\"image product-thumbnail pt-40\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7429badd20689d7e8823b4c2149e7a2062f8131b10806", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2855, "~/assets/imgs/shop/", 2855, 19, true);
#nullable restore
#line 51 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
AddHtmlAttributeValue("", 2874, item.Image, 2874, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                    <td class=\"product-des product-name\">\r\n                                        <h6 class=\"mb-5\"><a class=\"product-name mb-10 text-heading\" href=\"shop-product-right.html\">");
#nullable restore
#line 53 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                                                                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                        <div class=\"product-rate-cover\">\r\n                                            <div class=\"product-rate d-inline-block\">\r\n                                                <div class=\"product-rating\"");
            BeginWriteAttribute("style", " style=\"", 3365, "\"", 3398, 3);
            WriteAttributeValue("", 3373, "width:", 3373, 6, true);
#nullable restore
#line 56 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
WriteAttributeValue("", 3379, item.Raiting*20, 3379, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3397, "%", 3397, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n                                            <span class=\"font-small ml-5 text-muted\"> (");
#nullable restore
#line 59 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                                                                  Write(item.Raiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(".0)</span>\r\n                                        </div>\r\n                                    </td>\r\n                                    <td class=\"price\" data-title=\"Price\">\r\n                                        <h4 class=\"text-body\">$");
#nullable restore
#line 63 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h4>
                                    </td>
                                    <td class=""text-center detail-info"" data-title=""Stock"">
                                        <div class=""detail-extralink mr-15"">
                                            <div class=""detail-qty border radius"">
                                                <a href=""#"" class=""qty-down""><i class=""fi-rs-angle-small-down""></i></a>
                                                <span class=""qty-val"">");
#nullable restore
#line 69 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                                                 Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                <a href=""#"" class=""qty-up""><i class=""fi-rs-angle-small-up""></i></a>
                                            </div>
                                        </div>
                                    </td>
                                    <td class=""price"" data-title=""Price"">
                                        <h4 class=""text-brand"">$");
#nullable restore
#line 75 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                                            Write(item.Price * item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                                    </td>\r\n                                    <td class=\"action text-center\" data-title=\"Remove\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7429badd20689d7e8823b4c2149e7a2062f8131b16414", async() => {
                WriteLiteral("\r\n                                        <button type=\"submit\" href=\"#\" class=\"text-body\"><i class=\"fi-rs-trash\"></i></button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                                                                                               WriteLiteral(item.ProdId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                        </td>\r\n                                </tr> \r\n");
#nullable restore
#line 83 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                \r\n                               \r\n                            </tbody>\r\n                        </table>\r\n                        <h4 class=\"text-body\">Total: <span class=\"text-brand\">");
#nullable restore
#line 88 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
                                                                         Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span> </h4>
                    </div>
                    <div class=""divider-2 mb-30""></div>
                    <div class=""cart-action d-flex justify-content-between"">
                        <a class=""btn ""><i class=""fi-rs-arrow-left mr-10""></i>Continue Shopping</a>
                        <a class=""btn  mr-10 mb-sm-15""><i class=""fi-rs-refresh mr-10""></i>Update Cart</a>
                    </div>
");
#nullable restore
#line 95 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <h2>Your cart is empty!</h2>\r\n");
#nullable restore
#line 99 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Product\Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketItemVm>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591