using System.Web.Optimization;

namespace VideoRentalApps
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js",
                        "~/scripts/typeahead.bundle.js",
                        "~/scripts/toastr.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap-lumen.css",
                      "~/Content/bootstrap-theme.css",
                      "~/content/datatables/css/datatables.bootstrap.css",
                      "~/content/typeahead.css",
                      "~/content/toastr.css",
                      "~/Content/site.css"));

            /*Theme*/
            bundles.Add(new Bundle("~/bundles/tlib").Include(
                        "~/Scripts/jquery-{version}.js",
                        //"~/Scripts/bootstrap.js",
                        "~/scripts/bootbox.js",
                        "~/Scripts/respond.js",
                        "~/scripts/datatables/jquery.datatables.js",
                        "~/scripts/datatables/datatables.bootstrap.js",
                        "~/scripts/typeahead.bundle.js",
                        "~/scripts/toastr.js",
                         "~/Content/Arsha/vendor/aos/aos.js",
                         "~/Content/Arsha/vendor/bootstrap/js/bootstrap.bundle.min.js",
                         "~/Content/Arsha/vendor/glightbox/js/glightbox.min.js",
                         "~/Content/Arsha/vendor/isotope-layout/isotope.pkgd.min.js",
                         "~/Content/Arsha/vendor/php-email-form/validate.js",
                         "~/Content/Arsha/vendor/swiper/swiper-bundle.min.js",
                         "~/Content/Arsha/vendor/waypoints/noframework.waypoints.js",
                         "~/Content/Arsha/js/main.js"
                      ));
            bundles.Add(new StyleBundle("~/Content/tcss").Include(
                     "~/Content/bootstrap-theme.css",
                     "~/content/typeahead.css",
                     "~/content/toastr.css",
                     //"~/Content/site.css",
                     "~/Content/datatables/css/datatables.bootstrap.css",
                     "~/Content/Arsha/vendor/aos/aos.css",
                     "~/Content/Arsha/vendor/bootstrap/css/bootstrap.min.css",
                     "~/Content/Arsha/vendor/bootstrap-icons/bootstrap-icons.css",
                     "~/Content/Arsha/vendor/boxicons/css/boxicons.min.css",
                     "~/Content/Arsha/vendor/glightbox/css/glightbox.min.css",
                     "~/Content/Arsha/vendor/remixicon/remixicon.css",
                     "~/Content/Arsha/vendor/swiper/swiper-bundle.min.css",
                     "~/Content/Arsha/css/style.css"
                     ));

        }
    }
}
