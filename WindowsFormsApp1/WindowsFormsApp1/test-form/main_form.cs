using System;
using System.Windows.Forms;

namespace WindowsFormsApp1.test_form
{
    public partial class main_from : Form
    {
        public main_from()
        {
            InitializeComponent();
        }

        private void main_from_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void جمعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sum Summation = new sum();
            Summation.Show();
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main_from.ActiveForm.Close();
        }
    }
}
