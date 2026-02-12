using System;
using System.Linq;
using System.Windows.Forms;


using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Father : Form
    {
        public Father()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ensure initial total is correct on load
            UpdateTotalMembers();

            // Disable actions until a selection is made
            btnUpdate.Enabled = false;
            btnOpenChildren.Enabled = false;
        }

        // Shared handler for numeric up/down controls to recalculate total
        private void NumChildren_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalMembers();
        }

        private void UpdateTotalMembers()
        {
            // Sum numeric up/downs and display in lblTotalMembers
            var total = numMales.Value + numFemales.Value;
            lblTotalMembers.Text = decimal.ToInt32(total).ToString();
        }

        // Save a new parent row into the DataGridView
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtNationalID.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("الرجاء إدخال الرقم الوطني والاسم.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent duplicate national ID in grid (simple check)
            var exists = dgvParents.Rows.Cast<DataGridViewRow>()
                .Any(r => string.Equals(Convert.ToString(r.Cells["colNationalID"].Value), txtNationalID.Text.Trim(), StringComparison.OrdinalIgnoreCase));
            if (exists)
            {
                MessageBox.Show("الرقم الوطني موجود بالفعل في النظام.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add row
            dgvParents.Rows.Add(txtNationalID.Text.Trim(), txtFullName.Text.Trim(), txtPhone.Text.Trim());

            // Clear selection and disable update/open
            dgvParents.ClearSelection();
            btnUpdate.Enabled = false;
            btnOpenChildren.Enabled = false;
        }

        // Update selected parent row with current form values
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvParents.SelectedRows.Count == 0)
                return;

            var row = dgvParents.SelectedRows[0];
            row.Cells["colNationalID"].Value = txtNationalID.Text.Trim();
            row.Cells["colFullName"].Value = txtFullName.Text.Trim();
            row.Cells["colPhone"].Value = txtPhone.Text.Trim();
        }

        // Open children screen for selected parent (placeholder)
        private void BtnOpenChildren_Click(object sender, EventArgs e)
        {
            if (dgvParents.SelectedRows.Count == 0)
                return;

            var selectedNationalId = dgvParents.SelectedRows[0].Cells["colNationalID"].Value?.ToString();
            MessageBox.Show($"Open children screen for parent {selectedNationalId}", "Open Children", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // TODO: replace MessageBox with actual children form navigation.
        }

        // Populate form fields when a parent row is selected and enable actions
        private void DgvParents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParents.SelectedRows.Count == 0)
            {
                btnUpdate.Enabled = false;
                btnOpenChildren.Enabled = false;
                return;
            }

            var row = dgvParents.SelectedRows[0];
            txtNationalID.Text = row.Cells["colNationalID"].Value?.ToString() ?? string.Empty;
            txtFullName.Text = row.Cells["colFullName"].Value?.ToString() ?? string.Empty;
            txtPhone.Text = row.Cells["colPhone"].Value?.ToString() ?? string.Empty;

            btnUpdate.Enabled = true;
            btnOpenChildren.Enabled = true;
        }

        // Simple in-memory filtering for dgvParents by FullName column
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var query = txtSearch.Text?.Trim();
            if (string.IsNullOrEmpty(query))
            {
                foreach (DataGridViewRow r in dgvParents.Rows)
                    r.Visible = true;
                return;
            }

            var lower = query.ToLowerInvariant();
            foreach (DataGridViewRow r in dgvParents.Rows)
            {
                var val = r.Cells["colFullName"].Value?.ToString() ?? string.Empty;
                r.Visible = val.ToLowerInvariant().Contains(lower);
            }
        }

        private void txtNationalID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}