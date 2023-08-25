namespace WeatherService.Entities
{
    public class WeatherBitResponse
    {
        public int count { get; set; }
        public List<WeatherData> data { get; set; }
    }

    public class WeatherData
    {
        public string city_name { get; set; }
        public string state_codde { get; set; }
        public string country_code { get; set; }
        public string timezone { get; set; }
        public float lat { get; set; }
        public float lon { get; set; }    
        public string station { get; set; }
        public List<string> sources { get; set; }
        public int vis { get; set; }
        public int rh { get; set; }
        public float dewpt { get; set; }
        public int wind_dir { get; set; }
        public string wind_cdir { get; set; }
        public string wind_cdir_full { get; set; }
        public float wind_speed { get; set; }
        public float? gust { get; set; }
        public float temp { get; set; }
        public float app_temp { get; set; }
        public int clouds { get; set; }
        public Weather weather { get; set; }
        public string datetime { get; set; }
        public string ob_time { get; set; }
        public int ts { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public float slp { get; set; }
        public float pres { get; set; }
        public int aqi { get; set; }
        public float uv { get; set; }
        public float solar_rad { get; set; }
        public float ghi { get; set; }
        public float dni { get; set; }
        public float dhi { get; set; }
        public float elev_angle { get; set; }
        public int hour_angle { get; set; }
        public string pod { get; set; }
        public int precip { get; set; }
        public int snow { get; set; }
        
    }

    public class Weather
    {
        public string icon { get; set; }
        public int code { get; set; }
        public string description { get; set; }
    }

}
