#pragma checksum "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\ShopCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3070c0d3ed0d6a7966bd27a82afdfabbbad763e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShopCart_Index), @"mvc.1.0.view", @"/Views/ShopCart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ShopCart/Index.cshtml", typeof(AspNetCore.Views_ShopCart_Index))]
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
#line 1 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\_ViewImports.cshtml"
using shoooooop.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\_ViewImports.cshtml"
using shoooooop.Data.models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3070c0d3ed0d6a7966bd27a82afdfabbbad763e7", @"/Views/ShopCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59dd8a3a55147a718f257b34d1e9d5b47e6f1ddd", @"/Views/_ViewImports.cshtml")]
    public class Views_ShopCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 25, true);
            WriteLiteral("<div class=\"container\">\r\n");
            EndContext();
#line 3 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\ShopCart\Index.cshtml"
     foreach (var el in Model.shopCart.listShopItems)
    {

#line default
#line hidden
            BeginContext(114, 78, true);
            WriteLiteral("        <div class=\"alert alert-warning mt-3\">\r\n            <b>Автомобиль:</b>");
            EndContext();
            BeginContext(193, 11, false);
#line 6 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\ShopCart\Index.cshtml"
                         Write(el.car.name);

#line default
#line hidden
            EndContext();
            BeginContext(204, 32, true);
            WriteLiteral("<br />\r\n            <b>Цена:</b>");
            EndContext();
            BeginContext(237, 26, false);
#line 7 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\ShopCart\Index.cshtml"
                   Write(el.car.price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(263, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 9 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\ShopCart\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(288, 89, true);
            WriteLiteral("    <hr />\r\n    <div class=\"btn btn-danger\" asp-controller=\"Order\">Оплатить</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
