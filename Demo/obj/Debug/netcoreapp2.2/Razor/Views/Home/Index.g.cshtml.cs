#pragma checksum "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea31abe5ab4447b76a6daee5b2d650fbf83fe51a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Ivan\source\repos\Demo\Demo\Views\_ViewImports.cshtml"
using Demo;

#line default
#line hidden
#line 2 "C:\Users\Ivan\source\repos\Demo\Demo\Views\_ViewImports.cshtml"
using Demo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea31abe5ab4447b76a6daee5b2d650fbf83fe51a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18407c5b9dabc62761fc6cdd8f67817f22bc556", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Demo.Models.DemoStatistic>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(92, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
 if (User?.Identity?.IsAuthenticated ?? false)
{


#line default
#line hidden
            BeginContext(151, 70, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome, ");
            EndContext();
            BeginContext(222, 18, false);
#line 12 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
                                  Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(240, 19, true);
            WriteLiteral("</h1>\r\n    </div>\r\n");
            EndContext();
            BeginContext(261, 104, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(366, 40, false);
#line 19 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
            EndContext();
            BeginContext(406, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(474, 46, false);
#line 22 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Population));

#line default
#line hidden
            EndContext();
            BeginContext(520, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(683, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(756, 39, false);
#line 32 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
            EndContext();
            BeginContext(795, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(875, 45, false);
#line 35 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Population));

#line default
#line hidden
            EndContext();
            BeginContext(920, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(987, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 41 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1031, 119, true);
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome, to see statistic please log in</h1>\r\n    </div>\r\n");
            EndContext();
#line 47 "C:\Users\Ivan\source\repos\Demo\Demo\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Demo.Models.DemoStatistic>> Html { get; private set; }
    }
}
#pragma warning restore 1591
