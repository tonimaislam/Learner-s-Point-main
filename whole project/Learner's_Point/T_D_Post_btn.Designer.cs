namespace Learner_s_Point
{
    partial class T_D_Post_btn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_lbl = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.description_lbl = new System.Windows.Forms.TextBox();
            this.role_as = new System.Windows.Forms.Label();
            this.role_as_txt = new System.Windows.Forms.TextBox();
            this.post_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title_lbl
            // 
            this.title_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(76, 63);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(227, 26);
            this.title_lbl.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(72, 38);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(45, 22);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date.Location = new System.Drawing.Point(72, 104);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(50, 22);
            this.date.TabIndex = 3;
            this.date.Text = "Date";
            // 
            // date_lbl
            // 
            this.date_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(76, 129);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(227, 26);
            this.date_lbl.TabIndex = 2;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.description.Location = new System.Drawing.Point(72, 177);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(106, 22);
            this.description.TabIndex = 5;
            this.description.Text = "Description";
            // 
            // description_lbl
            // 
            this.description_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.Location = new System.Drawing.Point(76, 202);
            this.description_lbl.Multiline = true;
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(227, 87);
            this.description_lbl.TabIndex = 4;
            // 
            // role_as
            // 
            this.role_as.AutoSize = true;
            this.role_as.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_as.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.role_as.Location = new System.Drawing.Point(72, 304);
            this.role_as.Name = "role_as";
            this.role_as.Size = new System.Drawing.Size(77, 22);
            this.role_as.TabIndex = 7;
            this.role_as.Text = "Role As";
            // 
            // role_as_txt
            // 
            this.role_as_txt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_as_txt.Location = new System.Drawing.Point(76, 329);
            this.role_as_txt.Name = "role_as_txt";
            this.role_as_txt.Size = new System.Drawing.Size(227, 26);
            this.role_as_txt.TabIndex = 6;
            this.role_as_txt.Text = "Teacher";
            // 
            // post_btn
            // 
            this.post_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.post_btn.Location = new System.Drawing.Point(129, 394);
            this.post_btn.Name = "post_btn";
            this.post_btn.Size = new System.Drawing.Size(116, 31);
            this.post_btn.TabIndex = 8;
            this.post_btn.Text = "Post";
            this.post_btn.UseVisualStyleBackColor = true;
            this.post_btn.Click += new System.EventHandler(this.post_btn_Click);
            // 
            // T_D_Post_btn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.post_btn);
            this.Controls.Add(this.role_as);
            this.Controls.Add(this.role_as_txt);
            this.Controls.Add(this.description);
            this.Controls.Add(this.description_lbl);
            this.Controls.Add(this.date);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.title);
            this.Controls.Add(this.title_lbl);
            this.Name = "T_D_Post_btn";
            this.Size = new System.Drawing.Size(467, 477);
            this.Load += new System.EventHandler(this.T_D_Post_btn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title_lbl;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.TextBox date_lbl;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox description_lbl;
        private System.Windows.Forms.Label role_as;
        private System.Windows.Forms.TextBox role_as_txt;
        private System.Windows.Forms.Button post_btn;
    }
}
