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

        public bool isCustom { get; set; }
        public int rounds { get; set; }
        public string NewAbility { get; set; }

        public AddAbilityForm(List<Class> abilitiesList, string sentClass)
        {
            InitializeComponent();
            abilitiesList2 = abilitiesList;
            playerClass = abilitiesList2.Find(item => item.Classname ==  sentClass);
        }

        private void AddAbilityForm_Load(object sender, EventArgs e)
        {
            
            for (var x =0; x < abilitiesList2.Count; x++)
            {
                if (abilitiesList2[x] == playerClass)
                {
                    for (var z = 0; z < playerClass.abilities.Count; z++)
                    {
                        AbilitiesListBox.Items.Add(playerClass.abilities[z].AbilityName);
                    }
                }
            }
        }

        private void AddAbility_Click(object sender, EventArgs e)
        {
            NewAbility = AbilitiesListBox.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void AddCustomAbility_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text != "" && DurationTextBox.Text != "")
            {
                isCustom = true;
                NewAbility = NameTextBox.Text;
                rounds = Int32.Parse(DurationTextBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if(NameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a name for the Ability.");
            }
            else
            {
                MessageBox.Show("Please Enter duration of the Ability.");
            }
        }
    }
}
