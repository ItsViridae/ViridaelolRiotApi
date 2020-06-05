using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViridaeRiotApi.Data.Entities.MatchEntities;

namespace ViridaeRiotApi.Data.Dtos.MatchesHistoryDataDto
{
    public class MatchListDto
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
