#pragma checksum "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "216938c95d46869fffb5609213627c1a5bac7360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pets_Details), @"mvc.1.0.view", @"/Views/Pets/Details.cshtml")]
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
#line 1 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\_ViewImports.cshtml"
using PetAdopt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\_ViewImports.cshtml"
using PetAdopt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"216938c95d46869fffb5609213627c1a5bac7360", @"/Views/Pets/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65ead564819bb3f119d0c0c2dad59db942a70379", @"/Views/_ViewImports.cshtml")]
    public class Views_Pets_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PetAdopt.Models.Pet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Pet</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.PetType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Adopted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Adopted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateRegistered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateRegistered));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateAdopted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateAdopted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Breed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Breed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HouseTrained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.HouseTrained));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdoptionFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdoptionFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "216938c95d46869fffb5609213627c1a5bac736016083", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\SourceCode\PetAdopt\Views\Pets\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "216938c95d46869fffb5609213627c1a5bac736018255", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PetAdopt.Models.Pet> Html { get; private set; }
    }
}
#pragma warning restore 1591