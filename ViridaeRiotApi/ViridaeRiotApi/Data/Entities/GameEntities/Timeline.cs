﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViridaeRiotApi.Data.Entities.GameEntities
{
    public class Timeline
    {
        public int Id { get; set; }
        [JsonProperty("creepsPerMinDeltas")]
        public Dictionary<string, double> CreepsPerMinDeltas { get; set; }

        [JsonProperty("csDiffPerMinDeltas")]
        public Dictionary<string, double> CsDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenDiffPerMinDeltas")]
        public Dictionary<string, double> DamageTakenDiffPerMinDeltas { get; set; }

        [JsonProperty("damageTakenPerMinDeltas")]
        public Dictionary<string, double> DamageTakenPerMinDeltas { get; set; }

        [JsonProperty("goldPerMinDeltas")]
        public Dictionary<string, double> GoldPerMinDeltas { get; set; }

        [JsonProperty("lane")]
        public string Lane { get; set; }

        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("xpDiffPerMinDeltas")]
        public Dictionary<string, double> XpDiffPerMinDeltas { get; set; }

        [JsonProperty("xpPerMinDeltas")]
        public Dictionary<string, double> XpPerMinDeltas { get; set; }
    }
}
