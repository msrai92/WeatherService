namespace WeatherService.Entities
{
    public class WeatherForecast
    {

        public string date { get; set; }
        public Temperature temprature { get; set; }
        public string summary { get; set; }
    }
    
    public class Temperature
    {
        public float celcius { get; set; }
        public float fahrenheit { 
            get 
            {
                return (celcius * (9 / 5)) + 32;
            } 
        }
    }
}