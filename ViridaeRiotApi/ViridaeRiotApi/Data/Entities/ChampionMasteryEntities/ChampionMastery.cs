using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViridaeRiotApi.Data.Entities.ChampionMasteryEntities
{
    public class ChampionMastery
    {
        public int Id { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        public string ChampionName { get; set; }
        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }
        [JsonProperty("summonerId")]
        public int SummonerId { get; set; }
        public Summoner Summoner { get; set; }
    }
}
