#pragma checksum "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Country\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3dbfa3a3c1919f8d3b54132914bc372e702d0cf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Country_New), @"mvc.1.0.view", @"/Views/Country/New.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbfa3a3c1919f8d3b54132914bc372e702d0cf3", @"/Views/Country/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7982a9dd860efac7c89e6d23bde38b4c1ad1232", @"/Views/_ViewImports.cshtml")]
    public class Views_Country_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crepixa.ViewModels.CountryVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Country\New.cshtml"
  
    ViewData["Title"] = "New Tag";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>\r\n    New Country\r\n</h3>\r\n\r\n");
#nullable restore
#line 9 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Country\New.cshtml"
 using (Html.BeginForm("New", "Country", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"form-group\">\r\n            <label for=\"ARN\">Name In Arabic</label>\r\n            ");
#nullable restore
#line 14 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Country\New.cshtml"
       Write(Html.TextBoxFor(x => x.NameAr, new { @class = "form-control", @name = "ARN" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"ARE\">Name In English</label>\r\n            ");
#nullable restore
#line 18 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Country\New.cshtml"
       Write(Html.TextBoxFor(x => x.NameEn, new { @class = "form-control", @name = "ARE" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"ARE\">Select Image</label>\r\n            ");
#nullable restore
#line 22 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Country\New.cshtml"
       Write(Html.EditorFor(x => x.FileUpload));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" class=\"form-control btn btn-primary\" value=\"New Country\" />\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Country\New.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crepixa.ViewModels.CountryVM> Html { get; private set; }
    }
}
#pragma warning restore 1591