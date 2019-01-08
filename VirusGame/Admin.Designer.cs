namespace VirusGame
{
    partial class Admin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClear = new System.Windows.Forms.Button();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtChoice2Virus = new System.Windows.Forms.TextBox();
            this.txtChoice2Rep = new System.Windows.Forms.TextBox();
            this.txtChoice1Virus = new System.Windows.Forms.TextBox();
            this.txtChoice1Rep = new System.Windows.Forms.TextBox();
            this.txtChoice2Text = new System.Windows.Forms.TextBox();
            this.txtChoice1Text = new System.Windows.Forms.TextBox();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDeleteQuestionID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtClear);
            this.groupBox1.Controls.Add(this.txtQuestionID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAddQuestion);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.txtChoice2Virus);
            this.groupBox1.Controls.Add(this.txtChoice2Rep);
            this.groupBox1.Controls.Add(this.txtChoice1Virus);
            this.groupBox1.Controls.Add(this.txtChoice1Rep);
            this.groupBox1.Controls.Add(this.txtChoice2Text);
            this.groupBox1.Controls.Add(this.txtChoice1Text);
            this.groupBox1.Controls.Add(this.txtQuestionText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Update Question";
            // 
            // txtClear
            // 
            this.txtClear.BackColor = System.Drawing.Color.Teal;
            this.txtClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtClear.Location = new System.Drawing.Point(172, 430);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(75, 31);
            this.txtClear.TabIndex = 19;
            this.txtClear.Text = "Clear";
            this.txtClear.UseVisualStyleBackColor = false;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Location = new System.Drawing.Point(99, 16);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.Size = new System.Drawing.Size(160, 23);
            this.txtQuestionID.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Question ID:";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.Teal;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddQuestion.Location = new System.Drawing.Point(9, 430);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 31);
            this.btnAddQuestion.TabIndex = 16;
            this.btnAddQuestion.Text = "Add";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(90, 430);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(9, 374);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(250, 41);
            this.txtMessage.TabIndex = 15;
            // 
            // txtChoice2Virus
            // 
            this.txtChoice2Virus.Location = new System.Drawing.Point(114, 294);
            this.txtChoice2Virus.Name = "txtChoice2Virus";
            this.txtChoice2Virus.Size = new System.Drawing.Size(145, 23);
            this.txtChoice2Virus.TabIndex = 14;
            this.txtChoice2Virus.TextChanged += new System.EventHandler(this.txtChoice2Virus_TextChanged);
            // 
            // txtChoice2Rep
            // 
            this.txtChoice2Rep.Location = new System.Drawing.Point(154, 322);
            this.txtChoice2Rep.Name = "txtChoice2Rep";
            this.txtChoice2Rep.Size = new System.Drawing.Size(105, 23);
            this.txtChoice2Rep.TabIndex = 13;
            // 
            // txtChoice1Virus
            // 
            this.txtChoice1Virus.Location = new System.Drawing.Point(114, 232);
            this.txtChoice1Virus.Name = "txtChoice1Virus";
            this.txtChoice1Virus.Size = new System.Drawing.Size(145, 23);
            this.txtChoice1Virus.TabIndex = 12;
            // 
            // txtChoice1Rep
            // 
            this.txtChoice1Rep.Location = new System.Drawing.Point(147, 261);
            this.txtChoice1Rep.Name = "txtChoice1Rep";
            this.txtChoice1Rep.Size = new System.Drawing.Size(112, 23);
            this.txtChoice1Rep.TabIndex = 11;
            // 
            // txtChoice2Text
            // 
            this.txtChoice2Text.Location = new System.Drawing.Point(114, 206);
            this.txtChoice2Text.Name = "txtChoice2Text";
            this.txtChoice2Text.Size = new System.Drawing.Size(145, 23);
            this.txtChoice2Text.TabIndex = 10;
            // 
            // txtChoice1Text
            // 
            this.txtChoice1Text.Location = new System.Drawing.Point(114, 174);
            this.txtChoice1Text.Name = "txtChoice1Text";
            this.txtChoice1Text.Size = new System.Drawing.Size(145, 23);
            this.txtChoice1Text.TabIndex = 9;
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Location = new System.Drawing.Point(9, 67);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(250, 99);
            this.txtQuestionText.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label9.Location = new System.Drawing.Point(6, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Choice 2 Reputation:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label8.Location = new System.Drawing.Point(6, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Choice 2 Virus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label7.Location = new System.Drawing.Point(6, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Choice 1 Reputation:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Choice 1 Virus:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label5.Location = new System.Drawing.Point(6, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label4.Location = new System.Drawing.Point(6, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Choice 2 Text:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Choice 1 Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10F);
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Question Text:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDeleteQuestionID);
            this.groupBox3.Font = new System.Drawing.Font("Rockwell", 10F);
            this.groupBox3.Location = new System.Drawing.Point(12, 587);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 91);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Question";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(9, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Question ID:";
            // 
            // txtDeleteQuestionID
            // 
            this.txtDeleteQuestionID.Location = new System.Drawing.Point(99, 22);
            this.txtDeleteQuestionID.Name = "txtDeleteQuestionID";
            this.txtDeleteQuestionID.Size = new System.Drawing.Size(129, 23);
            this.txtDeleteQuestionID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 550);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Teal;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenu.Location = new System.Drawing.Point(12, 684);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(84, 50);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 740);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Cyber Safe Kids - Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtChoice2Virus;
        private System.Windows.Forms.TextBox txtChoice2Rep;
        private System.Windows.Forms.TextBox txtChoice1Virus;
        private System.Windows.Forms.TextBox txtChoice1Rep;
        private System.Windows.Forms.TextBox txtChoice2Text;
        private System.Windows.Forms.TextBox txtChoice1Text;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.TextBox txtDeleteQuestionID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtQuestionID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.Button btnMenu;
    }
}