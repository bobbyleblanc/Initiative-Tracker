namespace Initiative_Tracker
{
    partial class AddAbilityForm
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
            this.AbilitiesListBox = new System.Windows.Forms.ListBox();
            this.AddAbility = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomAbility = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AbilitiesListBox
            // 
            this.AbilitiesListBox.FormattingEnabled = true;
            this.AbilitiesListBox.Location = new System.Drawing.Point(30, 79);
            this.AbilitiesListBox.Name = "AbilitiesListBox";
            this.AbilitiesListBox.Size = new System.Drawing.Size(216, 147);
            this.AbilitiesListBox.TabIndex = 0;
            // 
            // AddAbility
            // 
            this.AddAbility.Location = new System.Drawing.Point(252, 79);
            this.AddAbility.Name = "AddAbility";
            this.AddAbility.Size = new System.Drawing.Size(75, 23);
            this.AddAbility.TabIndex = 1;
            this.AddAbility.Text = "Add Ability";
            this.AddAbility.UseVisualStyleBackColor = true;
            this.AddAbility.Click += new System.EventHandler(this.AddAbility_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(160, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(30, 275);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(146, 275);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationTextBox.TabIndex = 4;
            // 
            // AddCustomAbility
            // 
            this.AddCustomAbility.Location = new System.Drawing.Point(252, 272);
            this.AddCustomAbility.Name = "AddCustomAbility";
            this.AddCustomAbility.Size = new System.Drawing.Size(75, 23);
            this.AddCustomAbility.TabIndex = 5;
            this.AddCustomAbility.Text = "Add Ability";
            this.AddCustomAbility.UseVisualStyleBackColor = true;
            this.AddCustomAbility.Click += new System.EventHandler(this.AddCustomAbility_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Custom Ability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Duration";
            // 
            // AddAbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddCustomAbility);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddAbility);
            this.Controls.Add(this.AbilitiesListBox);
            this.Name = "AddAbilityForm";
            this.Text = "AddAbilityForm";
            this.Load += new System.EventHandler(this.AddAbilityForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AbilitiesListBox;
        private System.Windows.Forms.Button AddAbility;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Button AddCustomAbility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}