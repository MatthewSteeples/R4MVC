// <auto-generated />
// This file was generated by R4Mvc.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the r4mvc.json file (i.e. the settings file), save it and run the generator tool again.

// Make sure the compiler doesn't complain about missing Xml comments and CLS compliance
// 0108: suppress "Foo hides inherited member Foo.Use the new keyword if hiding was intended." when a controller and its abstract parent are both processed
#pragma warning disable 1591, 3008, 3009, 0108
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Routing;
using R4Mvc;

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class MVC
{
    static readonly R4Mvc.MembersAreaClass s_Members = new R4Mvc.MembersAreaClass();
    public static R4Mvc.MembersAreaClass Members => s_Members;
    static readonly R4Mvc.ProductsAreaClass s_Products = new R4Mvc.ProductsAreaClass();
    public static R4Mvc.ProductsAreaClass Products => s_Products;
    public static readonly AspNetFeatureFolders.Features.Calculator.CalculatorController Calculator = new AspNetFeatureFolders.Features.Calculator.R4MVC_CalculatorController();
    public static readonly AspNetFeatureFolders.Areas.Members.Features.Search.SearchController Search = new AspNetFeatureFolders.Areas.Members.Features.Search.R4MVC_SearchController();
    public static readonly R4Mvc.SharedController Shared = new R4Mvc.SharedController();
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class MVCPages
{
}

namespace R4Mvc
{
    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public class Dummy
    {
        private Dummy()
        {
        }

        public static Dummy Instance = new Dummy();
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class SharedController
    {
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames => s_ViewNames;
            public class _ViewNamesClass
            {
                public readonly string _Layout = "_Layout";
                public readonly string _ValidationScriptsPartial = "_ValidationScriptsPartial";
            }

            public readonly string _Layout = "~/Features/Shared/_Layout.cshtml";
            public readonly string _ValidationScriptsPartial = "~/Features/Shared/_ValidationScriptsPartial.cshtml";
        }

        static readonly ViewsClass s_Views = new ViewsClass();
        public ViewsClass Views => s_Views;
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class MembersAreaClass
    {
        public readonly string Name = "Members";
        public readonly AspNetFeatureFolders.Areas.Members.Features.Manage.ManageController Manage = new AspNetFeatureFolders.Areas.Members.Features.Manage.R4MVC_ManageController();
    }

    [GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
    public partial class ProductsAreaClass
    {
        public readonly string Name = "Products";
        public readonly AspNetFeatureFolders.Areas.Products.Search.SearchController Search = new AspNetFeatureFolders.Areas.Products.Search.R4MVC_SearchController();
    }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
public static partial class Links
{
    public const string UrlPath = "~";
    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
    public static partial class css
    {
        public const string UrlPath = "~/css";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string site_css = Url("site.css");
        public static readonly string site_min_css = Url("site.min.css");
    }

    public static partial class images
    {
        public const string UrlPath = "~/images";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string banner1_svg = Url("banner1.svg");
        public static readonly string banner2_svg = Url("banner2.svg");
        public static readonly string banner3_svg = Url("banner3.svg");
        public static readonly string banner4_svg = Url("banner4.svg");
    }

    public static partial class js
    {
        public const string UrlPath = "~/js";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static readonly string site_js = Url("site.js");
        public static readonly string site_min_js = Url("site.min.js");
    }

    public static partial class lib
    {
        public const string UrlPath = "~/lib";
        public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
        public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
        public static partial class bootstrap
        {
            public const string UrlPath = "~/lib/bootstrap";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static partial class dist
            {
                public const string UrlPath = "~/lib/bootstrap/dist";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static partial class css
                {
                    public const string UrlPath = "~/lib/bootstrap/dist/css";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string bootstrap_theme_css = Url("bootstrap-theme.css");
                    public static readonly string bootstrap_theme_css_map = Url("bootstrap-theme.css.map");
                    public static readonly string bootstrap_theme_min_css = Url("bootstrap-theme.min.css");
                    public static readonly string bootstrap_theme_min_css_map = Url("bootstrap-theme.min.css.map");
                    public static readonly string bootstrap_css = Url("bootstrap.css");
                    public static readonly string bootstrap_css_map = Url("bootstrap.css.map");
                    public static readonly string bootstrap_min_css = Url("bootstrap.min.css");
                    public static readonly string bootstrap_min_css_map = Url("bootstrap.min.css.map");
                }

                public static partial class fonts
                {
                    public const string UrlPath = "~/lib/bootstrap/dist/fonts";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string glyphicons_halflings_regular_eot = Url("glyphicons-halflings-regular.eot");
                    public static readonly string glyphicons_halflings_regular_svg = Url("glyphicons-halflings-regular.svg");
                    public static readonly string glyphicons_halflings_regular_ttf = Url("glyphicons-halflings-regular.ttf");
                    public static readonly string glyphicons_halflings_regular_woff = Url("glyphicons-halflings-regular.woff");
                    public static readonly string glyphicons_halflings_regular_woff2 = Url("glyphicons-halflings-regular.woff2");
                }

                public static partial class js
                {
                    public const string UrlPath = "~/lib/bootstrap/dist/js";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string bootstrap_js = Url("bootstrap.js");
                    public static readonly string bootstrap_min_js = Url("bootstrap.min.js");
                    public static readonly string npm_js = Url("npm.js");
                }
            }

            public static readonly string _bower_json = Url(".bower.json");
            public static readonly string LICENSE = Url("LICENSE");
        }

        public static partial class jquery
        {
            public const string UrlPath = "~/lib/jquery";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static partial class dist
            {
                public const string UrlPath = "~/lib/jquery/dist";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string jquery_js = Url("jquery.js");
                public static readonly string jquery_min_js = Url("jquery.min.js");
                public static readonly string jquery_min_map = Url("jquery.min.map");
            }

            public static partial class validation
            {
                public const string UrlPath = "~/lib/jquery-validation";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static partial class dist
                {
                    public const string UrlPath = "~/lib/jquery-validation/dist";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string additional_methods_js = Url("additional-methods.js");
                    public static readonly string additional_methods_min_js = Url("additional-methods.min.js");
                    public static readonly string jquery_validate_js = Url("jquery.validate.js");
                    public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
                }

                public static partial class unobtrusive
                {
                    public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
                    public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                    public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                    public static readonly string _bower_json = Url(".bower.json");
                    public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
                    public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
                }

                public static readonly string _bower_json = Url(".bower.json");
                public static readonly string LICENSE_md = Url("LICENSE.md");
            }

            public static partial class validation_unobtrusive
            {
                public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string _bower_json = Url(".bower.json");
                public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
                public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
            }

            public static readonly string _bower_json = Url(".bower.json");
            public static readonly string LICENSE_txt = Url("LICENSE.txt");
        }

        public static partial class jquery_validation
        {
            public const string UrlPath = "~/lib/jquery-validation";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static partial class dist
            {
                public const string UrlPath = "~/lib/jquery-validation/dist";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string additional_methods_js = Url("additional-methods.js");
                public static readonly string additional_methods_min_js = Url("additional-methods.min.js");
                public static readonly string jquery_validate_js = Url("jquery.validate.js");
                public static readonly string jquery_validate_min_js = Url("jquery.validate.min.js");
            }

            public static partial class unobtrusive
            {
                public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
                public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
                public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
                public static readonly string _bower_json = Url(".bower.json");
                public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
                public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
            }

            public static readonly string _bower_json = Url(".bower.json");
            public static readonly string LICENSE_md = Url("LICENSE.md");
        }

        public static partial class jquery_validation_unobtrusive
        {
            public const string UrlPath = "~/lib/jquery-validation-unobtrusive";
            public static string Url() => R4MvcHelpers.ProcessVirtualPath(UrlPath);
            public static string Url(string fileName) => R4MvcHelpers.ProcessVirtualPath(UrlPath + "/" + fileName);
            public static readonly string _bower_json = Url(".bower.json");
            public static readonly string jquery_validate_unobtrusive_js = Url("jquery.validate.unobtrusive.js");
            public static readonly string jquery_validate_unobtrusive_min_js = Url("jquery.validate.unobtrusive.min.js");
        }
    }

    public static readonly string favicon_ico = Url("favicon.ico");
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal static class R4MvcHelpers
{
    private static string ProcessVirtualPathDefault(string virtualPath) => virtualPath;
    public static Func<string, string> ProcessVirtualPath = ProcessVirtualPathDefault;
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult : ActionResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_ActionResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult : JsonResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_JsonResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_ContentResult : ContentResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_ContentResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_FileResult : FileResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_FileResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult : RedirectResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectResult(string area, string controller, string action, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult : RedirectToActionResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToActionResult(string area, string controller, string action, string protocol = null): base(" ", " ", " ")
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult : RedirectToRouteResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RedirectToRouteResult(string area, string controller, string action, string protocol = null): base(null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ActionResult : ActionResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ActionResult(string pageName, string pageHandler, string protocol = null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_JsonResult : JsonResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_JsonResult(string pageName, string pageHandler, string protocol = null): base(null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ContentResult : ContentResult, IR4MvcActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_ContentResult(string area, string controller, string action, string protocol = null)
    {
        this.InitMVCT4Result(area, controller, action, protocol);
    }

    public string Controller { get; set; }

    public string Action { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_FileResult : FileResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_FileResult(string pageName, string pageHandler, string protocol = null): base(null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectResult : RedirectResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectResult(string pageName, string pageHandler, string protocol = null): base(" ")
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToActionResult : RedirectToActionResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToActionResult(string pageName, string pageHandler, string protocol = null): base(" ", " ", " ")
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}

[GeneratedCode("R4Mvc", "1.0"), DebuggerNonUserCode]
internal partial class R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToRouteResult : RedirectToRouteResult, IR4PageActionResult
{
    public R4Mvc_Microsoft_AspNetCore_Mvc_RazorPages_RedirectToRouteResult(string pageName, string pageHandler, string protocol = null): base(null)
    {
        this.InitMVCT4Result(pageName, pageHandler, protocol);
    }

    public string PageName { get; set; }

    public string PageHandler { get; set; }

    public string Protocol { get; set; }

    public RouteValueDictionary RouteValueDictionary { get; set; }
}
#pragma warning restore 1591, 3008, 3009, 0108
