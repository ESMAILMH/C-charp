using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.fproject
{
    public partial class frm_message : Form
    {
        public frm_message(string message )
        {
            InitializeComponent();

            lbl_message.Text = message;
        }

        private void frm_message_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000; // ضبط الوقت لـ 3 ثوانٍ
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
