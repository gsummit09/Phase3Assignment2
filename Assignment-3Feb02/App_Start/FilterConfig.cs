﻿using System.Web;
using System.Web.Mvc;

namespace Assignment_3Feb02
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
