#pragma checksum "C:\Users\Curso\source\repos\SelfAssessmentFrontEnd\SelfAssessmentFront\Views\Shared\_AdminSideBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ffa185f37e1d1d2465c09965cae29696eddbae7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminSideBar), @"mvc.1.0.view", @"/Views/Shared/_AdminSideBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AdminSideBar.cshtml", typeof(AspNetCore.Views_Shared__AdminSideBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ffa185f37e1d1d2465c09965cae29696eddbae7", @"/Views/Shared/_AdminSideBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16cca4a8d57158885731fbf07956358fd6021928", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminSideBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 3823, true);
            WriteLiteral(@"

<!-- Sidebar -->
<ul class=""navbar-nav bg-gradient-primary sidebar sidebar-dark accordion"" id=""accordionSidebar"">

    <!-- Sidebar - Brand -->
    <a class=""sidebar-brand d-flex align-items-center justify-content-center"" href=""index.html"">
        <div class=""sidebar-brand-icon rotate-n-15"">
            <i class=""fas fa-laugh-wink""></i>
        </div>
        <div class=""sidebar-brand-text mx-3"">SB Admin <sup>2</sup></div>
    </a>

    <!-- Divider -->
    <hr class=""sidebar-divider my-0"">

    <!-- Nav Item - Dashboard -->
    <li class=""nav-item active"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-fw fa-tachometer-alt""></i>
            <span>Dashboard</span>
        </a>
    </li>

    <!-- Divider -->
    <hr class=""sidebar-divider"">

    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-fw fa-user""></i>
            <span>User</span>
        </a>
    </li>

    <hr class=""sidebar-divider"">

    <li class=""");
            WriteLiteral(@"nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-fw fa-user-clock""></i>
            <span>Client</span>
        </a>
    </li>

    <hr class=""sidebar-divider"">

    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-fw fa-users""></i>
            <span>Profiles</span>
        </a>
    </li>

    <hr class=""sidebar-divider"">

    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">
            <i class=""fas fa-fw fa-lightbulb""></i>
            <span>Skills</span>
        </a>
    </li>

    <hr class=""sidebar-divider"">

    <!-- Nav Item - Utilities Collapse Menu -->
    <li class=""nav-item"">
        <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseUtilities"" aria-expanded=""true"" aria-controls=""collapseUtilities"">
            <i class=""fas fa-fw fa-wrench""></i>
            <span>Utilities</span>
        </a>
        <div id=""collapseUtilities"" class=""collapse"" aria-label");
            WriteLiteral(@"ledby=""headingUtilities"" data-parent=""#accordionSidebar"">
            <div class=""bg-white py-2 collapse-inner rounded"">
                <a class=""collapse-item"" href=""#"">Change password</a>
            </div>
        </div>
    </li>

    <hr class=""sidebar-divider"">

    <!-- Nav Item - Utilities Collapse Menu -->
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"" data-toggle=""modal"" data-target=""#logoutModal"">
            <i class=""fas fa-fw fa-sign-out-alt""></i>
            <span>Logout</span>
        </a>
    </li>

    <!-- Divider -->
    <hr class=""sidebar-divider d-none d-md-block"">

    <!-- Sidebar Toggler (Sidebar) -->
    <div class=""text-center d-none d-md-inline"">
        <button class=""rounded-circle border-0"" id=""sidebarToggle""></button>
    </div>

</ul>
<!-- End of Sidebar -->
<!-- Logout Modal-->
<div class=""modal fade"" id=""logoutModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" ");
            WriteLiteral(@"role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Ready to Leave?</h5>
                <button class=""close"" type=""button"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">×</span>
                </button>
            </div>
            <div class=""modal-body"">Select ""Logout"" below if you are ready to end your current session.</div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Cancel</button>
                <a class=""btn btn-primary"" href=""/Home"">Logout</a>
            </div>
        </div>
    </div>
</div>");
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