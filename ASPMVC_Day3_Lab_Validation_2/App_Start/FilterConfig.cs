using System.Web;
using System.Web.Mvc;

namespace ASPMVC_Day3_Lab_Validation_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
