#pragma checksum "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88941dfca75f713afc1a00e45da7b1745864baf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilisateur_DeleteUser), @"mvc.1.0.view", @"/Views/Utilisateur/DeleteUser.cshtml")]
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
#line 1 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\_ViewImports.cshtml"
using WebCMSJIR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\_ViewImports.cshtml"
using WebCMSJIR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
using WebCMSJIR.Views.Utilisateur;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
using Oracle.ManagedDataAccess.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88941dfca75f713afc1a00e45da7b1745864baf1", @"/Views/Utilisateur/DeleteUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff12f2f1c28b66ce037e3e0bcf76c921bdbbd6b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilisateur_DeleteUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cmxform form-horizontal tasi-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Utilisateur/Supprimer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
  
    ViewData["Title"] = "DeleteUser";
    var id = ViewBag.Message;
    FonctionUser user3 = new FonctionUser();
    OracleDataReader sql = user3.AfficherUser(id);
    sql.Read();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-sm-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"" id=""modifier""><h3 class=""panel-title"">Suppression d'un utilisateur</h3></div>
            <div class=""panel-body"">
                <div class="" form"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88941dfca75f713afc1a00e45da7b1745864baf15400", async() => {
                WriteLiteral(@"

                        <div class=""form-group "">
                            <label for=""ID"" class=""control-label col-lg-2"">Identifiant</label>
                            <div class=""col-lg-10"">
                                <input class="" form-control""  name=""ID"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 980, "\"", 1005, 1);
#nullable restore
#line 23 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
WriteAttributeValue("", 988, sql.GetString(0), 988, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group "">
                            <label for=""nom"" class=""control-label col-lg-2"">Nom</label>
                            <div class=""col-lg-10"">
                                <input class="" form-control"" id=""nom"" name=""nom"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1362, "\"", 1387, 1);
#nullable restore
#line 29 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
WriteAttributeValue("", 1370, sql.GetString(1), 1370, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group "">
                            <label for=""mdp"" class=""control-label col-lg-2"">Mot de passe</label>
                            <div class=""col-lg-10"">
                                <input class=""form-control "" id=""mdp"" name=""mdp"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 1753, "\"", 1778, 1);
#nullable restore
#line 35 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
WriteAttributeValue("", 1761, sql.GetString(2), 1761, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group "">
                            <label for=""mdp"" class=""control-label col-lg-2"">Catégorie</label>
                            <div class=""col-lg-10"">
                                <input class=""form-control "" id=""cat"" name=""cat"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2141, "\"", 2166, 1);
#nullable restore
#line 41 "D:\CMS\WebCMSJIR\WebCMSJIR\Views\Utilisateur\DeleteUser.cshtml"
WriteAttributeValue("", 2149, sql.GetString(3), 2149, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-lg-offset-2 col-lg-10"">
                                <input type=""submit"" value=""Supprimer"" class=""btn btn-success "">
                                <input type=""reset"" value=""Annuler"" class=""btn btn-default"">
                            </div>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div> <!-- .form -->\r\n            </div> <!-- panel-body -->\r\n        </div> <!-- panel -->\r\n    </div> <!-- col -->\r\n</div><!-- content -->\r\n");
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