using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RitoAPI.Models
{
    public class ChampRotationModel
    {
        public List<int> freeChampionIds { get; set; }
        public List<int> freeChampionIdsForNewPlayers { get; set; }

        public int maxNewPlayerLevel { get; set; }
    }
}
