using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViridaeRiotApi.Data.Dtos.ChampionMasteryDto
{
    public class ChampionMasteryDto
    {
        public int Id { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        public string ChampionName { get; set; }
        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
    }
}
