#pragma checksum "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f22618f0cd132473901791b9b25739e12f97ebbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photo_Index), @"mvc.1.0.view", @"/Views/Photo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Photo/Index.cshtml", typeof(AspNetCore.Views_Photo_Index))]
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
#line 1 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f22618f0cd132473901791b9b25739e12f97ebbc", @"/Views/Photo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Photo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication1.Models.Photo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
  
    ViewData["Title"] = "View";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 28, true);
            WriteLiteral("\r\n<h2>View</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(167, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c6c04ac6d444859d0f1c46af5f1096", async() => {
                BeginContext(190, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(204, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(297, 41, false);
#line 17 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Titre));

#line default
#line hidden
            EndContext();
            BeginContext(338, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(394, 40, false);
#line 20 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Vues));

#line default
#line hidden
            EndContext();
            BeginContext(434, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(490, 44, false);
#line 23 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UrlHttps));

#line default
#line hidden
            EndContext();
            BeginContext(534, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 29 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(652, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(701, 40, false);
#line 32 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titre));

#line default
#line hidden
            EndContext();
            BeginContext(741, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(797, 39, false);
#line 35 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Vues));

#line default
#line hidden
            EndContext();
            BeginContext(836, 59, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 895, "\"", 915, 1);
#line 38 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
WriteAttributeValue("", 901, item.UrlHttps, 901, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(916, 110, true);
            WriteLiteral(" class=\"vignette\"/>\r\n                \r\n                \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1027, 65, false);
#line 43 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1113, 60, false);
#line 44 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new {  id=item.Cle  }));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1194, 69, false);
#line 45 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\coir3\source\repos\WebApplication1\WebApplication1\Views\Photo\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1302, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication1.Models.Photo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
