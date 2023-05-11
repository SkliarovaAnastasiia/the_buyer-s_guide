namespace TheBuyer_sGuide
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
            this.AllPointsButton = new System.Windows.Forms.Button();
            this.FavouriteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllPointsButton
            // 
            this.AllPointsButton.Location = new System.Drawing.Point(442, 155);
            this.AllPointsButton.Name = "AllPointsButton";
            this.AllPointsButton.Size = new System.Drawing.Size(354, 130);
            this.AllPointsButton.TabIndex = 0;
            this.AllPointsButton.Text = "button1";
            this.AllPointsButton.UseVisualStyleBackColor = true;
            this.AllPointsButton.Click += new System.EventHandler(this.AllPointsButton_Click);
            // 
            // FavouriteButton
            // 
            this.FavouriteButton.Location = new System.Drawing.Point(442, 362);
            this.FavouriteButton.Name = "FavouriteButton";
            this.FavouriteButton.Size = new System.Drawing.Size(354, 130);
            this.FavouriteButton.TabIndex = 1;
            this.FavouriteButton.Text = "button1";
            this.FavouriteButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(442, 567);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(354, 130);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "button1";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 894);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FavouriteButton);
            this.Controls.Add(this.AllPointsButton);
            this.Name = "EnterForm";
            this.Text = "EnterForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AllPointsButton;
        private System.Windows.Forms.Button FavouriteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}