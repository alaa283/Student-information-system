namespace Student_information_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Addstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentList = new System.Windows.Forms.ToolStripMenuItem();
            this.Statics = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ManageStudentform = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgScoreByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.courseToolStripMenuItem,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addstudent,
            this.StudentList,
            this.Statics,
            this.EditRemove,
            this.ManageStudentform,
            this.printToolStripMenuItem1});
            this.studentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // Addstudent
            // 
            this.Addstudent.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Addstudent.ForeColor = System.Drawing.SystemColors.Control;
            this.Addstudent.Name = "Addstudent";
            this.Addstudent.Size = new System.Drawing.Size(258, 26);
            this.Addstudent.Text = "Add New Student";
            this.Addstudent.Click += new System.EventHandler(this.studentsListToolStripMenuItem_Click);
            // 
            // StudentList
            // 
            this.StudentList.BackColor = System.Drawing.Color.DarkSlateGray;
            this.StudentList.ForeColor = System.Drawing.SystemColors.Control;
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(258, 26);
            this.StudentList.Text = "Student List";
            this.StudentList.Click += new System.EventHandler(this.staticsToolStripMenuItem_Click);
            // 
            // Statics
            // 
            this.Statics.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Statics.ForeColor = System.Drawing.SystemColors.Control;
            this.Statics.Name = "Statics";
            this.Statics.Size = new System.Drawing.Size(258, 26);
            this.Statics.Text = "Statics";
            this.Statics.Click += new System.EventHandler(this.editRemoveToolStripMenuItem_Click);
            // 
            // EditRemove
            // 
            this.EditRemove.BackColor = System.Drawing.Color.DarkSlateGray;
            this.EditRemove.ForeColor = System.Drawing.SystemColors.Control;
            this.EditRemove.Name = "EditRemove";
            this.EditRemove.Size = new System.Drawing.Size(258, 26);
            this.EditRemove.Text = "Edit/Remove";
            this.EditRemove.Click += new System.EventHandler(this.manageStudentsFormToolStripMenuItem_Click);
            // 
            // ManageStudentform
            // 
            this.ManageStudentform.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ManageStudentform.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageStudentform.Name = "ManageStudentform";
            this.ManageStudentform.Size = new System.Drawing.Size(258, 26);
            this.ManageStudentform.Text = "Manage student form";
            this.ManageStudentform.Click += new System.EventHandler(this.ManageStudentform_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.printToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(258, 26);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageCoursesToolStripMenuItem,
            this.printToolStripMenuItem});
            this.courseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(84, 26);
            this.courseToolStripMenuItem.Text = "Course";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.avgScoreByCourseToolStripMenuItem,
            this.printToolStripMenuItem2});
            this.scoreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.scoreToolStripMenuItem.Text = "Score";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.addCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.removeCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.removeCourseToolStripMenuItem.Text = "Remove Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.editCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageCoursesToolStripMenuItem
            // 
            this.manageCoursesToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.manageCoursesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageCoursesToolStripMenuItem.Name = "manageCoursesToolStripMenuItem";
            this.manageCoursesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageCoursesToolStripMenuItem.Text = "Manage Courses";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.printToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.addScoreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.removeScoreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.manageScoreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // avgScoreByCourseToolStripMenuItem
            // 
            this.avgScoreByCourseToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.avgScoreByCourseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.avgScoreByCourseToolStripMenuItem.Name = "avgScoreByCourseToolStripMenuItem";
            this.avgScoreByCourseToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.avgScoreByCourseToolStripMenuItem.Text = "Avg Score By Course";
            // 
            // printToolStripMenuItem2
            // 
            this.printToolStripMenuItem2.BackColor = System.Drawing.Color.DarkKhaki;
            this.printToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.printToolStripMenuItem2.Name = "printToolStripMenuItem2";
            this.printToolStripMenuItem2.Size = new System.Drawing.Size(263, 26);
            this.printToolStripMenuItem2.Text = "Print";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 494);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Addstudent;
        private System.Windows.Forms.ToolStripMenuItem StudentList;
        private System.Windows.Forms.ToolStripMenuItem Statics;
        private System.Windows.Forms.ToolStripMenuItem EditRemove;
        private System.Windows.Forms.ToolStripMenuItem ManageStudentform;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgScoreByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem2;
    }
}