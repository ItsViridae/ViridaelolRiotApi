using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViridaeRiotApi.Data.Entities.GameEntities
{
    public class Ban
    {
        public int Id { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
    }
}
