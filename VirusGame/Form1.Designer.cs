namespace VirusGame
{
    partial class MainGame
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
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblReputation = new System.Windows.Forms.Label();
            this.lblVirus = new System.Windows.Forms.Label();
            this.lblTurnCounter = new System.Windows.Forms.Label();
            this.prgReputation = new System.Windows.Forms.ProgressBar();
            this.prgVirus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.Teal;
            this.btnChoice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoice1.Location = new System.Drawing.Point(63, 402);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(100, 51);
            this.btnChoice1.TabIndex = 0;
            this.btnChoice1.Text = "Choice1";
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.Teal;
            this.btnChoice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoice2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoice2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChoice2.Location = new System.Drawing.Point(381, 402);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(100, 51);
            this.btnChoice2.TabIndex = 1;
            this.btnChoice2.Text = "Choice2";
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.Transparent;
            this.lblQuestion.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(11, 130);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(517, 249);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question Label";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // lblReputation
            // 
            this.lblReputation.AutoSize = true;
            this.lblReputation.BackColor = System.Drawing.Color.Transparent;
            this.lblReputation.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReputation.Location = new System.Drawing.Point(12, 71);
            this.lblReputation.Name = "lblReputation";
            this.lblReputation.Size = new System.Drawing.Size(159, 21);
            this.lblReputation.TabIndex = 3;
            this.lblReputation.Text = "Reputation Label";
            // 
            // lblVirus
            // 
            this.lblVirus.AutoSize = true;
            this.lblVirus.BackColor = System.Drawing.Color.Transparent;
            this.lblVirus.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirus.Location = new System.Drawing.Point(377, 71);
            this.lblVirus.Name = "lblVirus";
            this.lblVirus.Size = new System.Drawing.Size(111, 21);
            this.lblVirus.TabIndex = 4;
            this.lblVirus.Text = "Virus Label";
            // 
            // lblTurnCounter
            // 
            this.lblTurnCounter.AutoSize = true;
            this.lblTurnCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnCounter.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnCounter.Location = new System.Drawing.Point(221, 89);
            this.lblTurnCounter.Name = "lblTurnCounter";
            this.lblTurnCounter.Size = new System.Drawing.Size(107, 19);
            this.lblTurnCounter.TabIndex = 5;
            this.lblTurnCounter.Text = "Turn Counter";
            // 
            // prgReputation
            // 
            this.prgReputation.Location = new System.Drawing.Point(16, 99);
            this.prgReputation.Name = "prgReputation";
            this.prgReputation.Size = new System.Drawing.Size(147, 23);
            this.prgReputation.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgReputation.TabIndex = 6;
            // 
            // prgVirus
            // 
            this.prgVirus.ForeColor = System.Drawing.Color.Red;
            this.prgVirus.Location = new System.Drawing.Point(381, 99);
            this.prgVirus.Name = "prgVirus";
            this.prgVirus.Size = new System.Drawing.Size(147, 23);
            this.prgVirus.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgVirus.TabIndex = 7;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(541, 477);
            this.Controls.Add(this.prgVirus);
            this.Controls.Add(this.prgReputation);
            this.Controls.Add(this.lblTurnCounter);
            this.Controls.Add(this.lblVirus);
            this.Controls.Add(this.lblReputation);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Name = "MainGame";
            this.Text = "Cyber Safe Kids - Game";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoice1;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblReputation;
        private System.Windows.Forms.Label lblVirus;
        private System.Windows.Forms.Label lblTurnCounter;
        private System.Windows.Forms.ProgressBar prgReputation;
        private System.Windows.Forms.ProgressBar prgVirus;
    }
}

