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
    public partial class Student_Login_Page : Form
    {
        Thread th;
        public static string student_email; 
        public Student_Login_Page()
        {
            InitializeComponent();
        }
        public void open_Home_Page(object obj)
        {
            Application.Run(new Home_Page());
        }
        public void open_Register_Page(object obj)
        {
            Application.Run(new student_reg());
        }
        private void btn_student_login_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            if (txt_student_email.Text == "" || txt_student_pass.Text == "")
            {
                MessageBox.Show("Please Insert Email and Password !");
                
            }
            else
            {
                MySqlCommand command_1;
                MySqlDataReader mdr_1;
                string selectQuery_1 = "SELECT `Email`,`Password` FROM `approve_student` WHERE Email = '" + txt_student_email.Text + "' AND Password = '" + txt_student_pass.Text + "'";
                command_1 = new MySqlCommand(selectQuery_1, con);
                mdr_1 = command_1.ExecuteReader();

                if (mdr_1.Read())
                {
                    MessageBox.Show("Admin Not Apprpove Your Account");

                }
                else
                {
                    mdr_1.Close();
                    MySqlCommand command;
                    MySqlDataReader mdr;
                    string selectQuery = "SELECT Email,Password FROM student WHERE Email = '" + txt_student_email.Text + "' AND Password = '" + txt_student_pass.Text + "'";
                    command = new MySqlCommand(selectQuery, con);
                    mdr = command.ExecuteReader();
                    if (mdr.Read())
                    {
                        mdr.Close();
                        
                        student_email = txt_student_email.Text;
                        student_dashboard obj = new student_dashboard();
                        
                        obj.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email or Password Incorrect !!");
                    }

                    con.Close();
                }

                

            }




        }

        private void btn_student_back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Home_Page);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Student_Login_Page_Load(object sender, EventArgs e)
        {

        }

        private void s_r_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Register_Page);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void student_forgot_pass_Click(object sender, EventArgs e)
        {
            forgot_student_passwoard obj = new forgot_student_passwoard();
            obj.ShowDialog();
        }



        private void password_show_ckb_CheckedChanged_1(object sender, EventArgs e)
        {
            if (password_show_ckb.Checked)
            {
                txt_student_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_student_pass.UseSystemPasswordChar = true;

            }
        }
    }
}
