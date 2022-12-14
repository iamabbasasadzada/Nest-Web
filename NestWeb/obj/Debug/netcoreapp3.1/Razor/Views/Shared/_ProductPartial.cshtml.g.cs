#pragma checksum "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4998a2df24f02dea7ab0aa43b5f72c939dd9d0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4998a2df24f02dea7ab0aa43b5f72c939dd9d0b", @"/Views/Shared/_ProductPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c226a26236fd93394ec23f282070faf6f860645a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__ProductPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n    <style>\r\n        .product-img .default-img, .product-img .hover-img{\r\n            width:150px;\r\n            height:150px;\r\n        }\r\n    </style>\r\n");
            }
            );
#nullable restore
#line 11 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-lg-1-5 col-md-4 col-12 col-sm-6"">
        <div class=""product-cart-wrap mb-30"">
            <div class=""product-img-action-wrap"">
                <div class=""product-img product-img-zoom"">
                    <a href=""shop-product-right.html"">
                        <img class=""default-imgg""");
            BeginWriteAttribute("src", "  src=\"", 556, "\"", 642, 2);
            WriteAttributeValue("", 563, "assets/imgs/shop/", 563, 17, true);
#nullable restore
#line 18 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
WriteAttributeValue("", 580, item.ProductImages.FirstOrDefault(pi=>pi.IsFront==true).Image, 580, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 643, "\"", 649, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <img class=\"hover-imgg\"");
            BeginWriteAttribute("src", "  src=\"", 702, "\"", 787, 2);
            WriteAttributeValue("", 709, "assets/imgs/shop/", 709, 17, true);
#nullable restore
#line 19 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
WriteAttributeValue("", 726, item.ProductImages.FirstOrDefault(pi=>pi.IsBack==true).Image, 726, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 788, "\"", 794, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                    </a>
                </div>
                <div class=""product-action-1"">
                    <a aria-label=""Add To Wishlist"" class=""action-btn"" href=""shop-wishlist.html""><i class=""fi-rs-heart""></i></a>
                    <a aria-label=""Quick view"" class=""action-btn"" data-bs-toggle=""modal"" data-bs-target=""#quickViewModal""><i class=""fi-rs-eye""></i></a>
                </div>
                <div class=""product-badges product-badges-position product-badges-mrg"">
");
#nullable restore
#line 27 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                     if (item.StockCount == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"hot\">Bitdi</span>\r\n");
#nullable restore
#line 30 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"product-content-wrap\">\r\n                <div class=\"product-category\">\r\n                    <a href=\"shop-grid-right.html\">");
#nullable restore
#line 35 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                                              Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n                <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4998a2df24f02dea7ab0aa43b5f72c939dd9d0b8575", async() => {
#nullable restore
#line 37 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h2>\r\n                <div class=\"product-rate-cover\">\r\n                    <div class=\"product-rate d-inline-block\">\r\n                        <div class=\"product-rating\"");
            BeginWriteAttribute("style", " style=\"", 1937, "\"", 1971, 3);
            WriteAttributeValue("", 1945, "width:", 1945, 6, true);
#nullable restore
#line 40 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
WriteAttributeValue(" ", 1951, item.Raiting*20, 1952, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1970, "%", 1970, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                    </div>\r\n                    <span class=\"font-small ml-5 text-muted\"> (");
#nullable restore
#line 42 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                                                          Write(item.Raiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"product-card-bottom\">\r\n                    <div class=\"product-price\">\r\n                        <span>$");
#nullable restore
#line 49 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                    </div>\r\n                    <div class=\"add-cart\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4998a2df24f02dea7ab0aa43b5f72c939dd9d0b12633", async() => {
                WriteLiteral("\r\n                        <button type=\"submit\" class=\"add\" href=\"shop-cart.html\"><i class=\"fi-rs-shopping-cart mr-5\"></i>Add </button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
                                                                                              WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 61 "C:\Workspace_Main\CodeAcademyRepos\NestWebV10\NestWeb\Views\Shared\_ProductPartial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
