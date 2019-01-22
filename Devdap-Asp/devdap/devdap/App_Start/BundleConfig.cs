using System.Web;
using System.Web.Optimization;

namespace devdap
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bundle.css",
                      "~/Content/Site.css"));
        }
    }
}
