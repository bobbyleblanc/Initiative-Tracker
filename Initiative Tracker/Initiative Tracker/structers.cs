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
        public string PlayerClass { get; set; }
        public int HP { get; set; }
        public List<Ability> abilities = new List<Ability>();
    }

    public class InfoLayout
    {
        public System.Windows.Forms.Label playerName = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label HP = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label abilities = new System.Windows.Forms.Label();
        public System.Windows.Forms.Label Initiative = new System.Windows.Forms.Label();
        public System.Windows.Forms.Button AddAbility = new System.Windows.Forms.Button();
        public System.Windows.Forms.Button AddCondition = new System.Windows.Forms.Button();
    }

    public class Ability
    {
        public string AbilityName { get; set; }
        public int RemainingRounds { get; set; }
        public int AbilityDuration { get; set; }
    }

    public class Class
    {
        public string Classname { get; set; }
        public List<Ability> abilities { get; set; }
    }
    public class RootObject
    {
        public List<Class> Class { get; set; }
    }
}
