#pragma checksum "C:\Users\elif.karayel\source\repos\FirstCoreProject\FCP.WebUI\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b87ab28229ee8293d5daf63f95ce55ce7be2bbde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Create.cshtml", typeof(AspNetCore.Views_Product_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87ab28229ee8293d5daf63f95ce55ce7be2bbde", @"/Views/Product/Create.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FCP.Entities.Concrete.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\elif.karayel\source\repos\FirstCoreProject\FCP.WebUI\Views\Product\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 1479, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Product</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""ID"" class=""control-label""></label>
                <input asp-for=""ID"" class=""form-control"" />
                <span asp-validation-for=""ID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UnitPrice"" class=""control-label""></label>
                <input asp-for=""UnitPrice"" class=""form-control"" />
                <span asp-validation-for=""UnitPrice"" class=""text-danger""></span>
            </div>
 ");
            WriteLiteral(@"           <div class=""form-group"">
                <label asp-for=""UnitsInStock"" class=""control-label""></label>
                <input asp-for=""UnitsInStock"" class=""form-control"" />
                <span asp-validation-for=""UnitsInStock"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <div class=""checkbox"">
                    <label>
                        <input asp-for=""Discontinued"" /> ");
            EndContext();
            BeginContext(1609, 48, false);
#line 39 "C:\Users\elif.karayel\source\repos\FirstCoreProject\FCP.WebUI\Views\Product\Create.cshtml"
                                                    Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 600, true);
            WriteLiteral(@"
                    </label>
                </div>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryID"" class=""control-label""></label>
                <input asp-for=""CategoryID"" class=""form-control"" />
                <span asp-validation-for=""CategoryID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FCP.Entities.Concrete.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591