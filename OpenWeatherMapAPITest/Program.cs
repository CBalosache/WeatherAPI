using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine(OpenWeatherMapApiConfig.BaseUrl + "&" + OpenWeatherMapApiConfig.ApiUrlMod + OpenWeatherMapApiConfig.ApiKey);
            Console.ReadLine();
        }
    }
}
