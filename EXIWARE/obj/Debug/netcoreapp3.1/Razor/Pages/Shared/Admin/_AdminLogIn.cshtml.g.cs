#pragma checksum "E:\AIIF\SegAll\ENTERPRISE\WEB\BACK\NET\EJERCICIOS\EXIWARE\EXIWARE\Pages\Shared\Admin\_AdminLogIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "082031a38575b2f312948133c667025072670ded"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_Admin__AdminLogIn), @"mvc.1.0.view", @"/Pages/Shared/Admin/_AdminLogIn.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"082031a38575b2f312948133c667025072670ded", @"/Pages/Shared/Admin/_AdminLogIn.cshtml")]
    public class Pages_Shared_Admin__AdminLogIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""adminlogin"" style=""display: inline"">
    <div class=""form-group w-25"" >
        <label class=""control-label"" for=""Identificación:"">ID:</label>
        <input type=""text"" class=""form-control hidden"" 
            oninput=""this.value = this.value.replace(/[^0-9.]/g, '').replace(/(\..*)\./g, '$1');"" 
            name=""id"" id=""id"" placeholder=""Ingresa tu ID"" value=""123456789"">
    </div>
    <div class=""form-group w-25"">
        <label class=""control-label"" for=""Contraseña:"">Password</label>
        <input type=""password"" class=""form-control"" name=""pss"" id=""pss"" placeholder=""Ingresa tu password""
        value=""admin"">
    </div>
    <button type=""submit"" class=""btn btn-primary"" onclick=""login()"">Login</button>
</div>
<script>
    function login(){
        http = senddatas( 'api/LoginAdmin', 'POST', false, 
                JSON.stringify(
                {   'id':document.getElementById(""id"").value,
                    'pss':document.getElementById(""pss"").value
                } 
     ");
            WriteLiteral(@"       )
        );
        if(http.status == 200) {
            if( http.responseText.includes(""Ok"") ){
                ModalInfoShow( ""Status"", ""Sesión iniciada, presiona cerrar para continuar"" ).onclick = function(){location.reload();};
            }
        }else{
            ModalInfoShow( ""Error!!!"", http.responseText+"""" ).onclick = function(){
                    location.reload();
            };
        }
        return;
        var http = new XMLHttpRequest();
        var url = 'api/LoginAdmin';
        http.open('POST', url, false);
        http.setRequestHeader('Content-type', 'application/json')
        http.onreadystatechange = function() {
            if( http.readyState!=4 ){
                return;
            }
            if(http.status == 200) {
                if( http.responseText.includes(""Ok"") ){
                    ModalInfoShow( ""Status"", ""Sesión iniciada, presiona cerrar para continuar"" ).onclick = function(){location.reload();};
                }
            ");
            WriteLiteral(@"}else{
                ModalInfoShow( ""Error!!!"", http.responseText+"""" ).onclick = function(){
                        location.reload();
                };
            }
        }
        http.send(JSON.stringify(
            {   'id':document.getElementById(""id"").value,
                'pss':document.getElementById(""pss"").value
            } 
        ))
        document.getElementById(""id"").value = """";
        document.getElementById(""pss"").value = """";
        alert( http.responseText );//ModalInfoShow( """", """" );
    }
</script>
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