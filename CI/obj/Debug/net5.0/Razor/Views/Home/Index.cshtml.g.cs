#pragma checksum "C:\CI Platform\CI\CI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d8f33b4f63a9bf549a8cbe61305277ccfc88b5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\CI Platform\CI\CI\Views\_ViewImports.cshtml"
using CI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CI Platform\CI\CI\Views\_ViewImports.cshtml"
using CI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8f33b4f63a9bf549a8cbe61305277ccfc88b5e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756e72740a7df003d728fc5d214fd68fbd91fa66", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\CI Platform\CI\CI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d8f33b4f63a9bf549a8cbe61305277ccfc88b5e3938", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Log in</title>
    <link rel=""stylesheet"" href=""./css/login.css"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Nunito+Sans:wght@200;300;400;600;700;800;900&family=Roboto:wght@100;300;400;700&display=swap""
          rel=""stylesheet"">
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css"" rel=""stylesheet""
          integrity=""sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD"" crossorigin=""anonymous"">
    <!-- Slick -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick.css""
          integrity=""sha512-wR4oNhLBHf7smjy0K4oqzdWumd+r5/+6QO/vDda76MW5iug4PT7v86FoEkySIJft3XA0Ae6ax");
                WriteLiteral(@"hIvHrqwm793Nw==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick-theme.css"" integrity=""sha512-6lLUdeQ5uheMFbWm3CP271l14RsX1xtx+J5x2yeIDkkiBpeVTNhTqijME7GgRKKi6hCqovwCoBTlRBEC20M8Mg=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick.min.css"" integrity=""sha512-yHknP1/AwR+yx26cB1y0cjvQUMvEa2PFzt1c9LlS4pRQ5NOTZFWbhBig+X9G9eYW/8m0/4OXNx8pxJ6z57x0dw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d8f33b4f63a9bf549a8cbe61305277ccfc88b5e6662", async() => {
                WriteLiteral(@"
    <div class=""main-cont"">
        <div class=""slider poster-main-container"">
            <div class=""poster-container"">
                <img src=""./images/Grow-Trees-On-the-path-to-environment-sustainability-login.png""
                     alt=""Grow more trees"">
                <div class=""linear-try""></div>
                <div class=""poster-content"">
                    <p class=""poster-title"">Sed ut perspiciatis unde omnis iste natus voluptatem</p>
                    <p class=""poster-desc"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ea, perspiciatis
                        ipsa? Ad animi doloremque
                        dolor itaque? Non sed explicabo quaerat. Eum ipsam earum, impedit eius veniam iste inventore
                        minus
                        explicabo, doloribus modi provident nihil odio.
                    </p>
                </div>
            </div>
            <div class=""poster-container"">
                <img src=");
                WriteLiteral(@"""./images/Grow-Trees-On-the-path-to-environment-sustainability-login.png""
                     alt=""Grow more trees"">
                <div class=""linear-try""></div>
                <div class=""poster-content"">
                    <p class=""poster-title"">Sed ut perspiciatis unde omnis iste natus voluptatem</p>
                    <p class=""poster-desc"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ea, perspiciatis
                        ipsa? Ad animi doloremque
                        dolor itaque? Non sed explicabo quaerat. Eum ipsam earum, impedit eius veniam iste inventore
                        minus
                        explicabo, doloribus modi provident nihil odio.
                    </p>
                </div>
            </div>
            <div class=""poster-container"">
                <img src=""./images/Grow-Trees-On-the-path-to-environment-sustainability-login.png""
                     alt=""Grow more trees"">
                <div class=""line");
                WriteLiteral(@"ar-try""></div>
                <div class=""poster-content"">
                    <p class=""poster-title"">Sed ut perspiciatis unde omnis iste natus voluptatem</p>
                    <p class=""poster-desc"">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Ea, perspiciatis
                        ipsa? Ad animi doloremque
                        dolor itaque? Non sed explicabo quaerat. Eum ipsam earum, impedit eius veniam iste inventore
                        minus
                        explicabo, doloribus modi provident nihil odio.
                    </p>
                </div>
            </div>
        </div>
        <div class=""login-container"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d8f33b4f63a9bf549a8cbe61305277ccfc88b5e9803", async() => {
                    WriteLiteral(@"
                <div>
                    <label for=""email"">Email Address</label><br>
                    <input type=""email"" id=""email"" placeholder=""Enter Your Email"" required>
                </div>
                <div>
                    <label for=""password"">Password</label><br>
                    <input type=""password"" id=""password"" placeholder=""Enter Password"" required>
                </div>
                <button type=""submit"">Login</button>
                <p class=""mt-3 text-center""><a href=""./../Forgot-Password/Forgot.html"" class=""text-dark"">Lost Your Password ?</a></p>
                <p class=""mt-0 text-center"">Don’t have an account? <a href=""./../Registration-Page/Registration.html"">Create an account</a></p>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <a href=\"#\" class=\"privacy-policy\">Privacy Policy</a>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral(@"
<!-- Slick -->
<script src=""https://code.jquery.com/jquery-3.6.3.min.js""
        integrity=""sha256-pvPw+upLPUjgMXY0G+8O0xUf+/Im1MZjXxxgOcBQBXU="" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/slick-carousel/1.8.1/slick.min.js""
        integrity=""sha512-XtmMtDEcNz2j7ekrtHvOVR4iwwaD6o/FUJe6+Zq+HgcCsk3kj4uSQQR8weQ2QVj1o0Pk6PwYLohm206ZzNfubg==""
        crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js""
        integrity=""sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN""
        crossorigin=""anonymous""></script>
<script>
    $('.slider').slick({
        infinite: true,
        slidesToShow: 1,
        slidesToScroll: 1,
        // fade : true,
        autoplay : true,
        dots : true,
        arrows : false
    });
</script>

</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
