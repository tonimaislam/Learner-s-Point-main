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
    public partial class Student_update_profile : Form
    {
        Image img;
        public Student_update_profile()
        {
            InitializeComponent();
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
                cmd6.CommandText = "UPDATE `student` SET `Name`=@s_name,`Email`=@s_email,`Phone`=@s_phone,`Password`=@s_pass,`image`=@s_img WHERE Email = @email1;";
                cmd6.Parameters.AddWithValue("@s_name", update_name.Text);
                cmd6.Parameters.AddWithValue("@s_email", update_email.Text);
                cmd6.Parameters.AddWithValue("@s_phone", Update_phone.Text);
                cmd6.Parameters.AddWithValue("@s_pass", update_pass.Text);
                cmd6.Parameters.AddWithValue("@s_img", update_pic.Image);
                cmd6.Parameters.AddWithValue("@email1", Student_Login_Page.student_email);
                cmd6.ExecuteNonQuery();

                MySqlCommand cmd8;
                cmd8 = con.CreateCommand();
                cmd8.CommandText = "UPDATE `subjects` SET Email = @email WHERE Email = @email1;";
                cmd8.Parameters.AddWithValue("@email", update_email.Text);
                cmd8.Parameters.AddWithValue("@email1", Student_Login_Page.student_email);
                cmd8.ExecuteNonQuery();

                MySqlCommand cmd9;
                cmd9 = con.CreateCommand();
                cmd9.CommandText = "UPDATE `payment_details` SET Email = @email WHERE Email = @email1;";
                cmd9.Parameters.AddWithValue("@email", update_email.Text);
                cmd9.Parameters.AddWithValue("@email1", Student_Login_Page.student_email);
                cmd9.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Updated Successfully !!!");

                Student_Login_Page.student_email = update_email.Text;

                reset();
                this.Close();
            }
            void reset()
            {
                update_name.Clear();
                update_email.Clear();
                Update_phone.Clear();
                update_pass.Clear();
                update_pic.Image = img;

            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Student_update_profile_Load(object sender, EventArgs e)
        {
            update_name.Text = S_D_Profile.name;
            update_email.Text = S_D_Profile.email;
            Update_phone.Text = S_D_Profile.phone;
            update_pass.Text = S_D_Profile.pass;

        }
    }
}
