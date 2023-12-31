﻿using Newtonsoft.Json;

namespace SntProject.Models
{
    public class MetaData
    {
        [JsonProperty("1. Information")]
        public string Information { get; set; }

        [JsonProperty("2. Symbol")]
        public string Symbol { get; set; }

        [JsonProperty("3. Last Refreshed")]
        public string LastRefreshed { get; set; }

        [JsonProperty("4. Interval")]
        public string Interval { get; set; }

        [JsonProperty("5. Output Size")]
        public string OutputSize { get; set; }

        [JsonProperty("6. Time Zone")]
        public string TimeZone { get; set; }
    }
}
