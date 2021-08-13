using System.Collections.Generic;

namespace proxy_pattern
{
    public class YahooWeatherReportService : IWeatherReportService
    {
        public List<string> GetCountryList()
        {
            //you can retrieve the datas from webservice...
            return new List<string>() { "Germany", "France", "Sweden" };
        }

        public string GetCountryReport(string countryName)
        {
            switch (countryName)
            {
                case "Germany":
                    return "18";
                case "France":
                    return "25";
                case "Sweden":
                    return "12";
                default:
                    return string.Empty;
            }
        }
    }

}
