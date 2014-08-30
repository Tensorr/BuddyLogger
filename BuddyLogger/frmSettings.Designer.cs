namespace BuddyLogger
{
    partial class frmSettings
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbMegaDump = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbParents = new System.Windows.Forms.CheckBox();
            this.cbFields = new System.Windows.Forms.CheckBox();
            this.cbMethods = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(375, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbMegaDump
            // 
            this.cbMegaDump.AutoSize = true;
            this.cbMegaDump.Checked = Properties.Settings.Default.MD;
            this.cbMegaDump.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMegaDump.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "MD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMegaDump.Location = new System.Drawing.Point(3, 3);
            this.cbMegaDump.Name = "cbMegaDump";
            this.cbMegaDump.Size = new System.Drawing.Size(106, 21);
            this.cbMegaDump.TabIndex = 1;
            this.cbMegaDump.Text = "Mega Dump";
            this.cbMegaDump.UseVisualStyleBackColor = true;
            this.cbMegaDump.CheckedChanged += new System.EventHandler(this.cbMegaDump_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMethods);
            this.panel1.Controls.Add(this.cbFields);
            this.panel1.Controls.Add(this.cbParents);
            this.panel1.Controls.Add(this.cbMegaDump);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 65);
            this.panel1.TabIndex = 3;
            // 
            // cbParents
            // 
            this.cbParents.AutoSize = true;
            this.cbParents.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::BuddyLogger.Properties.Settings.Default, "MD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbParents.Enabled = global::BuddyLogger.Properties.Settings.Default.MD;
            this.cbParents.Location = new System.Drawing.Point(115, 3);
            this.cbParents.Name = "cbParents";
            this.cbParents.Size = new System.Drawing.Size(79, 21);
            this.cbParents.TabIndex = 2;
            this.cbParents.Text = "Parents";
            this.cbParents.UseVisualStyleBackColor = true;
            // 
            // cbFields
            // 
            this.cbFields.AutoSize = true;
            this.cbFields.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::BuddyLogger.Properties.Settings.Default, "MD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbFields.Enabled = global::BuddyLogger.Properties.Settings.Default.MD;
            this.cbFields.Location = new System.Drawing.Point(200, 3);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(67, 21);
            this.cbFields.TabIndex = 2;
            this.cbFields.Text = "Fields";
            this.cbFields.UseVisualStyleBackColor = true;
            // 
            // cbMethods
            // 
            this.cbMethods.AutoSize = true;
            this.cbMethods.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::BuddyLogger.Properties.Settings.Default, "MD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMethods.Enabled = global::BuddyLogger.Properties.Settings.Default.MD;
            this.cbMethods.Location = new System.Drawing.Point(273, 3);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(84, 21);
            this.cbMethods.TabIndex = 2;
            this.cbMethods.Text = "Methods";
            this.cbMethods.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "frmSettings";
            this.Text = "Methods";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbMegaDump;
        private System.Windows.Forms.CheckBox cbParents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbMethods;
        private System.Windows.Forms.CheckBox cbFields;

    }
}