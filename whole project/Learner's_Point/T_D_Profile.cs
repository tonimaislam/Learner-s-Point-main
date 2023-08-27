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
using System.IO;


namespace Learner_s_Point
{
    public partial class T_D_Profile : UserControl
    {
        public static string name, email, phone, pass;
        public T_D_Profile()
        {
            InitializeComponent();
        }




        private void T_D_Profile_Load(object sender, EventArgs e)
        {
            load_profile();
        }
        public void load_profile()
        {
            MySqlConnection con1 = new MySqlConnection(Database_Connect.connect_database());
            con1.Open();

            MySqlCommand command;
            command = con1.CreateCommand();
            command.CommandText = "SELECT Teacher_ID, `Name`, `Email`, `Phone`, `Password`, `image` FROM `teacher` WHERE Email = @student_email";
            command.Parameters.AddWithValue("@student_email", Teachers_Login_Page.teacher_email);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            sdr.Close();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                teacher_ID.Text = dr["Teacher_ID"].ToString();
                teacher_name.Text = dr["Name"].ToString();
                teacher_email.Text = dr["Email"].ToString();
                teacher_phone.Text = dr["Phone"].ToString();
                teacehr_pass.Text = dr["Password"].ToString();

                name = dr["Name"].ToString();
                email = dr["Email"].ToString();
                phone = dr["Phone"].ToString();
                pass = dr["Password"].ToString();
                /*
                byte[] img = (byte[])dt.Rows[0][5];

                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
                */

                da.Dispose();
            }
            con1.Close();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Teacehr_update_profile obj = new Teacehr_update_profile();
            obj.ShowDialog();

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            load_profile();
            teacher_dashboard obj = new teacher_dashboard();
            obj.profile_load();
        }
    }
}
