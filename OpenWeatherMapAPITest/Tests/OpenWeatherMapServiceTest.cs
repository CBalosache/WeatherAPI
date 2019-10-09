﻿using NUnit.Framework;
using OpenWeatherMapAPITest.Open_Weather_Map_API_Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapAPITest.Tests
{
    [TestFixture()]
    public class OpenWeatherMapServiceTest
    {
        private OpenWeatherMapApiService OWMAS = new OpenWeatherMapApiService();

        [Test()]
        public void WebbCallSuccessTest()
        {
            Assert.AreEqual(200, OWMAS.OWMADTO.OWMR.cod);
        }
        [Test()]
        public void MessageTest()
        {
            Assert.GreaterOrEqual(OWMAS.OWMADTO.OWMR.message, 0.00);
        }
        [Test()]
        public void CntTest()
        {
            Assert.AreEqual(40, OWMAS.OWMADTO.OWMR.cnt);
        }


        [Test()]
        public void CheckTheFirstDt()
        {
            Assert.AreEqual("1570622400", OWMAS.OWMADTO.OWMR.list[0].dt);
        }
        [Test()]
        public void CheckTemperature()
        {
            Assert.AreEqual(288.86, OWMAS.OWMADTO.OWMR.list[0].main.temp);
        }
        [Test()]
        public void CheckHumidity()
        {
            Assert.AreEqual(288.86, OWMAS.OWMADTO.OWMR.list[0].main.humidity);
        }
        [Test()]
        public void CheckWeatherDescription()
        {
            Assert.AreEqual("light rain", OWMAS.OWMADTO.OWMR.list[0].weather[0].description);
        }
        [Test()]
        public void CheckClouds()
        {
            Assert.AreEqual(100, OWMAS.OWMADTO.OWMR.list[0].clouds.all);
        }
        [Test()]
        public void CheckWind()
        {
            Assert.GreaterOrEqual(OWMAS.OWMADTO.OWMR.list[0].wind.speed, 0.00);
        }
        [Test()]
        public void CheckRain()
        {
            Assert.GreaterOrEqual(OWMAS.OWMADTO.OWMR.list[0].rain.threeh, 0.00);
        }
        [Test()]
        public void CheckSys()
        {
            Assert.AreEqual('d', OWMAS.OWMADTO.OWMR.list[0].sys.pod);
        }
        [Test()]
        public void CheckDt_txt()
        {
            Assert.AreEqual("2019-10-09 21:00:00", OWMAS.OWMADTO.OWMR.list[0].dt_txt);
        }


        [Test()]
        public void CheckCityId()
        {
            Assert.AreEqual(2643743, OWMAS.OWMADTO.OWMR.city.id);
        }
        [Test()]
        public void CheckCityName()
        {
            Assert.AreEqual("London", OWMAS.OWMADTO.OWMR.city.name);
        }
        [Test()]
        public void CheckCoordLat()
        {
            Assert.GreaterOrEqual(OWMAS.OWMADTO.OWMR.city.coord.lat, - 90);
            Assert.LessOrEqual(OWMAS.OWMADTO.OWMR.city.coord.lat, + 90);
        }
        [Test()]
        public void CheckCoordLon()
        {
            Assert.GreaterOrEqual(OWMAS.OWMADTO.OWMR.city.coord.lon, - 180);
            Assert.LessOrEqual(OWMAS.OWMADTO.OWMR.city.coord.lon, + 180);
        }
        [Test()]
        public void CheckCityCoord()
        {
            Assert.AreEqual(51.5073, OWMAS.OWMADTO.OWMR.city.coord.lat);
            Assert.AreEqual(-0.1277, OWMAS.OWMADTO.OWMR.city.coord.lon);
        }
        [Test()]
        public void CheckCountry()
        {
            Assert.AreEqual("GB", OWMAS.OWMADTO.OWMR.city.name);
        }
        [Test()]
        public void CheckPopulation()
        {
            Assert.GreaterOrEqual(OWMAS.OWMADTO.OWMR.city.population, 1000000);
        }
        [Test()]
        public void CheckTimezone()
        {
            Assert.AreEqual(3600, OWMAS.OWMADTO.OWMR.city.timezone);
        }
        [Test()]
        public void CheckSunrise()
        {
            Assert.AreEqual(1570601610, OWMAS.OWMADTO.OWMR.city.sunrise);
        }
        [Test()]
        public void CheckSunset()
        {
            Assert.GreaterOrEqual(OWMAS.OWMADTO.OWMR.city.sunset, 1570601610);
        }
    }
}
