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

        List<Class> abilitiesList2;
        Class playerClass;

        public AddAbilityForm(List<Class> abilitiesList, Class sentClass)
        {
            InitializeComponent();
            abilitiesList2 = abilitiesList;
            playerClass = sentClass;
        }

        private void AddAbilityForm_Load(object sender, EventArgs e)
        {
            
            for (var x =0; x < abilitiesList2.Count; x++)
            {
                if (abilitiesList2[x] == playerClass)
                {
                    for (var z = 0; z < playerClass.abilities.Count; z++)
                    {
                        AbilitiesListBox.Items.Add(playerClass.abilities[z]);
                    }
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
