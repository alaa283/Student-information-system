namespace Student_information_system
{
    partial class ManageCourseForm
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
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxCoursename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEditCourse = new System.Windows.Forms.Button();
            this.buttonRemoveCourse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.listBoxCourses = new System.Windows.Forms.ListBox();
            this.labelTotalStudents = new System.Windows.Forms.Label();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownHours.Location = new System.Drawing.Point(207, 160);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(284, 26);
            this.numericUpDownHours.TabIndex = 13;
            this.numericUpDownHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(81, 497);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(113, 48);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(207, 232);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(284, 128);
            this.textBoxDescription.TabIndex = 11;
            // 
            // textBoxCoursename
            // 
            this.textBoxCoursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoursename.Location = new System.Drawing.Point(207, 98);
            this.textBoxCoursename.Name = "textBoxCoursename";
            this.textBoxCoursename.Size = new System.Drawing.Size(284, 26);
            this.textBoxCoursename.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(63, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(33, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hours Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course Name:";
            // 
            // buttonEditCourse
            // 
            this.buttonEditCourse.BackColor = System.Drawing.Color.IndianRed;
            this.buttonEditCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCourse.ForeColor = System.Drawing.Color.White;
            this.buttonEditCourse.Location = new System.Drawing.Point(207, 497);
            this.buttonEditCourse.Name = "buttonEditCourse";
            this.buttonEditCourse.Size = new System.Drawing.Size(113, 48);
            this.buttonEditCourse.TabIndex = 14;
            this.buttonEditCourse.Text = "Edit";
            this.buttonEditCourse.UseVisualStyleBackColor = false;
            this.buttonEditCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemoveCourse
            // 
            this.buttonRemoveCourse.BackColor = System.Drawing.Color.DarkRed;
            this.buttonRemoveCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCourse.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveCourse.Location = new System.Drawing.Point(336, 497);
            this.buttonRemoveCourse.Name = "buttonRemoveCourse";
            this.buttonRemoveCourse.Size = new System.Drawing.Size(113, 48);
            this.buttonRemoveCourse.TabIndex = 15;
            this.buttonRemoveCourse.Text = "Remove";
            this.buttonRemoveCourse.UseVisualStyleBackColor = false;
            this.buttonRemoveCourse.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(153, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(207, 43);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(284, 26);
            this.textBoxID.TabIndex = 17;
            // 
            // listBoxCourses
            // 
            this.listBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCourses.FormattingEnabled = true;
            this.listBoxCourses.ItemHeight = 25;
            this.listBoxCourses.Location = new System.Drawing.Point(523, 44);
            this.listBoxCourses.Name = "listBoxCourses";
            this.listBoxCourses.Size = new System.Drawing.Size(254, 404);
            this.listBoxCourses.TabIndex = 18;
            // 
            // labelTotalStudents
            // 
            this.labelTotalStudents.BackColor = System.Drawing.Color.LightCoral;
            this.labelTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalStudents.ForeColor = System.Drawing.Color.White;
            this.labelTotalStudents.Location = new System.Drawing.Point(594, 451);
            this.labelTotalStudents.Name = "labelTotalStudents";
            this.labelTotalStudents.Size = new System.Drawing.Size(183, 58);
            this.labelTotalStudents.TabIndex = 44;
            this.labelTotalStudents.Text = "Total Courses:";
            this.labelTotalStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFirst
            // 
            this.buttonFirst.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.ForeColor = System.Drawing.Color.Black;
            this.buttonFirst.Location = new System.Drawing.Point(21, 397);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(113, 48);
            this.buttonFirst.TabIndex = 45;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = false;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.ForeColor = System.Drawing.Color.Black;
            this.buttonNext.Location = new System.Drawing.Point(140, 397);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(113, 48);
            this.buttonNext.TabIndex = 46;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = false;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.ForeColor = System.Drawing.Color.Black;
            this.buttonPrevious.Location = new System.Drawing.Point(262, 397);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(113, 48);
            this.buttonPrevious.TabIndex = 47;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            // 
            // buttonLast
            // 
            this.buttonLast.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast.ForeColor = System.Drawing.Color.Black;
            this.buttonLast.Location = new System.Drawing.Point(381, 397);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(113, 48);
            this.buttonLast.TabIndex = 48;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = false;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(789, 548);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.labelTotalStudents);
            this.Controls.Add(this.listBoxCourses);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRemoveCourse);
            this.Controls.Add(this.buttonEditCourse);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCoursename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxCoursename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEditCourse;
        private System.Windows.Forms.Button buttonRemoveCourse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ListBox listBoxCourses;
        private System.Windows.Forms.Label labelTotalStudents;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonLast;
    }
}