using System.Windows.Forms;

namespace Initiative_Tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addToListButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.enterInitiative = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roundsleft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.participantsBox = new System.Windows.Forms.GroupBox();
            this.participantBoxPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.form2Show = new System.Windows.Forms.Button();
            this.endCombat = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.beastiaryListBox = new System.Windows.Forms.ListBox();
            this.beastInitiative = new System.Windows.Forms.TextBox();
            this.AddMonster = new System.Windows.Forms.Button();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.characterTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classSelect = new System.Windows.Forms.ListBox();
            this.createCharacter = new System.Windows.Forms.Button();
            this.enterName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.participantsBox.SuspendLayout();
            this.participantBoxPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.characterTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(724, 35);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(133, 23);
            this.addToListButton.TabIndex = 0;
            this.addToListButton.Text = "Add to Combat";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(600, 294);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(257, 112);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(21, 294);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(257, 112);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // enterInitiative
            // 
            this.enterInitiative.Location = new System.Drawing.Point(663, 35);
            this.enterInitiative.Name = "enterInitiative";
            this.enterInitiative.Size = new System.Drawing.Size(55, 20);
            this.enterInitiative.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Initiative";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacterName,
            this.Abilities,
            this.Rounds});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(537, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(320, 167);
            this.dataGridView1.TabIndex = 31;
            // 
            // CharacterName
            // 
            this.CharacterName.HeaderText = "CharacterName";
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.ReadOnly = true;
            // 
            // Abilities
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Abilities.DefaultCellStyle = dataGridViewCellStyle2;
            this.Abilities.HeaderText = "Abilities";
            this.Abilities.Name = "Abilities";
            this.Abilities.ReadOnly = true;
            // 
            // Rounds
            // 
            this.Rounds.HeaderText = "Rounds";
            this.Rounds.Name = "Rounds";
            this.Rounds.ReadOnly = true;
            // 
            // Player
            // 
            this.Player.Text = "Name";
            this.Player.Width = 90;
            // 
            // Ability
            // 
            this.Ability.Text = "Ability";
            this.Ability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ability.Width = 90;
            // 
            // Roundsleft
            // 
            this.Roundsleft.Text = "Rounds";
            this.Roundsleft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Roundsleft.Width = 65;
            // 
            // participantsBox
            // 
            this.participantsBox.AutoSize = true;
            this.participantsBox.Controls.Add(this.participantBoxPanel);
            this.participantsBox.Location = new System.Drawing.Point(21, 18);
            this.participantsBox.Name = "participantsBox";
            this.participantsBox.Size = new System.Drawing.Size(487, 270);
            this.participantsBox.TabIndex = 32;
            this.participantsBox.TabStop = false;
            this.participantsBox.Text = "Current Participants";
            // 
            // participantBoxPanel
            // 
            this.participantBoxPanel.AutoScroll = true;
            this.participantBoxPanel.Controls.Add(this.label7);
            this.participantBoxPanel.Controls.Add(this.label6);
            this.participantBoxPanel.Controls.Add(this.label5);
            this.participantBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.participantBoxPanel.Location = new System.Drawing.Point(3, 16);
            this.participantBoxPanel.Name = "participantBoxPanel";
            this.participantBoxPanel.Size = new System.Drawing.Size(481, 251);
            this.participantBoxPanel.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Init.";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homeTab);
            this.tabControl1.Controls.Add(this.characterTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(883, 449);
            this.tabControl1.TabIndex = 33;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.form2Show);
            this.homeTab.Controls.Add(this.endCombat);
            this.homeTab.Controls.Add(this.label8);
            this.homeTab.Controls.Add(this.label9);
            this.homeTab.Controls.Add(this.beastiaryListBox);
            this.homeTab.Controls.Add(this.beastInitiative);
            this.homeTab.Controls.Add(this.AddMonster);
            this.homeTab.Controls.Add(this.characterListBox);
            this.homeTab.Controls.Add(this.participantsBox);
            this.homeTab.Controls.Add(this.dataGridView1);
            this.homeTab.Controls.Add(this.label2);
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Controls.Add(this.enterInitiative);
            this.homeTab.Controls.Add(this.backButton);
            this.homeTab.Controls.Add(this.nextButton);
            this.homeTab.Controls.Add(this.addToListButton);
            this.homeTab.Location = new System.Drawing.Point(4, 22);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(875, 423);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // form2Show
            // 
            this.form2Show.Location = new System.Drawing.Point(373, 303);
            this.form2Show.Name = "form2Show";
            this.form2Show.Size = new System.Drawing.Size(135, 37);
            this.form2Show.TabIndex = 40;
            this.form2Show.Text = "Open player screen";
            this.form2Show.UseVisualStyleBackColor = true;
            this.form2Show.Visible = false;
            this.form2Show.Click += new System.EventHandler(this.form2Show_Click);
            // 
            // endCombat
            // 
            this.endCombat.Location = new System.Drawing.Point(331, 346);
            this.endCombat.Name = "endCombat";
            this.endCombat.Size = new System.Drawing.Size(224, 60);
            this.endCombat.TabIndex = 39;
            this.endCombat.Text = "End Combat";
            this.endCombat.UseVisualStyleBackColor = true;
            this.endCombat.Visible = false;
            this.endCombat.Click += new System.EventHandler(this.endCombat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Initiative";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Name";
            // 
            // beastiaryListBox
            // 
            this.beastiaryListBox.FormattingEnabled = true;
            this.beastiaryListBox.Location = new System.Drawing.Point(537, 85);
            this.beastiaryListBox.Name = "beastiaryListBox";
            this.beastiaryListBox.Size = new System.Drawing.Size(120, 30);
            this.beastiaryListBox.TabIndex = 36;
            // 
            // beastInitiative
            // 
            this.beastInitiative.Location = new System.Drawing.Point(663, 86);
            this.beastInitiative.Name = "beastInitiative";
            this.beastInitiative.Size = new System.Drawing.Size(55, 20);
            this.beastInitiative.TabIndex = 35;
            // 
            // AddMonster
            // 
            this.AddMonster.Location = new System.Drawing.Point(724, 86);
            this.AddMonster.Name = "AddMonster";
            this.AddMonster.Size = new System.Drawing.Size(133, 23);
            this.AddMonster.TabIndex = 34;
            this.AddMonster.Text = "Add to Combat";
            this.AddMonster.UseVisualStyleBackColor = true;
            this.AddMonster.Click += new System.EventHandler(this.AddMonster_Click);
            // 
            // characterListBox
            // 
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.Location = new System.Drawing.Point(537, 34);
            this.characterListBox.Name = "characterListBox";
            this.characterListBox.Size = new System.Drawing.Size(120, 30);
            this.characterListBox.TabIndex = 33;
            // 
            // characterTab
            // 
            this.characterTab.Controls.Add(this.label4);
            this.characterTab.Controls.Add(this.label3);
            this.characterTab.Controls.Add(this.classSelect);
            this.characterTab.Controls.Add(this.createCharacter);
            this.characterTab.Controls.Add(this.enterName);
            this.characterTab.Location = new System.Drawing.Point(4, 22);
            this.characterTab.Name = "characterTab";
            this.characterTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterTab.Size = new System.Drawing.Size(875, 423);
            this.characterTab.TabIndex = 1;
            this.characterTab.Text = "Characters";
            this.characterTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // classSelect
            // 
            this.classSelect.FormattingEnabled = true;
            this.classSelect.Location = new System.Drawing.Point(185, 83);
            this.classSelect.Name = "classSelect";
            this.classSelect.Size = new System.Drawing.Size(121, 30);
            this.classSelect.TabIndex = 2;
            // 
            // createCharacter
            // 
            this.createCharacter.Location = new System.Drawing.Point(309, 80);
            this.createCharacter.Name = "createCharacter";
            this.createCharacter.Size = new System.Drawing.Size(75, 23);
            this.createCharacter.TabIndex = 1;
            this.createCharacter.Text = "Create Character";
            this.createCharacter.UseVisualStyleBackColor = true;
            this.createCharacter.Click += new System.EventHandler(this.createCharacter_Click);
            // 
            // enterName
            // 
            this.enterName.Location = new System.Drawing.Point(76, 83);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(100, 20);
            this.enterName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 889F));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1.Size = new System.Drawing.Size(889, 475);
            this.panel1.TabIndex = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 20);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "15",
            "18",
            "20",
            "25"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 16);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 475);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.participantsBox.ResumeLayout(false);
            this.participantBoxPanel.ResumeLayout(false);
            this.participantBoxPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.characterTab.ResumeLayout(false);
            this.characterTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enterInitiative;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColumnHeader Ability;
        private System.Windows.Forms.ColumnHeader Roundsleft;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.GroupBox participantsBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage characterTab;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TableLayoutPanel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button createCharacter;
        private System.Windows.Forms.TextBox enterName;
        private System.Windows.Forms.ListBox characterListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox classSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn CharacterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rounds;
        private Panel participantBoxPanel;
        private Label label6;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private ListBox beastiaryListBox;
        private TextBox beastInitiative;
        private Button AddMonster;
        private Button endCombat;
        private Button form2Show;
        private ToolStripComboBox toolStripComboBox1;
    }
}

