namespace the_buyer_s_guide
{
    partial class AllPoints
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
            this.AddPointButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveOption = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadOption = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridForPoints = new System.Windows.Forms.DataGridView();
            this.pointsList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridForPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // AddPointButton
            // 
            this.AddPointButton.Location = new System.Drawing.Point(790, 51);
            this.AddPointButton.Name = "AddPointButton";
            this.AddPointButton.Size = new System.Drawing.Size(156, 58);
            this.AddPointButton.TabIndex = 0;
            this.AddPointButton.Text = "Add";
            this.AddPointButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1202, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveOption,
            this.LoadOption,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveOption
            // 
            this.SaveOption.Name = "SaveOption";
            this.SaveOption.Size = new System.Drawing.Size(359, 44);
            this.SaveOption.Text = "Save";
            this.SaveOption.Click += new System.EventHandler(this.SaveOption_Click);
            // 
            // LoadOption
            // 
            this.LoadOption.Name = "LoadOption";
            this.LoadOption.Size = new System.Drawing.Size(359, 44);
            this.LoadOption.Text = "Load";
            this.LoadOption.Click += new System.EventHandler(this.LoadOption_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // GridForPoints
            // 
            this.GridForPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridForPoints.Location = new System.Drawing.Point(171, 175);
            this.GridForPoints.Name = "GridForPoints";
            this.GridForPoints.RowHeadersWidth = 82;
            this.GridForPoints.RowTemplate.Height = 41;
            this.GridForPoints.Size = new System.Drawing.Size(480, 449);
            this.GridForPoints.TabIndex = 2;
            this.GridForPoints.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridForPoints_CellContentClick);
            // 
            // pointsList
            // 
            this.pointsList.FormattingEnabled = true;
            this.pointsList.ItemHeight = 32;
            this.pointsList.Location = new System.Drawing.Point(718, 148);
            this.pointsList.Name = "pointsList";
            this.pointsList.Size = new System.Drawing.Size(414, 644);
            this.pointsList.TabIndex = 3;
            this.pointsList.SelectedIndexChanged += new System.EventHandler(this.pointsList_SelectedIndexChanged);
            // 
            // AllPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 882);
            this.Controls.Add(this.pointsList);
            this.Controls.Add(this.GridForPoints);
            this.Controls.Add(this.AddPointButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AllPoints";
            this.Text = "AllPoints";
            this.Load += new System.EventHandler(this.AllPoints_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridForPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddPointButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem SaveOption;
        private ToolStripMenuItem LoadOption;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView GridForPoints;
        private ListBox pointsList;
    }
}