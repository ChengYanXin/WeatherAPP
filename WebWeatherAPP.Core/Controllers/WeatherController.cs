using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebWeatherAPP.Core.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "程艳新";
        }
    }
}
