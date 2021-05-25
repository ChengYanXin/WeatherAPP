using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherAPP.Comman;

namespace WebWeatherAPP.Core.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        /// <summary>
        /// 调用外部api返回数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string GetWeather()
        {
            
            try
            {
                //Key需要从https://dev.qweather.com/docs/api/weather/weather-daily-forecast/获取
                var jsonResult =HttpHelper.Get($"https://devapi.qweather.com/v7/weather/3d?location=101281701&key=b2a7474bbef1463bb9f4beca63fee6bf");
                return jsonResult;
            }
            catch (Exception ex)
            {

                throw (ex);
            }
        }
    }
}
