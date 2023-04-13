using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System;
using Statistical_Weather_API.Domain;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using Org.BouncyCastle.Math.EC;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Statistical_Weather_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigins")]
    public class StatisticalWeatherController : ControllerBase
    {


        private WeatherForecastDbContext _context;
        public StatisticalWeatherController(WeatherForecastDbContext context) 
        {
            _context = context;
        }

        //history.openweathermap.org/data/2.5/aggregated/year?lat=28.5355&lon=77.3910&appid=

       


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <returns></returns>

        [HttpPost]
        [Route("StoreWeatherData")]

        public async Task<IActionResult> AddWeatherData(Forecastdata Data, int latitude, int longitude)
        {
            var ApiKey = "ddffgg";
            try
            {
                using (HttpClient http = new HttpClient())
                {
                    using (var response = await http.GetAsync($"history.openweathermap.org/data/2.5/aggregated/year?lat={latitude}&lon={longitude}&appid={ApiKey}"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        OneYearData DsObj = JsonConvert.DeserializeObject<OneYearData>(apiResponse);
                        foreach (var item in DsObj.City)
                        {
                            DateTime lastUpdated = DateTime.Now;
                            foreach (var forecast in item.Result)
                            {
                                Data.Id = 0;
                                Data.CityId = item.CityId;
                                Data.Day = forecast.Day;
                                Data.Month = forecast.Month;
                                Data.TempMedian = forecast.Temp.Median - 273.15; //temp converted from kelvin to celcius
                                Data.CloudMedian = forecast.Clouds.Median;
                                Data.Lastupdated = lastUpdated;
                                _context.Forecastdata.Add(Data);
                                _context.SaveChanges();
                            }
                        }
                    }
                }
                return Ok(true);
            }
            catch(Exception ex)
            {
                return Ok(ex);
            }        
        }


        [HttpGet]
        [Route("testGet")]

        public async Task<IActionResult> getForDates(DateTime initial, DateTime final, int City_Id)
        {
            
            List<Forecastdata> ForeCast = new List<Forecastdata>();
            var Data = _context.Forecastdata.ToList();
            try
            {
                var result = Data.Where(a => a.CityId == City_Id).ToList();


                foreach (var item in result)
                {
                    
                  var forecast_date = DateTime.Parse(item.Day.ToString() + "/" + item.Month.ToString() + "/" + "2023");
                  if(DateTime.Compare(forecast_date, initial) >= 0 && DateTime.Compare(forecast_date, final) <= 0)
                    {
                        ForeCast.Add(item);
                    }  
                    
                }
                return Ok(ForeCast);
            }catch(Exception ex)
            {
                return Ok(ex);
            }
        }
        

    }
}
