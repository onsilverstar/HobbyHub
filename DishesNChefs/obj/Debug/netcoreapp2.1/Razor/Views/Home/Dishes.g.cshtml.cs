#pragma checksum "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46feb5001ba481077485b929d5d6d17047fd1252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\_ViewImports.cshtml"
using ChefsDishes;

#line default
#line hidden
#line 2 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\_ViewImports.cshtml"
using ChefsDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46feb5001ba481077485b929d5d6d17047fd1252", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4173e1c09328e4989c76d1431c897dfcd73c0666", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dish>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "newdish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(26, 60, true);
            WriteLiteral("<nav class=\"nav\">\r\n    <a>Chefs</a>\r\n    <a>Dishes</a>\r\n    ");
            EndContext();
            BeginContext(86, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce8e2e1e763b4289b876ffeb2b3f600b", async() => {
                BeginContext(132, 10, true);
                WriteLiteral("Add a Dish");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(146, 323, true);
            WriteLiteral(@"
</nav>
<table class=""table"">
    <thead>
        <tr>
            <td><strong><em>Name</em></strong></td>
            <td><strong><em>Chef</em></strong></td>
            <td><strong><em>Tastiness</em></strong></td>
            <td><strong><em>Calories</em></strong></td>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 17 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\Home\Dishes.cshtml"
          foreach(var y in Model)
        {

#line default
#line hidden
            BeginContext(513, 22, true);
            WriteLiteral("<tr>\r\n            <td>");
            EndContext();
            BeginContext(536, 10, false);
#line 19 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\Home\Dishes.cshtml"
           Write(y.DishName);

#line default
#line hidden
            EndContext();
            BeginContext(546, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(570, 14, false);
#line 20 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\Home\Dishes.cshtml"
           Write(y.Creator.Name);

#line default
#line hidden
            EndContext();
            BeginContext(584, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(608, 11, false);
#line 21 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\Home\Dishes.cshtml"
           Write(y.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(619, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(643, 10, false);
#line 22 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\Home\Dishes.cshtml"
           Write(y.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(653, 34, true);
            WriteLiteral("</td>\r\n            \r\n        </tr>");
            EndContext();
#line 24 "C:\Users\v-sijumb\Desktop\Coding Dojo\Chefs N Dishes\ChefsDishes\DishesNChefs\Views\Home\Dishes.cshtml"
             }

#line default
#line hidden
            BeginContext(691, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591