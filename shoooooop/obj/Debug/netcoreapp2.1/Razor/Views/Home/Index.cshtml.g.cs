#pragma checksum "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b363a753e5de68c3ceae22db5d8d081e24c87079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b363a753e5de68c3ceae22db5d8d081e24c87079", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59dd8a3a55147a718f257b34d1e9d5b47e6f1ddd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 59, true);
            WriteLiteral("\r\n<h1>Лучшие варианты</h1>\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 6 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\Home\Index.cshtml"
      
        foreach (Car car in Model.favCars)
        {
            

#line default
#line hidden
            BeginContext(157, 28, false);
#line 9 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\Home\Index.cshtml"
       Write(Html.Partial("AllCars", car));

#line default
#line hidden
            EndContext();
#line 9 "C:\Users\Никита\Desktop\Разработка\repos\repos\shoooooop\shoooooop\Views\Home\Index.cshtml"
                                         

        }
    

#line default
#line hidden
            BeginContext(207, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
