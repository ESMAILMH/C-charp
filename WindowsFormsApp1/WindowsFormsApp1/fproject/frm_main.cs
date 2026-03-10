using System;
using System.IO;
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
            try
            {
                dGVpass.CurrentRow.Selected = true;
                txt_passid.Text = dGVpass.CurrentRow.Cells[0].Value.ToString();
                txt_title.Text = dGVpass.CurrentRow.Cells[1].Value.ToString();
                txt_name.Text = dGVpass.CurrentRow.Cells[2].Value.ToString();
                txt_Discription.Text = dGVpass.CurrentRow.Cells[4].Value.ToString();
                txt_pssword.Text = dGVpass.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading data: " + ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            dGVpass.Rows.RemoveAt(dGVpass.CurrentRow.Index);

        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string drow;
                string sPassID = txt_passid.Text;
                string sTitle = txt_title.Text;
                string sName = txt_name.Text;
                string sPassword = txt_pssword.Text;
                string sDescription = txt_Discription.Text;
                Boolean isDuplicate = true;

                if (string.IsNullOrWhiteSpace(sPassID) || string.IsNullOrWhiteSpace(sTitle) || string.IsNullOrWhiteSpace(sName) || string.IsNullOrWhiteSpace(sPassword))
                {
                    Form message = new frm_message("Please fill in all required fields.");
                    message.ShowDialog();
                }
                else
                {
                    StreamReader sr = new StreamReader(DatabasePath);
                    string line;
                    do
                    {
                        line = sr.ReadLine();
                        if (line != null)
                        {
                            string[] fields = line.Split(';');
                            if (fields[0] == sPassID)
                            {
                                isDuplicate = false;
                            }
                        }
                    } while ((line = sr.ReadLine()) != null);
                    sr.Close();

                    if (isDuplicate)
                    {

                        StreamWriter sw = new StreamWriter(DatabasePath, true);
                        drow = $"{sPassID};{sTitle};{sName};{sPassword};{sDescription}";
                        sw.WriteLine(drow);
                        sw.Close();
                        ReadData(DatabasePath, dGVpass);
                        txt_Discription.Text = "";
                        txt_pssword.Text = "";
                        txt_passid.Text = "";
                        txt_search.Text = "";
                        txt_title.Text = "";
                        txt_name.Text = "";
                    }
                    else
                    {
                        Form message = new frm_message("PassID already exists. Please use a unique PassID.");
                        message.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
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

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_resetPassId_Click(object sender, EventArgs e)
        {
            txt_passid.Text = PassIDGeneration(DatabasePath);
        }
        // password_ID Generation 

        public static string PassIDGeneration(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string line;
                int i = 1;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(';');
                        string intdataline = fields[0].Substring(1);
                        int intPassID = Convert.ToInt32(intdataline);
                        if (intPassID >= i)
                        {
                            i = intPassID + 1;
                        }
                    }
                } while (line != null);
                sr.Close();
                return "P0" + i.ToString("D3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PassID: " + ex.Message);
                return ""; // Return a default PassID in case of error
            }
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {

            txt_pssword.Text = GenerateRandomPassword();

        }

        /////// generate random password
        public static string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
            Random random = new Random();
            int length = 12; // طول كلمة المرور المطلوبة

            // استخدام Enumerable.Repeat لتوليد أحرف عشوائية وتحويلها إلى مصفوفة ثم نص
            char[] password = new char[length];
            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }
    }

}
