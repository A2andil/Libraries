#pragma checksum "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Subscriber\Send.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "454ce967191d271d08d3ed1e2bfe5d7bd5846d68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subscriber_Send), @"mvc.1.0.view", @"/Views/Subscriber/Send.cshtml")]
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
#line 2 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\_ViewImports.cshtml"
using Crepixa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"454ce967191d271d08d3ed1e2bfe5d7bd5846d68", @"/Views/Subscriber/Send.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7982a9dd860efac7c89e6d23bde38b4c1ad1232", @"/Views/_ViewImports.cshtml")]
    public class Views_Subscriber_Send : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Crepixa.ViewModels.SubscriberItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subscriber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Manage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary shadow-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 5px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Security", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Send", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Subscriber\Send.cshtml"
  
    ViewData["Title"] = "Manage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<button type=\"button\" id=\"SendMessage\" class=\"btn btn-success shadow-none\"\r\n        style=\"margin-bottom: 5px\">\r\n    <i class=\"fa fa-envelope fa-lg\" id=\"notloading\"></i>\r\n    <i class=\"fa fa-spinner fa-spin\" id=\"loading\"></i>  Send Emails\r\n</button>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454ce967191d271d08d3ed1e2bfe5d7bd5846d686159", async() => {
                WriteLiteral("\r\n    <i class=\"fa fa-tasks fa-lg\"></i>Manage\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "454ce967191d271d08d3ed1e2bfe5d7bd5846d687733", async() => {
                WriteLiteral(@"
    <input type=""text"" class=""form-control""
           placeholder=""Enter Subject""
           style=""margin-bottom: 5px""
           id=""SubjectId"" />
    <textarea class=""form-control"" placeholder=""Enter Message content"" id=""Message""></textarea>
    <table class=""table"" id=""list_all"">
        <tr class=""tbl"">
            <th>
                Name
            </th>
            <th>
                Email
            </th>
            <th>
                <input type=""checkbox"" id=""select_all"" class=""ptr"" />
            </th>
        </tr>
");
#nullable restore
#line 35 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Subscriber\Send.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr class=\"tbl\">\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Subscriber\Send.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Subscriber\Send.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Subscriber\Send.cshtml"
               Write(Html.CheckBoxFor(x => item.Ischecked, new { @class = "ptr" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\A2andil\Github\Libraries\crepixa\FullSite\Crepixa\Crepixa\Views\Subscriber\Send.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<!--------------------- JavaScript ------------------------>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var table = document.getElementById(""list_all"");
        document.getElementById('select_all').addEventListener('change', function () {
            let ans = this.checked;
            for (var i = 1; i < table.rows.length; i++) {
                table.rows[i].cells[2].children[0].checked = ans;
            }
        });
        //select all lists checked parent
        var table = document.getElementById(""list_all"");
        for (var i = 1; i < table.rows.length; i++) {
            table.rows[i].cells[2].children[0].addEventListener('change', function () {
                var parent = document.getElementById('select_all');
                var ans = true;
                for (var i = 1; i < table.rows.length; i++) {
                    ans &= table.rows[i].cells[2].children[0].checked;
                }
                parent.checked = ans;
            });
        }

        $('#loading').hide();

        $(""#SendMessage"").click(function () {
            var listI");
                WriteLiteral(@"tems = [];
            var rows = document.getElementById('list_all').rows;
            console.log(rows.length);
            for (let i = 1; i < rows.length; i++) {
                if (rows[i].cells[2].children[0].checked) {
                    var obj = {};
                    obj[""Name""] = rows[i].cells[0].innerText;
                    obj[""Email""] = rows[i].cells[1].innerText;
                    obj[""Ischecked""] = true;
                    listItems.push(obj);
                }
            }

            if (listItems.length < 1) {
                alert('You should select at least one item');
                return false;
            }

            $('#loading').show();
            $('#notloading').hide();

            var SenderObj = {
                ""Subject"": $('#SubjectId').val(),
                ""Message"": $('#Message').val(),
                ""subscribers"": listItems
            };

            $.ajax({
                type: ""POST"",
                url: ""/Subscriber/Se");
                WriteLiteral(@"nd"",
                data: {
                    'model': SenderObj
                },
                dataType: 'json',
                success: function (response) {
                    if (response == 'success') {
                        alert('Message Sent Successfully');
                        $('#loading').hide();
                        $('#notloading').show();
                        window.location.href = ""/Subscriber/Manage"";
                    }
                    else {
                        alert(response.IsSuccess);
                    }
                },
                error: function (req, status, error) {
                }
            });

        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Crepixa.ViewModels.SubscriberItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
