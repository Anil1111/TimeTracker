#pragma checksum "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7b03c85b3bcc34a3bc33fe2f84ef797f0cae17d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monthly_Index), @"mvc.1.0.view", @"/Views/Monthly/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monthly/Index.cshtml", typeof(AspNetCore.Views_Monthly_Index))]
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
#line 1 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\_ViewImports.cshtml"
using TimeTracker;

#line default
#line hidden
#line 2 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\_ViewImports.cshtml"
using TimeTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7b03c85b3bcc34a3bc33fe2f84ef797f0cae17d", @"/Views/Monthly/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8c56ab343f349f22663e19dc431a27361c7a97", @"/Views/_ViewImports.cshtml")]
    public class Views_Monthly_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeTracker.Models.UserCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 101, true);
            WriteLiteral("\r\n<h1>Month Links</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n\r\n    </thead>\r\n    <tbody>\r\n        ");
            EndContext();
            BeginContext(198, 82, false);
#line 15 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\Index.cshtml"
   Write(Html.RouteLink("January", new { action = "IndexMonth1", controller = "Monthly", }));

#line default
#line hidden
            EndContext();
            BeginContext(280, 26, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TimeTracker.Models.UserCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
