namespace C__Nav_Multi_Windows
{
    public partial class Form1 : Form
    {
        public static Form1 frm_home = new Form1();
        public Form1()
        {
            frm_home = this;
            InitializeComponent();
        }

        private void BTN_F1_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_1.frm_1.ShowDialog();
        }

        private void BTN_F2_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_2.frm_2.ShowDialog();
        }

        private void BTN_F3_Click(object sender, EventArgs e)
        {
            Hide();
            FRM_3.frm_3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
