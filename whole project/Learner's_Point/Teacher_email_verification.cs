using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learner_s_Point
{
    public partial class Teacher_email_verification : Form
    {
        public Teacher_email_verification()
        {
            InitializeComponent();
        }

        private void veryfy_btn_Click(object sender, EventArgs e)
        {
            if (forgot_teacher_password.randomcode == verification_code_txt.Text)
            {
                this.Close();
               Teacehr_reset_password obj = new Teacehr_reset_password();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verification Code Note Matched !");
            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
