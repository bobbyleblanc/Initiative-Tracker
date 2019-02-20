using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initiative_Tracker
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int PlayerInitiative { get; set; }
        public string Class { get; set; }
        public List<string> abilities = new List<string>();
    }
    public class Abilities
    {
        public string AbilityName { get; set; }
        public string AbilityDuration { get; set; }
    }

}
