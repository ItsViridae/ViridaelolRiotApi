using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViridaeRiotApi.Data.Entities.GameEntities;

namespace ViridaeRiotApi.Data.Dtos.GameDataDto
{
    public class ParticipantDto
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("spell1Id")]
        public int Spell1Id { get; set; }

        [JsonProperty("spell2Id")]
        public int Spell2Id { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }
    }
}
