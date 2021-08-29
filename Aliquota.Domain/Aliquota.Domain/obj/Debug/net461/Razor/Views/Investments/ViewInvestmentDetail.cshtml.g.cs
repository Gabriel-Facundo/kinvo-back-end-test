#pragma checksum "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fde83610e9f38fb46486f8f3f64e6159184ada7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Investments_ViewInvestmentDetail), @"mvc.1.0.view", @"/Views/Investments/ViewInvestmentDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Investments/ViewInvestmentDetail.cshtml", typeof(AspNetCore.Views_Investments_ViewInvestmentDetail))]
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
#line 1 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\_ViewImports.cshtml"
using Aliquota.Domain;

#line default
#line hidden
#line 2 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\_ViewImports.cshtml"
using Aliquota.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fde83610e9f38fb46486f8f3f64e6159184ada7c", @"/Views/Investments/ViewInvestmentDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a945cf6aa20908a1d46f86c17747c3215055b8f", @"/Views/_ViewImports.cshtml")]
    public class Views_Investments_ViewInvestmentDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aliquota.Domain.Models.Investment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewInvestments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveInvestment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius:4px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
  
    int monthsQuantity = ((DateTime.Now.Month - @Model.DayOfInvestment.Month) + ((DateTime.Now.Year - Model.DayOfInvestment.Year) * 12));
    double initialAmount = Model.InitialAmount;
    double actualProfit = initialAmount;
    for(int i = 0; i< monthsQuantity; i++)
    {
        actualProfit = actualProfit + actualProfit * 0.05;
    }
    actualProfit -= initialAmount;

#line default
#line hidden
            BeginContext(435, 24, true);
            WriteLiteral("<div>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(459, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dca878afc8e44f9d94dbf4114ea41b6f", async() => {
                BeginContext(491, 112, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Voltar\" class=\"btn btn-default\" style=\"border-radius:3px\" />\r\n        ");
                EndContext();
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
            EndContext();
            BeginContext(607, 73, true);
            WriteLiteral("\r\n    </p>\r\n</div>\r\n<br />\r\n<h3 style=\"text-align:center\">Investments of ");
            EndContext();
            BeginContext(681, 18, false);
#line 21 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                        Write(Model.InvestorName);

#line default
#line hidden
            EndContext();
            BeginContext(699, 43, true);
            WriteLiteral("</h3>\r\n<br />\r\n<p>\r\n    Day of investment: ");
            EndContext();
            BeginContext(743, 41, false);
#line 24 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                  Write(Model.DayOfInvestment.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(784, 34, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Initial amount: $");
            EndContext();
            BeginContext(819, 19, false);
#line 27 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                Write(Model.InitialAmount);

#line default
#line hidden
            EndContext();
            BeginContext(838, 53, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Amount of years passed until today: ");
            EndContext();
            BeginContext(893, 17, false);
#line 30 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                    Write(monthsQuantity/12);

#line default
#line hidden
            EndContext();
            BeginContext(911, 54, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Amount of months passed until today: ");
            EndContext();
            BeginContext(966, 14, false);
#line 33 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                    Write(monthsQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(980, 52, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Amount of days passed until today: ");
            EndContext();
            BeginContext(1034, 42, false);
#line 36 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                   Write((DateTime.Now-@Model.DayOfInvestment).Days);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 70, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Total profit based 5%/month with compound interest: $");
            EndContext();
            BeginContext(1148, 78, false);
#line 39 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                                    Write(actualProfit.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(1226, 32, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Total amount: $");
            EndContext();
            BeginContext(1259, 13, false);
#line 42 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
              Write(initialAmount);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 4, true);
            WriteLiteral(" + $");
            EndContext();
            BeginContext(1277, 78, false);
#line 42 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                Write(actualProfit.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 4, true);
            WriteLiteral(" = $");
            EndContext();
            BeginContext(1361, 94, false);
#line 42 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                                                                                                    Write((initialAmount+actualProfit).ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(1456, 16, true);
            WriteLiteral("\r\n</p>\r\n<br />\r\n");
            EndContext();
            BeginContext(1472, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12d60c40a8194b618da93affc18ad182", async() => {
                BeginContext(1579, 26, true);
                WriteLiteral("Simulate a date do remove?");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\gfacu\Desktop\C#\Aliquota.Domain Test\Aliquota.Domain\Aliquota.Domain\Views\Investments\ViewInvestmentDetail.cshtml"
                                   WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1609, 134, true);
            WriteLiteral("\r\n<br />\r\n\r\n<p style=\"font-size:80%\">\r\n    Don\'t worry, if you are sure, we will calculated your and our profit in the next page\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aliquota.Domain.Models.Investment> Html { get; private set; }
    }
}
#pragma warning restore 1591
