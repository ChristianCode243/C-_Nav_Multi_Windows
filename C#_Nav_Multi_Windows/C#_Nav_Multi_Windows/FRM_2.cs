using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Nav_Multi_Windows
{
    public partial class FRM_2 : Form
    {
        public static FRM_2 frm_2 = new FRM_2();
        public FRM_2()
        {
            frm_2 = this;
            InitializeComponent();
        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.frm_home.Show();
        }
    }
}
