#pragma checksum "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91447f7b1fd0bfa584d6a34b270a1e31f561e278"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Order_OrderHistory), @"mvc.1.0.view", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
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
#line 1 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\_ViewImports.cshtml"
using ASP.NET_Core_Spice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\_ViewImports.cshtml"
using ASP.NET_Core_Spice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91447f7b1fd0bfa584d6a34b270a1e31f561e278", @"/Areas/Customer/Views/Order/OrderHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b46a5e275ffaaa71a587b5932f903fd1a5026bf3", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Order_OrderHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASP.NET_Core_Spice.Models.ViewModels.OrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CreateButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
  
    ViewData["Title"] = "OrderHistory";
    Layout = "~/Views/Shared/_Layout.cshtml";   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"border backgroundWhite\">\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <h2 class=\"text-info\">\r\n                Order Histories\r\n            </h2>\r\n        </div>\r\n\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91447f7b1fd0bfa584d6a34b270a1e31f561e2784224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 21 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
         if (Model.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped border\">\r\n            <tr class=\"table-secondary\">\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(m => m.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(m => m.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(m => m.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(m => m.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayNameFor(m => m.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Total Items\r\n                </th>\r\n                <th></th>               \r\n            </tr>\r\n\r\n");
#nullable restore
#line 46 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayFor(m => item.OrderHeader.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayFor(m => item.OrderHeader.PickupName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayFor(m => item.OrderHeader.ApplicationUser.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayFor(m => item.OrderHeader.PickUpTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayFor(m => item.OrderHeader.OrderTotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
               Write(Html.DisplayFor(m => item.OrderDetails.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button type=\"submit\" class=\"btn btn-success anchorDetail\" data-id=\"");
#nullable restore
#line 68 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
                                                                                   Write(item.OrderHeader.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\r\n                        <i class=\"far fa-list-alt\"></i> Details\r\n                    </button>\r\n                </td>              \r\n            </tr>               \r\n");
#nullable restore
#line 73 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 75 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No categories available...</p>\r\n");
#nullable restore
#line 79 "D:\Project\ASP.NET-Core_Master\ASP.NET_Core_Spice\ASP.NET_Core_Spice\Areas\Customer\Views\Order\OrderHistory.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASP.NET_Core_Spice.Models.ViewModels.OrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
