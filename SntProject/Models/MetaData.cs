﻿using Newtonsoft.Json;

namespace SntProject.Models
{
    public class MetaData
    {
        [JsonProperty("1. Information")]
        public string _1Information { get; set; }

        [JsonProperty("2. Symbol")]
        public string _2Symbol { get; set; }

        [JsonProperty("3. Last Refreshed")]
        public string _3LastRefreshed { get; set; }

        [JsonProperty("4. Interval")]
        public string _4Interval { get; set; }

        [JsonProperty("5. Output Size")]
        public string _5OutputSize { get; set; }

        [JsonProperty("6. Time Zone")]
        public string _6TimeZone { get; set; }
    }
}
