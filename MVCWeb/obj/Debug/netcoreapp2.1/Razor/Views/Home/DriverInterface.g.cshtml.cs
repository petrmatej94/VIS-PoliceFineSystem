#pragma checksum "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c89ea0f6856e95d4c45f2c46a360f7bf4e211a9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DriverInterface), @"mvc.1.0.view", @"/Views/Home/DriverInterface.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DriverInterface.cshtml", typeof(AspNetCore.Views_Home_DriverInterface))]
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
#line 1 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\_ViewImports.cshtml"
using MVCWeb;

#line default
#line hidden
#line 2 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\_ViewImports.cshtml"
using MVCWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c89ea0f6856e95d4c45f2c46a360f7bf4e211a9c", @"/Views/Home/DriverInterface.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cde97a53175d408997593a1ef495533ac7364c09", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DriverInterface : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectVIS.Models.Record>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
  
    ViewData["Title"] = "Driver Interface";

#line default
#line hidden
            BeginContext(81, 50, true);
            WriteLiteral("\n<br />\n<br />\n<h2>Driver Interface</h2>\n\n<hr />\n\n");
            EndContext();
#line 12 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
 foreach (ProjectVIS.Models.Record rec in @ViewBag.recordsList)
{

#line default
#line hidden
            BeginContext(197, 26, true);
            WriteLiteral("    <p><strong>Record ID: ");
            EndContext();
            BeginContext(224, 6, false);
#line 14 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
                     Write(rec.ID);

#line default
#line hidden
            EndContext();
            BeginContext(230, 30, true);
            WriteLiteral("</strong></p>\n    <p>Ammount: ");
            EndContext();
            BeginContext(261, 11, false);
#line 15 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
           Write(rec.Ammount);

#line default
#line hidden
            EndContext();
            BeginContext(272, 26, true);
            WriteLiteral("</p>\n    <p>Points Taken: ");
            EndContext();
            BeginContext(299, 15, false);
#line 16 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
                Write(rec.PointsTaken);

#line default
#line hidden
            EndContext();
            BeginContext(314, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 17 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
     if (rec.PaidDate == null)
    {

#line default
#line hidden
            BeginContext(356, 64, true);
            WriteLiteral("        <p>Paid date:<strong> NOT PAID YET</strong></p>\n        ");
            EndContext();
            BeginContext(420, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42d0d9ca6c5b457aabe4ba1d51630c88", async() => {
                BeginContext(469, 43, true);
                WriteLiteral("\n            <input type=\"hidden\" name=\"ID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 512, "\"", 527, 1);
#line 21 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
WriteAttributeValue("", 520, rec.ID, 520, 7, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(528, 64, true);
                WriteLiteral(" />\n            <button type=\"submit\">Zaplatit</button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(599, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 24 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(621, 22, true);
            WriteLiteral("        <p>Paid date: ");
            EndContext();
            BeginContext(644, 12, false);
#line 27 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
                 Write(rec.PaidDate);

#line default
#line hidden
            EndContext();
            BeginContext(656, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 28 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"
    }

#line default
#line hidden
            BeginContext(667, 22, true);
            WriteLiteral("    <hr />\n    <br />\n");
            EndContext();
#line 31 "C:\Users\PMate\OneDrive\Plocha\Škola\5. Semestr\git\ProjectVIS\MVCWeb\Views\Home\DriverInterface.cshtml"


}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectVIS.Models.Record> Html { get; private set; }
    }
}
#pragma warning restore 1591
