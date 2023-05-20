namespace TraidingPointsApp
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownershipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.specializationDataGridViewTextBoxColumn,
            this.ownershipDataGridViewTextBoxColumn,
            this.workingHoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 42;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1245, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 200;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // specializationDataGridViewTextBoxColumn
            // 
            this.specializationDataGridViewTextBoxColumn.DataPropertyName = "Specialization";
            this.specializationDataGridViewTextBoxColumn.HeaderText = "Specialization";
            this.specializationDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.specializationDataGridViewTextBoxColumn.Name = "specializationDataGridViewTextBoxColumn";
            this.specializationDataGridViewTextBoxColumn.Width = 200;
            // 
            // ownershipDataGridViewTextBoxColumn
            // 
            this.ownershipDataGridViewTextBoxColumn.DataPropertyName = "Ownership";
            this.ownershipDataGridViewTextBoxColumn.HeaderText = "Ownership";
            this.ownershipDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.ownershipDataGridViewTextBoxColumn.Name = "ownershipDataGridViewTextBoxColumn";
            this.ownershipDataGridViewTextBoxColumn.Width = 200;
            // 
            // workingHoursDataGridViewTextBoxColumn
            // 
            this.workingHoursDataGridViewTextBoxColumn.DataPropertyName = "WorkingHours";
            this.workingHoursDataGridViewTextBoxColumn.HeaderText = "WorkingHours";
            this.workingHoursDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.workingHoursDataGridViewTextBoxColumn.Name = "workingHoursDataGridViewTextBoxColumn";
            this.workingHoursDataGridViewTextBoxColumn.Width = 200;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataSource = typeof(TraidingPointsApp.Models.Shop);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(42, 42);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shopToolStripMenuItem,
            this.favoriteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1353, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 41);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 46);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shopToolStripMenuItem
            // 
            this.shopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addShopToolStripMenuItem,
            this.removeShopToolStripMenuItem,
            this.editShopToolStripMenuItem});
            this.shopToolStripMenuItem.Name = "shopToolStripMenuItem";
            this.shopToolStripMenuItem.Size = new System.Drawing.Size(116, 41);
            this.shopToolStripMenuItem.Text = "Shop";
            // 
            // addShopToolStripMenuItem
            // 
            this.addShopToolStripMenuItem.Name = "addShopToolStripMenuItem";
            this.addShopToolStripMenuItem.Size = new System.Drawing.Size(275, 46);
            this.addShopToolStripMenuItem.Text = "Add";
            this.addShopToolStripMenuItem.Click += new System.EventHandler(this.addShopToolStripMenuItem_Click);
            // 
            // removeShopToolStripMenuItem
            // 
            this.removeShopToolStripMenuItem.Name = "removeShopToolStripMenuItem";
            this.removeShopToolStripMenuItem.Size = new System.Drawing.Size(275, 46);
            this.removeShopToolStripMenuItem.Text = "Remove";
            this.removeShopToolStripMenuItem.Click += new System.EventHandler(this.removeShopToolStripMenuItem_Click);
            // 
            // editShopToolStripMenuItem
            // 
            this.editShopToolStripMenuItem.Name = "editShopToolStripMenuItem";
            this.editShopToolStripMenuItem.Size = new System.Drawing.Size(275, 46);
            this.editShopToolStripMenuItem.Text = "Edit";
            this.editShopToolStripMenuItem.Click += new System.EventHandler(this.editShopToolStripMenuItem_Click);
            // 
            // favoriteToolStripMenuItem
            // 
            this.favoriteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoriteToolStripMenuItem,
            this.showFavoritesToolStripMenuItem,
            this.saveToFavoritesToolStripMenuItem,
            this.removeFromFavoritesToolStripMenuItem});
            this.favoriteToolStripMenuItem.Name = "favoriteToolStripMenuItem";
            this.favoriteToolStripMenuItem.Size = new System.Drawing.Size(160, 41);
            this.favoriteToolStripMenuItem.Text = "Favorite";
            // 
            // addToFavoriteToolStripMenuItem
            // 
            this.addToFavoriteToolStripMenuItem.Name = "addToFavoriteToolStripMenuItem";
            this.addToFavoriteToolStripMenuItem.Size = new System.Drawing.Size(359, 46);
            this.addToFavoriteToolStripMenuItem.Text = "Add";
            this.addToFavoriteToolStripMenuItem.Click += new System.EventHandler(this.addToFavoriteToolStripMenuItem_Click);
            // 
            // showFavoritesToolStripMenuItem
            // 
            this.showFavoritesToolStripMenuItem.Name = "showFavoritesToolStripMenuItem";
            this.showFavoritesToolStripMenuItem.Size = new System.Drawing.Size(359, 46);
            this.showFavoritesToolStripMenuItem.Text = "Show";
            this.showFavoritesToolStripMenuItem.Click += new System.EventHandler(this.showFavoritesToolStripMenuItem_Click);
            // 
            // saveToFavoritesToolStripMenuItem
            // 
            this.saveToFavoritesToolStripMenuItem.Name = "saveToFavoritesToolStripMenuItem";
            this.saveToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(359, 46);
            this.saveToFavoritesToolStripMenuItem.Text = "Save";
            this.saveToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.saveToFavoritesToolStripMenuItem_Click);
            // 
            // removeFromFavoritesToolStripMenuItem
            // 
            this.removeFromFavoritesToolStripMenuItem.Name = "removeFromFavoritesToolStripMenuItem";
            this.removeFromFavoritesToolStripMenuItem.Size = new System.Drawing.Size(359, 46);
            this.removeFromFavoritesToolStripMenuItem.Text = "Remove";
            this.removeFromFavoritesToolStripMenuItem.Click += new System.EventHandler(this.removeFromFavoritesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(46, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Location = new System.Drawing.Point(517, 125);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(217, 77);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Location = new System.Drawing.Point(115, 50);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(1024, 38);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1353, 1037);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editShopToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specializationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownershipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ToolStripMenuItem favoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToFavoriteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFavoritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromFavoritesToolStripMenuItem;
    }
}