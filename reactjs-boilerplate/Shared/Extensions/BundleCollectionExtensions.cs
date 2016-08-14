using System.Web.Optimization;
using System.Web.Optimization.React;

namespace reactjs_boilerplate.Shared.Extensions
{
    public static class BundleCollectionExtensions
    {
        public static void AddBabelBundleView(this BundleCollection bundles, string controllerName, string viewName)
        {
            bundles.Add(new BabelBundle($"~/jsx/{controllerName}/{viewName}").Include(
                $"~/scripts/web/{controllerName}/{viewName}.jsx"
            ));
        }
    }
}