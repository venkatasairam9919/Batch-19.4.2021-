#pragma checksum "D:\Training(4.19.2021)\Modules\Module-3\Asp.net MVC\HandsOn\HandsOnMVCPassingDatabetweenActionMethodtoView\HandsOnMVCPassingDatabetweenActionMethodtoView\Views\Demo\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5eaed366a67f4a18b9ebff26d3dd772c94a8daa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Show), @"mvc.1.0.view", @"/Views/Demo/Show.cshtml")]
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
#line 1 "D:\Training(4.19.2021)\Modules\Module-3\Asp.net MVC\HandsOn\HandsOnMVCPassingDatabetweenActionMethodtoView\HandsOnMVCPassingDatabetweenActionMethodtoView\Views\_ViewImports.cshtml"
using HandsOnMVCPassingDatabetweenActionMethodtoView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training(4.19.2021)\Modules\Module-3\Asp.net MVC\HandsOn\HandsOnMVCPassingDatabetweenActionMethodtoView\HandsOnMVCPassingDatabetweenActionMethodtoView\Views\_ViewImports.cshtml"
using HandsOnMVCPassingDatabetweenActionMethodtoView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5eaed366a67f4a18b9ebff26d3dd772c94a8daa", @"/Views/Demo/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3aa7acf9ed67a1b42136232fd5500e63ff5db83", @"/Views/_ViewImports.cshtml")]
    public class Views_Demo_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Training(4.19.2021)\Modules\Module-3\Asp.net MVC\HandsOn\HandsOnMVCPassingDatabetweenActionMethodtoView\HandsOnMVCPassingDatabetweenActionMethodtoView\Views\Demo\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 6 "D:\Training(4.19.2021)\Modules\Module-3\Asp.net MVC\HandsOn\HandsOnMVCPassingDatabetweenActionMethodtoView\HandsOnMVCPassingDatabetweenActionMethodtoView\Views\Demo\Show.cshtml"
       Write(ViewData["un"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>Hi,");
#nullable restore
#line 7 "D:\Training(4.19.2021)\Modules\Module-3\Asp.net MVC\HandsOn\HandsOnMVCPassingDatabetweenActionMethodtoView\HandsOnMVCPassingDatabetweenActionMethodtoView\Views\Demo\Show.cshtml"
  Write(ViewBag.Uname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
