using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Initiative_Tracker
{
    public partial class Form1 : Form
    {
        List<Player> playerList = new List<Player>();
        List<RootObject> abilitiesList = new List<RootObject>();
        List<InfoLayout> infoLayoutList = new List<InfoLayout>();
        List<Player> initiativeOrder = new List<Player>();
        List<Player> currentOrder = new List<Player>();
        public int numPlayers = 0;
        public int turn = 0;

        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            string json = File.ReadAllText("Players.json");//read the Players.json file
            playerList = JsonConvert.DeserializeObject<List<Player>>(json);//populate the playerList with all players found in the Players.json
            json = File.ReadAllText("Abilities.json");//read the Abilities.json file
            abilitiesList = JsonConvert.DeserializeObject<List<RootObject>>(json);//populate the abilitiesList with all abilites found in the Abiliteis.json
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            form2.Show();
            for(var x = 0; x<playerList.Count;x++)
            {
                characterListBox.Items.Add(playerList[x].PlayerName);
            }
            for (var x = 0; x < abilitiesList[0].Class.Count; x++)
            {
                classSelect.Items.Add(abilitiesList[0].Class[x].Classname);
            }
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            if (enterInitiative.Text != "" && characterListBox.SelectedIndex != -1)//check that both name and initiative were added for new players.
            {
                for (var x = 0; x<playerList.Count; x++)
                {
                    if (x == playerList.Count - 1)
                    {
                        numPlayers++;//increment the current players in the combat
                        var infolist = CreateInfoLayout();//create a new info layout for the players info to be displayed
                        infoLayoutList.Add(infolist);//run the function to create the controls for the info layout

                        //add the controls to the form.
                        participantsBox.Controls.Add(infolist.playerName);
                        participantsBox.Controls.Add(infolist.HP);
                        participantsBox.Controls.Add(infolist.abilities);
                        participantsBox.Controls.Add(infolist.Initiative);
                        participantsBox.Controls.Add(infolist.AddAbility);

                        playerList.Find(item => item.PlayerName == characterListBox.SelectedItem.ToString()).PlayerInitiative = Int32.Parse(enterInitiative.Text);

                        initiativeOrder.Add(playerList.Find(item => item.PlayerName == characterListBox.SelectedItem.ToString()));
                        initiativeOrder = initiativeOrder.OrderByDescending(k => k.PlayerInitiative).ToList();
                        var index = initiativeOrder.IndexOf(playerList.Find(item => item.PlayerName == characterListBox.SelectedItem.ToString()));
                        var temp = index - turn;
                        if (temp >= 0)
                        {
                            currentOrder.Insert(index - turn, playerList.Find(item => item.PlayerName == characterListBox.SelectedItem.ToString()));
                        }
                        else
                        {
                            currentOrder.Insert(currentOrder.Count-turn-index, playerList.Find(item => item.PlayerName == characterListBox.SelectedItem.ToString()));
                        }
                        dataGridView1.Rows.Clear();
                        //listView1.Items.Clear();
                        form2.listView1.Items.Clear();
                        for (int y = 0; y < currentOrder.Count; y++)
                        {
                            this.dataGridView1.Rows.Add(currentOrder[y].PlayerName, "", "");
                            foreach (Ability a in currentOrder[y].abilities)
                            {
                                if (dataGridView1["Abilities", y].Value.ToString() == "")
                                {
                                    dataGridView1["Abilities", y].Value = a.AbilityName;
                                    dataGridView1["Rounds", y].Value = a.AbilityDuration.ToString();
                                }
                                else
                                {
                                    dataGridView1["Abilities", y].Value += "\n" + a.AbilityName;
                                    dataGridView1["Rounds", y].Value += "\n" + a.AbilityDuration.ToString();
                                }
                            }

                            ListViewItem listItem = new ListViewItem(currentOrder[y].PlayerName); 
                            listItem.Name = currentOrder[y].PlayerName;
                            listItem.SubItems.Add("");
                            listItem.SubItems.Add("");

                            form2.listView1.Items.Add(listItem);
                            
                        }
                    }
                }
            }
            else if(characterListBox.SelectedIndex == -1)//ensure a name was entered
            {
                MessageBox.Show("Please select a character.");
            }
            else if (enterInitiative.Text == "")//ensure an initiative was entered.
            {

                MessageBox.Show("Please enter the characters initiative.");
            }


            /*if (enterName.Text == "")
            {
                Button button = new Button();
                this.Controls.Add(button);
                button.Location = new Point(450, 70);
                button.Size = new Size(40, 100);
                button.Text = "Created text";
            }
            else
            {
                if (playerList.Count() >= 1)
                {
                    playerList.Insert(insertIndex(Convert.ToInt32(enterInitiative.Text)), new Player
                    {
                        PlayerName = enterName.Text,
                        PlayerInitiative = Convert.ToInt32(enterInitiative.Text)
                    });

                    
                }
                else
                {
                    playerList.Add(new Player
                    {
                        PlayerName = enterName.Text,
                        PlayerInitiative = Convert.ToInt32(enterInitiative.Text)
                    });
                }
                updateOrder();
                enterName.Text = "";
                enterInitiative.Text = "";
            }*/
        }

        private int insertIndex(int playerInitiative)
        {
            for(int i=0; i<playerList.Count(); i++)
            {
                if (playerList[i].PlayerInitiative < playerInitiative)
                    return i;
            }
            return playerList.Count();
        }

        private void updateOrder()
        {/*
           for(int i=0; i<playerList.Count(); i++)
            {
                if (i == 0)
                {
                    player1.Text = playerList[i].PlayerName + playerList[i].PlayerInitiative;
                }
                if(i == 1)
                {
                    player2.Text = playerList[i].PlayerName + playerList[i].PlayerInitiative;
                }
                if (i == 2)
                {
                    player3.Text = playerList[i].PlayerName + playerList[i].PlayerInitiative;
                }
                if (i == 3)
                {
                    player4.Text = playerList[i].PlayerName + playerList[i].PlayerInitiative;
                }
                if (i == 4)
                {
                    player5.Text = playerList[i].PlayerName + playerList[i].PlayerInitiative;
                }
                if (i == 5)
                {
                    player6.Text = playerList[i].PlayerName + playerList[i].PlayerInitiative;
                }
            }*/
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            turn++;

            var lvi = currentOrder[0];
            currentOrder.RemoveAt(0);
            currentOrder.Insert(currentOrder.Count,lvi);
            dataGridView1.Rows.Clear();
            //dataGridView1.Items.Clear();
            form2.listView1.Items.Clear();
            for (int y = 0; y < currentOrder.Count; y++)
            {
                this.dataGridView1.Rows.Add(currentOrder[y].PlayerName, "", "");
                foreach(Ability a in currentOrder[y].abilities)
                {
                    a.AbilityDuration--;
                    if (dataGridView1["Abilities", y].Value.ToString() == "")
                    {
                        dataGridView1["Abilities", y].Value = a.AbilityName;
                        dataGridView1["Rounds", y].Value = a.AbilityDuration.ToString();
                    }
                    else
                    {
                        dataGridView1["Abilities", y].Value += "\n" + a.AbilityName;
                        dataGridView1["Rounds", y].Value += "\n" + a.AbilityDuration.ToString();
                    }
                }
                //dataGridView1.Items.Add(currentOrder[y].PlayerName);
                form2.listView1.Items.Add(currentOrder[y].PlayerName);
            }

            if(turn == currentOrder.Count)
            {
                turn = 0;
            }

            /*
            bool first = true;

            
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                if (first)
                {
                    int index = initiativeOrder.Count;
                    listView1.Items.RemoveAt(lvi.Index);
                    listView1.Items.Insert(index, lvi);
                }
                if (lvi.Index > 0)
                {
                    int index = lvi.Index - 1;
                    listView1.Items.RemoveAt(lvi.Index);
                    listView1.Items.Insert(index, lvi);
                }
            }
            */

            /*
            string tempName;        // NEXT

            for(int i=0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == player1.Text)
                {
                    int temp = Convert.ToInt32(listView1.Items[i].SubItems[2].Text) - 1;
                    listView1.Items[i].SubItems[2].Text = Convert.ToString(temp);
                    if(listView1.Items[i].SubItems[2].Text=="0")
                       listView1.Items[i].Remove();

                }
            }
            
            tempName = player1.Text;
            player1.Text = player2.Text;
            player2.Text = player3.Text;
            player3.Text = player4.Text;
            player4.Text = player5.Text;
            player5.Text = player6.Text;
            player6.Text = tempName;
            */
        }

        private void backButton_Click(object sender, EventArgs e)
        {

            MessageBox.Show("To be Implemented");
            /*
            string tempName;        // BACK
            
            tempName = player1.Text;
            player1.Text = player6.Text;
            player6.Text = player5.Text;
            player5.Text = player4.Text;
            player4.Text = player3.Text;
            player3.Text = player2.Text;
            player2.Text = tempName;
            */
        }

        private void AddAbility_Click(object sender, EventArgs e)
        {
/////////////////////////////////////////////////////////////////////////////////////////FIX TO USE CHARACTERS NAME///////////////////////////////////////////////////////////////////////////
            int s = Int32.Parse((sender as Button).Name.Substring(10));// get the index number for the button pressed
            using (var addAbilityForm = new AddAbilityForm(abilitiesList[0].Class, playerList[s].PlayerClass))//create the add ability form and send it the abilitiesList
            {
                var result = addAbilityForm.ShowDialog();//Show the add abilities form

                if (result == DialogResult.OK)
                {
                    string val = addAbilityForm.NewAbility;
                    var characterName = currentOrder.Find(character => character.PlayerName == playerList[s - 1].PlayerName).PlayerName;
                    Ability newAbility = abilitiesList[0].Class.Find(item => item.Classname == playerList[s].PlayerClass).abilities.Find(ability => ability.AbilityName == val);
                    currentOrder.Find(character => character.PlayerName == playerList[s - 1].PlayerName).abilities.Add(newAbility);

                    int rowIndex = -1;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(characterName))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    if (dataGridView1["Abilities", rowIndex].Value.ToString() == "")
                    {
                        dataGridView1["Abilities", rowIndex].Value = newAbility.AbilityName;
                        dataGridView1["Rounds",rowIndex].Value = newAbility.AbilityDuration.ToString();
                    }
                    else
                    {
                        dataGridView1["Abilities", rowIndex].Value += "\n" + newAbility.AbilityName;
                        dataGridView1["Rounds", rowIndex].Value += "\n" + newAbility.AbilityDuration.ToString();
                    }
                }
            }
        }

        private void AddCondtion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To be Implemented");
            /*
            /////////////////////////////////////////////////////////////////////////////////////////FIX TO USE CHARACTERS NAME///////////////////////////////////////////////////////////////////////////
            int s = Int32.Parse((sender as Button).Name.Substring(10));// get the index number for the button pressed
            using (var addAbilityForm = new AddAbilityForm(abilitiesList[0].Class, playerList[s].PlayerClass))//create the add ability form and send it the abilitiesList
            {
                var result = addAbilityForm.ShowDialog();//Show the add abilities form

                if (result == DialogResult.OK)
                {
                    string val = addAbilityForm.NewAbility;
                    var characterName = currentOrder.Find(character => character.PlayerName == playerList[s - 1].PlayerName).PlayerName;
                    Ability newAbility = abilitiesList[0].Class.Find(item => item.Classname == playerList[s].PlayerClass).abilities.Find(ability => ability.AbilityName == val);
                    currentOrder.Find(character => character.PlayerName == playerList[s - 1].PlayerName).abilities.Add(newAbility);

                    int rowIndex = -1;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(characterName))
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }
                    if (dataGridView1["Abilities", rowIndex].Value.ToString() == "")
                    {
                        dataGridView1["Abilities", rowIndex].Value = newAbility.AbilityName;
                        dataGridView1["Rounds", rowIndex].Value = newAbility.AbilityDuration;
                    }
                    else
                    {
                        dataGridView1["Abilities", rowIndex].Value += "\n" + newAbility.AbilityName;
                        dataGridView1["Rounds", rowIndex].Value += "\n" + newAbility.AbilityDuration;
                    }
                }
            }*/
        }

        private InfoLayout CreateInfoLayout()
        {
            InfoLayout infoLayout = new InfoLayout();
            var vOffset = 29 * infoLayoutList.Count;

            infoLayout.playerName.AutoSize = true;
            infoLayout.playerName.Location = new System.Drawing.Point(66, 31+vOffset);
            infoLayout.playerName.Name = $"player{infoLayoutList.Count +1}";
            infoLayout.playerName.Size = new System.Drawing.Size(45, 13);
            infoLayout.playerName.TabIndex = 13;
            infoLayout.playerName.Text = $"{characterListBox.SelectedItem}";

            infoLayout.HP.AutoSize = true;
            infoLayout.HP.Location = new System.Drawing.Point(130, 31 + vOffset);
            infoLayout.HP.Name = $"HP{infoLayoutList.Count + 1}";
            infoLayout.HP.Size = new System.Drawing.Size(45, 13);
            infoLayout.HP.TabIndex = 13;
            infoLayout.HP.Text = $"HP {infoLayoutList.Count + 1}";

            infoLayout.abilities.AutoSize = true;
            infoLayout.abilities.Location = new System.Drawing.Point(211, 31 + vOffset);
            infoLayout.abilities.Name = $"abilites{infoLayoutList.Count + 1}";
            infoLayout.abilities.Size = new System.Drawing.Size(45, 13);
            infoLayout.abilities.TabIndex = 13;
            infoLayout.abilities.Text = $"Ability {infoLayoutList.Count + 1}";

            infoLayout.Initiative.AutoSize = true;
            infoLayout.Initiative.Location = new System.Drawing.Point(45, 31 + vOffset);
            infoLayout.Initiative.Name = $"Initiative{infoLayoutList.Count + 1}";
            infoLayout.Initiative.Size = new System.Drawing.Size(45, 13);
            infoLayout.Initiative.TabIndex = 13;
            infoLayout.Initiative.Text = $"{enterInitiative.Text}";

            infoLayout.AddAbility.Location = new System.Drawing.Point(270, 31 + vOffset);
            infoLayout.AddAbility.Name = $"AddAbility{infoLayoutList.Count + 1}";
            infoLayout.AddAbility.Size = new System.Drawing.Size(133,23);
            infoLayout.AddAbility.TabIndex = 1;
            infoLayout.AddAbility.Text = "Add Ability";
            infoLayout.AddAbility.UseVisualStyleBackColor = true;
            infoLayout.AddAbility.Click += new System.EventHandler(this.AddAbility_Click);

            infoLayout.AddCondtion.Location = new System.Drawing.Point(300, 31 + vOffset);
            infoLayout.AddCondtion.Name = $"AddCondtion{infoLayoutList.Count + 1}";
            infoLayout.AddCondtion.Size = new System.Drawing.Size(133, 23);
            infoLayout.AddCondtion.TabIndex = 1;
            infoLayout.AddCondtion.Text = "AddCondtion";
            infoLayout.AddCondtion.UseVisualStyleBackColor = true;
            infoLayout.AddCondtion.Click += new System.EventHandler(this.AddCondtion_Click);

            return infoLayout;
        }

        private void createCharacter_Click(object sender, EventArgs e)
        {
            if (enterName.Text != "")//check that both name and initiative were added for new players.
            {
                for (var x = 0; x < playerList.Count; x++)
                {
                    Player currentPlayer = playerList[x];
                    if (currentPlayer.PlayerName == enterName.Text)
                    {
                        MessageBox.Show("Please enter the characters name.");
                    }
                }

                var player = new Player//update the new players info
                {
                    //update the new players info
                    PlayerName = enterName.Text,
                    PlayerClass = classSelect.Text
                };
                // create a new player
                playerList.Add(player);// add the new player to the player list

                var jsonData = JsonConvert.SerializeObject(playerList);//create new json string from the updated player list
                File.WriteAllText("Players.json", jsonData);//update the .json file with the new list.

                characterListBox.Items.Add(playerList[playerList.Count-1].PlayerName);
            }
        }
    }
}
