#pragma checksum "C:\Users\Curso\source\repos\SelfAssessmentFrontEnd\SelfAssessmentFront\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a05d8e389844ead140156bdb4bd4ca3797bf1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Register.cshtml", typeof(AspNetCore.Views_Home_Register))]
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
#line 1 "C:\Users\Curso\source\repos\SelfAssessmentFrontEnd\SelfAssessmentFront\Views\_ViewImports.cshtml"
using InterviewFront;

#line default
#line hidden
#line 2 "C:\Users\Curso\source\repos\SelfAssessmentFrontEnd\SelfAssessmentFront\Views\_ViewImports.cshtml"
using InterviewFront.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a05d8e389844ead140156bdb4bd4ca3797bf1a", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16cca4a8d57158885731fbf07956358fd6021928", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Curso\source\repos\SelfAssessmentFrontEnd\SelfAssessmentFront\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";
    Layout = "_InitialLayout";

#line default
#line hidden
            BeginContext(78, 559, true);
            WriteLiteral(@"
<div class=""container"">

    <div class=""card o-hidden border-0 shadow-lg my-5"">
        <div class=""card-body p-0"">
            <!-- Nested Row within Card Body -->
            <div class=""row"">
                <div class=""col-lg-5 d-none d-lg-block bg-register-image""></div>
                <div class=""col-lg-7"">
                    <div class=""p-5"">
                        <div class=""text-center"">
                            <h1 class=""h4 text-gray-900 mb-4"">Create an Account!</h1>
                        </div>
                        ");
            EndContext();
            BeginContext(637, 1647, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e55aedb0d70476db1ca2d6336cf8d79", async() => {
                BeginContext(656, 1621, true);
                WriteLiteral(@"
                            <div class=""form-group row"">
                                <div class=""col-sm-6 mb-3 mb-sm-0"">
                                    <input type=""text"" class=""form-control form-control-user"" id=""exampleFirstName"" placeholder=""First Name"">
                                </div>
                                <div class=""col-sm-6"">
                                    <input type=""text"" class=""form-control form-control-user"" id=""exampleLastName"" placeholder=""Last Name"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <input type=""email"" class=""form-control form-control-user"" id=""exampleInputEmail"" placeholder=""Email Address"">
                            </div>
                            <div class=""form-group row"">
                                <div class=""col-sm-6 mb-3 mb-sm-0"">
                                    <input type=""password"" class=""form-control");
                WriteLiteral(@" form-control-user"" id=""exampleInputPassword"" placeholder=""Password"">
                                </div>
                                <div class=""col-sm-6"">
                                    <input type=""password"" class=""form-control form-control-user"" id=""exampleRepeatPassword"" placeholder=""Repeat Password"">
                                </div>
                            </div>
                            <a href=""/Home"" class=""btn btn-primary btn-user btn-block"">
                                Register Account
                            </a>
                        ");
                EndContext();
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
            EndContext();
            BeginContext(2284, 500, true);
            WriteLiteral(@"
                        <hr>
                        <div class=""text-center"">
                            <a class=""small"" href=""/Home/ForgotPassword"">Forgot Password?</a>
                        </div>
                        <div class=""text-center"">
                            <a class=""small"" href=""/Home"">Already have an account? Login!</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591