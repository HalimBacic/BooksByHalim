#pragma checksum "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db5f69ca3349ce87fe9f16893e958cf80f2bd267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\_ViewImports.cshtml"
using BooksByHalim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\_ViewImports.cshtml"
using BooksByHalim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5f69ca3349ce87fe9f16893e958cf80f2bd267", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4465a67325670e7b2302675200119fd8c5d9c7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BooksByHalim.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RateBook", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mycontainer\" style=\"border-top:solid 2px black; border-bottom:solid 2px black\">\r\n        <div class=\"left_side\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 270, "\"", 304, 1);
#nullable restore
#line 11 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
WriteAttributeValue("", 276, Url.Content(item.ImagePath), 276, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"300\" width=\"180\" alt=\"IMAGE\" />\r\n        </div>\r\n\r\n        <div class=\"center_side\">\r\n            <table class=\"table table-hover\">\r\n                <tbody>\r\n                    <tr>\r\n                        <td colspan=\"3\">");
#nullable restore
#line 18 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"3\">");
#nullable restore
#line 21 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"3\">");
#nullable restore
#line 24 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <td colspan=\"3\">");
#nullable restore
#line 27 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                    </tr>\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n\r\n        <div class=\"right_side\">\r\n            <h3> Rating: </h3>\r\n            <h2> ");
#nullable restore
#line 36 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
            Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 1297, "\"", 1305, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db5f69ca3349ce87fe9f16893e958cf80f2bd2677300", async() => {
                WriteLiteral("Rate this");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
                                                                                       WriteLiteral(item.Name);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 42 "D:\BooksBayHalim\BooksByHalim\BooksByHalim\Views\Books\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BooksByHalim.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
