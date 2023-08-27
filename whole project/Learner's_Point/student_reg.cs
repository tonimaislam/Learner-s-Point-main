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
using System.IO;

namespace Learner_s_Point
{
    public partial class student_reg : Form
    {
        Thread th;
        public static string student_name, student_email,student_phone, student_pass;
        public static Image student_image;
        public student_reg()
        {
            InitializeComponent();
        }
        public void open_Student_Login(object obj)
        {
            Application.Run(new Student_Login_Page());
        }
        public void open_payment_page(object obj)
        {
            Application.Run(new payment_System());
        }

        private void chose_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                user_picture.Image = Image.FromFile(opf.FileName);
                student_image = Image.FromFile(opf.FileName);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void r_back_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open_Student_Login);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void r_s_register_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();

            if (r_s_name.Text == "" || r_s_email.Text == "" || r_s_phone.Text == "" || r_s_password.Text == "") 
            {
                MessageBox.Show("Please Insert All Fields !");
            }
            else
            {
                MySqlCommand command;
                MySqlDataReader mdr;
                string selectQuery = "SELECT Email FROM student WHERE Email = '" + r_s_email.Text + "'";
                command = new MySqlCommand(selectQuery, con);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    MessageBox.Show("This Email Already Taken !! Try to Login !!");
                    
                }
                else
                {
                    student_name = r_s_name.Text;
                    student_email = r_s_email.Text;
                    student_pass = r_s_password.Text;
                    student_phone = r_s_phone.Text;

                    mdr.Close();


                    this.Close();
                    th = new Thread(open_payment_page);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }

            }

        }

    }

}
