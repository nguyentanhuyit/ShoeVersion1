#pragma checksum "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d250be42ce3abe8948653f06df0b57dcc7ccc16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductDetail), @"mvc.1.0.view", @"/Views/Product/ProductDetail.cshtml")]
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
#line 1 "D:\dotnet-workspace\Shoe\Shoe\Views\_ViewImports.cshtml"
using Shoe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dotnet-workspace\Shoe\Shoe\Views\_ViewImports.cshtml"
using Shoe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d250be42ce3abe8948653f06df0b57dcc7ccc16", @"/Views/Product/ProductDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ab9ced67c29f9216e1ca434fdd17ec89dabdf8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/user/img/avatar/avatar_default.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
  
    ViewData["Title"] = "ProductDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumb Section Begin -->
    <section class=""breadcrumb-section set-bg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12 text-center"">
                    <div class=""breadcrumb__text"">
                        <div class=""breadcrumb__option"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d250be42ce3abe8948653f06df0b57dcc7ccc166336", async() => {
                WriteLiteral("Trang chủ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <a href=\"./index.html\">");
#nullable restore
#line 13 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                              Write(ViewBag.Detail.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a href=\"./index.html\"></a>\r\n                            <span> ");
#nullable restore
#line 15 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                              Write(ViewBag.Detail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Breadcrumb Section End -->
 <!-- Product Details Section Begin -->
    <section class=""product-details spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-md-6"">
                    <div class=""product__details__pic"">
                        <div class=""product__details__pic__item"">
                            <img class=""product__details__pic__item--large""");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1227, "\"", 1289, 1);
#nullable restore
#line 31 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1266, ViewBag.Detail.MainImg, 1266, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1290, "\"", 1296, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"product__details__pic__slider owl-carousel\">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 34 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1484, "\"", 1543, 1);
#nullable restore
#line 35 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1523, ViewBag.Detail.Img1, 1523, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1544, "\"", 1550, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 36 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1624, "\"", 1683, 1);
#nullable restore
#line 37 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1663, ViewBag.Detail.Img2, 1663, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1684, "\"", 1690, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 38 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1764, "\"", 1823, 1);
#nullable restore
#line 39 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1803, ViewBag.Detail.Img3, 1803, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1824, "\"", 1830, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img data-imgbigurl=\"");
#nullable restore
#line 40 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                            Write(ViewBag.Detail.Img3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("src", "\r\n                                src=\"", 1904, "\"", 1963, 1);
#nullable restore
#line 41 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 1943, ViewBag.Detail.Img3, 1943, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1964, "\"", 1970, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-lg-6 col-md-6\">\r\n                    <div class=\"product__details__text\">\r\n                        <h3>");
#nullable restore
#line 47 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                       Write(ViewBag.Detail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <div class=""product__details__rating"">
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star""></i>
                            <i class=""fa fa-star-half-o""></i>
                            <span>(18 đánh giá)</span>
                        </div>
                        <div class=""product__details__price"">");
#nullable restore
#line 56 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                        Write(ViewBag.Detail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</div>\r\n                        <p>- Màu sắc: ");
#nullable restore
#line 57 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                 Write(ViewBag.Detail.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"size\">\r\n                            <p>- Kích thước: </p>\r\n                            <div class=\"size_item\">\r\n");
#nullable restore
#line 61 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                foreach(var item in ViewBag.ListSize){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span");
            BeginWriteAttribute("id", " id=\"", 3084, "\"", 3113, 2);
            WriteAttributeValue("", 3089, "size_click", 3089, 10, true);
#nullable restore
#line 62 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("", 3099, item.SizeId, 3099, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"size_click\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3133, "\"", 3174, 3);
            WriteAttributeValue("", 3143, "chooseSize(", 3143, 11, true);
#nullable restore
#line 62 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue(" ", 3154, item.SizeId, 3155, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3167, ",this)", 3168, 7, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 62 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                                                                                                Write(item.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 63 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 3286, "\"", 3294, 0);
            EndWriteAttribute();
            WriteLiteral(" id =\"SizeID\"/>\r\n                            </div>\r\n                        </div>\r\n                        <pc class=\"sellout\">- Còn hàng: Còn *n* sản phẩm</pc>\r\n                        </div>\r\n                        \r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 3543, "\"", 3592, 3);
            WriteAttributeValue("", 3553, "addToCart(", 3553, 10, true);
#nullable restore
#line 70 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue("  ", 3563, ViewBag.Detail.ProductId, 3565, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3590, ")", 3591, 2, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""primary-btn add-to-cart"">Thêm vào giỏ hàng</a>
                        <ul>
                            <li><b>Vận chuyển</b> <span>Trong 1 ngày <samp></samp></span></li>
                        </ul>
                        <h6>Có thể bạn thích</h6>
                        <div class=""product_relative"">
                            <div class=""col-lg-4 product_container"">
                                <div class=""product__item"">
                                    <div class=""product__item__pic set-bg"" data-setbg=""http://img.mwc.com.vn/giay-thoi-trang?&w=450&h=450&FileInput=//Upload/2020/02/84528813-176342960295985-3914722502571458560-n.jpg"">
                                        <ul class=""product__item__pic__hover"">
                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d250be42ce3abe8948653f06df0b57dcc7ccc1618056", async() => {
                WriteLiteral("<i class=\"fa fa-retweet\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"product__item__text\">\r\n                                        <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d250be42ce3abe8948653f06df0b57dcc7ccc1620172", async() => {
                WriteLiteral("aaaaaa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h6>
                                        <h5>1000000đ</h5>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4 product_container"">
                                <div class=""product__item"">
                                    <div class=""product__item__pic set-bg"" data-setbg=""http://img.mwc.com.vn/giay-thoi-trang?&w=450&h=450&FileInput=//Upload/2020/02/84528813-176342960295985-3914722502571458560-n.jpg"">
                                        <ul class=""product__item__pic__hover"">
                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d250be42ce3abe8948653f06df0b57dcc7ccc1622715", async() => {
                WriteLiteral("<i class=\"fa fa-retweet\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"product__item__text\">\r\n                                        <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d250be42ce3abe8948653f06df0b57dcc7ccc1624831", async() => {
                WriteLiteral("aaaaaa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h6>
                                        <h5>1000000đ</h5>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4 product_container"">
                                <div class=""product__item"">
                                    <div class=""product__item__pic set-bg"" data-setbg=""http://img.mwc.com.vn/giay-thoi-trang?&w=450&h=450&FileInput=//Upload/2020/02/84528813-176342960295985-3914722502571458560-n.jpg"">
                                        <ul class=""product__item__pic__hover"">
                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d250be42ce3abe8948653f06df0b57dcc7ccc1627374", async() => {
                WriteLiteral("<i class=\"fa fa-retweet\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                    </div>\r\n                                    <div class=\"product__item__text\">\r\n                                        <h6>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d250be42ce3abe8948653f06df0b57dcc7ccc1629490", async() => {
                WriteLiteral("aaaaaa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h6>
                                        <h5>1000000đ</h5>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-12"">
                    <div class=""product__details__tab"">
                        <ul class=""nav nav-tabs"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" data-toggle=""tab"" href=""#tabs-1"" role=""tab""
                                    aria-selected=""true"">Mô tả</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" data-toggle=""tab"" href=""#tabs-2"" role=""tab""
                                    aria-selected=""false"">Nhận xét <span>(");
#nullable restore
#line 127 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                                      Write(ViewBag.ReviewSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(@")</span></a>
                            </li>
                        </ul>
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""tabs-1"" role=""tabpanel"">
                                <div class=""product__details__tab__desc"">
                                    <h6>Mô tả</h6>
                                    <p>");
#nullable restore
#line 134 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                  Write(ViewBag.Detail.Discription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            
                            <div class=""tab-pane"" id=""tabs-2"" role=""tabpanel"">
                                <div class=""product__details__tab__desc"">
                                    <div class=""container bootstrap snippets bootdey"">
                                        <div class=""row"">
                                            <div class=""col-md-12"">
                                                <div class=""blog-comment"">
                                                    <p class=""comment-size"">");
#nullable restore
#line 144 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                                       Write(ViewBag.ReviewSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" bình luận</p>\r\n                                                    <hr/>\r\n                                                    <ul class=\"comments\">\r\n");
#nullable restore
#line 147 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                          foreach(var item in ViewBag.ReviewList){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <li class=\"clearfix\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d250be42ce3abe8948653f06df0b57dcc7ccc1634734", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                            <div class=\"post-comments\">\r\n                                                                <p>\r\n                                                                    ");
#nullable restore
#line 152 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                               Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                </p>
                                                                
                                                            </div>
                                                        </li>
");
#nullable restore
#line 157 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    </ul>
                                                    <textarea class=""form-control"" placeholder=""Viết bình luận"" rows=""3""></textarea>
                                                    <br>
                                                    <button type=""button"" class=""btn btn-info pull-right""");
            BeginWriteAttribute("onclick", " onclick=\"", 10297, "\"", 10346, 3);
            WriteAttributeValue("", 10307, "addComment(", 10307, 11, true);
#nullable restore
#line 161 "D:\dotnet-workspace\Shoe\Shoe\Views\Product\ProductDetail.cshtml"
WriteAttributeValue(" ", 10318, ViewBag.Detail.ProductId, 10319, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 10344, ")", 10345, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">Post</button>
                                                    <div class=""clearfix""></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- Product Details Section End -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591