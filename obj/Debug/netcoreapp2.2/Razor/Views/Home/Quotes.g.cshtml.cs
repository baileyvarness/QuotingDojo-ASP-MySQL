#pragma checksum "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/Home/Quotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "325db50161d69d55bfd6a3654289d040ea49ce90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Quotes), @"mvc.1.0.view", @"/Views/Home/Quotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Quotes.cshtml", typeof(AspNetCore.Views_Home_Quotes))]
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
#line 1 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo;

#line default
#line hidden
#line 2 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325db50161d69d55bfd6a3654289d040ea49ce90", @"/Views/Home/Quotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Quotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dictionary<string, object>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 19, true);
            WriteLiteral("\n<h1>Quotes</h1>\n\n\n");
            EndContext();
#line 6 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/Home/Quotes.cshtml"
 foreach (var quote in Model)
{


#line default
#line hidden
            BeginContext(92, 12, true);
            WriteLiteral("        <p>\"");
            EndContext();
            BeginContext(105, 18, false);
#line 9 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/Home/Quotes.cshtml"
       Write(quote["YourQuote"]);

#line default
#line hidden
            EndContext();
            BeginContext(123, 18, true);
            WriteLiteral("\"</p>\n        <p>-");
            EndContext();
            BeginContext(142, 17, false);
#line 10 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/Home/Quotes.cshtml"
       Write(quote["YourName"]);

#line default
#line hidden
            EndContext();
            BeginContext(159, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(161, 19, false);
#line 10 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/Home/Quotes.cshtml"
                          Write(quote["created_at"]);

#line default
#line hidden
            EndContext();
            BeginContext(180, 18, true);
            WriteLiteral("</p>\n        <hr>\n");
            EndContext();
#line 12 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/QuotingDojo/Views/Home/Quotes.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dictionary<string, object>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
