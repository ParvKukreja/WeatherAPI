using Newtonsoft.Json;
using System.Collections.Generic;

namespace Statistical_Weather_API
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class City
    {
        [JsonProperty("cod")]
        public int Cod { get; set; }

        [JsonProperty("city_id")]
        public int CityId { get; set; }

        [JsonProperty("calctime")]
        public double Calctime { get; set; }

        [JsonProperty("result")]
        public List<Result> Result { get; set; }
    }

    public class _Clouds
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("median")]
        public int Median { get; set; }

        [JsonProperty("mean")]
        public double Mean { get; set; }

        [JsonProperty("p25")]
        public int P25 { get; set; }

        [JsonProperty("p75")]
        public int P75 { get; set; }

        [JsonProperty("st_dev")]
        public double StDev { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }

    public class _Humidity
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("median")]
        public int Median { get; set; }

        [JsonProperty("mean")]
        public double Mean { get; set; }

        [JsonProperty("p25")]
        public int P25 { get; set; }

        [JsonProperty("p75")]
        public int P75 { get; set; }

        [JsonProperty("st_dev")]
        public double StDev { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }

    public class _Precipitation
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public double Max { get; set; }

        [JsonProperty("median")]
        public int Median { get; set; }

        [JsonProperty("mean")]
        public double Mean { get; set; }

        [JsonProperty("p25")]
        public int P25 { get; set; }

        [JsonProperty("p75")]
        public int P75 { get; set; }

        [JsonProperty("st_dev")]
        public double StDev { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }

    public class _Pressure
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("median")]
        public int Median { get; set; }

        [JsonProperty("mean")]
        public double Mean { get; set; }

        [JsonProperty("p25")]
        public int P25 { get; set; }

        [JsonProperty("p75")]
        public int P75 { get; set; }

        [JsonProperty("st_dev")]
        public double StDev { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }

    public class _Result
    {
        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("day")]
        public int Day { get; set; }

        [JsonProperty("temp")]
        public Temp Temp { get; set; }

        [JsonProperty("pressure")]
        public Pressure Pressure { get; set; }

        [JsonProperty("humidity")]
        public Humidity Humidity { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("precipitation")]
        public Precipitation Precipitation { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
    }

    public class OneYearData
    {
        [JsonProperty("city")]
        public List<City> City { get; set; }
    }

    public class _Temp
    {
        [JsonProperty("record_min")]
        public double RecordMin { get; set; }

        [JsonProperty("record_max")]
        public int RecordMax { get; set; }

        [JsonProperty("average_min")]
        public double AverageMin { get; set; }

        [JsonProperty("average_max")]
        public double AverageMax { get; set; }

        [JsonProperty("median")]
        public double Median { get; set; }

        [JsonProperty("mean")]
        public double Mean { get; set; }

        [JsonProperty("p25")]
        public double P25 { get; set; }

        [JsonProperty("p75")]
        public double P75 { get; set; }

        [JsonProperty("st_dev")]
        public double StDev { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }

    public class _Wind
    {
        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("median")]
        public int Median { get; set; }

        [JsonProperty("mean")]
        public double Mean { get; set; }

        [JsonProperty("p25")]
        public int P25 { get; set; }

        [JsonProperty("p75")]
        public int P75 { get; set; }

        [JsonProperty("st_dev")]
        public double StDev { get; set; }

        [JsonProperty("num")]
        public int Num { get; set; }
    }


}
