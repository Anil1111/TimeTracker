#pragma checksum "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74c2d4c88769e925aee399827f220ff7f0b5625b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monthly_IndexMonth11), @"mvc.1.0.view", @"/Views/Monthly/IndexMonth11.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Monthly/IndexMonth11.cshtml", typeof(AspNetCore.Views_Monthly_IndexMonth11))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74c2d4c88769e925aee399827f220ff7f0b5625b", @"/Views/Monthly/IndexMonth11.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea8c56ab343f349f22663e19dc431a27361c7a97", @"/Views/_ViewImports.cshtml")]
    public class Views_Monthly_IndexMonth11 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TimeTracker.Models.UserCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml"
  
    ViewData["Title"] = "IndexMonth11";

#line default
#line hidden
            BeginContext(103, 107, true);
            WriteLiteral("\r\n<h1>November</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(211, 50, false);
#line 13 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(261, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(317, 48, false);
#line 16 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml"
           Write(Html.DisplayNameFor(model => model.MinutesSpent));

#line default
#line hidden
            EndContext();
            BeginContext(365, 88, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
            EndContext();
#line 23 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(502, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(541, 49, false);
#line 26 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.Title));

#line default
#line hidden
            EndContext();
            BeginContext(590, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(618, 47, false);
#line 27 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml"
               Write(Html.DisplayFor(modelItem => item.MinutesSpent));

#line default
#line hidden
            EndContext();
            BeginContext(665, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\Daniel\source\repos\TimeTracker\TimeTracker\Views\Monthly\IndexMonth11.cshtml"
        }

#line default
#line hidden
            BeginContext(702, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(968, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
            BeginContext(998, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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