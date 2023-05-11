namespace TradingPoints
{
    partial class EnterForm
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
            this.TradingPointsButton = new System.Windows.Forms.Button();
            this.FavouriteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TradingPointsButton
            // 
            this.TradingPointsButton.Location = new System.Drawing.Point(379, 101);
            this.TradingPointsButton.Name = "TradingPointsButton";
            this.TradingPointsButton.Size = new System.Drawing.Size(339, 111);
            this.TradingPointsButton.TabIndex = 0;
            this.TradingPointsButton.Text = "button1";
            this.TradingPointsButton.UseVisualStyleBackColor = true;
            this.TradingPointsButton.Click += new System.EventHandler(this.TradingPointsButton_Click);
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.Location = new System.Drawing.Point(379, 277);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.Size = new System.Drawing.Size(339, 111);
            this.FavouriteButton.TabIndex = 1;
            this.FavouriteButton.Text = "button1";
            this.FavouriteButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(379, 460);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(339, 111);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "button1";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 815);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FavouriteButton);
            this.Controls.Add(this.TradingPointsButton);
            this.Name = "EnterForm";
            this.Text = "EnterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TradingPointsButton;
        private System.Windows.Forms.Button FavouriteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}