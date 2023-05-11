namespace the_buyer_s_guide
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
            this.AllPointsButton = new System.Windows.Forms.Button();
            this.FavouriteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllPointsButton
            // 
            this.AllPointsButton.Location = new System.Drawing.Point(523, 157);
            this.AllPointsButton.Name = "AllPointsButton";
            this.AllPointsButton.Size = new System.Drawing.Size(381, 145);
            this.AllPointsButton.TabIndex = 0;
            this.AllPointsButton.Text = "Всі торгові точки";
            this.AllPointsButton.UseVisualStyleBackColor = true;
            this.AllPointsButton.Click += new System.EventHandler(this.AllPointsButton_Click);
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.Location = new System.Drawing.Point(523, 387);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.Size = new System.Drawing.Size(381, 145);
            this.FavouriteButton.TabIndex = 1;
            this.FavouriteButton.Text = "Вибране";
            this.FavouriteButton.UseVisualStyleBackColor = true;
            this.FavouriteButton.Click += new System.EventHandler(this.FavouriteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(523, 619);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(381, 145);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Вийти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 902);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FavouriteButton);
            this.Controls.Add(this.AllPointsButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AllPointsButton;
        private Button FavouriteButton;
        private Button ExitButton;
    }
}