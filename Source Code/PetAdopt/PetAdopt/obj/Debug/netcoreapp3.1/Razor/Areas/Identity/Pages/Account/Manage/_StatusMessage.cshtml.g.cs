#pragma checksum "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf0ba0e017fe2d5d40e06cba52017213983ba34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__StatusMessage), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
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
#line 1 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\_ViewImports.cshtml"
using PetAdopt.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\_ViewImports.cshtml"
using PetAdopt.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using PetAdopt.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using PetAdopt.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf0ba0e017fe2d5d40e06cba52017213983ba34", @"/Areas/Identity/Pages/Account/Manage/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca70e40306e0aa404956c459fd483b5322f6c81", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0f703c7eaeb3515b4c2b52f3f9c8cec664b5da5", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e73612431326794a4d47605ff047881d3747d0d", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
#line 6 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
#line 8 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 10 "\\Mac\Dropbox\Personal\5_Study\2_Apps\SilverwarePos_Interview\Source Code\PetAdopt\PetAdopt\Areas\Identity\Pages\Account\Manage\_StatusMessage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
