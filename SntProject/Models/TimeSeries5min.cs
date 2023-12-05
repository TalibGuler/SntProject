using Newtonsoft.Json;

namespace SntProject.Models
{
    public class TimeSeries5min
    {
        [JsonProperty("1. open")]
        public string _1open { get; set; }

        [JsonProperty("2. high")]
        public string _2high { get; set; }

        [JsonProperty("3. low")]
        public string _3low { get; set; }

        [JsonProperty("4. close")]
        public string _4close { get; set; }

        [JsonProperty("5. volume")]
        public string _5volume { get; set; }
    }
}
