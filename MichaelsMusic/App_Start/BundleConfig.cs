﻿using System.Web;
using System.Web.Optimization;

namespace MichaelsMusic
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/vendor/jquery-1.10.2.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/foundation").Include(
                "~/Scripts/vendor/foundation.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/foundation.min.css",
                "~/Content/app.css"));
        }
    }
}
