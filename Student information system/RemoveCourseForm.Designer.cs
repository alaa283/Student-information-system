namespace Student_information_system
{
    partial class RemoveCourseForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCourseID = new System.Windows.Forms.TextBox();
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Enter The Course ID :";
            // 
            // textBoxCourseID
            // 
            this.textBoxCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseID.Location = new System.Drawing.Point(267, 47);
            this.textBoxCourseID.Name = "textBoxCourseID";
            this.textBoxCourseID.Size = new System.Drawing.Size(219, 26);
            this.textBoxCourseID.TabIndex = 14;
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.BackColor = System.Drawing.Color.Maroon;
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveCourse.Location = new System.Drawing.Point(514, 43);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(117, 35);
            this.buttonRemoveCourse.TabIndex = 15;
            this.buttonRemoveCourse.Text = "Remove";
            this.buttonRemoveCourse.UseVisualStyleBackColor = false;
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(642, 110);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Controls.Add(this.textBoxCourseID);
            this.Controls.Add(this.label4);
            this.Name = "RemoveCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCourseID;
        private System.Windows.Forms.Button buttonRemoveCourse;
    }
}