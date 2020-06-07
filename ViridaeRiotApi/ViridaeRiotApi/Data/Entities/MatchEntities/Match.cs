using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViridaeRiotApi.Data.Constants;

namespace ViridaeRiotApi.Data.Entities.MatchEntities
{
    public class Match
    {
        [JsonProperty("champion")]
        public int Champion { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("lane")]
        public Lane Lane { get; set; }

        [JsonProperty("platformId")]
        public PlatformId PlatformId { get; set; }

        [JsonProperty("queue")]
        public int Queue { get; set; }

        [JsonProperty("role")]
        public Role Role { get; set; }

        [JsonProperty("season")]
        public int Season { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }
    }
}
