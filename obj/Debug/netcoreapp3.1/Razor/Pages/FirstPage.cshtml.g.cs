#pragma checksum "C:\Users\swapn\source\repos\LearningNewSkills\Pages\FirstPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67500932df808de037a056b274a4511d86df2cfe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LearningNewSkills.Pages.Pages_FirstPage), @"mvc.1.0.razor-page", @"/Pages/FirstPage.cshtml")]
namespace LearningNewSkills.Pages
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
#line 1 "C:\Users\swapn\source\repos\LearningNewSkills\Pages\_ViewImports.cshtml"
using LearningNewSkills;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67500932df808de037a056b274a4511d86df2cfe", @"/Pages/FirstPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc4916933736d215dfd07e4e68f6492da636881", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FirstPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div>This is my first page.</div>\r\n    <div>");
#nullable restore
#line 6 "C:\Users\swapn\source\repos\LearningNewSkills\Pages\FirstPage.cshtml"
    Write(DateTime.Now.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LearningNewSkills.Pages.FirstPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LearningNewSkills.Pages.FirstPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LearningNewSkills.Pages.FirstPageModel>)PageContext?.ViewData;
        public LearningNewSkills.Pages.FirstPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
