#pragma checksum "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\Mahasiswa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33c581dd384de9baa1433d20975480a2327d2cea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mahasiswa_Index), @"mvc.1.0.view", @"/Views/Mahasiswa/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mahasiswa/Index.cshtml", typeof(AspNetCore.Views_Mahasiswa_Index))]
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
#line 1 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\_ViewImports.cshtml"
using WorkshopASPCore21;

#line default
#line hidden
#line 2 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\_ViewImports.cshtml"
using WorkshopASPCore21.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33c581dd384de9baa1433d20975480a2327d2cea", @"/Views/Mahasiswa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54b66eb411a9618835f574c2d306170a8c010866", @"/Views/_ViewImports.cshtml")]
    public class Views_Mahasiswa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WorkshopASPCore21.Models.Mahasiswa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 291, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6"">
        <h2>Daftar Mahasiswa</h2>

        <table class=""table table-striped"">
            <tr>
                <th>Nim</th>
                <th>Nama</th>
                <th>IPK</th>
                <th>Email</th>
            </tr>
");
            EndContext();
#line 14 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\Mahasiswa\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(397, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(444, 8, false);
#line 17 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\Mahasiswa\Index.cshtml"
                   Write(item.Nim);

#line default
#line hidden
            EndContext();
            BeginContext(452, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(484, 9, false);
#line 18 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\Mahasiswa\Index.cshtml"
                   Write(item.Nama);

#line default
#line hidden
            EndContext();
            BeginContext(493, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(525, 8, false);
#line 19 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\Mahasiswa\Index.cshtml"
                   Write(item.IPK);

#line default
#line hidden
            EndContext();
            BeginContext(533, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(565, 10, false);
#line 20 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\Mahasiswa\Index.cshtml"
                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(575, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 22 "D:\Workshop\2020\WorkshopACCI\WorkshopASPCore21\WorkshopASPCore21\Views\Mahasiswa\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(620, 40, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WorkshopASPCore21.Models.Mahasiswa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
