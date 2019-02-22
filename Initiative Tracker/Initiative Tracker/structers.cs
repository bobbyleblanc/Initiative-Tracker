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
        public int HP { get; set; }
        public List<string> abilities = new List<string>();
    }
    public class Abilities
    {
        public string AbilityName { get; set; }
        public string AbilityDuration { get; set; }
    }
    public class InfoLayout
    {
        public System.Windows.Forms.Label playerName = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label HP = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label abilities = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label Initiative = new System.Windows.Forms.Label();
        public System.Windows.Forms.Button AddAbility = new System.Windows.Forms.Button();
    }

}
