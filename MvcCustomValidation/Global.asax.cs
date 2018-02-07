using MvcCustomValidation.AttributeAdapter;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcCustomValidation
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // メッセージリソースファイルの定義と必須チェック時のカスタム属性を追加
            DefaultModelBinder.ResourceClassKey = "Resources";
            DataAnnotationsModelValidatorProvider.RegisterAdapter(typeof(RequiredAttribute), typeof(CustomRequiredAttributeAdapter));
        }
    }
}
