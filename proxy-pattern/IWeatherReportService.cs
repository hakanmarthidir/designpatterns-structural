using System.Collections.Generic;

namespace proxy_pattern
{
    public interface IWeatherReportService
    {
        List<string> GetCountryList();
        string GetCountryReport(string countryName);
    }

}
