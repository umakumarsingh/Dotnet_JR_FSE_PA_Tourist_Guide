#pragma checksum "D:\IIHT\Task-11\InMemory\TouristGuide\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07f67aa491ac635cc2aa3a432f450196442ba987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
#line 1 "D:\IIHT\Task-11\InMemory\TouristGuide\Views\_ViewImports.cshtml"
using TouristGuide;

#line default
#line hidden
#line 2 "D:\IIHT\Task-11\InMemory\TouristGuide\Views\_ViewImports.cshtml"
using TouristGuide.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f67aa491ac635cc2aa3a432f450196442ba987", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e6067a946f12667a5bca57837da501ff6d5d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<TouristGuide.Entities.Destination>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 48, true);
            WriteLiteral("<ul class=\"navbar-nav flex-grow-1 float-left\">\r\n");
            EndContext();
#line 3 "D:\IIHT\Task-11\InMemory\TouristGuide\Views\Shared\Components\TopMenu\Default.cshtml"
     foreach (var item in Model)
    {
        var url = item.Url;
        var target = "_self";

        if (url.StartsWith("~"))
        {
            url = Url.Content(url);
        }
        if (item.OpenInNewWindow)
        {
            target = "_blank";
        }

#line default
#line hidden
            BeginContext(382, 58, true);
            WriteLiteral("        <li class=\"nav-item\"><a class=\"nav-link text-dark\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 440, "\"", 451, 1);
#line 16 "D:\IIHT\Task-11\InMemory\TouristGuide\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 447, url, 447, 4, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("target", " target=\"", 452, "\"", 468, 1);
#line 16 "D:\IIHT\Task-11\InMemory\TouristGuide\Views\Shared\Components\TopMenu\Default.cshtml"
WriteAttributeValue("", 461, target, 461, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(469, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(471, 9, false);
#line 16 "D:\IIHT\Task-11\InMemory\TouristGuide\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(480, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 17 "D:\IIHT\Task-11\InMemory\TouristGuide\Views\Shared\Components\TopMenu\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(498, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<TouristGuide.Entities.Destination>> Html { get; private set; }
    }
}
#pragma warning restore 1591
