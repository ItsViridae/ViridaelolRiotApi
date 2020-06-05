using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViridaeRiotApi.Data.Constants;

namespace ViridaeRiotApi.Data.Dtos.GameDataDto
{
    public class PlayerDto
    {
        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("currentAccountId")]
        public string CurrentAccountId { get; set; }

        [JsonProperty("currentPlatformId")]
        public PlatformId CurrentPlatformId { get; set; }

        [JsonProperty("matchHistoryUri")]
        public string MatchHistoryUri { get; set; }

        [JsonProperty("platformId")]
        public PlatformId PlatformId { get; set; }

        [JsonProperty("profileIcon")]
        public int ProfileIcon { get; set; }

        [JsonProperty("summonerId")]
        public string SummonerId { get; set; }

        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }

}
