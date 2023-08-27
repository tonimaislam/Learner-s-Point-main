namespace Learner_s_Point
{
    partial class student_dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout_btn = new System.Windows.Forms.Button();
            this.profile_btn = new System.Windows.Forms.Button();
            this.enrolled_course = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.home_page_btn = new System.Windows.Forms.Button();
            this.student_name_lbl = new System.Windows.Forms.Label();
            this.student_profile = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.s_D_Profile1 = new Learner_s_Point.S_D_Profile();
            this.s_D_Enrolled_course1 = new Learner_s_Point.S_D_Enrolled_course();
            this.s_D_Post1 = new Learner_s_Point.S_D_Post();
            this.s_D_Home1 = new Learner_s_Point.S_D_Home();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_profile)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(25)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.Logout_btn);
            this.panel1.Controls.Add(this.profile_btn);
            this.panel1.Controls.Add(this.enrolled_course);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.home_page_btn);
            this.panel1.Controls.Add(this.student_name_lbl);
            this.panel1.Controls.Add(this.student_profile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 454);
            this.panel1.TabIndex = 0;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Logout_btn.FlatAppearance.BorderSize = 10;
            this.Logout_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.Location = new System.Drawing.Point(10, 385);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(206, 40);
            this.Logout_btn.TabIndex = 7;
            this.Logout_btn.Text = "LogOut";
            this.Logout_btn.UseVisualStyleBackColor = false;
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.profile_btn.FlatAppearance.BorderSize = 10;
            this.profile_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_btn.ForeColor = System.Drawing.Color.White;
            this.profile_btn.Location = new System.Drawing.Point(10, 332);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(206, 40);
            this.profile_btn.TabIndex = 6;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseVisualStyleBackColor = false;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // enrolled_course
            // 
            this.enrolled_course.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.enrolled_course.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enrolled_course.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.enrolled_course.FlatAppearance.BorderSize = 10;
            this.enrolled_course.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrolled_course.ForeColor = System.Drawing.Color.White;
            this.enrolled_course.Location = new System.Drawing.Point(10, 280);
            this.enrolled_course.Name = "enrolled_course";
            this.enrolled_course.Size = new System.Drawing.Size(206, 40);
            this.enrolled_course.TabIndex = 5;
            this.enrolled_course.Text = "Enrolled Course";
            this.enrolled_course.UseVisualStyleBackColor = false;
            this.enrolled_course.Click += new System.EventHandler(this.enrolled_course_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // home_page_btn
            // 
            this.home_page_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(60)))), ((int)(((byte)(109)))));
            this.home_page_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home_page_btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.home_page_btn.FlatAppearance.BorderSize = 10;
            this.home_page_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_page_btn.ForeColor = System.Drawing.Color.White;
            this.home_page_btn.Location = new System.Drawing.Point(10, 181);
            this.home_page_btn.Name = "home_page_btn";
            this.home_page_btn.Size = new System.Drawing.Size(206, 40);
            this.home_page_btn.TabIndex = 3;
            this.home_page_btn.Text = "Home";
            this.home_page_btn.UseVisualStyleBackColor = false;
            this.home_page_btn.Click += new System.EventHandler(this.home_page_btn_Click);
            // 
            // student_name_lbl
            // 
            this.student_name_lbl.AutoSize = true;
            this.student_name_lbl.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_name_lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.student_name_lbl.Location = new System.Drawing.Point(48, 145);
            this.student_name_lbl.Name = "student_name_lbl";
            this.student_name_lbl.Size = new System.Drawing.Size(129, 25);
            this.student_name_lbl.TabIndex = 2;
            this.student_name_lbl.Text = "Sanzida Akter";
            // 
            // student_profile
            // 
            this.student_profile.BackColor = System.Drawing.Color.Transparent;
            this.student_profile.Image = ((System.Drawing.Image)(resources.GetObject("student_profile.Image")));
            this.student_profile.Location = new System.Drawing.Point(43, 12);
            this.student_profile.Name = "student_profile";
            this.student_profile.Size = new System.Drawing.Size(133, 127);
            this.student_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.student_profile.TabIndex = 1;
            this.student_profile.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.panel2.Controls.Add(this.s_D_Profile1);
            this.panel2.Controls.Add(this.s_D_Enrolled_course1);
            this.panel2.Controls.Add(this.s_D_Post1);
            this.panel2.Controls.Add(this.s_D_Home1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(491, 454);
            this.panel2.TabIndex = 1;
            // 
            // s_D_Profile1
            // 
            this.s_D_Profile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.s_D_Profile1.Location = new System.Drawing.Point(0, 0);
            this.s_D_Profile1.Name = "s_D_Profile1";
            this.s_D_Profile1.Size = new System.Drawing.Size(491, 454);
            this.s_D_Profile1.TabIndex = 12;
            // 
            // s_D_Enrolled_course1
            // 
            this.s_D_Enrolled_course1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.s_D_Enrolled_course1.Location = new System.Drawing.Point(0, 0);
            this.s_D_Enrolled_course1.Name = "s_D_Enrolled_course1";
            this.s_D_Enrolled_course1.Size = new System.Drawing.Size(491, 453);
            this.s_D_Enrolled_course1.TabIndex = 11;
            // 
            // s_D_Post1
            // 
            this.s_D_Post1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.s_D_Post1.Location = new System.Drawing.Point(0, 0);
            this.s_D_Post1.Name = "s_D_Post1";
            this.s_D_Post1.Size = new System.Drawing.Size(491, 451);
            this.s_D_Post1.TabIndex = 10;
            // 
            // s_D_Home1
            // 
            this.s_D_Home1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.s_D_Home1.Location = new System.Drawing.Point(0, 0);
            this.s_D_Home1.Name = "s_D_Home1";
            this.s_D_Home1.Size = new System.Drawing.Size(491, 453);
            this.s_D_Home1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(144, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_btn.BackgroundImage")));
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(465, 10);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(14, 14);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // student_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "student_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "student_dashboard";
            this.Load += new System.EventHandler(this.student_dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_profile)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox student_profile;
        private System.Windows.Forms.Label student_name_lbl;
        private System.Windows.Forms.Button home_page_btn;
        private System.Windows.Forms.Button enrolled_course;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button profile_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button Logout_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private S_D_Home s_D_Home1;
        private S_D_Post s_D_Post1;
        private S_D_Enrolled_course s_D_Enrolled_course1;
        private S_D_Profile s_D_Profile1;
    }
}