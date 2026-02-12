using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    partial class Form_FamilyDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSons;
        private System.Windows.Forms.TabPage tabDaughters;

        // Sons controls
        private System.Windows.Forms.TextBox txtSonNationalID;
        private System.Windows.Forms.TextBox txtSonName;
        private System.Windows.Forms.ComboBox cmbSonBloodType;
        private System.Windows.Forms.NumericUpDown numSonAge;
        private System.Windows.Forms.TextBox txtSonWorkPlace;
        private System.Windows.Forms.TextBox txtSonPhone;
        private System.Windows.Forms.Button btnAddSon;
        private System.Windows.Forms.DataGridView dgvSons;

        // Daughters controls
        private System.Windows.Forms.TextBox txtDaughterNationalID;
        private System.Windows.Forms.TextBox txtDaughterName;
        private System.Windows.Forms.ComboBox cmbDaughterBloodType;
        private System.Windows.Forms.NumericUpDown numDaughterAge;
        private System.Windows.Forms.TextBox txtDaughterWorkPlace;
        private System.Windows.Forms.TextBox txtDaughterPhone;
        private System.Windows.Forms.Button btnAddDaughter;
        private System.Windows.Forms.DataGridView dgvDaughters;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblParentName = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSons = new System.Windows.Forms.TabPage();
            this.txtSonNationalID = new System.Windows.Forms.TextBox();
            this.txtSonName = new System.Windows.Forms.TextBox();
            this.cmbSonBloodType = new System.Windows.Forms.ComboBox();
            this.numSonAge = new System.Windows.Forms.NumericUpDown();
            this.txtSonWorkPlace = new System.Windows.Forms.TextBox();
            this.txtSonPhone = new System.Windows.Forms.TextBox();
            this.btnAddSon = new System.Windows.Forms.Button();
            this.dgvSons = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDaughters = new System.Windows.Forms.TabPage();
            this.txtDaughterNationalID = new System.Windows.Forms.TextBox();
            this.txtDaughterName = new System.Windows.Forms.TextBox();
            this.cmbDaughterBloodType = new System.Windows.Forms.ComboBox();
            this.numDaughterAge = new System.Windows.Forms.NumericUpDown();
            this.txtDaughterWorkPlace = new System.Windows.Forms.TextBox();
            this.txtDaughterPhone = new System.Windows.Forms.TextBox();
            this.btnAddDaughter = new System.Windows.Forms.Button();
            this.dgvDaughters = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabSons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSonAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSons)).BeginInit();
            this.tabDaughters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaughterAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaughters)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblParentName.Location = new System.Drawing.Point(12, 9);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(267, 24);
            this.lblParentName.TabIndex = 0;
            this.lblParentName.Text = "بيانات عائلة السيد: [اسم الأب المحدد]";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSons);
            this.tabControl.Controls.Add(this.tabDaughters);
            this.tabControl.Location = new System.Drawing.Point(12, 45);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(909, 400);
            this.tabControl.TabIndex = 1;
            // 
            // tabSons
            // 
            this.tabSons.Controls.Add(this.txtSonNationalID);
            this.tabSons.Controls.Add(this.txtSonName);
            this.tabSons.Controls.Add(this.cmbSonBloodType);
            this.tabSons.Controls.Add(this.numSonAge);
            this.tabSons.Controls.Add(this.txtSonWorkPlace);
            this.tabSons.Controls.Add(this.txtSonPhone);
            this.tabSons.Controls.Add(this.btnAddSon);
            this.tabSons.Controls.Add(this.dgvSons);
            this.tabSons.Location = new System.Drawing.Point(4, 25);
            this.tabSons.Name = "tabSons";
            this.tabSons.Padding = new System.Windows.Forms.Padding(3);
            this.tabSons.Size = new System.Drawing.Size(901, 371);
            this.tabSons.TabIndex = 0;
            this.tabSons.Text = "الأبناء";
            this.tabSons.UseVisualStyleBackColor = true;
            // 
            // txtSonNationalID
            // 
            this.txtSonNationalID.Location = new System.Drawing.Point(20, 20);
            this.txtSonNationalID.Name = "txtSonNationalID";
            this.txtSonNationalID.Size = new System.Drawing.Size(320, 22);
            this.txtSonNationalID.TabIndex = 0;
            // 
            // txtSonName
            // 
            this.txtSonName.Location = new System.Drawing.Point(20, 52);
            this.txtSonName.Name = "txtSonName";
            this.txtSonName.Size = new System.Drawing.Size(320, 22);
            this.txtSonName.TabIndex = 1;
            // 
            // cmbSonBloodType
            // 
            this.cmbSonBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSonBloodType.FormattingEnabled = true;
            this.cmbSonBloodType.Location = new System.Drawing.Point(20, 84);
            this.cmbSonBloodType.Name = "cmbSonBloodType";
            this.cmbSonBloodType.Size = new System.Drawing.Size(320, 24);
            this.cmbSonBloodType.TabIndex = 2;
            // 
            // numSonAge
            // 
            this.numSonAge.Location = new System.Drawing.Point(20, 116);
            this.numSonAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numSonAge.Name = "numSonAge";
            this.numSonAge.Size = new System.Drawing.Size(120, 22);
            this.numSonAge.TabIndex = 3;
            // 
            // txtSonWorkPlace
            // 
            this.txtSonWorkPlace.Location = new System.Drawing.Point(20, 148);
            this.txtSonWorkPlace.Name = "txtSonWorkPlace";
            this.txtSonWorkPlace.Size = new System.Drawing.Size(320, 22);
            this.txtSonWorkPlace.TabIndex = 4;
            // 
            // txtSonPhone
            // 
            this.txtSonPhone.Location = new System.Drawing.Point(20, 180);
            this.txtSonPhone.Name = "txtSonPhone";
            this.txtSonPhone.Size = new System.Drawing.Size(320, 22);
            this.txtSonPhone.TabIndex = 5;
            // 
            // btnAddSon
            // 
            this.btnAddSon.Location = new System.Drawing.Point(20, 212);
            this.btnAddSon.Name = "btnAddSon";
            this.btnAddSon.Size = new System.Drawing.Size(120, 30);
            this.btnAddSon.TabIndex = 6;
            this.btnAddSon.Text = "إضافة ابن";
            this.btnAddSon.UseVisualStyleBackColor = true;
            this.btnAddSon.Click += new System.EventHandler(this.BtnAddSon_Click);
            // 
            // dgvSons
            // 
            this.dgvSons.AllowUserToAddRows = false;
            this.dgvSons.AllowUserToDeleteRows = false;
            this.dgvSons.ColumnHeadersHeight = 29;
            this.dgvSons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvSons.Location = new System.Drawing.Point(360, 20);
            this.dgvSons.Name = "dgvSons";
            this.dgvSons.ReadOnly = true;
            this.dgvSons.RowHeadersVisible = false;
            this.dgvSons.RowHeadersWidth = 51;
            this.dgvSons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSons.Size = new System.Drawing.Size(535, 330);
            this.dgvSons.TabIndex = 7;
            this.dgvSons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSons_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // tabDaughters
            // 
            this.tabDaughters.Controls.Add(this.txtDaughterNationalID);
            this.tabDaughters.Controls.Add(this.txtDaughterName);
            this.tabDaughters.Controls.Add(this.cmbDaughterBloodType);
            this.tabDaughters.Controls.Add(this.numDaughterAge);
            this.tabDaughters.Controls.Add(this.txtDaughterWorkPlace);
            this.tabDaughters.Controls.Add(this.txtDaughterPhone);
            this.tabDaughters.Controls.Add(this.btnAddDaughter);
            this.tabDaughters.Controls.Add(this.dgvDaughters);
            this.tabDaughters.Location = new System.Drawing.Point(4, 25);
            this.tabDaughters.Name = "tabDaughters";
            this.tabDaughters.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaughters.Size = new System.Drawing.Size(752, 371);
            this.tabDaughters.TabIndex = 1;
            this.tabDaughters.Text = "البنات";
            this.tabDaughters.UseVisualStyleBackColor = true;
            // 
            // txtDaughterNationalID
            // 
            this.txtDaughterNationalID.Location = new System.Drawing.Point(20, 20);
            this.txtDaughterNationalID.Name = "txtDaughterNationalID";
            this.txtDaughterNationalID.Size = new System.Drawing.Size(320, 22);
            this.txtDaughterNationalID.TabIndex = 0;
            // 
            // txtDaughterName
            // 
            this.txtDaughterName.Location = new System.Drawing.Point(20, 52);
            this.txtDaughterName.Name = "txtDaughterName";
            this.txtDaughterName.Size = new System.Drawing.Size(320, 22);
            this.txtDaughterName.TabIndex = 1;
            // 
            // cmbDaughterBloodType
            // 
            this.cmbDaughterBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDaughterBloodType.FormattingEnabled = true;
            this.cmbDaughterBloodType.Location = new System.Drawing.Point(20, 84);
            this.cmbDaughterBloodType.Name = "cmbDaughterBloodType";
            this.cmbDaughterBloodType.Size = new System.Drawing.Size(320, 24);
            this.cmbDaughterBloodType.TabIndex = 2;
            // 
            // numDaughterAge
            // 
            this.numDaughterAge.Location = new System.Drawing.Point(20, 116);
            this.numDaughterAge.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numDaughterAge.Name = "numDaughterAge";
            this.numDaughterAge.Size = new System.Drawing.Size(120, 22);
            this.numDaughterAge.TabIndex = 3;
            // 
            // txtDaughterWorkPlace
            // 
            this.txtDaughterWorkPlace.Location = new System.Drawing.Point(20, 148);
            this.txtDaughterWorkPlace.Name = "txtDaughterWorkPlace";
            this.txtDaughterWorkPlace.Size = new System.Drawing.Size(320, 22);
            this.txtDaughterWorkPlace.TabIndex = 4;
            // 
            // txtDaughterPhone
            // 
            this.txtDaughterPhone.Location = new System.Drawing.Point(20, 180);
            this.txtDaughterPhone.Name = "txtDaughterPhone";
            this.txtDaughterPhone.Size = new System.Drawing.Size(320, 22);
            this.txtDaughterPhone.TabIndex = 5;
            // 
            // btnAddDaughter
            // 
            this.btnAddDaughter.Location = new System.Drawing.Point(20, 212);
            this.btnAddDaughter.Name = "btnAddDaughter";
            this.btnAddDaughter.Size = new System.Drawing.Size(120, 30);
            this.btnAddDaughter.TabIndex = 6;
            this.btnAddDaughter.Text = "إضافة بنت";
            this.btnAddDaughter.UseVisualStyleBackColor = true;
            this.btnAddDaughter.Click += new System.EventHandler(this.BtnAddDaughter_Click);
            // 
            // dgvDaughters
            // 
            this.dgvDaughters.AllowUserToAddRows = false;
            this.dgvDaughters.AllowUserToDeleteRows = false;
            this.dgvDaughters.ColumnHeadersHeight = 29;
            this.dgvDaughters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvDaughters.Location = new System.Drawing.Point(360, 20);
            this.dgvDaughters.Name = "dgvDaughters";
            this.dgvDaughters.ReadOnly = true;
            this.dgvDaughters.RowHeadersVisible = false;
            this.dgvDaughters.RowHeadersWidth = 51;
            this.dgvDaughters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDaughters.Size = new System.Drawing.Size(370, 330);
            this.dgvDaughters.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // Form_FamilyDetails
            // 
            this.ClientSize = new System.Drawing.Size(933, 461);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.lblParentName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_FamilyDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تفاصيل العائلة";
            this.Load += new System.EventHandler(this.Form_FamilyDetails_Load);
            this.tabControl.ResumeLayout(false);
            this.tabSons.ResumeLayout(false);
            this.tabSons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSonAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSons)).EndInit();
            this.tabDaughters.ResumeLayout(false);
            this.tabDaughters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaughterAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaughters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewCellEventHandler dgvSons_CellContentClick;
    }
}