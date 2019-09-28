using System;
using Xunit;
using iassettechnicaltest.Pesentation.Controllers;
using Newtonsoft.Json.Linq;
namespace iassettechnicaltest.Presentation.Test
{
    public class WeatherResponseTest
    {
        [Fact]
        public void WeatherResponse()
        {
            WeatherController _weather = new WeatherController();
            var responseString = _weather.Get();
            dynamic _json = JObject.Parse(responseString.ToString());
            int status = (int)_json.Status;
            Assert.Equal(0, status);
        }
    }
}
