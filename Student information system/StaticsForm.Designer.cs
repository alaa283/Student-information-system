namespace Student_information_system
{
    partial class StaticsForm
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
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panelMale = new System.Windows.Forms.Panel();
            this.panelFemale = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panelMale.SuspendLayout();
            this.panelFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.LightCoral;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(1, 1);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(448, 141);
            this.panelTotal.TabIndex = 0;
            // 
            // panelMale
            // 
            this.panelMale.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMale.Controls.Add(this.labelMale);
            this.panelMale.Location = new System.Drawing.Point(1, 141);
            this.panelMale.Name = "panelMale";
            this.panelMale.Size = new System.Drawing.Size(226, 111);
            this.panelMale.TabIndex = 1;
            // 
            // panelFemale
            // 
            this.panelFemale.BackColor = System.Drawing.Color.RosyBrown;
            this.panelFemale.Controls.Add(this.labelFemale);
            this.panelFemale.Location = new System.Drawing.Point(224, 141);
            this.panelFemale.Name = "panelFemale";
            this.panelFemale.Size = new System.Drawing.Size(225, 111);
            this.panelFemale.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.Color.LightCoral;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(448, 141);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Students:100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMale.ForeColor = System.Drawing.SystemColors.Control;
            this.labelMale.Location = new System.Drawing.Point(52, 46);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(116, 25);
            this.labelMale.TabIndex = 0;
            this.labelMale.Text = "Male:50%";
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFemale.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFemale.Location = new System.Drawing.Point(48, 46);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(142, 25);
            this.labelFemale.TabIndex = 0;
            this.labelFemale.Text = "Female:50%";
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 252);
            this.Controls.Add(this.panelFemale);
            this.Controls.Add(this.panelMale);
            this.Controls.Add(this.panelTotal);
            this.Name = "StaticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticsForm";
            this.panelTotal.ResumeLayout(false);
            this.panelMale.ResumeLayout(false);
            this.panelMale.PerformLayout();
            this.panelFemale.ResumeLayout(false);
            this.panelFemale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Panel panelMale;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Panel panelFemale;
        private System.Windows.Forms.Label labelFemale;
    }
}