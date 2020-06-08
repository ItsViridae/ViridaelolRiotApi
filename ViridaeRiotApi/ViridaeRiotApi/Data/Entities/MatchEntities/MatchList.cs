using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViridaeRiotApi.Data.Entities.MatchEntities
{
    public class MatchList
    {
        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }

        [JsonProperty("matches")]
        public Match[] Matches { get; set; }

        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("totalGames")]
        public int TotalGames { get; set; }
    }
}
