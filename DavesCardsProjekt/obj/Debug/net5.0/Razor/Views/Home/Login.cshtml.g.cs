#pragma checksum "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d573a417e7feeb5ffe96af784b0ceeb026b4f51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 1 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/_ViewImports.cshtml"
using DavesCardsProjekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/_ViewImports.cshtml"
using DavesCardsProjekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d573a417e7feeb5ffe96af784b0ceeb026b4f51", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968db0c93e089245195235eecf9c9e8052acd12a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DavesCardsProjekt.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"acc-head\">\n    <h3>Välkommen!</h3>\n </div>\n\n<div class=\"acc-container\">\n\n");
#nullable restore
#line 9 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
     using (Html.BeginForm()) //Skickar värden till controller HomeController
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Logga in</h3>\n        <div class=\"Loggain\">\n            <p>Användarnamn</p>\n            <div> ");
#nullable restore
#line 14 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
             Write(Html.EditorFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div> <br />\n            <p>Lösenord</p>\n            <div> ");
#nullable restore
#line 16 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
             Write(Html.PasswordFor(m => m.Passw));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div> <br />\n            <button type=\"submit\" name=\"loggain\"> Logga in </button>\n        </div>\n");
            WriteLiteral("        <div class=\"errormsg\">\n            <br />\n            <p> ");
#nullable restore
#line 22 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
           Write(ViewBag.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n        </div>\n");
#nullable restore
#line 24 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 26 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
     using (Html.BeginForm("Register", "Home", FormMethod.Post)) //Skickar inmatade värden till HomeController
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Skapa konto </h3>\n        <div class=\"Loggain\">\n            <p>Användarnamn</p>\n            <div div=\"inmatning\"> ");
#nullable restore
#line 31 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
                             Write(Html.EditorFor(m => m.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div> <br />\n            <p>E-postadress</p>\n            <div div=\"inmatning\"> ");
#nullable restore
#line 33 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
                             Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div> <br />\n            <p>Lösenord</p>\n            <div div=\"inmatning\"> ");
#nullable restore
#line 35 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"
                             Write(Html.PasswordFor(m => m.Passw));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div> <br />\n            <button type=\"submit\" name=\"skapakonto\"> Skapa konto</button>\n\n        </div>\n");
#nullable restore
#line 39 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Home/Login.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DavesCardsProjekt.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591