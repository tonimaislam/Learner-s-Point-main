namespace Learner_s_Point
{
    partial class Teachers_Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers_Login_Page));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_teacher_back = new System.Windows.Forms.Button();
            this.lbl_teacher_login_wrong = new System.Windows.Forms.Label();
            this.Hello_Sir = new System.Windows.Forms.Label();
            this.btn_Teacher_login = new System.Windows.Forms.Button();
            this.txt_teacher_pass = new System.Windows.Forms.TextBox();
            this.txt_teacher_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password_show_ckb = new System.Windows.Forms.CheckBox();
            this.forgot_password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_teacher_back
            // 
            this.btn_teacher_back.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_teacher_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teacher_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_teacher_back.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_teacher_back.Location = new System.Drawing.Point(449, 244);
            this.btn_teacher_back.Name = "btn_teacher_back";
            this.btn_teacher_back.Size = new System.Drawing.Size(72, 32);
            this.btn_teacher_back.TabIndex = 16;
            this.btn_teacher_back.Text = "Back";
            this.btn_teacher_back.UseVisualStyleBackColor = false;
            this.btn_teacher_back.Click += new System.EventHandler(this.btn_teacher_back_Click);
            // 
            // lbl_teacher_login_wrong
            // 
            this.lbl_teacher_login_wrong.AutoSize = true;
            this.lbl_teacher_login_wrong.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teacher_login_wrong.ForeColor = System.Drawing.Color.Red;
            this.lbl_teacher_login_wrong.Location = new System.Drawing.Point(334, 263);
            this.lbl_teacher_login_wrong.Name = "lbl_teacher_login_wrong";
            this.lbl_teacher_login_wrong.Size = new System.Drawing.Size(0, 22);
            this.lbl_teacher_login_wrong.TabIndex = 15;
            // 
            // Hello_Sir
            // 
            this.Hello_Sir.AutoSize = true;
            this.Hello_Sir.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hello_Sir.Location = new System.Drawing.Point(346, 61);
            this.Hello_Sir.Name = "Hello_Sir";
            this.Hello_Sir.Size = new System.Drawing.Size(132, 37);
            this.Hello_Sir.TabIndex = 14;
            this.Hello_Sir.Text = "Hello Sir !";
            // 
            // btn_Teacher_login
            // 
            this.btn_Teacher_login.BackColor = System.Drawing.Color.DarkBlue;
            this.btn_Teacher_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Teacher_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Teacher_login.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Teacher_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Teacher_login.Location = new System.Drawing.Point(356, 244);
            this.btn_Teacher_login.Name = "btn_Teacher_login";
            this.btn_Teacher_login.Size = new System.Drawing.Size(72, 32);
            this.btn_Teacher_login.TabIndex = 13;
            this.btn_Teacher_login.Text = "Login";
            this.btn_Teacher_login.UseVisualStyleBackColor = false;
            this.btn_Teacher_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // txt_teacher_pass
            // 
            this.txt_teacher_pass.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_teacher_pass.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teacher_pass.Location = new System.Drawing.Point(356, 172);
            this.txt_teacher_pass.Name = "txt_teacher_pass";
            this.txt_teacher_pass.Size = new System.Drawing.Size(165, 29);
            this.txt_teacher_pass.TabIndex = 12;
            this.txt_teacher_pass.UseSystemPasswordChar = true;
            this.txt_teacher_pass.TextChanged += new System.EventHandler(this.txt_teacher_pass_TextChanged);
            // 
            // txt_teacher_email
            // 
            this.txt_teacher_email.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_teacher_email.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_teacher_email.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_teacher_email.Location = new System.Drawing.Point(356, 131);
            this.txt_teacher_email.Name = "txt_teacher_email";
            this.txt_teacher_email.Size = new System.Drawing.Size(165, 29);
            this.txt_teacher_email.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email";
            // 
            // password_show_ckb
            // 
            this.password_show_ckb.AutoSize = true;
            this.password_show_ckb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_show_ckb.Location = new System.Drawing.Point(385, 212);
            this.password_show_ckb.Name = "password_show_ckb";
            this.password_show_ckb.Size = new System.Drawing.Size(136, 22);
            this.password_show_ckb.TabIndex = 17;
            this.password_show_ckb.Text = "Show Password";
            this.password_show_ckb.UseVisualStyleBackColor = true;
            this.password_show_ckb.CheckedChanged += new System.EventHandler(this.password_show_ckb_CheckedChanged);
            // 
            // forgot_password
            // 
            this.forgot_password.AutoSize = true;
            this.forgot_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_password.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.Location = new System.Drawing.Point(394, 288);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(129, 23);
            this.forgot_password.TabIndex = 18;
            this.forgot_password.Text = "forgot password?";
            this.forgot_password.Click += new System.EventHandler(this.forgot_password_Click);
            // 
            // Teachers_Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(606, 340);
            this.Controls.Add(this.forgot_password);
            this.Controls.Add(this.password_show_ckb);
            this.Controls.Add(this.btn_teacher_back);
            this.Controls.Add(this.lbl_teacher_login_wrong);
            this.Controls.Add(this.Hello_Sir);
            this.Controls.Add(this.btn_Teacher_login);
            this.Controls.Add(this.txt_teacher_pass);
            this.Controls.Add(this.txt_teacher_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Teachers_Login_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Teachers_Login_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_teacher_back;
        private System.Windows.Forms.Label lbl_teacher_login_wrong;
        private System.Windows.Forms.Label Hello_Sir;
        private System.Windows.Forms.Button btn_Teacher_login;
        private System.Windows.Forms.TextBox txt_teacher_pass;
        private System.Windows.Forms.TextBox txt_teacher_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox password_show_ckb;
        private System.Windows.Forms.Label forgot_password;
    }
}