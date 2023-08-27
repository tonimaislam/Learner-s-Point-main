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
    public partial class T_D_Show_Tutorials_details : Form
    {
        public T_D_Show_Tutorials_details()
        {
            InitializeComponent();
        }

        private void T_D_Show_Tutorials_details_Load(object sender, EventArgs e)
        {
            sub_name.Text = T_D_My_tutorials.sub_name;
            sub_code.Text = T_D_My_tutorials.sub_code;
            Class.Text = T_D_My_tutorials.Class;
            video_link.Text = T_D_My_tutorials.video_link;
        }
    }
}
