#pragma checksum "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fceb6020a0c290d5c28820470f49afa96d697eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperHero_GetHerosByName), @"mvc.1.0.view", @"/Views/SuperHero/GetHerosByName.cshtml")]
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
#line 1 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\_ViewImports.cshtml"
using HerosWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\_ViewImports.cshtml"
using HerosWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fceb6020a0c290d5c28820470f49afa96d697eaf", @"/Views/SuperHero/GetHerosByName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b3de5e45da17b4871b00c2b8baba2ee3e319bf", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperHero_GetHerosByName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HerosDB.Models.SuperHero>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetHeros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
  
    ViewData["Title"] = "GetHerosByName";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetHerosByName</h1>\r\n\r\n<div>\r\n    <h4>SuperHero</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayNameFor(model => model.RealName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayFor(model => model.RealName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayNameFor(model => model.Alias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayFor(model => model.Alias));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayNameFor(model => model.HideOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
       Write(Html.DisplayFor(model => model.HideOut));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 40 "C:\Revature\201019-Uta-UiPath\training-code\3-Asp.Net Core\HerosApp\HerosWeb\Views\SuperHero\GetHerosByName.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fceb6020a0c290d5c28820470f49afa96d697eaf7082", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HerosDB.Models.SuperHero> Html { get; private set; }
    }
}
#pragma warning restore 1591
