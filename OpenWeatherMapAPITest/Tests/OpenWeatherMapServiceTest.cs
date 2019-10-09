using NUnit.Framework;
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
        public void WebbCallSuccessCheck()
        {
            Assert.AreEqual("200", OWMAS.OWMADTO.OWMR.cod);
        }
        [Test()]
        public void CheckGBPValue()
        {
            Assert.AreEqual("1570622400", OWMAS.OWMADTO.OWMR.list[0].dt);
        }
    }
}
