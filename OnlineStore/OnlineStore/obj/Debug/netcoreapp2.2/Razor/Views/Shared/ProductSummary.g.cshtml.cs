#pragma checksum "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\CourseProject\docs\OnlineStore\OnlineStore\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b87e8d4c467bd17d777bd553f323d7989c063819"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductSummary.cshtml", typeof(AspNetCore.Views_Shared_ProductSummary))]
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
#line 1 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\CourseProject\docs\OnlineStore\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore.Models;

#line default
#line hidden
#line 3 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\CourseProject\docs\OnlineStore\OnlineStore\Views\_ViewImports.cshtml"
using OnlineStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b87e8d4c467bd17d777bd553f323d7989c063819", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa3f2ecc62dab1970212be85913077d718bb244", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 150, true);
            WriteLiteral("    <div class=\"card card-outline-primary m-1 p-1\">\r\n        <div class=\"p-1\" style=\"background-color: burlywood\">\r\n            <h4>\r\n                ");
            EndContext();
            BeginContext(167, 10, false);
#line 5 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\CourseProject\docs\OnlineStore\OnlineStore\Views\Shared\ProductSummary.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(177, 112, true);
            WriteLiteral("\r\n                <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                    <small>");
            EndContext();
            BeginContext(290, 25, false);
#line 7 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\CourseProject\docs\OnlineStore\OnlineStore\Views\Shared\ProductSummary.cshtml"
                      Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(315, 101, true);
            WriteLiteral("</small>\r\n                </span>\r\n            </h4>\r\n        </div>\r\n    <div class=\"card-text p-1\">");
            EndContext();
            BeginContext(417, 17, false);
#line 11 "C:\Users\kensk\OneDrive\Desktop\MSSA\Projects\CourseProject\docs\OnlineStore\OnlineStore\Views\Shared\ProductSummary.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(434, 16, true);
            WriteLiteral("</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
