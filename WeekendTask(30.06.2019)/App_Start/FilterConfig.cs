using System.Web;
using System.Web.Mvc;

namespace WeekendTask_30._06._2019_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
