#pragma checksum "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Product\ShowSteamFan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d74d8733e38952bd3fc313e7c3b3841b3d38deb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowSteamFan), @"mvc.1.0.view", @"/Views/Product/ShowSteamFan.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d74d8733e38952bd3fc313e7c3b3841b3d38deb1", @"/Views/Product/ShowSteamFan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d469fa2e3b21f102bfd409d398eb1d489da3e70", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowSteamFan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BaiTapLon.Models.ProductManagement.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Product\ShowSteamFan.cshtml"
   
    ViewBag.Title = "Danh sách quạt hơi nước";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\" row\">\r\n");
#nullable restore
#line 12 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Product\ShowSteamFan.cshtml"
     foreach (var steam in Model)
    {
        // 1 dong co 4 cot

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\" col-sm-3\">\r\n\r\n            <div class=\" card my-3 text-center\">\r\n                <div class=\" card\">\r\n                    <div class=\" card-header\">\r\n                        <h6>");
#nullable restore
#line 20 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Product\ShowSteamFan.cshtml"
                       Write(steam.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                    ");
#nullable restore
#line 22 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Product\ShowSteamFan.cshtml"
               Write(steam.Utilities);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    <div class=\" card-footer\">\r\n                        <h5> ");
#nullable restore
#line 25 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Product\ShowSteamFan.cshtml"
                        Write(steam.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\DataPersonal\Codegym\module3\BaiTapLon\BaiTaoLon\BaiTaoLon\Views\Product\ShowSteamFan.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
