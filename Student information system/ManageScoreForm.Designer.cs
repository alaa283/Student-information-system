namespace Student_information_system
{
    partial class ManageScoreForm
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
            this.textBoxStudentScore = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveScore = new System.Windows.Forms.Button();
            this.buttonAvgScore = new System.Windows.Forms.Button();
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonShowStudents = new System.Windows.Forms.Button();
            this.buttonShowScores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxStudentScore
            // 
            this.textBoxStudentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentScore.Location = new System.Drawing.Point(165, 138);
            this.textBoxStudentScore.Name = "textBoxStudentScore";
            this.textBoxStudentScore.Size = new System.Drawing.Size(283, 26);
            this.textBoxStudentScore.TabIndex = 30;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentID.Location = new System.Drawing.Point(164, 30);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(283, 26);
            this.textBoxStudentID.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Student ID:";
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(164, 85);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(283, 28);
            this.comboBoxCourse.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Select Course:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(165, 193);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(283, 128);
            this.textBoxDescription.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Score:";
            // 
            // buttonRemoveScore
            // 
            this.buttonRemoveScore.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRemoveScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveScore.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveScore.Location = new System.Drawing.Point(334, 361);
            this.buttonRemoveScore.Name = "buttonRemoveScore";
            this.buttonRemoveScore.Size = new System.Drawing.Size(113, 48);
            this.buttonRemoveScore.TabIndex = 33;
            this.buttonRemoveScore.Text = "Remove";
            this.buttonRemoveScore.UseVisualStyleBackColor = false;
            // 
            // buttonAvgScore
            // 
            this.buttonAvgScore.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAvgScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAvgScore.ForeColor = System.Drawing.Color.White;
            this.buttonAvgScore.Location = new System.Drawing.Point(94, 428);
            this.buttonAvgScore.Name = "buttonAvgScore";
            this.buttonAvgScore.Size = new System.Drawing.Size(353, 48);
            this.buttonAvgScore.TabIndex = 32;
            this.buttonAvgScore.Text = "Average Score By Course";
            this.buttonAvgScore.UseVisualStyleBackColor = false;
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonAddScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddScore.ForeColor = System.Drawing.Color.White;
            this.buttonAddScore.Location = new System.Drawing.Point(164, 361);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(113, 48);
            this.buttonAddScore.TabIndex = 31;
            this.buttonAddScore.Text = "Add";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(464, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 410);
            this.dataGridView1.TabIndex = 34;
            // 
            // buttonShowStudents
            // 
            this.buttonShowStudents.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonShowStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowStudents.ForeColor = System.Drawing.Color.White;
            this.buttonShowStudents.Location = new System.Drawing.Point(464, 40);
            this.buttonShowStudents.Name = "buttonShowStudents";
            this.buttonShowStudents.Size = new System.Drawing.Size(155, 39);
            this.buttonShowStudents.TabIndex = 35;
            this.buttonShowStudents.Text = "Show Students";
            this.buttonShowStudents.UseVisualStyleBackColor = false;
            // 
            // buttonShowScores
            // 
            this.buttonShowScores.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonShowScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowScores.ForeColor = System.Drawing.Color.White;
            this.buttonShowScores.Location = new System.Drawing.Point(788, 40);
            this.buttonShowScores.Name = "buttonShowScores";
            this.buttonShowScores.Size = new System.Drawing.Size(155, 39);
            this.buttonShowScores.TabIndex = 36;
            this.buttonShowScores.Text = "Show Scores";
            this.buttonShowScores.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(418, 15);
            this.label5.TabIndex = 37;
            this.label5.Text = "*to edit a score you have to delete it and RE add it with the values you want   ";
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(946, 507);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonShowScores);
            this.Controls.Add(this.buttonShowStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonRemoveScore);
            this.Controls.Add(this.buttonAvgScore);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.textBoxStudentScore);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentScore;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveScore;
        private System.Windows.Forms.Button buttonAvgScore;
        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonShowStudents;
        private System.Windows.Forms.Button buttonShowScores;
        private System.Windows.Forms.Label label5;
    }
}