#pragma checksum "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\EXIWARE\EXIWARE\Pages\Shared\Admin\_AdminAll\_AdminAdminOpts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b42ab6b808221d540b5eae8ab54a9d9a337c94ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_Admin__AdminAll__AdminAdminOpts), @"mvc.1.0.view", @"/Pages/Shared/Admin/_AdminAll/_AdminAdminOpts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b42ab6b808221d540b5eae8ab54a9d9a337c94ce", @"/Pages/Shared/Admin/_AdminAll/_AdminAdminOpts.cshtml")]
    public class Pages_Shared_Admin__AdminAll__AdminAdminOpts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<ul class=""nav nav-tabs"" id=""AdminOpts"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" id=""AdminInsert-tab"" data-toggle=""tab"" href=""#AdminInsert"" role=""tab"" aria-controls=""AdminInsert"" aria-selected=""true"">Ingresar</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""AdminModify-tab"" data-toggle=""tab"" href=""#AdminModify"" role=""tab"" aria-controls=""AdminModify"" aria-selected=""false"">Modificar</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""AllAdmins-tab"" data-toggle=""tab"" href=""#AllAdmins"" role=""tab"" aria-controls=""AllAdmins"" aria-selected=""false"">Administradores</a>
    </li>
</ul>
<div class=""tab-content"" id=""AdminOptsContent"">
    <div class=""tab-pane fade show active"" id=""AdminInsert"" role=""tabpanel"" aria-labelledby=""AdminInsert-tab"">
        ");
#nullable restore
#line 14 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\EXIWARE\EXIWARE\Pages\Shared\Admin\_AdminAll\_AdminAdminOpts.cshtml"
   Write(Html.Partial("Admin/_AdminAll/_AdminInsert"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"tab-pane fade\" id=\"AdminModify\" role=\"tabpanel\" aria-labelledby=\"AdminModify-tab\">\r\n        ");
#nullable restore
#line 17 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\EXIWARE\EXIWARE\Pages\Shared\Admin\_AdminAll\_AdminAdminOpts.cshtml"
   Write(Html.Partial("Admin/_AdminAll/_AdminModify"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"tab-pane fade\" id=\"AllAdmins\" role=\"tabpanel\" aria-labelledby=\"AllAdmins-tab\">\r\n        ");
#nullable restore
#line 20 "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\EXIWARE\EXIWARE\Pages\Shared\Admin\_AdminAll\_AdminAdminOpts.cshtml"
   Write(Html.Partial("Admin/_AdminAll/_AdminTableAll"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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