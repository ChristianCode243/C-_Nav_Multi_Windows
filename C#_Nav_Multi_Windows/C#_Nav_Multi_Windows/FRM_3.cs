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
    public partial class FRM_3 : Form
    {
        public static FRM_3 frm_3 = new FRM_3();
        public FRM_3()
        {
            frm_3 = this;
            InitializeComponent();
        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.frm_home.Show();
        }
    }
}
