#pragma checksum "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af669020049eeb3f65bed1ca41f3cefdb03f8849"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinancialItems_Index), @"mvc.1.0.view", @"/Views/FinancialItems/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\_ViewImports.cshtml"
using _10XOne.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\_ViewImports.cshtml"
using _10XOne.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af669020049eeb3f65bed1ca41f3cefdb03f8849", @"/Views/FinancialItems/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c239f49a54b75951d2ac29258306d53cfe12e9a", @"/Views/_ViewImports.cshtml")]
    public class Views_FinancialItems_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<_10XOne.Core.Models.FinancialItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af669020049eeb3f65bed1ca41f3cefdb03f88493643", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""table-responsive"">
    <table class=""table-striped table-bordered"">
        <thead>
            <tr>
                <td>
                    Partner ID
                </td>
                <td>
                    Date
                </td>
                <td>
                    Amount
                </td>
                <td>
                    Action
                </td>
            </tr>
        </thead>

");
#nullable restore
#line 27 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
         foreach (var financialItem in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 30 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
               Write(financialItem.PARTNER_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
               Write(financialItem.DATE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
               Write(financialItem.AMOUNT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
#nullable restore
#line 34 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", null, new { id = financialItem.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    ");
#nullable restore
#line 35 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", null, new { id = financialItem.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 38 "C:\Users\User\Desktop\10xONECode\10XOne.Web\Views\FinancialItems\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<_10XOne.Core.Models.FinancialItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591