#pragma checksum "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e084921f3df1e98454a549ec47b0cf415ed5247c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProduct_Create), @"mvc.1.0.view", @"/Views/AdminProduct/Create.cshtml")]
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
#nullable restore
#line 4 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
using Shoe.Models.DBModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e084921f3df1e98454a549ec47b0cf415ed5247c", @"/Views/AdminProduct/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ab9ced67c29f9216e1ca434fdd17ec89dabdf8", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProduct_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Shoe.Models.DBModels.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<button style=\"color:darkblue\">");
#nullable restore
#line 5 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                          Write(Html.ActionLink("Back", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n");
#nullable restore
#line 7 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
 using (Html.BeginForm("Create", "AdminProduct", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                            

    List<SelectListItem> listSelect = new List<SelectListItem>();
    foreach (var item in new shoeContext().Categories.ToList())
    {
        SelectListItem select = new SelectListItem { Value = item.CategoryId.ToString(), Text = item.CategoryName };
        listSelect.Add(select);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <div style=\"text-align:center\">\r\n            <h2>Create new product</h2>\r\n        </div>\r\n        <hr />\r\n        ");
#nullable restore
#line 22 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <table class=\"table\">\r\n");
            WriteLiteral("            <tr>\r\n                <td>Product name</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.EditorFor(model => model.ProductName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.ProductName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Price</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Gender</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.EditorFor(model => model.Gender, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 43 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Color</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.EditorFor(model => model.Color, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 50 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Color, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Discription</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.EditorFor(model => model.Discription, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 57 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Discription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Category</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.DropDownListFor(model => model.CategoryId, listSelect, "Choose a category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 64 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.CategoryId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>Size</td>\r\n            </tr>\r\n\r\n            <tr>\r\n                <table class=\"table\">\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size36", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 36\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 78 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality36", new { size = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 81 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale36", new { size = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 86 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size37", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 37\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 89 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality37", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 92 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale37", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 97 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size38", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 38\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 100 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality38", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 103 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale38", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 108 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size39", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 39\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 111 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality39", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 114 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale39", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 119 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size40", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 40\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 122 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality40", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 125 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale40", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 130 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size41", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 41\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 133 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality41", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 136 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale41", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 141 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size42", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 42\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 144 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality42", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 147 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale42", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 152 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size43", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 43\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 155 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality43", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 158 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale43", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 163 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                       Write(Html.CheckBox("size44", false));

#line default
#line hidden
#nullable disable
            WriteLiteral(" 44\r\n                        </td>\r\n                        <td>\r\n                            Quality: ");
#nullable restore
#line 166 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                Write(Html.Editor("quality44", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            Quality Sale:  ");
#nullable restore
#line 169 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
                                      Write(Html.Editor("qualitySale44", 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </td>
                    </tr>
                </table>
            </tr>
        </table>

        <div class=""form-group"" style=""text-align:center"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" style=""background-color:forestgreen; color:black"" />
            </div>
        </div>
    </div>
");
#nullable restore
#line 182 "D:\dotnet-workspace\Shoe\Shoe\Views\AdminProduct\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Shoe.Models.DBModels.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
