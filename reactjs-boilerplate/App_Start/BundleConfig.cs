using reactjs_boilerplate.Shared.Extensions;
using System.Web.Optimization;

namespace reactjs_boilerplate
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/js/reactjs").Include(
                "~/scripts/react/react.js",
                "~/scripts/react/react-dom.js"
            ));

            // Here add JSX Bundles for each View
            bundles.AddBabelBundleView("Home", "Index");

            // Forces files to be combined and minified in debug mode
            BundleTable.EnableOptimizations = false;
        }
    }
}