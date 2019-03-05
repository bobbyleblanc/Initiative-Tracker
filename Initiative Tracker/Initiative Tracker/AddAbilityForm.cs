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
        List<Ability> abilitiesList2;

        public bool isCustom { get; set; }
        public int rounds { get; set; }
        public string NewAbility { get; set; }

        public AddAbilityForm(List<Ability> abilitiesList) 
        {
            InitializeComponent();
            abilitiesList2 = abilitiesList;
        }

        private void AddAbilityForm_Load(object sender, EventArgs e)
        {
            for (var z = 0; z <abilitiesList2.Count; z++)
            {
                AbilitiesListBox.Items.Add(abilitiesList2[z].AbilityName);
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
