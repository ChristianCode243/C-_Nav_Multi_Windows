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
    public partial class FRM_1 : Form
    {
        public static FRM_1 frm_1 = new FRM_1();
        public FRM_1()
        {
            frm_1 = this;
            InitializeComponent();
        }

        private void BTN_back_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.frm_home.Show();
        }
    }
}
