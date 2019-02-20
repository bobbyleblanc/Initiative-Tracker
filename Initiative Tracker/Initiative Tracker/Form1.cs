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

        public Form1()
        {
            InitializeComponent();
            string json = File.ReadAllText("Players.json");
            playerList = JsonConvert.DeserializeObject<List<Player>>(json);
            json = File.ReadAllText("Abilities.json");
            abilitiesList = JsonConvert.DeserializeObject<List<Abilities>>(json);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
                Form2 form2 = new Form2();
                form2.Show();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enterName.Text == "")
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
            }
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
        {
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tempName;        // BACK

            tempName = player1.Text;
            player1.Text = player6.Text;
            player6.Text = player5.Text;
            player5.Text = player4.Text;
            player4.Text = player3.Text;
            player3.Text = player2.Text;
            player2.Text = tempName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ability1.Text == "")
            {

            }
            else
            {
                string[] row = { player1.Text, ability1.Text, rounds1.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                ability1.Text = "";
                rounds1.Text = "";
            }
        }

        private void addAbility2_Click(object sender, EventArgs e)
        {
            if (ability2.Text == "")
            {

            }
            else
            {
                string[] row = { player2.Text, ability2.Text, rounds2.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                ability2.Text = "";
                rounds2.Text = "";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ability3.Text == "")
            {

            }
            else
            {
                string[] row = { player3.Text, ability3.Text, rounds3.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                ability3.Text = "";
                rounds3.Text = "";
            }
        }

        private void addAbility4_Click(object sender, EventArgs e)
        {
            if (ability4.Text == "")
            {

            }
            else
            {
                string[] row = { player4.Text, ability4.Text, rounds4.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                ability4.Text = "";
                rounds4.Text = "";
            }
        }

        private void addAbility5_Click(object sender, EventArgs e)
        {
            if (ability5.Text == "")
            {

            }
            else
            {
                string[] row = { player5.Text, ability5.Text, rounds5.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                ability5.Text = "";
                rounds5.Text = "";
            }
        }

        private void addAbility6_Click(object sender, EventArgs e)
        {
            if (ability6.Text == "")
            {

            }
            else
            {
                string[] row = { player6.Text, ability6.Text, rounds6.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                ability6.Text = "";
                rounds6.Text = "";
            }
        }
    }
}
