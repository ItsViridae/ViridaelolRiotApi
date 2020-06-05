using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViridaeRiotApi.Data.Entities;
using ViridaeRiotApi.Data.Entities.GameEntities;

namespace ViridaeRiotApi.Data.Dtos.GameDataDto
{
    public class TeamDto
    {
        [JsonProperty("bans")]
        public Ban[] Bans { get; set; }

        [JsonProperty("baronKills")]
        public int BaronKills { get; set; }

        [JsonProperty("dominionVictoryScore")]
        public int DominionVictoryScore { get; set; }

        [JsonProperty("dragonKills")]
        public int DragonKills { get; set; }

        [JsonProperty("firstBaron")]
        public bool FirstBaron { get; set; }

        [JsonProperty("firstBlood")]
        public bool FirstBlood { get; set; }

        [JsonProperty("firstDragon")]
        public bool FirstDragon { get; set; }

        [JsonProperty("firstInhibitor")]
        public bool FirstInhibitor { get; set; }

        [JsonProperty("firstRiftHerald")]
        public bool FirstRiftHerald { get; set; }

        [JsonProperty("firstTower")]
        public bool FirstTower { get; set; }

        [JsonProperty("inhibitorKills")]
        public int InhibitorKills { get; set; }

        [JsonProperty("riftHeraldKills")]
        public int RiftHeraldKills { get; set; }

        [JsonProperty("teamId")]
        public int TeamId { get; set; }

        [JsonProperty("towerKills")]
        public int TowerKills { get; set; }

        [JsonProperty("vilemawKills")]
        public int VilemawKills { get; set; }

        [JsonProperty("win")]
        public string Win { get; set; }
    }

}
