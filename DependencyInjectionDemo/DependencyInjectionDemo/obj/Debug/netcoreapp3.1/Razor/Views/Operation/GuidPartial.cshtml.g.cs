#pragma checksum "F:\test\DependencyInjection\DependencyInjectionDemo\DependencyInjectionDemo\Views\Operation\GuidPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02c8dd6cabb0d7b4a763df18b76d58328e11b550"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operation_GuidPartial), @"mvc.1.0.view", @"/Views/Operation/GuidPartial.cshtml")]
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
#line 1 "F:\test\DependencyInjection\DependencyInjectionDemo\DependencyInjectionDemo\Views\_ViewImports.cshtml"
using DependencyInjectionDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\test\DependencyInjection\DependencyInjectionDemo\DependencyInjectionDemo\Views\_ViewImports.cshtml"
using DependencyInjectionDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\test\DependencyInjection\DependencyInjectionDemo\DependencyInjectionDemo\Views\Operation\GuidPartial.cshtml"
using DependencyInjectionDemo.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02c8dd6cabb0d7b4a763df18b76d58328e11b550", @"/Views/Operation/GuidPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7503816a0d6eb9df3650c9a76a61b6e68f5c00ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Operation_GuidPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div>\r\n        <h2>GuidItem Shows</h2>\r\n\r\n        <h3>TransientGuid: ");
#nullable restore
#line 13 "F:\test\DependencyInjection\DependencyInjectionDemo\DependencyInjectionDemo\Views\Operation\GuidPartial.cshtml"
                      Write(OperationTransientRepository.GetOperationId());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n        <h3>ScopedGuid: ");
#nullable restore
#line 15 "F:\test\DependencyInjection\DependencyInjectionDemo\DependencyInjectionDemo\Views\Operation\GuidPartial.cshtml"
                   Write(OperationScopeRepository.GetOperationId());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n        <h3>SingletonGuid: ");
#nullable restore
#line 17 "F:\test\DependencyInjection\DependencyInjectionDemo\DependencyInjectionDemo\Views\Operation\GuidPartial.cshtml"
                      Write(OperationSingletonRepository.GetOperationId());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOperationSingletonRepository OperationSingletonRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOperationScopeRepository OperationScopeRepository { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOperationTransientRepository OperationTransientRepository { get; private set; }
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