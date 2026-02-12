using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.test_form
{
    public partial class AgeCalculate : Form
    {
        public AgeCalculate()
        {
            InitializeComponent();
        }

        private void AgeCalculate_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string yourname= txtname.Text;
            DateTime birthdate = Convert.ToDateTime(bdPicker.Text);
            int days=DateTime.Now.Subtract(birthdate).Days;
            int months = days / 30;
            int years = days / 365;
            lbldayscount.Text = days.ToString() + " Days";
            lblmonthscount.Text = months.ToString() + " Months";
            lblyearscount.Text = years.ToString() + " Years";
            lblresult.Visible = true;
            lblresult.Text = "Hello " + yourname + ", You are " + years.ToString() + " Years,\n " + (months - years * 12).ToString() + " Months and " + (days - months * 30).ToString() + " Days old.";
 
        }
    }
}
