#pragma checksum "/Users/melcabrera/Desktop/Projects/Wiki/COPC_Wiki/Views/Home/Article.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd6cf740cb22961bbddc96ab2560016b59985ce2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Article), @"mvc.1.0.view", @"/Views/Home/Article.cshtml")]
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
#line 1 "/Users/melcabrera/Desktop/Projects/Wiki/COPC_Wiki/Views/_ViewImports.cshtml"
using COPC_Wiki;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/melcabrera/Desktop/Projects/Wiki/COPC_Wiki/Views/_ViewImports.cshtml"
using COPC_Wiki.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd6cf740cb22961bbddc96ab2560016b59985ce2", @"/Views/Home/Article.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf2e3b65f5bc4bca831bb9dd824b5c1d83916f88", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Article : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<COPC_Wiki.Models.Articles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"contentbody\">");
#nullable restore
#line 4 "/Users/melcabrera/Desktop/Projects/Wiki/COPC_Wiki/Views/Home/Article.cshtml"
                        Write(Html.Raw(@Model.wikiArticles[0].content));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
 <style>
     
    .WikiPage  .container {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        height: 100%;
        
    }
    .WikiPage .container .p {
        text-transform: uppercase;
        font-weight: bold;
        font-size: 2.5em;


    }
    .WikiPage .container .contentbody p img
    {
        width: 60%;
        position: relative;
        display: block;
        margin-left: auto;
        margin-right: auto;
    }
    .contentbody
    {
        padding-top: 5% !important;
        height: 100%;
        color: black;
        text-shadow:10px 10px 10px rgba(0,0,0,.3);
        width: inherit;
    }
    .WikiPage  a {
        position: relative;
    }
    
    .WikiPage  p 
    {
        text-transform: uppercase;
        font-size: 1em;
        letter-spacing: 0.1em;
        
        font-weight: bold;
        margin-top: 20px;
    }

 </style>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<COPC_Wiki.Models.Articles> Html { get; private set; }
    }
}
#pragma warning restore 1591
