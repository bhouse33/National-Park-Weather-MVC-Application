#pragma checksum "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "762ad95aada0a7bed31babf0aec2756fdc33a897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_Index), @"mvc.1.0.view", @"/Views/Survey/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/Index.cshtml", typeof(AspNetCore.Views_Survey_Index))]
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
#line 1 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#line 2 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"762ad95aada0a7bed31babf0aec2756fdc33a897", @"/Views/Survey/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9b07c050a0c51332b819e62acfb82d2ccb8e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Park>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("survey-park-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
            BeginContext(63, 92, true);
            WriteLiteral("\r\n<h2>Top Parks By Number of Surveys Submitted as Favorite</h2>\r\n<div class=\"surveys\">\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
 foreach (Park park in Model)
{

#line default
#line hidden
            BeginContext(189, 33, true);
            WriteLiteral("    <div class=\"park-survey\">\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
     if (park.Surveys.Count > 0)
    {

#line default
#line hidden
            BeginContext(263, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(271, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d6faf53f633d4d369ed593fb95cf16c4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 307, "~/images/img/parks/", 307, 19, true);
#line 17 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
AddHtmlAttributeValue("", 326, park.ParkCode, 326, 16, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 342, ".jpg", 342, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(350, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(354, 31, true);
            WriteLiteral("        <h3 class=\"park-name\"> ");
            EndContext();
            BeginContext(386, 13, false);
#line 19 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
                          Write(park.ParkName);

#line default
#line hidden
            EndContext();
            BeginContext(399, 8, true);
            WriteLiteral(" </h3>\r\n");
            EndContext();
            BeginContext(409, 26, true);
            WriteLiteral("        <h5 class=\"count\">");
            EndContext();
            BeginContext(436, 18, false);
#line 21 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
                     Write(park.Surveys.Count);

#line default
#line hidden
            EndContext();
            BeginContext(454, 25, true);
            WriteLiteral(" Surveys Submitted</h5>\r\n");
            EndContext();
#line 22 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(486, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 24 "C:\Users\Brandon House\Pairs\capstones\c-module-3-capstone-team-5\WebApplication.Web\Views\Survey\Index.cshtml"
}

#line default
#line hidden
            BeginContext(501, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Park>> Html { get; private set; }
    }
}
#pragma warning restore 1591