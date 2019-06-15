﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abc.Nrtwnd.WebUI.ExtensionMethod
{
    public class CurrentSession
    {
        public static void Set<T>(string key, T obj)
        {
            HttpContext.Current.Session[key] = obj;
        }

        public static T Get<T>(string key) where T : class, new()
        {
            if (HttpContext.Current.Session[key]!=null)
            {
                return HttpContext.Current.Session[key] as T;
            }

            return default(T);
        }

        public static void Remove(string key)
        {
            if (HttpContext.Current.Session[key]!=null)
            {
                HttpContext.Current.Session.Remove(key);
            }
        }

        public static void Clear()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}