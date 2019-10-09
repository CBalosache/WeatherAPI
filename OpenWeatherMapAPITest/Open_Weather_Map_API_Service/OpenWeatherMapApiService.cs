using Newtonsoft.Json.Linq;
using OpenWeatherMapAPITest.Open_Weather_Map_API_Service.Data_Handling;
using OpenWeatherMapAPITest.Open_Weather_Map_API_Service.HTTP_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest.Open_Weather_Map_API_Service
{
    class OpenWeatherMapApiService
    {
        //WE need DTO
        public OpenWeatherMapApiDTO OWMADTO = new OpenWeatherMapApiDTO();

        //WE need CALL MANAGER
        public OpenWeatherMapApiCallManager OWMACM = new OpenWeatherMapApiCallManager();

        //WE need JOBJECT
        public JObject OpenWeatherMapApiJson;
        public OpenWeatherMapApiService()
        {
            OWMADTO.DeserializeOpenWheatherMap(OWMACM.GetLatestWeatherInformation());
            OpenWeatherMapApiJson = JObject.Parse(OWMACM.GetLatestWeatherInformation());
        }
        public int GetTotalMainClasses()
        {
            int count = 0;
            foreach (var item in OpenWeatherMapApiJson["list"])
            {
                count++;
            }
            return count;
        }
    }
}
