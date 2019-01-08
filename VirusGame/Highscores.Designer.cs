namespace VirusGame
{
    partial class Highscores
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
            this.lblScores = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblPlaces = new System.Windows.Forms.Label();
            this.lblUsernames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.BackColor = System.Drawing.Color.Transparent;
            this.lblScores.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.Location = new System.Drawing.Point(197, 95);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(54, 19);
            this.lblScores.TabIndex = 7;
            this.lblScores.Text = "label1";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Teal;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(87, 293);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 42);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.BackColor = System.Drawing.Color.Transparent;
            this.lblHighscore.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(12, 70);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(249, 25);
            this.lblHighscore.TabIndex = 4;
            this.lblHighscore.Text = "Place  Username  Score";
            // 
            // lblPlaces
            // 
            this.lblPlaces.AutoSize = true;
            this.lblPlaces.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaces.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaces.Location = new System.Drawing.Point(13, 95);
            this.lblPlaces.Name = "lblPlaces";
            this.lblPlaces.Size = new System.Drawing.Size(54, 19);
            this.lblPlaces.TabIndex = 5;
            this.lblPlaces.Text = "label1";
            this.lblPlaces.Click += new System.EventHandler(this.lblPlaces_Click);
            // 
            // lblUsernames
            // 
            this.lblUsernames.AutoSize = true;
            this.lblUsernames.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernames.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernames.Location = new System.Drawing.Point(83, 95);
            this.lblUsernames.Name = "lblUsernames";
            this.lblUsernames.Size = new System.Drawing.Size(54, 19);
            this.lblUsernames.TabIndex = 6;
            this.lblUsernames.Text = "label1";
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(266, 347);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.lblUsernames);
            this.Controls.Add(this.lblPlaces);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.btnMenu);
            this.Name = "Highscores";
            this.Text = "Cyber Safe Kids - Highscores";
            this.Load += new System.EventHandler(this.Highscores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label lblPlaces;
        private System.Windows.Forms.Label lblUsernames;
    }
}