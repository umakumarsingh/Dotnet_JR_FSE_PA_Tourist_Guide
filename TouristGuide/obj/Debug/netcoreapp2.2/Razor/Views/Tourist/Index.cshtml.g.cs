#pragma checksum "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69eccd59ec050b220a0f47cbf7241d8cb9807c73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tourist_Index), @"mvc.1.0.view", @"/Views/Tourist/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tourist/Index.cshtml", typeof(AspNetCore.Views_Tourist_Index))]
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
#line 1 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\_ViewImports.cshtml"
using TouristGuide;

#line default
#line hidden
#line 2 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\_ViewImports.cshtml"
using TouristGuide.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69eccd59ec050b220a0f47cbf7241d8cb9807c73", @"/Views/Tourist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42e6067a946f12667a5bca57837da501ff6d5d30", @"/Views/_ViewImports.cshtml")]
    public class Views_Tourist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TouristGuide.BusinessLayer.ViewModels.PlaceViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(102, 344, true);
            WriteLiteral(@"<div class=""jumbotron p-3 p-md-5 text-white rounded bg-dark"">
    <div class=""col-md-6 px-0"">
        <h1 class=""display-4 font-italic"">Popular In India</h1>
        <p class=""lead my-3"">India is a home to the finest architectural heritage, serene ghats, spectacular landscapes and largest tiger reserve.</p>
        <p class=""lead mb-0""><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 446, "\"", 524, 1);
#line 9 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
WriteAttributeValue("", 453, Url.Action("AboutIndia","Tourist", new { @class = "btn btn-primary" }), 453, 71, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 153, true);
            WriteLiteral(" class=\"text-white font-weight-bold\">Continue reading...</a></p>\r\n    </div>\r\n</div>\r\n<h1 class=\"text-center\">All destination for a memorable trip</h1>\r\n");
            EndContext();
#line 13 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
 if (Model.PageCount() == 0)
{

#line default
#line hidden
            BeginContext(711, 101, true);
            WriteLiteral("    <tr>\r\n        <td style=\"color:red;\" colspan=\"12\">\r\n            Records not found |\r\n            ");
            EndContext();
            BeginContext(813, 85, false);
#line 18 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
       Write(Html.ActionLink("Go To Home", "Index", "Tourist", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(898, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 21 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(938, 24, true);
            WriteLiteral("<div class=\"row mb-2\">\r\n");
            EndContext();
#line 25 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
     foreach (var place in Model.PaginatedPlace())
    {

#line default
#line hidden
            BeginContext(1021, 270, true);
            WriteLiteral(@"        <div class=""col-md-6"">
            <div class=""card flex-md-row mb-4 box-shadow h-auto"">
                <div class=""card-body d-flex flex-column align-items-start"">
                    <strong class=""d-inline-block mb-2 text-primary"">Place By Experiences :- ");
            EndContext();
            BeginContext(1292, 17, false);
#line 30 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
                                                                                        Write(place.Experiences);

#line default
#line hidden
            EndContext();
            BeginContext(1309, 104, true);
            WriteLiteral("</strong>\r\n                    <h3 class=\"mb-0\">\r\n                        <a class=\"text-dark\" href=\"#\">");
            EndContext();
            BeginContext(1414, 10, false);
#line 32 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
                                                 Write(place.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1424, 95, true);
            WriteLiteral("</a>\r\n                    </h3>\r\n                    <div class=\"mb-1 text-muted\">Attraction : ");
            EndContext();
            BeginContext(1520, 16, false);
#line 34 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
                                                         Write(place.Attraction);

#line default
#line hidden
            EndContext();
            BeginContext(1536, 57, true);
            WriteLiteral("</div>\r\n                    <p class=\"card-text mb-auto\">");
            EndContext();
            BeginContext(1594, 17, false);
#line 35 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
                                            Write(place.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1611, 28, true);
            WriteLiteral("</p>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1639, "\"", 1739, 1);
#line 36 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
WriteAttributeValue("", 1646, Url.Action("Details","Tourist", new { PlaceId = place.PlaceId, @class = "btn btn-primary" }), 1646, 93, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1740, 83, true);
            WriteLiteral(">Continue reading</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 40 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1830, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 42 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1841, 25, true);
            WriteLiteral("<ul class=\"pagination\">\r\n");
            EndContext();
#line 44 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
     for (int i = 1; i <= Model.PageCount(); i++)
    {

#line default
#line hidden
            BeginContext(1924, 11, true);
            WriteLiteral("        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1935, "\"", 2003, 1);
#line 46 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
WriteAttributeValue("", 1943, i == Model.CurrentPage ? "page-item active" : "page-item", 1943, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2004, 35, true);
            WriteLiteral(">\r\n            <a class=\"page-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2039, "\"", 2084, 1);
#line 47 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
WriteAttributeValue("", 2046, Url.Action("Index", new { page = i }), 2046, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2085, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2087, 1, false);
#line 47 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"
                                                                          Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(2088, 21, true);
            WriteLiteral("</a>\r\n        </li>\r\n");
            EndContext();
#line 49 "D:\IIHT DATA\InMemory Artifacts_3.0\TouristGuide_CleanCode\TouristGuide\Views\Tourist\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(2118, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TouristGuide.BusinessLayer.ViewModels.PlaceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
