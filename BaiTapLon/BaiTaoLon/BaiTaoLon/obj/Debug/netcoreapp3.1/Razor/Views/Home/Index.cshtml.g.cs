#pragma checksum "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0343860b4da36f7f0378472d863797f4cc75d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\_ViewImports.cshtml"
using BaiTaoLon;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\_ViewImports.cshtml"
using BaiTaoLon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0343860b4da36f7f0378472d863797f4cc75d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d469fa2e3b21f102bfd409d398eb1d489da3e70", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BaiTapLon.Models.ProductManagement.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
Write(Model[0].ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 11 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
                 Write(Model[0].ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 11 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
                                         Write(Model[0].Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n\r\n");
#nullable restore
#line 15 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
Write(Html.Raw(Model[0].Description.Replace("\r\n", "<br />")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 18 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 20 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
  Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
#nullable restore
#line 20 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
                      Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("   </p>\r\n");
#nullable restore
#line 21 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
     foreach (var ite in item.Images)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>");
#nullable restore
#line 23 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
      Write(ite.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 24 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 27 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BaiTapLon.Models.ProductManagement.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
