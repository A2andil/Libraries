#pragma checksum "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380e1f42123a433b4e85fb2b2cc9226b016a2a43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_New), @"mvc.1.0.view", @"/Views/Account/New.cshtml")]
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
#line 1 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\_ViewImports.cshtml"
using Crepixa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
using Crepixa.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
using Crepixa.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380e1f42123a433b4e85fb2b2cc9226b016a2a43", @"/Views/Account/New.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7982a9dd860efac7c89e6d23bde38b4c1ad1232", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Crepixa.ViewModels.AccountVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
  
    ViewData["Title"] = "New";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
 using (Html.BeginForm("New", "Account", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"form-group\">\r\n            <label for=\"nm\">Name</label>\r\n            ");
#nullable restore
#line 14 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
       Write(Html.TextBoxFor(x => x.Account.FullName, new { @class = "form-control", @name = "nm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"em\">Email</label>\r\n            ");
#nullable restore
#line 18 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
       Write(Html.TextBoxFor(x => x.Account.Email, new { @class = "form-control", @name = "em" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"sal\">Mobile</label>\r\n            ");
#nullable restore
#line 22 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
       Write(Html.TextBoxFor(x => x.Account.Mobile, new { @class = "form-control", @name = "sal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"Upload\">Profile Picture</label>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "380e1f42123a433b4e85fb2b2cc9226b016a2a435640", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 26 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FileUpload);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"sal\">Salary</label>\r\n            ");
#nullable restore
#line 30 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
       Write(Html.TextBoxFor(x => x.Account.Salary, new { @class = "form-control", @name = "sal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"pass\">Password</label>\r\n            ");
#nullable restore
#line 34 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
       Write(Html.PasswordFor(x => x.Account.Password, new { @class = "form-control", @name = "pass" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"role\">Select Role</label>\r\n            ");
#nullable restore
#line 38 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
       Write(Html.DropDownListFor(x => x.Account.RoleId,
                new SelectList(Model.Roles, "Id", "Name"),
                new { @class = "form-control", @name = "role" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"ct\">Select Country</label>\r\n            ");
#nullable restore
#line 44 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
       Write(Html.DropDownListFor(x => x.Account.CountryId,
                new SelectList(Model.Countries, "Id", "NameEn"),
                new { @class = "form-control", @name = "ct" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <input type=\"submit\" class=\"form-control btn btn-primary\" value=\"New Account\" />\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Account\New.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crepixa.ViewModels.AccountVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
