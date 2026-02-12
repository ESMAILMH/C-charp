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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void pnlcontent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_name.Text = "";
            txt_pssword.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {  
                    
               
                if (txt_name.Text == "admin" && txt_pssword.Text == "admin")
                {
                    Form Show_message = new frm_message("Seccesfully login ");
                    Show_message.Show();

                    frm_main main = new frm_main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_name.Text) && string.IsNullOrEmpty(txt_pssword.Text))
                    {
                        Form Show_message = new frm_message("Please enter both username and password.");
                        Show_message.Show();
                       
                        return;
                    }
                    else if (string.IsNullOrEmpty(txt_name.Text))
                    {
                        Form Show_message = new frm_message("Please enter both username and password.");
                        Show_message.Show();
                        return;
                    }
                    else {
                        Form Show_message = new frm_message("Please enter both username and password.");
                        Show_message.Show();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        { }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
