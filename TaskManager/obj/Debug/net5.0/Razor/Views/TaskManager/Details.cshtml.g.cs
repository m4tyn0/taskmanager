<<<<<<< Updated upstream
#pragma checksum "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "879bd0cc6078095265625a1ceeb79f8a320428f0"
=======
#pragma checksum "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "890a54a9073f4de1ab94ed1d45978c28c57ffd2a"
>>>>>>> Stashed changes
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TaskManager_Details), @"mvc.1.0.view", @"/Views/TaskManager/Details.cshtml")]
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
#line 1 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/_ViewImports.cshtml"
using TaskManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/_ViewImports.cshtml"
using TaskManager.Models;

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
#nullable restore
#line 2 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
using TaskManager.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879bd0cc6078095265625a1ceeb79f8a320428f0", @"/Views/TaskManager/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"769665f143f4b1f12903ebc8dc30fc33d7f5a735", @"/Views/_ViewImports.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"890a54a9073f4de1ab94ed1d45978c28c57ffd2a", @"/Views/TaskManager/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d85dcc713d4f2a4c9670ea3b0aa59ecf8d2afb", @"/Views/_ViewImports.cshtml")]
>>>>>>> Stashed changes
    public class Views_TaskManager_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManager.Models.TaskUnit>
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
<<<<<<< Updated upstream
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
   ViewData["Title"] = "details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>details</h1>\r\n<div class=\"d-flex justify-content-around\">\r\n    <div class=\"card w-25 centrvolby\">\r\n\r\n\r\n        <dl class=\"p2  \">\r\n            <dt class=\"col-sm-5\">\r\n                ");
#nullable restore
#line 15 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));
=======
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
  
    ViewData["Title"] = "Details";
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-5\">\r\n                ");
#nullable restore
#line 21 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Content));
=======
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n \r\n    <hr />\r\n    <dl class=\"row card center\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayFor(model => model.Content));
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-5\">\r\n                ");
#nullable restore
#line 27 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.tag));
=======
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Content));
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 30 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayFor(model => model.tag));
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
       Write(Html.DisplayFor(model => model.Content));
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-5\">\r\n                ");
#nullable restore
#line 33 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TimeCreated));
=======
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.tag));
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 36 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
           Write(Html.DisplayFor(model => model.TimeCreated));
=======
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
       Write(Html.DisplayFor(model => model.tag));
>>>>>>> Stashed changes

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        <div class=\"text-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879bd0cc6078095265625a1ceeb79f8a320428f07251", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-fill\" fill=\"black\"></i>");
=======
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "890a54a9073f4de1ab94ed1d45978c28c57ffd2a5992", async() => {
                WriteLiteral("Edit");
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
#line 41 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
                                   WriteLiteral(Model.Id);
=======
#line 34 "/Users/matyno/Desktop/CODE/EriaLabs/TaskManager/TaskManager/Views/TaskManager/Details.cshtml"
                           WriteLiteral(Model.Id);
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
            WriteLiteral(" |\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "879bd0cc6078095265625a1ceeb79f8a320428f09437", async() => {
                WriteLiteral("back to list");
=======
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "890a54a9073f4de1ab94ed1d45978c28c57ffd2a8116", async() => {
                WriteLiteral("Back to List");
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
=======
            WriteLiteral("\r\n</div>\r\n");
>>>>>>> Stashed changes
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManager.Models.TaskUnit> Html { get; private set; }
    }
}
#pragma warning restore 1591
