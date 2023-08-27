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
    public partial class teacher_dashboard : Form
    {
        Thread th;
        Image teacher_image;
        string teachers_email = Teachers_Login_Page.teacher_email;
        int post_count = 0, upload_count = 0, home_count = 0,my_tutorials_count = 0,profile_count =0;
        public teacher_dashboard()
        {
            InitializeComponent();
        }
        private void teacher_dashboard_Load(object sender, EventArgs e)
        {
            t_D_Post_btn1.Hide();
            t_D_Upload_btn1.Hide();
            t_D_My_tutorials1.Hide();
            //t_D_Home1.Hide();
            t_D_Profile1.Hide();
            profile_load();





        }
        public void profile_load()
        {
            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();
            MySqlCommand command;
            command = con1.CreateCommand();
            command.CommandText = "SELECT  `Name`,`image` FROM `teacher` WHERE Email = @teacher_email";
            command.Parameters.AddWithValue("@teacher_email", Teachers_Login_Page.teacher_email);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            sdr.Close();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                teacher_name_lbl.Text = dr["Name"].ToString();
                /*
                byte[] img1 = (byte[])dt.Rows[0][1];

                MemoryStream msi = new MemoryStream(img1);
                student_profile.Image = System.Drawing.Image.FromStream(msi);
                */

                da.Dispose();

            }

            con1.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void open_Home_Page(object obj)
        {
            Application.Run(new Home_Page());
        }




        private void home_btn_Click(object sender, EventArgs e)
        {
           
            upload_count = 0;
            post_count = 0;
            my_tutorials_count = 0;
            profile_count = 0;
            if (home_count % 2 == 0)
            {
                t_D_Home1.Show();
                t_D_Home1.BringToFront();

                t_D_Upload_btn1.Hide();
                t_D_My_tutorials1.Hide();
                t_D_Post_btn1.Hide();
                t_D_Profile1.Hide();

                home_count++;
            }
            else
            {
                t_D_Home1.Hide();
                home_count++;
            }
            profile_load();
        }


        private void post_btn_Click(object sender, EventArgs e)
        {
            
            upload_count = 0;
            home_count = 0;
            my_tutorials_count = 0;
            profile_count = 0;
            if (post_count % 2 == 0)
            {
                t_D_Post_btn1.Show();
                t_D_Post_btn1.BringToFront();

                t_D_Upload_btn1.Hide();
                t_D_My_tutorials1.Hide();
                t_D_Home1.Hide();
                t_D_Profile1.Hide();

                post_count++;
            }
            else
            {
                t_D_Post_btn1.Hide();
                post_count++;
            }
            profile_load();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(open_Home_Page);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
            else
            {

            }

        }

        private void course_upload_btn_Click(object sender, EventArgs e)
        {
            

            post_count = 0;
            home_count = 0;
            my_tutorials_count = 0;
            profile_count = 0;
            if (upload_count % 2 == 0)
            {
                t_D_Upload_btn1.Show();
                t_D_Upload_btn1.BringToFront();

                t_D_Post_btn1.Hide();
                t_D_My_tutorials1.Hide();
                t_D_Home1.Hide();
                t_D_Profile1.Hide();

                upload_count++;
            }
            else
            {
                t_D_Upload_btn1.Hide();
                upload_count++;
            }
            profile_load();
        }
        private void my_all_course_btn_Click(object sender, EventArgs e)
        {
            
            post_count = 0;
            upload_count = 0;
            home_count = 0;
            profile_count = 0;
            
            if (my_tutorials_count % 2 == 0)
            {
                t_D_My_tutorials1.Show();
                t_D_My_tutorials1.BringToFront();
                t_D_Post_btn1.Hide();
                t_D_Upload_btn1.Hide();
                t_D_Home1.Hide();
                t_D_Profile1.Hide();
                my_tutorials_count++;
            }
            else
            {
                t_D_My_tutorials1.Hide();
                my_tutorials_count++;
            }

            profile_load();

        }
        private void profile_btn_Click(object sender, EventArgs e)
        {
            

            post_count = 0;
            upload_count = 0;
            home_count = 0;
            my_tutorials_count = 0;
            if (profile_count % 2 == 0)
            {
                t_D_Profile1.Show();
                t_D_Profile1.BringToFront();
                t_D_Post_btn1.Hide();
                t_D_Upload_btn1.Hide();
                t_D_Home1.Hide();
                profile_count++;
            }
            else
            {
                t_D_Profile1.Hide();
                profile_count++;
            }
            profile_load();
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
