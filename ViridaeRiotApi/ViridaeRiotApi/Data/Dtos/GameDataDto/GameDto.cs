using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViridaeRiotApi.Data.Constants;
using ViridaeRiotApi.Data.Entities;
using ViridaeRiotApi.Data.Entities.GameEntities;

namespace ViridaeRiotApi.Data.Dtos.GameDataDto
{
    public class GameDto
    {
        [JsonProperty("gameCreation")]
        public int GameCreation { get; set; }

        [JsonProperty("gameDuration")]
        public int GameDuration { get; set; }

        [JsonProperty("gameId")]
        public int GameId { get; set; }

        [JsonProperty("gameMode")]
        public GameMode GameMode { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("gameVersion")]
        public string GameVersion { get; set; }

        [JsonProperty("mapId")]
        public int MapId { get; set; }

        [JsonProperty("participantIdentities")]
        public Participant[] ParticipantIdentities { get; set; }

        [JsonProperty("participants")]
        public Participant[] Participants { get; set; }

        [JsonProperty("platformId")]
        public PlatformId PlatformId { get; set; }

        [JsonProperty("queueId")]
        public int QueueId { get; set; }

        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }

        [JsonProperty("teams")]
        public Team[] Teams { get; set; }
    }
}
