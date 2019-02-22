using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initiative_Tracker
{
    public partial class AddAbilityForm : Form
    {

        List<Abilities> abilitiesList2;
        string playerClass;

        public AddAbilityForm(List<Abilities> abilitiesList, string sentClass)
        {
            InitializeComponent();
            abilitiesList2 = abilitiesList;
            playerClass = sentClass;
        }

        private void AddAbilityForm_Load(object sender, EventArgs e)
        {
            
            for (var x =0; x < abilitiesList2.Count; x++)
            {
                Abilities Class = abilitiesList2[x];
                if (Class.AbilityName == "fight")
                {
                    AbilitiesListBox.Items.Add(Class.AbilityName);
                }
            }
        }

        private void AddAbility_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
