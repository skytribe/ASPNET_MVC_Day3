﻿using System.Web;
using System.Web.Mvc;

namespace ASPMVC_Templates
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
