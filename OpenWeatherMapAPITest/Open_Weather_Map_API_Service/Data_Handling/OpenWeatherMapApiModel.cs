using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest.Open_Weather_Map_API_Service.Data_Handling
{
    //public class hdh
    //{
    //    public string DT { get; set; }
    //    public string dt_txt { get; set; }
    //}
    public class WeatherList
    {
        public int dt { get; set; }
        public string dt_txt { get; set; }
        public Main main { get; set; }
        public Weather[] weather { get; set; }
        
    }
    public class Main
    {
        public double Temp { get; set; }
        public double Temp_Min { get; set; }
        public double Temp_Max { get; set; }
        public double Pressure { get; set; }
        public double Sea_Level { get; set; }
        public double Grnd_Level { get; set; }
        public int Humidity { get; set; }
        public double Temp_kf { get; set; }
    }
    public class Weather
    {
        public string main { get; set; }
        public string id { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public class Clouds
    {
        public int All { get; set; }
        public double Deg { get; set; }
    }
    public class Wind
    {
        public double Speed { get; set; }
    }
    public class Rain
    {
        public decimal Threeh { get; set; }
    }
    public class Sys
    {
        public char Pod { get; set; }
    }
    public class City
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Population { get; set; }
        public int Timezone { get; set; }
        public int Sunrise { get; set; }
        public int Sunset { get; set; }
    }
    public class Coord
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
    public class OpenWheatherMapRoot
    {
        public string cod { get; set; }
        public string message { get; set; }
        public string cnt { get; set; }
        //public hdh list { get; set; }
        public City city { get; set; }
    }
}
