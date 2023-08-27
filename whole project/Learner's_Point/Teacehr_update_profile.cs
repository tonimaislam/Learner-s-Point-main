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
    public partial class Teacehr_update_profile : Form
    {
        Image img;
        public Teacehr_update_profile()
        {
            InitializeComponent();
            img = update_pic.Image;
        }

        private void choose_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                update_pic.Image = Image.FromFile(opf.FileName);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (update_name.Text == "" || update_email.Text == "" || Update_phone.Text == "" || update_pass.Text == "" || update_pic.Image == img)
            {
                MessageBox.Show("Please Insert Actual Value !");
            }
            else
            {
                MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
                con.Open();

                MySqlCommand cmd6;
                cmd6 = con.CreateCommand();
                cmd6.CommandText = "UPDATE `teacher` SET `Name`=@name,`Email`=@email,`Phone`=@phone,`Password`=@pass,`image`=@img WHERE Email = @email1;";
                cmd6.Parameters.AddWithValue("@name", update_name.Text);
                cmd6.Parameters.AddWithValue("@email", update_email.Text);
                cmd6.Parameters.AddWithValue("@phone", Update_phone.Text);
                cmd6.Parameters.AddWithValue("@pass", update_pass.Text);
                cmd6.Parameters.AddWithValue("@img", update_pic.Image);
                cmd6.Parameters.AddWithValue("@email1", Teachers_Login_Page.teacher_email);
                cmd6.ExecuteNonQuery();

                MySqlCommand cmd8;
                cmd8 = con.CreateCommand();
                cmd8.CommandText = "UPDATE `course_details` SET `Teacher_Email`=@email WHERE Teacher_Email = @email1";
                cmd8.Parameters.AddWithValue("@email", update_email.Text);
                cmd8.Parameters.AddWithValue("@email1", Teachers_Login_Page.teacher_email);
                cmd8.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Updated Successfully !!!");

                Teachers_Login_Page.teacher_email = update_email.Text;
                
                T_D_Profile obj = new T_D_Profile();
                obj.load_profile();

                reset();
                this.Close();
            }
        }

        void reset()
        {
            update_name.Clear();
            update_email.Clear();
            Update_phone.Clear();
            update_pass.Clear();
            update_pic.Image = img;

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Teacehr_update_profile_Load(object sender, EventArgs e)
        {
            update_name.Text = T_D_Profile.name;
            update_email.Text = T_D_Profile.email;
            Update_phone.Text = T_D_Profile.phone;
            update_pass.Text = T_D_Profile.pass;
        }
    }
}
