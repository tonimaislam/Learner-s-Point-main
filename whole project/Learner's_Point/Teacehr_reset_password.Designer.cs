namespace Learner_s_Point
{
    partial class Teacehr_reset_password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacehr_reset_password));
            this.exit_btn = new System.Windows.Forms.Button();
            this.pass_update_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.re_type_pass_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.new_pass_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.exit_btn.Location = new System.Drawing.Point(279, 6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(14, 14);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // pass_update_btn
            // 
            this.pass_update_btn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_update_btn.Location = new System.Drawing.Point(101, 269);
            this.pass_update_btn.Name = "pass_update_btn";
            this.pass_update_btn.Size = new System.Drawing.Size(84, 33);
            this.pass_update_btn.TabIndex = 13;
            this.pass_update_btn.Text = "Update";
            this.pass_update_btn.UseVisualStyleBackColor = true;
            this.pass_update_btn.Click += new System.EventHandler(this.pass_update_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(55, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Re-Type New Password";
            // 
            // re_type_pass_txt
            // 
            this.re_type_pass_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re_type_pass_txt.Location = new System.Drawing.Point(58, 220);
            this.re_type_pass_txt.Name = "re_type_pass_txt";
            this.re_type_pass_txt.Size = new System.Drawing.Size(171, 29);
            this.re_type_pass_txt.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(55, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter New Password";
            // 
            // new_pass_txt
            // 
            this.new_pass_txt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_pass_txt.Location = new System.Drawing.Point(58, 158);
            this.new_pass_txt.Name = "new_pass_txt";
            this.new_pass_txt.Size = new System.Drawing.Size(171, 29);
            this.new_pass_txt.TabIndex = 8;
            // 
            // Teacehr_reset_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(105)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.pass_update_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.re_type_pass_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_pass_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Teacehr_reset_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacehr_reset_password";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button pass_update_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox re_type_pass_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_pass_txt;
    }
}