#pragma checksum "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a28a81d2125bb418fe61618f41d9d747cc63641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
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
#line 1 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\_ViewImports.cshtml"
using _0306191183_Buoi2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\_ViewImports.cshtml"
using _0306191183_Buoi2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a28a81d2125bb418fe61618f41d9d747cc63641", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9204bd2723bc505d9a84442918ae3636a2f4c9c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Account>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class="" table table-hover table-light"">
    <thead class=""table-primary"">
        <tr class=""text-center"">
            <th>Username</th>
            <th>Password</th>
            <th>Phone</th>
            <th>Birthday</th>
            <th>Email</th>
            <th>Status</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
         foreach (Account p in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td class=\"font-weight-bold\"> ");
#nullable restore
#line 18 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                                     Write(p.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"font-weight-bold\"> ");
#nullable restore
#line 19 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                                     Write(p.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\"> ");
#nullable restore
#line 20 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                                Write(p.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 21 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                               Write(p.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\"> ");
#nullable restore
#line 22 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                                Write(p.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">\r\n");
#nullable restore
#line 24 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                 if (p.Status == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"text-danger\">C??n s??? d???ng</span> ");
#nullable restore
#line 25 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                                                              }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>H???t s??? d???ng</span>");
#nullable restore
#line 27 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button class=\"btn btn-outline-primary\">S???a</button>\r\n                <button class=\"btn btn-outline-danger\">X??a</button>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 35 "D:\Study\ASP.NET\0306191183_Buoi2\0306191183_Buoi2\Views\Accounts\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Account>> Html { get; private set; }
    }
}
#pragma warning restore 1591
