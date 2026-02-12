using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.test_form
{
    public partial class combo : Form
    {
        String[] status = {
    "Active",
    "Inactive",
    "Pending",
    "Suspended"
};
        String[] role = {
    "Admin",
    "Manager",
    "Employee",
    "Guest"
};
        String[] department = {
    "HR",
    "Finance",
    "IT",
    "Sales",
    "Operations"
};
        String[] category = {
    "General",
    "Technical",
    "Administrative",
    "Financial",
    "Support"
};
        String[] priority = {
    "Low",
    "Medium",
    "High",
    "Urgent"
};

        public combo()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Status":
                    comboBox2.Items.Clear();
                    for (int i = 0; i < status.Length; i++)
                    {
                        comboBox2.Items.Add(status[i]);
                    }
                    break;
                case "Role":
                    comboBox2.Items.Clear();
                    for (int i = 0; i < role.Length; i++)
                    {
                        comboBox2.Items.Add(role[i]);
                    }
                    break;
                case "Department":
                    comboBox2.Items.Clear();
                    for (int i = 0; i < department.Length; i++)
                    {
                        comboBox2.Items.Add(department[i]);
                    }
                    break;
                case "Category":
                    comboBox2.Items.Clear();
                    for (int i = 0; i < category.Length; i++)
                    {
                        comboBox2.Items.Add(category[i]);
                    }
                    break;
                case "Priority":
                    comboBox2.Items.Clear();
                    for (int i = 0; i < priority.Length; i++)
                    {
                        comboBox2.Items.Add(priority[i]);
                    }
                    break;
                default:
                    comboBox2.Items.Clear();
                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Status");
            comboBox1.Items.Add("Role");
            comboBox1.Items.Add("Department");
            comboBox1.Items.Add("Category");
            comboBox1.Items.Add("Priority");
            var groups = new (string Name, string[] Items)[]
      {
        ("Status", new string[] { "Active", "Inactive", "Pending", "Suspended" }),
        ("Role", new string[] { "Admin", "Manager", "Employee", "Guest" }),
        ("Department", new string[] { "HR", "Finance", "IT", "Sales", "Operations" }),
        ("Category", new string[] { "General", "Technical", "Administrative", "Financial", "Support" }),
        ("Priority", new string[] { "Low", "Medium", "High", "Urgent" })
      };

     
            foreach (var g in groups)
            {
                int rowIndex = dGView1.Rows.Add(g.Name);
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dGView1.Rows[rowIndex].Cells["Column2"];
                comboCell.Items.AddRange(g.Items); // العمود الثاني = القيم المناسبة
            }
        }
    }
}
