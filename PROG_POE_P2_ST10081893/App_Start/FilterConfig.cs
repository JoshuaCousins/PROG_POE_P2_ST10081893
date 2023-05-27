using System.Web;
using System.Web.Mvc;

namespace PROG_POE_P2_ST10081893
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
