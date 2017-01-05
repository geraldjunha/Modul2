using System.Web;
using System.Web.Mvc;

namespace HelloWorld_Junha_17_XIR1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
