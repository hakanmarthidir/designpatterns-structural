using System;

namespace proxy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and bind it with DI containers or create the object in proxy class 
            YahooWeatherReportService service = new YahooWeatherReportService();
            WeatherProxy weatherProxy = new WeatherProxy(service);
            var countryList = weatherProxy.GetCountryList();

            foreach (var country in countryList)
            {
                Console.WriteLine(country);
            }
        }
    }

}
