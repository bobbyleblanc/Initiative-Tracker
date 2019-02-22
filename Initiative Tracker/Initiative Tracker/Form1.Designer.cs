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
            this.addToListButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.enterName = new System.Windows.Forms.TextBox();
            this.enterInitiative = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Roundsleft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.participantsBox = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.characterTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabControl1.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToListButton
            // 
            this.addToListButton.Location = new System.Drawing.Point(585, 92);
            this.addToListButton.Name = "addToListButton";
            this.addToListButton.Size = new System.Drawing.Size(133, 23);
            this.addToListButton.TabIndex = 0;
            this.addToListButton.Text = "Add to List";
            this.addToListButton.UseVisualStyleBackColor = true;
            this.addToListButton.Click += new System.EventHandler(this.addToListButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(531, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 112);
            this.button2.TabIndex = 1;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 112);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // enterName
            // 
            this.enterName.Location = new System.Drawing.Point(585, 66);
            this.enterName.Name = "enterName";
            this.enterName.Size = new System.Drawing.Size(72, 20);
            this.enterName.TabIndex = 9;
            // 
            // enterInitiative
            // 
            this.enterInitiative.Location = new System.Drawing.Point(663, 66);
            this.enterInitiative.Name = "enterInitiative";
            this.enterInitiative.Size = new System.Drawing.Size(55, 20);
            this.enterInitiative.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 50);
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
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Player,
            this.Ability,
            this.Roundsleft});
            this.listView1.Location = new System.Drawing.Point(531, 139);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(257, 149);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.homeTab.Controls.Add(this.participantsBox);
            this.homeTab.Controls.Add(this.listView1);
            this.homeTab.Controls.Add(this.label2);
            this.homeTab.Controls.Add(this.label1);
            this.homeTab.Controls.Add(this.enterInitiative);
            this.homeTab.Controls.Add(this.enterName);
            this.homeTab.Controls.Add(this.button3);
            this.homeTab.Controls.Add(this.button2);
            this.homeTab.Controls.Add(this.addToListButton);
            this.homeTab.Location = new System.Drawing.Point(4, 22);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(809, 423);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // characterTab
            // 
            this.characterTab.Location = new System.Drawing.Point(4, 22);
            this.characterTab.Name = "characterTab";
            this.characterTab.Padding = new System.Windows.Forms.Padding(3);
            this.characterTab.Size = new System.Drawing.Size(792, 397);
            this.characterTab.TabIndex = 1;
            this.characterTab.Text = "Characters";
            this.characterTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.tabControl1.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addToListButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox enterName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enterInitiative;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ability;
        private System.Windows.Forms.ColumnHeader Roundsleft;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.GroupBox participantsBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage characterTab;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TableLayoutPanel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

