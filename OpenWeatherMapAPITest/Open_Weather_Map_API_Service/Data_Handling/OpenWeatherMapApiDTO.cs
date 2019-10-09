using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest.Open_Weather_Map_API_Service.Data_Handling
{
    public class OpenWeatherMapApiDTO
    {
        public OpenWheatherMapRoot OWMR { get; set; }
        public void DeserializeOpenWheatherMap(String OpenWheatherMapResponse)
        {
            OWMR = JsonConvert.DeserializeObject<OpenWheatherMapRoot>(OpenWheatherMapResponse);
        }
    }
}
