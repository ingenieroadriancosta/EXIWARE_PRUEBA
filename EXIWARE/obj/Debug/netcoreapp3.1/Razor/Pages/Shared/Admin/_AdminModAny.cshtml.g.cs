#pragma checksum "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\EXIWARE\EXIWARE\Pages\Shared\Admin\_AdminModAny.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "436de7b9a755db58bf57ed347d071c0388151747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_Admin__AdminModAny), @"mvc.1.0.view", @"/Pages/Shared/Admin/_AdminModAny.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"436de7b9a755db58bf57ed347d071c0388151747", @"/Pages/Shared/Admin/_AdminModAny.cshtml")]
    public class Pages_Shared_Admin__AdminModAny : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""form-group  w-25 "">
    <label for=""sel1"">Opciones:</label>
    <select class=""form-control form-control-sm"" id=""ProcsSelect"" onchange = ""ShowHideDivSelect()"">
        Opciones:
        <option>Buscar</option>
        <option>Agregar</option>
        <option>Modificar</option>
    </select>
</div>

");
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
