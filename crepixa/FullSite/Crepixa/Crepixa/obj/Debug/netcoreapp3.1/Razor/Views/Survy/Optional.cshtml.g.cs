#pragma checksum "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fc113a9f464d3990ca92fa3e9c91e3f3cfffac1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survy_Optional), @"mvc.1.0.view", @"/Views/Survy/Optional.cshtml")]
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
#line 1 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\_ViewImports.cshtml"
using Crepixa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\_ViewImports.cshtml"
using Crepixa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fc113a9f464d3990ca92fa3e9c91e3f3cfffac1", @"/Views/Survy/Optional.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7982a9dd860efac7c89e6d23bde38b4c1ad1232", @"/Views/_ViewImports.cshtml")]
    public class Views_Survy_Optional : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crepixa.ViewModels.OptionalVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
  
    ViewData["Title"] = "Ordinary";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
 using (Html.BeginForm("Optional", "Survy", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"form-group\">\r\n            <label for=\"q\">Question</label>\r\n            ");
#nullable restore
#line 10 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
       Write(Html.TextBoxFor(x => x.Question, new { @class = "form-control", @name = "q" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"F\">First Choice</label>\r\n            ");
#nullable restore
#line 14 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
       Write(Html.TextBoxFor(x => x.A, new { @class = "form-control", @name = "F" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"S\">Second Choice</label>\r\n            ");
#nullable restore
#line 18 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
       Write(Html.TextBoxFor(x => x.B, new { @class = "form-control", @name = "S" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"T\">Third Choice</label>\r\n            ");
#nullable restore
#line 22 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
       Write(Html.TextBoxFor(x => x.C, new { @class = "form-control", @name = "T" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"Ft\">Fourth Choice</label>\r\n            ");
#nullable restore
#line 26 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
       Write(Html.TextBoxFor(x => x.D, new { @class = "form-control", @name = "Ft" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" class=\"form-control btn btn-primary\" value=\"New Question\" />\r\n    </div>\r\n");
#nullable restore
#line 30 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Survy\Optional.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crepixa.ViewModels.OptionalVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
