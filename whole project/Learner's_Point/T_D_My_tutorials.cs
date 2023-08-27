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
    public partial class T_D_My_tutorials : UserControl
    {
        string techer_email = Teachers_Login_Page.teacher_email;
        public static string sub_name, sub_code,video_link,Class;
        public T_D_My_tutorials()
        {
            InitializeComponent();
        }

        private void T_D_My_tutorials_Load(object sender, EventArgs e)
        {
            Tutorial_load();
        }
        public void Tutorial_load()
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command;
            command = con.CreateCommand();
            command.CommandText = "SELECT `Subject_Name`, `Subject_Code`, `Video_Link`, `Class` FROM `course_details` Where Teacher_Email = @teacher_email";
            command.Parameters.AddWithValue("@teacher_email", Teachers_Login_Page.teacher_email);
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            My_tutorial_gride.DataSource = dt;

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Tutorial_load();

        }

        private void My_tutorial_gride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sub_name = My_tutorial_gride.SelectedRows[0].Cells[0].Value.ToString();
            sub_code= My_tutorial_gride.SelectedRows[0].Cells[1].Value.ToString();
            video_link = My_tutorial_gride.SelectedRows[0].Cells[2].Value.ToString();
            Class = My_tutorial_gride.SelectedRows[0].Cells[3].Value.ToString();
            T_D_Show_Tutorials_details obj = new T_D_Show_Tutorials_details();
            obj.ShowDialog();
        }
    }
}
