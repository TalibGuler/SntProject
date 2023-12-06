using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SntProject.Models;
using System.Diagnostics;
using System.Globalization;
using System.Net;

namespace SntProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string url = "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=IBM&interval=5min&apikey=demo";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private Stock GetStocks()
        {
            Stock result;
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                result = JsonConvert.DeserializeObject<Stock>(json);
            }
            return result;
        }

        private List<DataPoint> GetDataPoints(Stock stock)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            int i = 0;

            foreach (var item in stock.TimeSeries5min)
            {
                var y = double.Parse(item.Value.Close, CultureInfo.InvariantCulture);

                dataPoints.Add(new DataPoint(i, y));
                i++;
            }
            return dataPoints;
        }

        public IActionResult Index()
        {
            Stock result = GetStocks();
            List<DataPoint> dataPoints = GetDataPoints(result);

            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            return View(result.MetaData);
        }

        public IActionResult Privacy()
        {
            return View();
        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}