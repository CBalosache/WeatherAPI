using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest.Open_Weather_Map_API_Service.HTTP_Manager
{
    class OpenWeatherMapApiCallManager
    {
        readonly IRestClient client;
        public IRestResponse restResponse { get; set; }
        public OpenWeatherMapApiCallManager()
        {
            client = new RestClient(OpenWeatherMapApiConfig.BaseUrl);
        }
        public string GetLatestWeatherInformation()
        {
            var request = new RestRequest(OpenWeatherMapApiConfig.BaseUrl + "&" + OpenWeatherMapApiConfig.ApiUrlMod + OpenWeatherMapApiConfig.ApiKey);
            var response = client.Execute(request, Method.GET);
            restResponse = response;
            return response.Content;
        }
    }
}
