using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.fproject
{

    public partial class frm_main : Form
    {
        string DatabasePath = Path.Combine(Application.StartupPath, "Database.txt");

        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            if (!File.Exists(DatabasePath))
            {
                File.Create(DatabasePath).Close();
            }
            ReadData(DatabasePath, dGVpass);
        }
        public static void ReadData(string filePath, DataGridView dgv)
        {
            try
            {
                dgv.Rows.Clear();
                StreamReader reDatabase = new StreamReader(filePath);

                string reline;
                do
                {
                    reline = reDatabase.ReadLine();
                    if (reline != null)
                    {
                        object[] datalines = reline.Split(';');
                        dgv.Rows.Add(datalines);
                    }

                } while (reline != null);
                reDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data: " + ex.Message);
            }
        }


        private void dGVpass_DoubleClick(object sender, EventArgs e)
        {
            dGVpass.CurrentRow.Selected = true;
            txt_passid.Text = dGVpass.CurrentRow.Cells[0].Value.ToString();
            txt_title.Text = dGVpass.CurrentRow.Cells[1].Value.ToString();
            txt_name.Text = dGVpass.CurrentRow.Cells[2].Value.ToString();
            txt_Discription.Text = dGVpass.CurrentRow.Cells[4].Value.ToString();
            txt_pssword.Text = dGVpass.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dGVpass.Rows.RemoveAt(dGVpass.CurrentRow.Index);

        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            string drow;
            string sPassID = txt_passid.Text;
            string sTitle = txt_title.Text;
            string sName = txt_name.Text;
            string sPassword = txt_pssword.Text;
            string sDescription = txt_Discription.Text;

            if (string.IsNullOrWhiteSpace(sPassID) || string.IsNullOrWhiteSpace(sTitle) || string.IsNullOrWhiteSpace(sName) || string.IsNullOrWhiteSpace(sPassword))
            {
                Form message = new frm_message("Please fill in all required fields.");
                message.ShowDialog();
            }
            else
            {
                StreamReader sr = new StreamReader(sPassID);
                string line;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(';');
                        if (fields[0] == sPassID)
                        {
                            Form message = new frm_message("A record with this PassID already exists. Please use a unique PassID.");
                            message.ShowDialog();

                        }
                    }
                } while ((line = sr.ReadLine()) != null);
            }
            drow = $"{sPassID};{sTitle};{sName};{sPassword};{sDescription}";

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_Discription.Text = "";
            txt_pssword.Text = "";
            txt_passid.Text = "";
            txt_search.Text = "";
            txt_title.Text = "";
            txt_name.Text = "";
        }
    }
}
