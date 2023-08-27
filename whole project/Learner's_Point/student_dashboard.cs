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
    public partial class student_dashboard : Form
    {
        Thread th;
        int home_count = 0, post_count = 0, enroll_count = 0,profile_count = 0;
        public student_dashboard()
        {
            InitializeComponent();


        }
        private void student_dashboard_Load(object sender, EventArgs e)
        {

            student_profile_load();
            s_D_Enrolled_course1.Hide();
            s_D_Home1.Hide();
            s_D_Post1.Hide();
            s_D_Profile1.Hide();
        }
        public void student_profile_load()
        {
            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();
            MySqlCommand command;
            command = con1.CreateCommand();
            command.CommandText = "SELECT `Name`, `image` FROM `student` WHERE Email = @student_email";
            command.Parameters.AddWithValue("@student_email", Student_Login_Page.student_email);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            sdr.Close();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                student_name_lbl.Text = dr["Name"].ToString();
                /*
                byte[] img = (byte[])dt.Rows[0][1];

                MemoryStream ms = new MemoryStream(img);
                

                student_profile.Image = Image.FromStream(ms);*/
                da.Dispose();
            }

            con1.Close();

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        public void open_Home_Page(object obj)
        {
            Application.Run(new Home_Page());
        }
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                S_D_Enrolled_course.payable_taka = 0;
                th = new Thread(open_Home_Page);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {

            }
        }

        private void home_page_btn_Click(object sender, EventArgs e)
        {
            S_D_Home obj = new S_D_Home();
            obj.Post_load();
            enroll_count = 0;
            post_count = 0;
            profile_count = 0;
            if (home_count % 2 == 0)
            {
                s_D_Home1.Show();
                s_D_Home1.BringToFront();
                s_D_Post1.Hide();
                s_D_Enrolled_course1.Hide();
                s_D_Profile1.Hide();

                home_count++;
            }
            else
            {
                s_D_Home1.Hide();
                home_count++;
            }
            student_profile_load();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            post_count = 0;
            home_count = 0;
            enroll_count = 0;
            if (profile_count % 2 == 0)
            {
                s_D_Profile1.Show();
                s_D_Profile1.BringToFront();
                s_D_Home1.Hide();
                s_D_Post1.Hide();
                s_D_Enrolled_course1.Hide();

                profile_count++;
            }
            else
            {
                s_D_Profile1.Hide();
                profile_count++;
            }
            student_profile_load();
        }

        private void enrolled_course_Click(object sender, EventArgs e)
        {
            post_count = 0;
            profile_count = 0;
            home_count = 0;
            if (enroll_count % 2 == 0)
            {
                s_D_Enrolled_course1.Show();
                s_D_Enrolled_course1.BringToFront();
                s_D_Home1.Hide();
                s_D_Post1.Hide();
                s_D_Profile1.Hide();

                enroll_count++;
            }
            else
            {
                s_D_Enrolled_course1.Hide();
                enroll_count++;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            home_count = 0;
            enroll_count = 0;
            if (post_count % 2 == 0)
            {
                s_D_Post1.Show();
                s_D_Post1.BringToFront();
                s_D_Home1.Hide();
                s_D_Enrolled_course1.Hide();
                s_D_Profile1.Hide();

                post_count++;
            }
            else
            {
                s_D_Post1.Hide();
                post_count++;
            }

        }
    }
}
