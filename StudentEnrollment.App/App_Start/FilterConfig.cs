using StudentEnrollment.App.Filters;
using System.Web;
using System.Web.Mvc;

namespace StudentEnrollment.App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomExceptionFilter());
            filters.Add(new LogRequestFilter());
        }
    }
}
