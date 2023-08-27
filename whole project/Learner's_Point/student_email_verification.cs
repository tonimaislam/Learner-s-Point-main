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
    public partial class student_email_verification : Form
    {
        public student_email_verification()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void veryfy_btn_Click(object sender, EventArgs e)
        {
            if (forgot_student_passwoard.randomcode == verification_code_txt.Text)
            {
                this.Close();
                student_reset_pass obj = new student_reset_pass();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verification Code Note Matched !");
            }
        }
    }
}
