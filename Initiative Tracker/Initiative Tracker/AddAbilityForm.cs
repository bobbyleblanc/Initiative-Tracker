﻿using System;
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

        public string AddAbilityForm(List<Class> abilitiesList, string sentClass)
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
            return AbilitiesListBox.SelectedItem;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
