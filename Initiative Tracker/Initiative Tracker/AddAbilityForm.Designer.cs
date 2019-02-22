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
            this.SuspendLayout();
            // 
            // AbilitiesListBox
            // 
            this.AbilitiesListBox.FormattingEnabled = true;
            this.AbilitiesListBox.Location = new System.Drawing.Point(96, 79);
            this.AbilitiesListBox.Name = "AbilitiesListBox";
            this.AbilitiesListBox.Size = new System.Drawing.Size(166, 147);
            this.AbilitiesListBox.TabIndex = 0;
            // 
            // AddAbility
            // 
            this.AddAbility.Location = new System.Drawing.Point(288, 79);
            this.AddAbility.Name = "AddAbility";
            this.AddAbility.Size = new System.Drawing.Size(75, 23);
            this.AddAbility.TabIndex = 1;
            this.AddAbility.Text = "Add Ability";
            this.AddAbility.UseVisualStyleBackColor = true;
            this.AddAbility.Click += new System.EventHandler(this.AddAbility_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(288, 202);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AddAbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddAbility);
            this.Controls.Add(this.AbilitiesListBox);
            this.Name = "AddAbilityForm";
            this.Text = "AddAbilityForm";
            this.Load += new System.EventHandler(this.AddAbilityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox AbilitiesListBox;
        private System.Windows.Forms.Button AddAbility;
        private System.Windows.Forms.Button Cancel;
    }
}