namespace DataBase
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSessions = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonSubjects = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSessions
            // 
            this.buttonSessions.BackColor = System.Drawing.Color.Pink;
            this.buttonSessions.Location = new System.Drawing.Point(12, 12);
            this.buttonSessions.Name = "buttonSessions";
            this.buttonSessions.Size = new System.Drawing.Size(100, 40);
            this.buttonSessions.TabIndex = 0;
            this.buttonSessions.Text = "Sessions";
            this.buttonSessions.UseVisualStyleBackColor = false;
            this.buttonSessions.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.BackColor = System.Drawing.Color.Pink;
            this.buttonSchedule.Location = new System.Drawing.Point(140, 12);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(100, 40);
            this.buttonSchedule.TabIndex = 1;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonSchedule_Click);
            // 
            // buttonSubjects
            // 
            this.buttonSubjects.BackColor = System.Drawing.Color.Pink;
            this.buttonSubjects.Location = new System.Drawing.Point(271, 12);
            this.buttonSubjects.Name = "buttonSubjects";
            this.buttonSubjects.Size = new System.Drawing.Size(100, 40);
            this.buttonSubjects.TabIndex = 2;
            this.buttonSubjects.Text = "Subjects";
            this.buttonSubjects.UseVisualStyleBackColor = false;
            this.buttonSubjects.Click += new System.EventHandler(this.buttonSubjects_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.Pink;
            this.buttonGroups.Location = new System.Drawing.Point(402, 12);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(100, 40);
            this.buttonGroups.TabIndex = 3;
            this.buttonGroups.Text = "Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.Pink;
            this.buttonStudents.Location = new System.Drawing.Point(543, 12);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(100, 40);
            this.buttonStudents.TabIndex = 4;
            this.buttonStudents.Text = "Students";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonResults
            // 
            this.buttonResults.BackColor = System.Drawing.Color.Pink;
            this.buttonResults.Location = new System.Drawing.Point(684, 12);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(100, 40);
            this.buttonResults.TabIndex = 5;
            this.buttonResults.Text = "Results";
            this.buttonResults.UseVisualStyleBackColor = false;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonResults);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.buttonSubjects);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonSessions);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSessions;
        private Button buttonSchedule;
        private Button buttonSubjects;
        private Button buttonGroups;
        private Button buttonStudents;
        private Button buttonResults;
    }
}