using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.test_form
{
    public partial class sum : Form
    {
        String connString = ("Server=localhost;Port=3306;Database=modernsystems;Uid=root;Pwd=ames2000;");

        public sum()
        {
            InitializeComponent();
               }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int number1, number2, result;
            
            result = 0;
            if (txt1.Text.Length > 0 && txt2.Text.Length > 0)
            {
                number1 = Convert.ToInt32(txt1.Text);
                number2 = Convert.ToInt32(txt2.Text);
                result = number1 + number2;
                lblsum.Text = "الناتج: " + result.ToString();
            }
            else
            {
                MessageBox.Show("عذراً، يرجى إدخال الأرقام في الحقول المطلوبة", "خطأ في الإدخال");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sum_Load(object sender, EventArgs e)
        {

        }

     

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
