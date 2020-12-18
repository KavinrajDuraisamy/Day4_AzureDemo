using System.Web;
using System.Web.Mvc;

namespace SampleWeb_K8_AppAzureProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
