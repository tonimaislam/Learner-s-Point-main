using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learner_s_Point
{
    public partial class S_D_Show_post_details : Form
    {
        public S_D_Show_post_details()
        {
            InitializeComponent();
        }

        private void S_D_Show_post_details_Load(object sender, EventArgs e)
        {
            title.Text = S_D_Home.title;
            date.Text = S_D_Home.date;
            description.Text = S_D_Home.description;
            role_as.Text = S_D_Home.role_as;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
