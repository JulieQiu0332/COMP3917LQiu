#pragma checksum "C:\Users\julie\Desktop\COMP3973\lab02_MVC\Views\File\Content.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19ce8a380025294a0b7a3f68a33e600126629d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_File_Content), @"mvc.1.0.view", @"/Views/File/Content.cshtml")]
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
#line 1 "C:\Users\julie\Desktop\COMP3973\lab02_MVC\Views\_ViewImports.cshtml"
using lab02_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\julie\Desktop\COMP3973\lab02_MVC\Views\_ViewImports.cshtml"
using lab02_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ce8a380025294a0b7a3f68a33e600126629d60", @"/Views/File/Content.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dd236a14322375bcc8968cb68dd8a647cf687ae", @"/Views/_ViewImports.cshtml")]
    public class Views_File_Content : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\julie\Desktop\COMP3973\lab02_MVC\Views\File\Content.cshtml"
  
    ViewData["Title"] = "File Content";
    string content = ViewBag.Content as string;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>");
#nullable restore
#line 9 "C:\Users\julie\Desktop\COMP3973\lab02_MVC\Views\File\Content.cshtml"
Write(content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
