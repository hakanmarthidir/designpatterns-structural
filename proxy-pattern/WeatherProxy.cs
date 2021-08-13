using System.Collections.Generic;

namespace proxy_pattern
{
    public class WeatherProxy : IWeatherReportService
    {

        private IWeatherReportService _weatherReportService;
        private List<string> _cachedCountryList;
        private string _cachedCountryReport;

        public WeatherProxy(IWeatherReportService weatherReportService)
        {
            this._weatherReportService = weatherReportService;
        }

        //public WeatherProxy()
        //{
        //    this._weatherReportService = new YahooWeatherReportService();
        //}

        public List<string> GetCountryList()
        {
            if(this._cachedCountryList == null)
                this._cachedCountryList =  this._weatherReportService.GetCountryList();

            return this._cachedCountryList;
        }

        public string GetCountryReport(string countryName)
        {
            if (this._cachedCountryReport == null)
            {
                this._cachedCountryReport = this.GetCountryReport(countryName);
            }
            return this._cachedCountryReport;
        }
    }

}
