namespace AttributeFinder
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.toolStripMenu = new System.Windows.Forms.ToolStrip();
			this.tsbLoadAttributes = new System.Windows.Forms.ToolStripButton();
			this.tsbClose = new System.Windows.Forms.ToolStripButton();
			this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.gbEntities = new System.Windows.Forms.GroupBox();
			this.splitContainerResults = new System.Windows.Forms.SplitContainer();
			this.gwAttributes = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbxEnableEntityFiltering = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbxEnableAttributeFiltering = new System.Windows.Forms.CheckBox();
			this.grbFilterAttributes = new System.Windows.Forms.GroupBox();
			this.lblPrefixAttr = new System.Windows.Forms.Label();
			this.txtAttributePrefixFilter = new System.Windows.Forms.TextBox();
			this.cbxEnableAttributePrefixFilter = new System.Windows.Forms.CheckBox();
			this.cbxListAttributeTypes = new System.Windows.Forms.CheckedListBox();
			this.grbFilterEntities = new System.Windows.Forms.GroupBox();
			this.lblPrefix = new System.Windows.Forms.Label();
			this.txtEntityPrefixFilter = new System.Windows.Forms.TextBox();
			this.cbxEnableEntityPrefixFiltering = new System.Windows.Forms.CheckBox();
			this.cbxListEntities = new System.Windows.Forms.CheckedListBox();
			this.lvAttributes = new System.Windows.Forms.ListView();
			this.chAttributeDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAttributeLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chAttributeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chEntityDisplayName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chEntityLogicalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.lblMessage = new System.Windows.Forms.Label();
			this.toolStripMenu.SuspendLayout();
			this.gbEntities.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerResults)).BeginInit();
			this.splitContainerResults.Panel1.SuspendLayout();
			this.splitContainerResults.Panel2.SuspendLayout();
			this.splitContainerResults.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gwAttributes)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.grbFilterAttributes.SuspendLayout();
			this.grbFilterEntities.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripMenu
			// 
			this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadAttributes,
            this.tsbClose,
            this.tssSeparator1});
			this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
			this.toolStripMenu.Name = "toolStripMenu";
			this.toolStripMenu.Size = new System.Drawing.Size(1277, 31);
			this.toolStripMenu.TabIndex = 4;
			this.toolStripMenu.Text = "toolStrip1";
			// 
			// tsbLoadAttributes
			// 
			this.tsbLoadAttributes.Image = global::AttributeFinder.Properties.Resources.CopyView_16;
			this.tsbLoadAttributes.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbLoadAttributes.Name = "tsbLoadAttributes";
			this.tsbLoadAttributes.Size = new System.Drawing.Size(121, 28);
			this.tsbLoadAttributes.Text = "Loads Attributes";
			this.tsbLoadAttributes.ToolTipText = "Loads all the attributes for search";
			this.tsbLoadAttributes.Click += new System.EventHandler(this.tsb_Click);
			// 
			// tsbClose
			// 
			this.tsbClose.Image = global::AttributeFinder.Properties.Resources.CloseChart32;
			this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbClose.Name = "tsbClose";
			this.tsbClose.Size = new System.Drawing.Size(64, 28);
			this.tsbClose.Text = "Close";
			this.tsbClose.ToolTipText = "Closes the Tool";
			this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click_1);
			// 
			// tssSeparator1
			// 
			this.tssSeparator1.Name = "tssSeparator1";
			this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// gbEntities
			// 
			this.gbEntities.Controls.Add(this.splitContainerResults);
			this.gbEntities.Controls.Add(this.lvAttributes);
			this.gbEntities.Controls.Add(this.panel2);
			this.gbEntities.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbEntities.Location = new System.Drawing.Point(0, 31);
			this.gbEntities.Name = "gbEntities";
			this.gbEntities.Size = new System.Drawing.Size(1277, 894);
			this.gbEntities.TabIndex = 5;
			this.gbEntities.TabStop = false;
			this.gbEntities.Text = "Attributes";
			// 
			// splitContainerResults
			// 
			this.splitContainerResults.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerResults.Location = new System.Drawing.Point(3, 42);
			this.splitContainerResults.Name = "splitContainerResults";
			// 
			// splitContainerResults.Panel1
			// 
			this.splitContainerResults.Panel1.Controls.Add(this.gwAttributes);
			this.splitContainerResults.Panel1.Controls.Add(this.lblMessage);
			this.splitContainerResults.Panel1MinSize = 75;
			// 
			// splitContainerResults.Panel2
			// 
			this.splitContainerResults.Panel2.Controls.Add(this.groupBox2);
			this.splitContainerResults.Panel2.Controls.Add(this.groupBox1);
			this.splitContainerResults.Panel2.Controls.Add(this.grbFilterAttributes);
			this.splitContainerResults.Panel2.Controls.Add(this.grbFilterEntities);
			this.splitContainerResults.Size = new System.Drawing.Size(1271, 849);
			this.splitContainerResults.SplitterDistance = 982;
			this.splitContainerResults.TabIndex = 5;
			// 
			// gwAttributes
			// 
			this.gwAttributes.AllowUserToAddRows = false;
			this.gwAttributes.AllowUserToDeleteRows = false;
			this.gwAttributes.AllowUserToOrderColumns = true;
			this.gwAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gwAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gwAttributes.Location = new System.Drawing.Point(0, 0);
			this.gwAttributes.Name = "gwAttributes";
			this.gwAttributes.ReadOnly = true;
			this.gwAttributes.Size = new System.Drawing.Size(982, 849);
			this.gwAttributes.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbxEnableEntityFiltering);
			this.groupBox2.Location = new System.Drawing.Point(12, 7);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(267, 39);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			// 
			// cbxEnableEntityFiltering
			// 
			this.cbxEnableEntityFiltering.AutoSize = true;
			this.cbxEnableEntityFiltering.Location = new System.Drawing.Point(49, 16);
			this.cbxEnableEntityFiltering.Name = "cbxEnableEntityFiltering";
			this.cbxEnableEntityFiltering.Size = new System.Drawing.Size(131, 17);
			this.cbxEnableEntityFiltering.TabIndex = 2;
			this.cbxEnableEntityFiltering.Text = "Enable Filter By Entitty";
			this.cbxEnableEntityFiltering.UseVisualStyleBackColor = true;
			this.cbxEnableEntityFiltering.CheckedChanged += new System.EventHandler(this.cbxFilterByEntity_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbxEnableAttributeFiltering);
			this.groupBox1.Location = new System.Drawing.Point(12, 456);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(267, 34);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// cbxEnableAttributeFiltering
			// 
			this.cbxEnableAttributeFiltering.AutoSize = true;
			this.cbxEnableAttributeFiltering.Location = new System.Drawing.Point(49, 11);
			this.cbxEnableAttributeFiltering.Name = "cbxEnableAttributeFiltering";
			this.cbxEnableAttributeFiltering.Size = new System.Drawing.Size(167, 17);
			this.cbxEnableAttributeFiltering.TabIndex = 1;
			this.cbxEnableAttributeFiltering.Text = "Enable Attribute Type Filtering";
			this.cbxEnableAttributeFiltering.UseVisualStyleBackColor = true;
			this.cbxEnableAttributeFiltering.CheckedChanged += new System.EventHandler(this.cbxEnableAttributeFiltering_CheckedChanged);
			// 
			// grbFilterAttributes
			// 
			this.grbFilterAttributes.Controls.Add(this.lblPrefixAttr);
			this.grbFilterAttributes.Controls.Add(this.txtAttributePrefixFilter);
			this.grbFilterAttributes.Controls.Add(this.cbxEnableAttributePrefixFilter);
			this.grbFilterAttributes.Controls.Add(this.cbxListAttributeTypes);
			this.grbFilterAttributes.Enabled = false;
			this.grbFilterAttributes.Location = new System.Drawing.Point(12, 498);
			this.grbFilterAttributes.Name = "grbFilterAttributes";
			this.grbFilterAttributes.Size = new System.Drawing.Size(270, 341);
			this.grbFilterAttributes.TabIndex = 3;
			this.grbFilterAttributes.TabStop = false;
			this.grbFilterAttributes.Text = "Filter Attribute Types";
			// 
			// lblPrefixAttr
			// 
			this.lblPrefixAttr.AutoSize = true;
			this.lblPrefixAttr.Location = new System.Drawing.Point(8, 308);
			this.lblPrefixAttr.Name = "lblPrefixAttr";
			this.lblPrefixAttr.Size = new System.Drawing.Size(33, 13);
			this.lblPrefixAttr.TabIndex = 5;
			this.lblPrefixAttr.Text = "Prefix";
			// 
			// txtAttributePrefixFilter
			// 
			this.txtAttributePrefixFilter.Enabled = false;
			this.txtAttributePrefixFilter.Location = new System.Drawing.Point(49, 305);
			this.txtAttributePrefixFilter.Name = "txtAttributePrefixFilter";
			this.txtAttributePrefixFilter.Size = new System.Drawing.Size(207, 20);
			this.txtAttributePrefixFilter.TabIndex = 4;
			// 
			// cbxEnableAttributePrefixFilter
			// 
			this.cbxEnableAttributePrefixFilter.AutoSize = true;
			this.cbxEnableAttributePrefixFilter.Enabled = false;
			this.cbxEnableAttributePrefixFilter.Location = new System.Drawing.Point(6, 281);
			this.cbxEnableAttributePrefixFilter.Name = "cbxEnableAttributePrefixFilter";
			this.cbxEnableAttributePrefixFilter.Size = new System.Drawing.Size(127, 17);
			this.cbxEnableAttributePrefixFilter.TabIndex = 3;
			this.cbxEnableAttributePrefixFilter.Text = "Enable Prefix Filtering";
			this.cbxEnableAttributePrefixFilter.UseVisualStyleBackColor = true;
			this.cbxEnableAttributePrefixFilter.CheckedChanged += new System.EventHandler(this.cbxEnableAttributePrefixFilter_CheckedChanged);
			// 
			// cbxListAttributeTypes
			// 
			this.cbxListAttributeTypes.Enabled = false;
			this.cbxListAttributeTypes.FormattingEnabled = true;
			this.cbxListAttributeTypes.Location = new System.Drawing.Point(9, 23);
			this.cbxListAttributeTypes.Name = "cbxListAttributeTypes";
			this.cbxListAttributeTypes.Size = new System.Drawing.Size(254, 244);
			this.cbxListAttributeTypes.TabIndex = 0;
			// 
			// grbFilterEntities
			// 
			this.grbFilterEntities.Controls.Add(this.lblPrefix);
			this.grbFilterEntities.Controls.Add(this.txtEntityPrefixFilter);
			this.grbFilterEntities.Controls.Add(this.cbxEnableEntityPrefixFiltering);
			this.grbFilterEntities.Controls.Add(this.cbxListEntities);
			this.grbFilterEntities.Enabled = false;
			this.grbFilterEntities.Location = new System.Drawing.Point(12, 52);
			this.grbFilterEntities.Name = "grbFilterEntities";
			this.grbFilterEntities.Size = new System.Drawing.Size(267, 400);
			this.grbFilterEntities.TabIndex = 2;
			this.grbFilterEntities.TabStop = false;
			this.grbFilterEntities.Text = "Filter Entities";
			// 
			// lblPrefix
			// 
			this.lblPrefix.AutoSize = true;
			this.lblPrefix.Location = new System.Drawing.Point(7, 374);
			this.lblPrefix.Name = "lblPrefix";
			this.lblPrefix.Size = new System.Drawing.Size(33, 13);
			this.lblPrefix.TabIndex = 7;
			this.lblPrefix.Text = "Prefix";
			// 
			// txtEntityPrefixFilter
			// 
			this.txtEntityPrefixFilter.Enabled = false;
			this.txtEntityPrefixFilter.Location = new System.Drawing.Point(62, 368);
			this.txtEntityPrefixFilter.Name = "txtEntityPrefixFilter";
			this.txtEntityPrefixFilter.Size = new System.Drawing.Size(183, 20);
			this.txtEntityPrefixFilter.TabIndex = 6;
			// 
			// cbxEnableEntityPrefixFiltering
			// 
			this.cbxEnableEntityPrefixFiltering.AutoSize = true;
			this.cbxEnableEntityPrefixFiltering.Enabled = false;
			this.cbxEnableEntityPrefixFiltering.Location = new System.Drawing.Point(9, 350);
			this.cbxEnableEntityPrefixFiltering.Name = "cbxEnableEntityPrefixFiltering";
			this.cbxEnableEntityPrefixFiltering.Size = new System.Drawing.Size(127, 17);
			this.cbxEnableEntityPrefixFiltering.TabIndex = 5;
			this.cbxEnableEntityPrefixFiltering.Text = "Enable Prefix Filtering";
			this.cbxEnableEntityPrefixFiltering.UseVisualStyleBackColor = true;
			this.cbxEnableEntityPrefixFiltering.CheckedChanged += new System.EventHandler(this.cbxEnableEntityPrefixFiltering_CheckedChanged);
			// 
			// cbxListEntities
			// 
			this.cbxListEntities.Enabled = false;
			this.cbxListEntities.FormattingEnabled = true;
			this.cbxListEntities.Location = new System.Drawing.Point(9, 20);
			this.cbxListEntities.Name = "cbxListEntities";
			this.cbxListEntities.Size = new System.Drawing.Size(249, 319);
			this.cbxListEntities.TabIndex = 1;
			// 
			// lvAttributes
			// 
			this.lvAttributes.CheckBoxes = true;
			this.lvAttributes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAttributeDisplayName,
            this.chAttributeLogicalName,
            this.chAttributeType,
            this.chEntityDisplayName,
            this.chEntityLogicalName});
			this.lvAttributes.FullRowSelect = true;
			this.lvAttributes.HideSelection = false;
			this.lvAttributes.Location = new System.Drawing.Point(846, 438);
			this.lvAttributes.Name = "lvAttributes";
			this.lvAttributes.Size = new System.Drawing.Size(1223, 599);
			this.lvAttributes.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvAttributes.TabIndex = 2;
			this.lvAttributes.UseCompatibleStateImageBehavior = false;
			this.lvAttributes.View = System.Windows.Forms.View.Details;
			this.lvAttributes.Visible = false;
			// 
			// chAttributeDisplayName
			// 
			this.chAttributeDisplayName.Text = "Display Name";
			this.chAttributeDisplayName.Width = 200;
			// 
			// chAttributeLogicalName
			// 
			this.chAttributeLogicalName.Text = "Logical Name";
			this.chAttributeLogicalName.Width = 200;
			// 
			// chAttributeType
			// 
			this.chAttributeType.Text = "Attribute Type";
			this.chAttributeType.Width = 150;
			// 
			// chEntityDisplayName
			// 
			this.chEntityDisplayName.DisplayIndex = 4;
			this.chEntityDisplayName.Text = "Entity Display Name";
			this.chEntityDisplayName.Width = 150;
			// 
			// chEntityLogicalName
			// 
			this.chEntityLogicalName.DisplayIndex = 3;
			this.chEntityLogicalName.Text = "Entity Logical Name";
			this.chEntityLogicalName.Width = 150;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtSearch);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1271, 26);
			this.panel2.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Search Attributes";
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.txtSearch.Enabled = false;
			this.txtSearch.Location = new System.Drawing.Point(92, 3);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(1173, 20);
			this.txtSearch.TabIndex = 0;
			this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.lblMessage.Location = new System.Drawing.Point(0, 0);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(982, 849);
			this.lblMessage.TabIndex = 5;
			this.lblMessage.Text = "Please click Load Attributes to retrieve attributes from CDS";
			this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MyPluginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gbEntities);
			this.Controls.Add(this.toolStripMenu);
			this.Name = "MyPluginControl";
			this.Size = new System.Drawing.Size(1277, 925);
			this.Load += new System.EventHandler(this.MyPluginControl_Load);
			this.toolStripMenu.ResumeLayout(false);
			this.toolStripMenu.PerformLayout();
			this.gbEntities.ResumeLayout(false);
			this.splitContainerResults.Panel1.ResumeLayout(false);
			this.splitContainerResults.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerResults)).EndInit();
			this.splitContainerResults.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gwAttributes)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grbFilterAttributes.ResumeLayout(false);
			this.grbFilterAttributes.PerformLayout();
			this.grbFilterEntities.ResumeLayout(false);
			this.grbFilterEntities.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLoadAttributes;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.GroupBox gbEntities;
        private System.Windows.Forms.ListView lvAttributes;
        private System.Windows.Forms.ColumnHeader chAttributeDisplayName;
        private System.Windows.Forms.ColumnHeader chAttributeLogicalName;
        private System.Windows.Forms.ColumnHeader chAttributeType;
        private System.Windows.Forms.ColumnHeader chEntityDisplayName;
        private System.Windows.Forms.ColumnHeader chEntityLogicalName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gwAttributes;
        private System.Windows.Forms.SplitContainer splitContainerResults;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grbFilterAttributes;
        private System.Windows.Forms.TextBox txtAttributePrefixFilter;
        private System.Windows.Forms.CheckBox cbxEnableAttributePrefixFilter;
        private System.Windows.Forms.CheckBox cbxEnableAttributeFiltering;
        private System.Windows.Forms.CheckedListBox cbxListAttributeTypes;
        private System.Windows.Forms.GroupBox grbFilterEntities;
        private System.Windows.Forms.CheckBox cbxEnableEntityFiltering;
        private System.Windows.Forms.CheckedListBox cbxListEntities;
        private System.Windows.Forms.TextBox txtEntityPrefixFilter;
        private System.Windows.Forms.CheckBox cbxEnableEntityPrefixFiltering;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrefixAttr;
        private System.Windows.Forms.Label lblPrefix;
		private System.Windows.Forms.Label lblMessage;
	}
}
