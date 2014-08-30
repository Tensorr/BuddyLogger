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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbMethods = new System.Windows.Forms.CheckBox();
            this.cbFields = new System.Windows.Forms.CheckBox();
            this.cbParents = new System.Windows.Forms.CheckBox();
            this.cbMegaDump = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.cbVendors = new System.Windows.Forms.CheckBox();
            this.cbNPC = new System.Windows.Forms.CheckBox();
            this.cbPalceables = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.engineTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isLootableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rotationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDeletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceSqrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inLineOfSightDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isFacingDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.torPlaceableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torPlaceableBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(384, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dump";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbMethods);
            this.panel1.Controls.Add(this.cbFields);
            this.panel1.Controls.Add(this.cbParents);
            this.panel1.Controls.Add(this.cbMegaDump);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 32);
            this.panel1.TabIndex = 4;
            // 
            // cbMethods
            // 
            this.cbMethods.AutoSize = true;
            this.cbMethods.Checked = global::BuddyLogger.Properties.Settings.Default.Methods;
            this.cbMethods.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::BuddyLogger.Properties.Settings.Default, "MD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMethods.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Methods", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMethods.Enabled = global::BuddyLogger.Properties.Settings.Default.MD;
            this.cbMethods.Location = new System.Drawing.Point(363, 3);
            this.cbMethods.Name = "cbMethods";
            this.cbMethods.Size = new System.Drawing.Size(84, 21);
            this.cbMethods.TabIndex = 2;
            this.cbMethods.Text = "Methods";
            this.cbMethods.UseVisualStyleBackColor = true;
            // 
            // cbFields
            // 
            this.cbFields.AutoSize = true;
            this.cbFields.Checked = global::BuddyLogger.Properties.Settings.Default.Fields;
            this.cbFields.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFields.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::BuddyLogger.Properties.Settings.Default, "MD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbFields.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Fields", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbFields.Enabled = global::BuddyLogger.Properties.Settings.Default.MD;
            this.cbFields.Location = new System.Drawing.Point(236, 3);
            this.cbFields.Name = "cbFields";
            this.cbFields.Size = new System.Drawing.Size(67, 21);
            this.cbFields.TabIndex = 2;
            this.cbFields.Text = "Fields";
            this.cbFields.UseVisualStyleBackColor = true;
            // 
            // cbParents
            // 
            this.cbParents.AutoSize = true;
            this.cbParents.Checked = global::BuddyLogger.Properties.Settings.Default.Parents;
            this.cbParents.DataBindings.Add(new System.Windows.Forms.Binding("Enabled", global::BuddyLogger.Properties.Settings.Default, "MD", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbParents.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Parents", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbParents.Enabled = global::BuddyLogger.Properties.Settings.Default.MD;
            this.cbParents.Location = new System.Drawing.Point(125, 3);
            this.cbParents.Name = "cbParents";
            this.cbParents.Size = new System.Drawing.Size(79, 21);
            this.cbParents.TabIndex = 2;
            this.cbParents.Text = "Parents";
            this.cbParents.UseVisualStyleBackColor = true;
            // 
            // cbMegaDump
            // 
            this.cbMegaDump.AutoSize = true;
            this.cbMegaDump.Checked = global::BuddyLogger.Properties.Settings.Default.MD;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.cbVendors);
            this.groupBox2.Controls.Add(this.cbNPC);
            this.groupBox2.Controls.Add(this.cbPalceables);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 69);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = global::BuddyLogger.Properties.Settings.Default.Placeables;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Placeables", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox3.Location = new System.Drawing.Point(239, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 21);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Text = "NPC";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.cbPalceables_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::BuddyLogger.Properties.Settings.Default.Abilites;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Abilites", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(366, 18);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(58, 21);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "NPC";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.cbPalceables_CheckedChanged);
            // 
            // cbVendors
            // 
            this.cbVendors.AutoSize = true;
            this.cbVendors.Checked = global::BuddyLogger.Properties.Settings.Default.Vendors;
            this.cbVendors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVendors.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Vendors", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbVendors.Location = new System.Drawing.Point(128, 42);
            this.cbVendors.Name = "cbVendors";
            this.cbVendors.Size = new System.Drawing.Size(83, 21);
            this.cbVendors.TabIndex = 0;
            this.cbVendors.Text = "Vendors";
            this.cbVendors.UseVisualStyleBackColor = true;
            this.cbVendors.CheckedChanged += new System.EventHandler(this.cbPalceables_CheckedChanged);
            // 
            // cbNPC
            // 
            this.cbNPC.AutoSize = true;
            this.cbNPC.Checked = global::BuddyLogger.Properties.Settings.Default.Npc;
            this.cbNPC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNPC.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Npc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbNPC.Location = new System.Drawing.Point(128, 18);
            this.cbNPC.Name = "cbNPC";
            this.cbNPC.Size = new System.Drawing.Size(58, 21);
            this.cbNPC.TabIndex = 0;
            this.cbNPC.Text = "NPC";
            this.cbNPC.UseVisualStyleBackColor = true;
            this.cbNPC.CheckedChanged += new System.EventHandler(this.cbPalceables_CheckedChanged);
            // 
            // cbPalceables
            // 
            this.cbPalceables.AutoSize = true;
            this.cbPalceables.Checked = global::BuddyLogger.Properties.Settings.Default.Placeables;
            this.cbPalceables.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPalceables.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::BuddyLogger.Properties.Settings.Default, "Placeables", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbPalceables.Location = new System.Drawing.Point(3, 18);
            this.cbPalceables.Name = "cbPalceables";
            this.cbPalceables.Size = new System.Drawing.Size(99, 21);
            this.cbPalceables.TabIndex = 0;
            this.cbPalceables.Text = "Palceables";
            this.cbPalceables.UseVisualStyleBackColor = true;
            this.cbPalceables.CheckedChanged += new System.EventHandler(this.cbPalceables_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.engineTypeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.isLootableDataGridViewCheckBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.rotationDataGridViewTextBoxColumn,
            this.isDeletedDataGridViewCheckBoxColumn,
            this.guidDataGridViewTextBoxColumn,
            this.distanceSqrDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.yDiffDataGridViewTextBoxColumn,
            this.inLineOfSightDataGridViewCheckBoxColumn,
            this.isFacingDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.torPlaceableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 423);
            this.dataGridView1.TabIndex = 1;
            // 
            // engineTypeDataGridViewTextBoxColumn
            // 
            this.engineTypeDataGridViewTextBoxColumn.DataPropertyName = "EngineType";
            this.engineTypeDataGridViewTextBoxColumn.HeaderText = "EngineType";
            this.engineTypeDataGridViewTextBoxColumn.Name = "engineTypeDataGridViewTextBoxColumn";
            this.engineTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isLootableDataGridViewCheckBoxColumn
            // 
            this.isLootableDataGridViewCheckBoxColumn.DataPropertyName = "IsLootable";
            this.isLootableDataGridViewCheckBoxColumn.HeaderText = "IsLootable";
            this.isLootableDataGridViewCheckBoxColumn.Name = "isLootableDataGridViewCheckBoxColumn";
            this.isLootableDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rotationDataGridViewTextBoxColumn
            // 
            this.rotationDataGridViewTextBoxColumn.DataPropertyName = "Rotation";
            this.rotationDataGridViewTextBoxColumn.HeaderText = "Rotation";
            this.rotationDataGridViewTextBoxColumn.Name = "rotationDataGridViewTextBoxColumn";
            this.rotationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDeletedDataGridViewCheckBoxColumn
            // 
            this.isDeletedDataGridViewCheckBoxColumn.DataPropertyName = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.HeaderText = "IsDeleted";
            this.isDeletedDataGridViewCheckBoxColumn.Name = "isDeletedDataGridViewCheckBoxColumn";
            this.isDeletedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "Guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "Guid";
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            this.guidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceSqrDataGridViewTextBoxColumn
            // 
            this.distanceSqrDataGridViewTextBoxColumn.DataPropertyName = "DistanceSqr";
            this.distanceSqrDataGridViewTextBoxColumn.HeaderText = "DistanceSqr";
            this.distanceSqrDataGridViewTextBoxColumn.Name = "distanceSqrDataGridViewTextBoxColumn";
            this.distanceSqrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yDiffDataGridViewTextBoxColumn
            // 
            this.yDiffDataGridViewTextBoxColumn.DataPropertyName = "YDiff";
            this.yDiffDataGridViewTextBoxColumn.HeaderText = "YDiff";
            this.yDiffDataGridViewTextBoxColumn.Name = "yDiffDataGridViewTextBoxColumn";
            this.yDiffDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inLineOfSightDataGridViewCheckBoxColumn
            // 
            this.inLineOfSightDataGridViewCheckBoxColumn.DataPropertyName = "InLineOfSight";
            this.inLineOfSightDataGridViewCheckBoxColumn.HeaderText = "InLineOfSight";
            this.inLineOfSightDataGridViewCheckBoxColumn.Name = "inLineOfSightDataGridViewCheckBoxColumn";
            this.inLineOfSightDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // isFacingDataGridViewCheckBoxColumn
            // 
            this.isFacingDataGridViewCheckBoxColumn.DataPropertyName = "IsFacing";
            this.isFacingDataGridViewCheckBoxColumn.HeaderText = "IsFacing";
            this.isFacingDataGridViewCheckBoxColumn.Name = "isFacingDataGridViewCheckBoxColumn";
            this.isFacingDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // torPlaceableBindingSource
            // 
            this.torPlaceableBindingSource.DataSource = typeof(Buddy.Swtor.Objects.TorPlaceable);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 52);
            this.panel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSettings";
            this.Text = "Methods";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torPlaceableBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbMethods;
        private System.Windows.Forms.CheckBox cbFields;
        private System.Windows.Forms.CheckBox cbParents;
        private System.Windows.Forms.CheckBox cbMegaDump;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbPalceables;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox cbVendors;
        private System.Windows.Forms.CheckBox cbNPC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isLootableDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rotationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDeletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceSqrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inLineOfSightDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFacingDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource torPlaceableBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;

    }
}