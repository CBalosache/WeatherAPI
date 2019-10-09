﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest
{
    class OpenWeatherMapApiConfig
    {
        public static readonly String BaseUrl = ConfigurationManager.AppSettings["base_url"];
        public static readonly String ApiKey = ConfigurationManager.AppSettings["api_key"];
        public static readonly String ApiUrlMod = ConfigurationManager.AppSettings["access_key_url_mod"];
    }
}
