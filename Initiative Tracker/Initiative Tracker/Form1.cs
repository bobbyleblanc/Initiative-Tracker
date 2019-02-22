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
        List<Abilities> abilitiesList = new List<Abilities>();
        List<InfoLayout> infoLayoutList = new List<InfoLayout>();
        public int numPlayers = 0;

        public Form1()
        {
            InitializeComponent();
            string json = File.ReadAllText("Players.json");//read the Players.json file
            playerList = JsonConvert.DeserializeObject<List<Player>>(json);//populate the playerList with all players found in the Players.json
            json = File.ReadAllText("Abilities.json");//read the Abilities.json file
            abilitiesList = JsonConvert.DeserializeObject<List<Abilities>>(json);//populate the abilitiesList with all abilites found in the Abiliteis.json
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
             Form2 form2 = new Form2();
             form2.Show();
        }

        private void addToListButton_Click(object sender, EventArgs e)
        {
            if (enterName.Text != "" && enterInitiative.Text != "")//check that both name and initiative were added for new players.
            {
                numPlayers++;//increment the current players in the combat
                var infolist = CreateInfoLayout();//create a new info layout for the players info to be displayed
                infoLayoutList.Add(infolist);//run the function to create the controls for the info layout

                //add the controls to the form.
                this.Controls.Add(infolist.playerName);
                this.Controls.Add(infolist.HP);
                this.Controls.Add(infolist.abilities);
                this.Controls.Add(infolist.Initiative);
                this.Controls.Add(infolist.AddAbility);


                var player = new Player(); // create a new player
                //update the new players info
                player.PlayerName = infolist.playerName.Text;
                player.PlayerInitiative = Int32.Parse(infolist.Initiative.Text);
                playerList.Add(player);// add the new player to the player list

                var jsonData = JsonConvert.SerializeObject(playerList);//create new json string from the updated player list
                File.WriteAllText("Players.json", jsonData);//update the .json file with the new list.
            }
            else if(enterName.Text == "")//ensure a name was entered
            {
                MessageBox.Show("Please enter the characters name.");
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

        private void button2_Click(object sender, EventArgs e)
        {/*
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

        private void button3_Click(object sender, EventArgs e)
        {/*
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

            int s = Int32.Parse((sender as Button).Name.Substring(10));// get the index number for the button pressed
            Form addAbilityForm = new AddAbilityForm(abilitiesList,playerList[s].Class);//create the add ability form and send it the abilitiesList
            addAbilityForm.Show();//Show the add abilities form
        }

        private InfoLayout CreateInfoLayout()
        {
            InfoLayout infoLayout = new InfoLayout();

            infoLayout.playerName.AutoSize = true;
            infoLayout.playerName.Location = new System.Drawing.Point(66, 31+(29*infoLayoutList.Count));
            infoLayout.playerName.Name = $"player{infoLayoutList.Count +1}";
            infoLayout.playerName.Size = new System.Drawing.Size(45, 13);
            infoLayout.playerName.TabIndex = 13;
            infoLayout.playerName.Text = $"{enterName.Text}";

            infoLayout.HP.AutoSize = true;
            infoLayout.HP.Location = new System.Drawing.Point(130, 31 + (29 * infoLayoutList.Count));
            infoLayout.HP.Name = $"HP{infoLayoutList.Count + 1}";
            infoLayout.HP.Size = new System.Drawing.Size(45, 13);
            infoLayout.HP.TabIndex = 13;
            infoLayout.HP.Text = $"HP {infoLayoutList.Count + 1}";

            infoLayout.abilities.AutoSize = true;
            infoLayout.abilities.Location = new System.Drawing.Point(211, 31 + (29 * infoLayoutList.Count));
            infoLayout.abilities.Name = $"abilites{infoLayoutList.Count + 1}";
            infoLayout.abilities.Size = new System.Drawing.Size(45, 13);
            infoLayout.abilities.TabIndex = 13;
            infoLayout.abilities.Text = $"Ability {infoLayoutList.Count + 1}";

            infoLayout.Initiative.AutoSize = true;
            infoLayout.Initiative.Location = new System.Drawing.Point(45, 31 + (29 * infoLayoutList.Count));
            infoLayout.Initiative.Name = $"Initiative{infoLayoutList.Count + 1}";
            infoLayout.Initiative.Size = new System.Drawing.Size(45, 13);
            infoLayout.Initiative.TabIndex = 13;
            infoLayout.Initiative.Text = $"{enterInitiative.Text}";


            infoLayout.AddAbility.Location = new System.Drawing.Point(270, 31 + (29 * infoLayoutList.Count));
            infoLayout.AddAbility.Name = $"AddAbility{infoLayoutList.Count + 1}";
            infoLayout.AddAbility.Size = new System.Drawing.Size(133,23);
            infoLayout.AddAbility.TabIndex = 1;
            infoLayout.AddAbility.Text = "Add Ability";
            infoLayout.AddAbility.UseVisualStyleBackColor = true;
            infoLayout.AddAbility.Click += new System.EventHandler(this.AddAbility_Click);

            return infoLayout;
        }
    }
}
