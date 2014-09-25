using System.Web;
using System.Web.Optimization;

namespace AmericanWayPiracicaba.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap/css/bootstrap.min.css",
                "~/Content/css/base.css",
                "~/Content/plugins/font-awesome/css/font-awesome.min.css",
                "~/Content/plugins/owl-carousel/owl.carousel.css",
                "~/Content/plugins/owl-carousel/owl.transitions.css",
                "~/Content/plugins/owl-carousel/owl.theme.css",
                "~/Content/plugins/lightbox/css/lightbox.css",
                "~/Content/css/style-theme.css",
                "~/Content/css/fonts/stylesheet.css",
                "~/Content/css/style-colours.css",
                "~/Content/css/style-mixedcolours.css",
                "~/Content/css/styles.css",
                "~/Content/css/loader.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                "~/Content/js/jquery.min.js",
                "~/Content/js/bootstrap.min.js",
                "~/Content/js/jquery.easing.1.3.js",
                "~/Content/js/detectmobilebrowser.js",
                "~/Content/plugins/owl-carousel/owl.carousel.min.js",
                "~/Content/plugins/lightbox/js/lightbox.min.js",
                "~/Content/plugins/masonry/masonry.pkgd.min.js",
                //"~/Content/plugins/pace/pace.min.js",
                "~/Content/js/functions.js",
                "~/Content/js/initialise-functions.js"
            ));
        }
    }
}
