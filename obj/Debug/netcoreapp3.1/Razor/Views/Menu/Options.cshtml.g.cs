#pragma checksum "/Users/adrianavelasco/Projects/ExampleOne/ExampleOne/Views/Menu/Options.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b130980c0b69b6f484f12e64c473fed4175543"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Options), @"mvc.1.0.view", @"/Views/Menu/Options.cshtml")]
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
#line 1 "/Users/adrianavelasco/Projects/ExampleOne/ExampleOne/Views/_ViewImports.cshtml"
using ExampleOne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/adrianavelasco/Projects/ExampleOne/ExampleOne/Views/_ViewImports.cshtml"
using ExampleOne.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35b130980c0b69b6f484f12e64c473fed4175543", @"/Views/Menu/Options.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3c58f51070e74dcfb015149aa402d8c6f7503f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Options : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MyDrinks>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/adrianavelasco/Projects/ExampleOne/ExampleOne/Views/Menu/Options.cshtml"
  
    ViewData["Title"] = "Su's C & T";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .col-lg-6 {\r\n        justify-content: center;\r\n    }\r\n\r\n\n</style>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35b130980c0b69b6f484f12e64c473fed41755433309", async() => {
                WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"" style=""font-family:papyrus;"">Su's Coffee & Tea Stop</h1>
    </div>
    <div class=""row"" >
        <div class=""col-sm col-lg-7"" >
            <h1 style=""font-family:papyrus;""><u>Classics</u></h1>
            <ul>
                <li><h2 style=""font-family:papyrus;""><a href=""/Home/Index#section-1"">Ube Series</a></h2></li>
                <li><h2 style=""font-family:papyrus;""><a href=""/Home/Index#section-2"">Cold Foam Series</a></h2></li>
                <li><h2 style=""font-family:papyrus;""><a href=""/Home/Index#section-4"">Iced Coffee Series</a></h2></li>
            </ul>
        </div>
        <div class=""col-sm col-lg-5"">
            <img src=""coffee.jpg"" width=""250"" height=""150"">
        </div>
    </div>
    <br />
    <div class=""row "">
        <div class=""col-sm col-lg-7"">
            <h1 style=""font-family:papyrus;""><u>Seasonal</u></h1>
            <ul>
                <li><h2 style=""font-family:papyrus;""><a href=""/Home/Index#section-3"">Lemonade ");
                WriteLiteral(@"Series</a></h2></li>
                <li><h2 style=""font-family:papyrus;""><a href=""/Home/Index#section-5"">Tea Series</a></h2></li>
            </ul>
        </div>
        <div class=""col-sm col-lg-5"">
            <img src=""rose_jar.jpg"" width=""200"" height=""250"">
        </div>
        </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MyDrinks>> Html { get; private set; }
    }
}
#pragma warning restore 1591
