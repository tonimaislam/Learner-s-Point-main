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
    public partial class T_D_Home : UserControl
    {
        public static String title, date,description,role_as;

        private void refresh_Click(object sender, EventArgs e)
        {
            Post_load();
        }

        public T_D_Home()
        {
            InitializeComponent();
        }

        private void T_D_Home_Load(object sender, EventArgs e)
        {
            Post_load();
        }
        public void Post_load()
        {
            MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
            con.Open();
            MySqlCommand command;
            command = con.CreateCommand();
            command.CommandText = "SELECT `Title`, `Date`, `Description`,`Role_As` FROM `post`;";
            MySqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            Home_gride.DataSource = dt;

        }

        private void Home_gride_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            title = Home_gride.SelectedRows[0].Cells[0].Value.ToString();
            date = Home_gride.SelectedRows[0].Cells[1].Value.ToString();
            description = Home_gride.SelectedRows[0].Cells[2].Value.ToString();
            role_as = Home_gride.SelectedRows[0].Cells[3].Value.ToString();
            T_D_Show_post_details obj = new T_D_Show_post_details();
            obj.ShowDialog();
        }
    }
}
