using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Learner_s_Point
{
    public partial class T_D_Upload_btn : UserControl
    {
        string techer_email = Teachers_Login_Page.teacher_email;
        public T_D_Upload_btn()
        {
            InitializeComponent();
        }

        private void Course_teacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            if (course_name.Text == "" || course_code.Text == "" || Course_teacher.Text == "" || teacher_id.Text == "" || video_link.Text == "" || class_txt.Text == "" )
            {
                MessageBox.Show("Please Insert All Fields !");
            }
            else
            {
                MySqlCommand cmd1;
                cmd1 = con.CreateCommand();
                cmd1.CommandText = "INSERT INTO course_details(`Subject_Name`, `Subject_Code`, `Teacher_Name`, `Teacher_ID`, `Video_Link`, `Class`,Teacher_Email) VALUES(@Course_Name,@Course_Code,@Course_Teacher, @Teacher_ID,@Video_Link,@Class,@teacher_email)";
                cmd1.Parameters.AddWithValue("@Course_Name", course_name.Text);
                cmd1.Parameters.AddWithValue("@Course_Code", course_code.Text);
                cmd1.Parameters.AddWithValue("@Course_Teacher", Course_teacher.Text);
                cmd1.Parameters.AddWithValue("@Teacher_ID", teacher_id.Text);
                cmd1.Parameters.AddWithValue("@Video_Link", video_link.Text);
                cmd1.Parameters.AddWithValue("@Class", class_txt.Text);
                cmd1.Parameters.AddWithValue("@teacher_email", techer_email);
                cmd1.ExecuteNonQuery();
                con.Close();
                ResetFormData();
                MessageBox.Show("Course Uploaded !!");

            }

        }
        public void ResetFormData()
        {
            course_name.Clear();
            course_code.Clear();
            Course_teacher.Clear();
            teacher_id.Clear();
            video_link.Clear();
            class_txt.Clear();
        }

        private void T_D_Upload_btn_Load(object sender, EventArgs e)
        {

        }
    }
}
