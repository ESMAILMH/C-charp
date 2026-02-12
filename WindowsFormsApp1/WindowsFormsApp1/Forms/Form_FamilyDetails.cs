using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Form_FamilyDetails : Form
    {
        private readonly string _parentName;
        public string ParentNationalId { get; }

        public Form_FamilyDetails(string parentName, string parentNationalId = null)
        {
            _parentName = parentName ?? string.Empty;
            ParentNationalId = parentNationalId;
            InitializeComponent();
        }

        private void Form_FamilyDetails_Load(object sender, EventArgs e)
        {
            lblParentName.Text = $"بيانات عائلة السيد: {_parentName}";

            // Populate blood type combos if designer didn't already
            var bloodTypes = new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" };
            if (cmbSonBloodType.Items.Count == 0)
                cmbSonBloodType.Items.AddRange(bloodTypes);
            if (cmbDaughterBloodType.Items.Count == 0)
                cmbDaughterBloodType.Items.AddRange(bloodTypes);

            if (cmbSonBloodType.SelectedIndex < 0) cmbSonBloodType.SelectedIndex = 0;
            if (cmbDaughterBloodType.SelectedIndex < 0) cmbDaughterBloodType.SelectedIndex = 0;
        }

        private void BtnAddSon_Click(object sender, EventArgs e)
        {
            AddChildToGrid(dgvSons,
                txtSonNationalID.Text.Trim(),
                txtSonName.Text.Trim(),
                cmbSonBloodType.Text,
                (int)numSonAge.Value,
                txtSonWorkPlace.Text.Trim(),
                txtSonPhone.Text.Trim());
        }

        private void BtnAddDaughter_Click(object sender, EventArgs e)
        {
            AddChildToGrid(dgvDaughters,
                txtDaughterNationalID.Text.Trim(),
                txtDaughterName.Text.Trim(),
                cmbDaughterBloodType.Text,
                (int)numDaughterAge.Value,
                txtDaughterWorkPlace.Text.Trim(),
                txtDaughterPhone.Text.Trim());
        }

        private void AddChildToGrid(DataGridView grid, string nationalId, string name, string bloodType, int age, string workplace, string phone)
        {
            if (string.IsNullOrWhiteSpace(nationalId) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("الرجاء إدخال الرقم الوطني واسم الابن/البنت.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicate national ID for this grid
            var exists = grid.Rows.Cast<DataGridViewRow>()
                .Any(r => string.Equals(Convert.ToString(r.Cells["colChildNationalID"].Value), nationalId, StringComparison.OrdinalIgnoreCase));
            if (exists)
            {
                MessageBox.Show("الرقم الوطني موجود بالفعل في هذه القائمة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            grid.Rows.Add(nationalId, name, bloodType, age, workplace, phone);

            // Clear inputs for next entry; preserve blood type selection
            if (grid == dgvSons)
            {
                txtSonNationalID.Clear();
                txtSonName.Clear();
                numSonAge.Value = 0;
                txtSonWorkPlace.Clear();
                txtSonPhone.Clear();
                txtSonNationalID.Focus();
            }
            else
            {
                txtDaughterNationalID.Clear();
                txtDaughterName.Clear();
                numDaughterAge.Value = 0;
                txtDaughterWorkPlace.Clear();
                txtDaughterPhone.Clear();
                txtDaughterNationalID.Focus();                          
            }
        }

        // Expose counts so caller can read results after dialog closes
        public int SonsCount => dgvSons?.Rows.Count ?? 0;
        public int DaughtersCount => dgvDaughters?.Rows.Count ?? 0;

        
    }
}