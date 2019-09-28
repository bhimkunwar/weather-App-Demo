using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace iassettechnicaltest.Pesentation.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        [HttpGet("[action]")]
        public string[] Get()
        {
            string apiKey = "fc0c4e1ec49d0c022df6519574a1a2ca";
            string city = "london";
            string code = "uk";
            string _url = "http://api.openweathermap.org/data/2.5/forecast?q=";

            var request = (HttpWebRequest)WebRequest.Create(_url+city+","+code+ "&APPID=" + apiKey);
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var response = (HttpWebResponse)request.GetResponse();

            string content = string.Empty;
            using (var stream = response.GetResponseStream())
            {
                using (var _reader = new StreamReader(stream))
                {
                    content = _reader.ReadToEnd();
                }
            }

            return new string[] { content };
        }
    }
}
