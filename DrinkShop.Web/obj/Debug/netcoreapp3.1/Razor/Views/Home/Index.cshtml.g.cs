#pragma checksum "C:\Users\Gjorge\Desktop\DrinkShopApplication\DrinkShop.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bac3072b460da555c145d6fbcdc1d1be6e335538"
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
#line 1 "C:\Users\Gjorge\Desktop\DrinkShopApplication\DrinkShop.Web\Views\_ViewImports.cshtml"
using DrinkShop.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gjorge\Desktop\DrinkShopApplication\DrinkShop.Web\Views\_ViewImports.cshtml"
using DrinkShop.Domain.DomainModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bac3072b460da555c145d6fbcdc1d1be6e335538", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6728b7ab96fd00d31fda05ccd83a79d2fcd8daa9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:#00ADB5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onmouseover", new global::Microsoft.AspNetCore.Html.HtmlString("this.style.color=\'#00FFF5\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onmouseout", new global::Microsoft.AspNetCore.Html.HtmlString("this.style.color=\'#00ADB5\'"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""text-center"">
    <div class=""row"">
        <div class=""col"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                </ol>
                <div class=""carousel-inner "">
                    <div class=""carousel-item active"">
                        <img class=""d-block w-100"" height=""700"" src="".\images\e.jpg"" alt=""First slide"">
                    </div>
                    <div class=""carousel-item"">
                        <img class=""d-block w-100"" height=""700"" src="".\images\j.jpg"" alt=""Second slide"">
                    </div>
                    <div class=""carousel-item"">
                        <im");
            WriteLiteral(@"g class=""d-block w-100"" height=""700"" src="".\images\i.jpg"" alt=""Third slide"">
                        <div class=""carousel-caption d-md-block d-inline"">
                            <h5><button class=""btn btn-outline-dark"">Products</button></h5>
                        </div>
                    </div>
                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
    </div>
    <div class=""container"">
        <div class=""row my-5"">
            <d");
            WriteLiteral("iv class=\"col-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac3072b460da555c145d6fbcdc1d1be6e3355387743", async() => {
                WriteLiteral(@"
                    <div class=""card text-white bg-dark mb-3"" style=""max-width: 18rem;"">
                        <img class=""card-img-top"" src=""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxARBhASDw8SDxAQFRIQDxESDxAQEhAPFhIYGBUVExUYKC8gGCAmGxUVIjEhMSksLi4uFx81ODMsOzQtLi0BCgoKDg0OGxAQGy0lHyYvLS0tLSstLS0rKy0tLS0rLSstLS0rLSstLS0tLS0tLS0rKy0tKy0tLS0tLS0tLTUtLf/AABEIAOEA4QMBIgACEQEDEQH/xAAbAAEAAgMBAQAAAAAAAAAAAAAABQYDBAcCAf/EADwQAAIBAgQBCAYIBgMAAAAAAAABAgMRBAUSITEGEyIyQVFxgSQzYZGxshQjQmJyc8HwFRYlNDWhNlLh/8QAGQEBAAMBAQAAAAAAAAAAAAAAAAECAwQF/8QAIBEBAQACAgMBAQEBAAAAAAAAAAECEQMxBBIhEzIzFP/aAAwDAQACEQMRAD8A7iAAAAAAAAAAAAAAAAD5J2i33ERj8VVjhnKM7P8ACv1Jk2i1MA5xieVWNhXdqsGl2SpRa/1YvuWYl1cupVGknOEZNLhdrsIS2gAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAB4rO1GT7k/gQOZS9D4O34Xcn6vq34P4EJmcPQWXxVrnWZP0h7P28TqHJyq55FQk+OhL3bfoczzCN677LHS+TUr5Dh2ko9BKy4bbFb2mJMAEJAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAeavq34P4ETjv7J+BK1X9VLwfwILNMUllzacXtt9ZFJ+bLYoqh41ekSOjclf8Aj9D8L+ZnM8Ti4vES3h28KsJHS+SUk+TtBpprS7NO66zK2/SJcABIAAAAAAAAAAAAAAAAAA");
                WriteLiteral(@"AAAAAAAAAAAAADxX9RLwfwNFUYvDpSjfxubmKklhZt7JRk34WNaHqIlMrpMan8Gw0nvQg3+EkMvoxhhFGCUYxclFLglqZ8p8TJhpJ03Z3s5LzuMKVmABdAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAGlm2LdLBtx3nLowX3n2+RFupuiA5eZtNZdPDYZasRWjoe+1OD2bk/ar7FQwOW5xzEYvHKio9VQUqrtvs9Wz493YXDAZZu5S3k3eUnu22b/ANHSdjz+Tkyyvs3xmvimYnAZu6Fo5o0+9YeEW/O5I8hcficNqw+YS165uVKvdtapcYzb3V32lj5oxV8FGULNEcedxu05TawAjsoqtQ5uTu4dV98P/CRPQxy9pthZoABZAAAAAAAAAAAAAAAAAAAAAAAAAAABCZtLVmkI9kIOXnKVvgibILG/5yX5cPmkY8/8VbDtvUIJU0YXxNin1EaeJrqnScmm7dkVdnLyY26ka42TtlSMsY7ERDPaPPRjPVSctoucejfucldLzJmBWYXG/YncvTBNacRTkv8Asov2qXR/VEoR2J4R/FD50SJ2cPTLMABsoAAAAAAAAAAAAAAAAAAAAAAAAAAAQmNg/wCMSdnbRBXs7XvImzUrL69/vsK54e80mXTzDaHgitZliZR5Nyqy3lK0+LSvJ3tdb2V0vIta4FazzCxjkU6c3FQTsnLZab9G7urPsv7PInDCYoyu1RxeMvXhF9sdTW7TTkotb8H0k/J+xq38lcxTyvTVqRUqc501qkk3BO8f9NLyKnjcPBVaenpysrRj03JJ3WqXZG6T4LdLfsN7BUtEUuLu3J+1u7/fsK8slThdLtOtGTjpkn0o8Gn9pEmVfLX9dHxLQRx4+qcrsABoqAAAAAAAAAAAAAAAAAAAAAAAAAAAalX178jbNSs/SH5EwZOw0MX2mPRiFQkr9K1TTK8etLTJbPubnHwS8o/EvFKrLhKOuElqdNPmuE4bfavdp8LWXG7Ya+OVo7bEbD1gxaxWmOuS+zr0c1");
                WriteLiteral(@"qa5upe6krJqbpLbZ6b7boj6UcRqeqSbb206Ul0ZJtdvFxfft78sl4teXeuj4lpKhkupQp6+urKT72tr+fHzLeWxVoACyAAAAAAAAAAAAAAAAAAAAAAAAAAADTrf3D8jcNCvVj9NcdS1WT03V7d9u4mDPKKcLNXT4p8GRWKw1PVfRG6d1suPeSv2SDznFwjSqR52EJqN+lNRa1X0vfhfS/cwIzHYSnp6ke7h2Wt8CPo01GfRSV3d2Vrs8YTFc3g1DEV6cquq1ozi+tK0Ul47eTMkPWGVX6TmA9ZHxLUVTA9aPiWstirQAFkAAAAAAAAAAAAAAAAAAAAAAAAAAAFSzmL/m6k7PSqSV7bJ6n2ltK3nE7Z14wj8ZFOTk/PH2TMfa6ZM0zF0sXTcY67xs4KSje9+F9r8CsZtyoUsQ6c8txUpbbpYCopJXt15/efvZb6NOMoq8U+66TseKuAouep0qbffojf3mV8rGT7E/nXMsfysoQqtywGJUvvUsArS1am7xne7k2/Ftm79PqSy1VZUJ4eM501T1zpuclfd2g2kuHbf2Fxr5HhJyvLC0ZfipQfxRt0cBS0KPNQ0x6sdEbLwXYVnlYb6q147pynJKs6nL+h1pqNRt8ZaVonx7jupDVIKMHpSXHZJImTbDk/Td0pcfUABogAAAAAAAAAAAAAAAAAAAAAAAAAAArGev8ArS/Lj8ZFnKtnv+dX5cPmmYeT/nV8O0jhvVR8EfXJn3Cr6mPgj1p3ODPqNoxWPUOJ7cRTXSKY9prxNbPz+BLkZV6r8/gSZ6HjdVjmAA6WYAAAAAAAAAAAAAAAAAAAAAAAAAABU+UMrZ8vyofNMthUOU3+ej+VH55GPP8AxVsO0xgpejx8Ee0zBgH6LDwMtzz+S/I3j1Jnym+keJM9U3uZ436mvVV7e/4EoRFZ/vyJc9Dxuqx5AAHUzAAAAAAAAAAAAAAAAAAAAAAAAAAAKlymX9cj+VH55ltKrynlGObwcnbVTtH2tTd0vejHn/irY9t3AP0WPg");
                WriteLiteral(@"amaZnGhhZTdnZ2inOMFKT7E3x7eCb22TPVGenK3Ur3oUoK8tXRlZGhyYw06+Pnja0dEbOngaNvU0L9Ko/vzsm33JI4rhvTX2Mmz7n67hOnGlKzlFc5JuST3tGcYy7eNmvaTlGSb2d+K81xNflBln0jAOKloqReujUXWp1V1ZJ/68GyuZLjJ1cLVVFRw2Og/SaUovROqnvNLulbj7Sv5/T2Wus9veTJS8LnVRzp0sRQdKtOcaaSvKEm5JXi+7cuh2eNNSs86AA6VAAAAAAAAAAAAAAAAAAAAAAAAAAACocqcrx9SvGphqivTbcVw48Vf98C3gizY5bm2Dxs6C52niZtWvB6JpPvi1tLzUTb/mXG4fBQisK8Rp2tzdenUSVut0XF+R0c+WMP+fGXctX965jR5bY+dZR/hsqKvvOcK9VJeEUmR9HAYmrnE61Snid25aqcNE3wtGCfVXjLs7Tr1j6TfHxvdR766c3wmS5hUzSnU0OhTpO9NVKsqtRu1tU31b2vskrX7eJ0PCxkqKU3eXazKDXHGYzURsABZAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA//9k="" alt=""Image"">
                        <div class=""card-header h-25"">
                            <h6 class=""text-white"">Best Offer</h6>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac3072b460da555c145d6fbcdc1d1be6e33553813722", async() => {
                WriteLiteral(@"
                    <div class=""card text-white bg-dark mb-3"" style=""max-width: 18rem;"">
                        <img class=""card-img-top"" src=""https://www.irishdrinkshop.com/image/cache/catalog/World%20Gin/Bombay%20Sapphire%20Gin-1000x1000.jpg"" alt=""Image"">
                        <div class=""card-header h-25"">
                            <h6 class=""text-white"">Newest!</h6>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-4\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bac3072b460da555c145d6fbcdc1d1be6e33553816160", async() => {
                WriteLiteral(@"
                    <div class=""card text-white bg-dark mb-3"" style=""max-width: 18rem;"">
                        <img class=""card-img-top"" src=""https://www.irishdrinkshop.com/image/cache/catalog/World%20Gin/Gordon's%20London%20Dry%20Gin-1000x1000.jpg"" alt=""Image"">
                        <div class=""card-header h-25"">
                            <h6 class=""text-white"">Best Product</h6>
                        </div>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
