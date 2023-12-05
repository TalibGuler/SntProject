using Newtonsoft.Json;

namespace SntProject.Models
{
    public class Stock
    {
        [JsonProperty("Meta Data")]
        public MetaData MetaData { get; set; }

        [JsonProperty("Time Series (5min)")]
        public Dictionary<string, TimeSeries5min> TimeSeries5min = new Dictionary<string, TimeSeries5min>();
    }
}
