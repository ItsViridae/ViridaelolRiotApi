using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViridaeRiotApi.Data.Entities.GameEntities
{
    public class ParticipantIdentity
    {
        public int Id { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }
    }
}
