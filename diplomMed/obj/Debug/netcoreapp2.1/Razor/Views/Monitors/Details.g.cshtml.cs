#pragma checksum "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bb6833dee3ad4df575ceac072091d526186c7d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monitors_Details), @"mvc.1.0.view", @"/Views/Monitors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monitors/Details.cshtml", typeof(AspNetCore.Views_Monitors_Details))]
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
#line 1 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\_ViewImports.cshtml"
using diplomMed;

#line default
#line hidden
#line 2 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\_ViewImports.cshtml"
using diplomMed.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bb6833dee3ad4df575ceac072091d526186c7d5", @"/Views/Monitors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb8118d1b551ad4c376b65a6b0e8d27901a9cec6", @"/Views/_ViewImports.cshtml")]
    public class Views_Monitors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<diplomMed.Models.Monitor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Monitor</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(200, 39, false);
#line 14 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ekg));

#line default
#line hidden
            EndContext();
            BeginContext(239, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(283, 35, false);
#line 17 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ekg));

#line default
#line hidden
            EndContext();
            BeginContext(318, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(362, 38, false);
#line 20 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(400, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(444, 34, false);
#line 23 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ad));

#line default
#line hidden
            EndContext();
            BeginContext(478, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(522, 40, false);
#line 26 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Kapn));

#line default
#line hidden
            EndContext();
            BeginContext(562, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(606, 36, false);
#line 29 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Kapn));

#line default
#line hidden
            EndContext();
            BeginContext(642, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(686, 44, false);
#line 32 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pulsoxxx));

#line default
#line hidden
            EndContext();
            BeginContext(730, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(774, 40, false);
#line 35 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pulsoxxx));

#line default
#line hidden
            EndContext();
            BeginContext(814, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(858, 44, false);
#line 38 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Diagonal));

#line default
#line hidden
            EndContext();
            BeginContext(902, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(946, 40, false);
#line 41 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Diagonal));

#line default
#line hidden
            EndContext();
            BeginContext(986, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1030, 41, false);
#line 44 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Resol));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1115, 37, false);
#line 47 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Resol));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1196, 41, false);
#line 50 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Equip));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1281, 40, false);
#line 53 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Equip.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1321, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1368, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ea9f8cc75394a7899f099bdf5f906ad", async() => {
                BeginContext(1414, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\sasha\source\repos\diplomMed\diplomMed\Views\Monitors\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1422, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1430, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32b443c0037e405a9123931162dc31d1", async() => {
                BeginContext(1452, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1468, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<diplomMed.Models.Monitor> Html { get; private set; }
    }
}
#pragma warning restore 1591
