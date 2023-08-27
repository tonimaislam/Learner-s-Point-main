using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Learner_s_Point
{
    public partial class Teachers_Login_Page : Form
    {
        Thread th;
        public static string teacher_email;
        public Teachers_Login_Page()
        {
            InitializeComponent();
        }
        public void open_Home_Page(object obj)
        {
            Application.Run(new Home_Page());
        }
        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            if (txt_teacher_email.Text == "" || txt_teacher_pass.Text == "")
            {
                MessageBox.Show("Please Insert Email and Password !");

            }
            else
            {
                
                MySqlCommand command;
                MySqlDataReader mdr;
                string selectQuery = "SELECT Email,Password FROM teacher WHERE Email = '" + txt_teacher_email.Text + "' AND Password = '" + txt_teacher_pass.Text + "'";
                command = new MySqlCommand(selectQuery, con);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    teacher_email = txt_teacher_email.Text;

                    
                    teacher_dashboard obj = new teacher_dashboard();
                    obj.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Email or Password Incorrect !!");
                }


            }
            con.Close();
        }

        private void btn_teacher_back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Home_Page);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Teachers_Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void password_show_ckb_CheckedChanged(object sender, EventArgs e)
        {
            if (password_show_ckb.Checked)
            {
                txt_teacher_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_teacher_pass.UseSystemPasswordChar = true;

            }
        }

        private void txt_teacher_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void forgot_password_Click(object sender, EventArgs e)
        {
            
            forgot_teacher_password obj = new forgot_teacher_password();
            obj.ShowDialog();
        }
    }
}
