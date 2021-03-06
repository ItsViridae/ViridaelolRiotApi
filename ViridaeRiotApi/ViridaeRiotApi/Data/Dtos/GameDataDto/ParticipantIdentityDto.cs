﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViridaeRiotApi.Data.Entities;
using ViridaeRiotApi.Data.Entities.GameEntities;

namespace ViridaeRiotApi.Data.Dtos.GameDataDto
{
    public class ParticipantIdentityDto
    {
        public int Id { get; set; }
        [JsonProperty("participantId")]
        public int ParticipantId { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }
    }

}
