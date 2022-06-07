using System.Web;
using System.Web.Mvc;

namespace Vidly_Clone
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
            // filters.Add(new RequireHttpsAttribute());  // comment out if you want https only
        }
    }
}
