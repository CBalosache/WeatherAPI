﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest.Open_Weather_Map_API_Service.Data_Handling
{
    public class WeatherList
    {
        public int dt { get; set; }
        public string dt_txt { get; set; }
        public Main main { get; set; }
        public Weather[] weather { get; set; }
        public Clouds clouds { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Sys sys { get; set; }
    }
    public class Main
    {
        public double temp { get; set; }
        public double temp_Min { get; set; }
        public double temp_Max { get; set; }
        public double pressure { get; set; }
        public double sea_Level { get; set; }
        public double grnd_Level { get; set; }
        public int humidity { get; set; }
        public double temp_kf { get; set; }
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
        public int all { get; set; }
    }
    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
    }
    public class Rain
    {
        public double threeh { get; set; }
    }
    public class Sys
    {
        public char pod { get; set; }
    }
    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
    public class Coord
    {
        public double lat { get; set; }
        public double lon { get; set; }
    }
    public class OpenWheatherMapRoot
    {
        public string cod { get; set; }
        public string message { get; set; }
        public string cnt { get; set; }
        public WeatherList[] list { get; set; }
        public City city { get; set; }
    }
}
