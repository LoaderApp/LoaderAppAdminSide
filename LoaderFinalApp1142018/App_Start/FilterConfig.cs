﻿using System.Web;
using System.Web.Mvc;

namespace LoaderFinalApp1142018
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
