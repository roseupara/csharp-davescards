#pragma checksum "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f488198c4ba1c91e3fe97c63da54ccd12ee676e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Pokemon), @"mvc.1.0.view", @"/Views/Shop/Pokemon.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f488198c4ba1c91e3fe97c63da54ccd12ee676e5", @"/Views/Shop/Pokemon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"968db0c93e089245195235eecf9c9e8052acd12a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Pokemon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DavesCardsProjekt.Models.Card>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    <div class=\"container-rubrik\">\n        <h3>Pokemon</h3>\n    </div>\n\n    <div class=\"container\">\n\n        <div class=\"card-container\">\n");
#nullable restore
#line 10 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml"
             foreach (var card in Model) //Loopar ut inneh??llet fr??n modellen, som finns lagrat i databasen. 
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\n                    <div class=\"card-top\">\n\n                        <h1 class=\"card-title\"> ");
#nullable restore
#line 15 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml"
                                           Write(Html.DisplayFor(m => card.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                        <p class=\"card-price\"> ");
#nullable restore
#line 16 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml"
                                          Write(Html.DisplayFor(m => card.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" KR </p>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f488198c4ba1c91e3fe97c63da54ccd12ee676e54691", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 611, "~/cardsimg/", 611, 11, true);
#nullable restore
#line 17 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml"
AddHtmlAttributeValue("", 622, Html.DisplayFor(m => card.ImgPath), 622, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <p class=\"card-descript\"> ");
#nullable restore
#line 18 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml"
                                             Write(Html.DisplayFor(m => card.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-stock\"> Antal: ");
#nullable restore
#line 19 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml"
                                                 Write(Html.DisplayFor(m => card.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <button class=\"tocart-btn\"><p>L??gg i varukorg</p></button>\n\n                    </div>\n                </div>\n");
#nullable restore
#line 24 "/Users/roseupara/Desktop/DavesCardsProjekt/DavesCardsProjekt/Views/Shop/Pokemon.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DavesCardsProjekt.Models.Card>> Html { get; private set; }
    }
}
#pragma warning restore 1591
