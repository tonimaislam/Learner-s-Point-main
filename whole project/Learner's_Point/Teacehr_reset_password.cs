﻿using System;
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
    public partial class Teacehr_reset_password : Form
    {
        static public string email = forgot_teacher_password.teacher_email;
        public Teacehr_reset_password()
        {
            InitializeComponent();
        }

        private void pass_update_btn_Click(object sender, EventArgs e)
        {
            if (new_pass_txt.Text == "" || re_type_pass_txt.Text == "")
            {
                MessageBox.Show("Empty Field not valid !");
            }
            else
            {
                if (new_pass_txt.Text == re_type_pass_txt.Text)
                {
                    MySqlConnection con = new MySqlConnection(Database_Connect.connect_database());
                    con.Open();
                    MySqlCommand command;
                    command = con.CreateCommand();
                    command.CommandText = "UPDATE `teacher` SET `Password`='" + re_type_pass_txt.Text + "' WHERE Email = @teacher_email;";
                    command.Parameters.AddWithValue("@teacher_email", email);
                    command.ExecuteNonQuery();
                    con.Close();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Password Not Matched !");
                }

            }
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
