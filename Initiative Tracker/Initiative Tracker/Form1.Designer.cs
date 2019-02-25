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
            this.addToListButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.enterInitiative = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roundsleft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.participantsBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.characterListBox = new System.Windows.Forms.ListBox();
            this.characterTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.classSelect = new System.Windows.Forms.ListBox();
            this.createCharacter = new System.Windows.Forms.Button();
            this.enterName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rounds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.characterTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(585, 102);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(133, 23);
            this.addToListButton.TabIndex = 0;
            this.addToListButton.Text = "Add to List";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(531, 294);
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
            this.backButton.Location = new System.Drawing.Point(12, 294);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(257, 112);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // enterInitiative
            // 
            this.enterInitiative.Location = new System.Drawing.Point(675, 66);
            this.enterInitiative.Name = "enterInitiative";
            this.enterInitiative.Size = new System.Drawing.Size(55, 20);
            this.enterInitiative.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Initiative";
            // 
            // listView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacterName,
            this.Abilities,
            this.Rounds});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(537, 139);
            this.dataGridView1.Name = "listView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(257, 149);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
            this.participantsBox.Location = new System.Drawing.Point(21, 27);
            this.participantsBox.Name = "participantsBox";
            this.participantsBox.Size = new System.Drawing.Size(487, 250);
            this.participantsBox.TabIndex = 32;
            this.participantsBox.TabStop = false;
            this.participantsBox.Text = "Current Participants";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.homeTab);
            this.tabControl1.Controls.Add(this.characterTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 449);
            this.tabControl1.TabIndex = 33;
            // 
            // homeTab
            // 
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
            this.homeTab.Size = new System.Drawing.Size(809, 423);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // characterListBox
            // 
            this.characterListBox.FormattingEnabled = true;
            this.characterListBox.Location = new System.Drawing.Point(537, 66);
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
            this.characterTab.Size = new System.Drawing.Size(809, 423);
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
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 823F));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panel1.Size = new System.Drawing.Size(823, 475);
            this.panel1.TabIndex = 34;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 20);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CharacterName
            // 
            this.CharacterName.HeaderText = "CharacterName";
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.ReadOnly = true;
            // 
            // Abilities
            // 
            this.Abilities.HeaderText = "Abilities";
            this.Abilities.Name = "Abilities";
            this.Abilities.ReadOnly = true;
            this.Abilities.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            // 
            // Rounds
            // 
            this.Rounds.HeaderText = "Rounds";
            this.Rounds.Name = "Rounds";
            this.Rounds.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 475);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.characterTab.ResumeLayout(false);
            this.characterTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

