#pragma checksum "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "372c816ea1779de8e5e85701416ede4c8beb527c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Main.cshtml", typeof(MyApp.Namespace.Home.Views_Home_Main))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"372c816ea1779de8e5e85701416ede4c8beb527c", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_Commerce.Models.MainWrapper>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 33, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(70, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372c816ea1779de8e5e85701416ede4c8beb527c3355", async() => {
                BeginContext(76, 198, true);
                WriteLiteral("\n    <meta charset=\"UTF-8\">\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\n    <link rel=\"stylesheet\" href=\"css/style.css\" type=\"text/css\">    \n    <title>Sucess</title>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(281, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(282, 1199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372c816ea1779de8e5e85701416ede4c8beb527c4727", async() => {
                BeginContext(288, 71, true);
                WriteLiteral("\n    <a href = \"logout\">Logout</a>\n    <br/>\n    <br/>\n    <h1>Welcome ");
                EndContext();
                BeginContext(360, 28, false);
#line 14 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
           Write(Model.RegisterUser.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(388, 171, true);
                WriteLiteral(":</h1>\n\n    <h1>Dashboard | <a href=\"products\">Products</a> | <a href=\"orders\">Orders</a> | <a href=\"customers\">Customers</a> | <a href=\"\">Settings</a></h1>\n    <div>\n    ");
                EndContext();
                BeginContext(559, 97, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "372c816ea1779de8e5e85701416ede4c8beb527c5726", async() => {
                    BeginContext(565, 84, true);
                    WriteLiteral("\n        <input type=\"text\"/>\n        <input type = \"submit\" value = \"Filter\"/>\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(656, 52, true);
                WriteLiteral("\n    </div>\n    <div>\n    <div class=\"allproducts\">\n");
                EndContext();
#line 25 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
         foreach(var product in Model.ThreeProducts)
        {

#line default
#line hidden
                BeginContext(771, 58, true);
                WriteLiteral("            <div class=\"productlist\">\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 829, "\"", 849, 1);
#line 28 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
WriteAttributeValue("", 835, product.Image, 835, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(850, 21, true);
                WriteLiteral(">\n                <p>");
                EndContext();
                BeginContext(872, 19, false);
#line 29 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
              Write(product.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(891, 25, true);
                WriteLiteral("</p>\n                <p>(");
                EndContext();
                BeginContext(917, 23, false);
#line 30 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
               Write(product.QuantityInStore);

#line default
#line hidden
                EndContext();
                BeginContext(940, 36, true);
                WriteLiteral(" left)</p>\n            </div>      \n");
                EndContext();
#line 32 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
        }

#line default
#line hidden
                BeginContext(986, 88, true);
                WriteLiteral("    </div>\n    <a href=\"products\">Show more Products...</a>\n    <h1>Recent Orders:</h1>\n");
                EndContext();
#line 36 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
     foreach(var order in Model.ThreeOrders)
    {

#line default
#line hidden
                BeginContext(1125, 12, true);
                WriteLiteral("        <h5>");
                EndContext();
                BeginContext(1138, 19, false);
#line 38 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
       Write(order.Customer.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1157, 11, true);
                WriteLiteral(" purchased ");
                EndContext();
                BeginContext(1169, 19, false);
#line 38 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
                                      Write(order.OrderQuantity);

#line default
#line hidden
                EndContext();
                BeginContext(1188, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1190, 25, false);
#line 38 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
                                                           Write(order.Product.ProductName);

#line default
#line hidden
                EndContext();
                BeginContext(1215, 6, true);
                WriteLiteral("</h5>\n");
                EndContext();
#line 39 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
    }

#line default
#line hidden
                BeginContext(1227, 72, true);
                WriteLiteral("    <a href=\"orders\">Show all Orders...</a>\n    <h1>New Customers:</h1>\n");
                EndContext();
#line 42 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
     foreach(var customer in Model.ThreeCustomers)
    {

#line default
#line hidden
                BeginContext(1356, 12, true);
                WriteLiteral("        <h5>");
                EndContext();
                BeginContext(1369, 13, false);
#line 44 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
       Write(customer.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1382, 24, true);
                WriteLiteral(" joined the store.</h5>\n");
                EndContext();
#line 45 "/Users/skylermilliken/Documents/CODINGDOJO/C##/Assignments/E_Commerce/Views/Home/Main.cshtml"
    }

#line default
#line hidden
                BeginContext(1412, 62, true);
                WriteLiteral("    <a href=\"customers\">Show all Customers...</a>\n    </div>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1481, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Commerce.Models.MainWrapper> Html { get; private set; }
    }
}
#pragma warning restore 1591