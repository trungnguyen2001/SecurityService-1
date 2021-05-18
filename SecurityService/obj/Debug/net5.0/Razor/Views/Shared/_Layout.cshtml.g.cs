#pragma checksum "/Users/hungphat/Documents/SecurityService/SecurityService/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d24dd89260276607e04a29bf9a54f81ce84a1346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "/Users/hungphat/Documents/SecurityService/SecurityService/Views/_ViewImports.cshtml"
using SecurityService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hungphat/Documents/SecurityService/SecurityService/Views/_ViewImports.cshtml"
using SecurityService.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d24dd89260276607e04a29bf9a54f81ce84a1346", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66f6346004d8434be2a240c051c6369585341a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/PhatCss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24dd89260276607e04a29bf9a54f81ce84a13465647", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 6 "/Users/hungphat/Documents/SecurityService/SecurityService/Views/Shared/_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - SecurityService</title>\n");
                WriteLiteral("    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.4.1/font/bootstrap-icons.css\">\n");
                WriteLiteral("    <link rel=\"stylesheet\" href=\"https://unpkg.com/swiper/swiper-bundle.css\" />\n    <link rel=\"stylesheet\" href=\"https://unpkg.com/swiper/swiper-bundle.min.css\" />\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d24dd89260276607e04a29bf9a54f81ce84a13466642", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d24dd89260276607e04a29bf9a54f81ce84a13467803", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
            WriteLiteral("\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24dd89260276607e04a29bf9a54f81ce84a13469658", async() => {
                WriteLiteral(@"

    <style>
    </style>
    <div class=""banner"">
        <div class=""banner-content"">
            <span><i class=""bi bi-shield-check"" style=""font-size:14px;""></i> Your safety is our responsibility</span>
            <span><i class=""bi bi-shield-check"" style=""font-size:14px;""></i> Your safety is our responsibility</span>
            <span><i class=""bi bi-shield-check"" style=""font-size:14px;""></i> Your safety is our responsibility</span>
            <span><i class=""bi bi-shield-check"" style=""font-size:14px;""></i> Your safety is our responsibility</span>
            <span><i class=""bi bi-shield-check"" style=""font-size:14px;""></i> Your safety is our responsibility</span>
        </div>


    </div>
    <header>
        <!-- navigation bar-->
        <div class=""myNav"" id=""myNav"">
            <nav>
                <div class=""myNav-header"">
                    <ul>
                        <li class=""star-logo"">
                            <a href=""../Home/Index"">
                                <img src=""../img");
                WriteLiteral(@"/logoResize.png"" style=""width:30px;"" />
                            </a>
                        </li>

                    </ul>
                    <div class=""ham-menu"" id=""ham-menu"">
                        <input class=""menu-btn"" type=""checkbox"" id=""menu-btn"" name=""menu-btn"" />
                        <label class=""menu-icon"" for=""menu-btn""><span class=""nav-icon"" id=""nav-icon""></span></label>
                    </div>
                    <div class=""search-around"" id=""search-around""></div>
                </div>

                <ul class=""myNav-list"" id=""myNav-list"">
                    <li>
                        <a href=""../Home/Index"" class=""logo myNav-item"">
                            <img src=""../img/logo.png"" style=""width:150px;"" />
                        </a>
                    </li>
                    <li><a href=""../Home/Index"" class=""myNav-item"">Home</a> </li>
                    <li><a href=""../About/Index"" class=""myNav-item"">About Us</a></li>
                    <li>
                  ");
                WriteLiteral(@"      <div class=""dropdown"">
                            <a href=""#"" class=""myNav-item"">Our Bussiness <i class=""bi bi-caret-down"" style=""font-size:16px;""></i> </a>
                            <div class=""dropdown-content"">
                                <a href=""#"">Manned guarding</a>
                                <a href=""#"">Cash Services</a>
                                <a href=""#"">Electronic security systems</a>
                                <a href=""#"">Recruitment and training</a>
                            </div>
                        </div>
                    </li>
                    <li><a href=""#"" id=""search""><i class=""bi bi-search"" style=""font-size:14px;""></i></a> </li>
                    <li><a href=""../Contact/Index"" class=""myNav-item"">Contact us</a> </li>
                </ul>
                <div class=""search-form"">
                    <input type=""text"" placeholder=""Search.."" />
                    <a class=""close""><i class=""bi bi-x"" style=""font-size:30px;color:white;""></i></a>
  ");
                WriteLiteral(@"              </div>
                <div class=""search-dropdown"">

                </div>
            </nav>
        </div>
        <div class=""search-around"" id=""search-around""></div>

    </header>
    <!-- Slider main container -->
    <div class=""swiper-container"">
        <!-- Additional required wrapper -->
        <div class=""swiper-wrapper"">
            <!-- Slides -->
            <div class=""swiper-slide"">Slide 1</div>
            <div class=""swiper-slide"">Slide 2</div>
            <div class=""swiper-slide"">Slide 3</div>
        </div>
        <!-- If we need pagination -->
        <div class=""swiper-pagination""></div>

        <!-- If we need navigation buttons -->
");
                WriteLiteral("\n        <!-- If we need scrollbar -->\n");
                WriteLiteral("    </div>\n\n\n    <main role=\"main\" class=\"pb-3\">\n        ");
#nullable restore
#line 108 "/Users/hungphat/Documents/SecurityService/SecurityService/Views/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>

    <section class=""footer"" id=""footer"">
        <div class=""footer-container"">
            <div class=""footer-content"">
                <div class=""footer-content-top"">
                    <div class=""col-content"">
                        <label> About Star Security</label>
                        <ul>
                            <li><a href=""#""> 1 </a></li>
                            <li><a href=""#""> 1 </a></li>
                            <li><a href=""#""> 1 </a></li>
                            <li><a href=""#""> 1 </a></li>
                        </ul>
                    </div>
                    <div class=""col-content"">
                        <label> Quick Links</label>
                        <ul>
                            <li><a href=""#""> 1 </a></li>
                            <li><a href=""#""> 1 </a></li>
                            <li><a href=""#""> 1 </a></li>
                            <li><a href=""#""> 1 </a></li>
                        </ul>
                    </div>
        ");
                WriteLiteral(@"            <div class=""col-content"">
                        <label> Quick Links</label>
                        <ul>
                            <li><a href=""#""> Manned guarding </a></li>
                            <li><a href=""#""> Cash Services </a></li>
                            <li><a href=""#""> Electronic security systems </a></li>
                            <li><a href=""#""> Recruitment and training </a></li>
                        </ul>
                    </div>
                    <div class=""col-content"">
                        <label> Find Us </label>
                        <ul>
                            <li><a href=""#""> <i class=""bi bi-facebook"" style=""color: #3b5998;""></i> Facebook </a></li>
                            <li><a href=""#""> <i class=""bi bi-twitter"" style=""color: #1DA1F2;""></i> Twitter </a></li>
                            <li><a href=""#""> <i class=""bi bi-instagram"" style=""color: #E1306C""></i> Instagram </a></li>

                        </ul>
                    </div>
       ");
                WriteLiteral(@"         </div>
                <div class=""copyright"">
                    <div class=""footer-legal-copyright"">
                        Copyright © 2021 Star Security Service . All rights reserved.
                    </div>
                </div>

            </div>

        </div>
    </section>
    <script></script>

");
                WriteLiteral("    <script src=\"https://unpkg.com/swiper/swiper-bundle.js\"></script>\n    <script src=\"https://unpkg.com/swiper/swiper-bundle.min.js\"></script>\n");
                WriteLiteral("    <script src=\"https://code.jquery.com/jquery-3.6.0.min.js\"></script>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24dd89260276607e04a29bf9a54f81ce84a134617114", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24dd89260276607e04a29bf9a54f81ce84a134618198", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d24dd89260276607e04a29bf9a54f81ce84a134619282", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#nullable restore
#line 171 "/Users/hungphat/Documents/SecurityService/SecurityService/Views/Shared/_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
#nullable restore
#line 172 "/Users/hungphat/Documents/SecurityService/SecurityService/Views/Shared/_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
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
            WriteLiteral("\n</html>\n\n");
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
