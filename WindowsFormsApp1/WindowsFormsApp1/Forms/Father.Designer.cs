
namespace WindowsFormsApp1.Forms
{
    partial class Father
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.labelWorkPlace = new System.Windows.Forms.Label();
            this.txtWorkPlace = new System.Windows.Forms.TextBox();
            this.labelBloodType = new System.Windows.Forms.Label();
            this.cmbBloodType = new System.Windows.Forms.ComboBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labelMotherName = new System.Windows.Forms.Label();
            this.txtMotherName = new System.Windows.Forms.TextBox();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.labelNationalId = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblTotalCaption = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.labelFemales = new System.Windows.Forms.Label();
            this.numFemales = new System.Windows.Forms.NumericUpDown();
            this.labelMales = new System.Windows.Forms.Label();
            this.numMales = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvParents = new System.Windows.Forms.DataGridView();
            this.colNationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOpenChildren = new System.Windows.Forms.Button();
            this.groupBoxData.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFemales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.labelWorkPlace);
            this.groupBoxData.Controls.Add(this.txtWorkPlace);
            this.groupBoxData.Controls.Add(this.labelBloodType);
            this.groupBoxData.Controls.Add(this.cmbBloodType);
            this.groupBoxData.Controls.Add(this.labelPhone);
            this.groupBoxData.Controls.Add(this.txtPhone);
            this.groupBoxData.Controls.Add(this.labelMotherName);
            this.groupBoxData.Controls.Add(this.txtMotherName);
            this.groupBoxData.Controls.Add(this.labelFatherName);
            this.groupBoxData.Controls.Add(this.txtFatherName);
            this.groupBoxData.Controls.Add(this.labelBirthDate);
            this.groupBoxData.Controls.Add(this.dtpBirthDate);
            this.groupBoxData.Controls.Add(this.labelFullName);
            this.groupBoxData.Controls.Add(this.txtFullName);
            this.groupBoxData.Controls.Add(this.labelNationalId);
            this.groupBoxData.Controls.Add(this.txtNationalID);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(560, 367);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "مجموعة إدخال البيانات";
            // 
            // labelWorkPlace
            // 
            this.labelWorkPlace.AutoSize = true;
            this.labelWorkPlace.Location = new System.Drawing.Point(420, 318);
            this.labelWorkPlace.Name = "labelWorkPlace";
            this.labelWorkPlace.Size = new System.Drawing.Size(57, 16);
            this.labelWorkPlace.TabIndex = 15;
            this.labelWorkPlace.Text = "جهة العمل:";
            // 
            // txtWorkPlace
            // 
            this.txtWorkPlace.Location = new System.Drawing.Point(20, 315);
            this.txtWorkPlace.Name = "txtWorkPlace";
            this.txtWorkPlace.Size = new System.Drawing.Size(390, 22);
            this.txtWorkPlace.TabIndex = 14;
            // 
            // labelBloodType
            // 
            this.labelBloodType.AutoSize = true;
            this.labelBloodType.Location = new System.Drawing.Point(420, 278);
            this.labelBloodType.Name = "labelBloodType";
            this.labelBloodType.Size = new System.Drawing.Size(57, 16);
            this.labelBloodType.TabIndex = 13;
            this.labelBloodType.Text = "فصيلة الدم:";
            // 
            // cmbBloodType
            // 
            this.cmbBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBloodType.FormattingEnabled = true;
            this.cmbBloodType.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbBloodType.Location = new System.Drawing.Point(20, 275);
            this.cmbBloodType.Name = "cmbBloodType";
            this.cmbBloodType.Size = new System.Drawing.Size(390, 24);
            this.cmbBloodType.TabIndex = 12;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(420, 238);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(61, 16);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "رقم الهاتف:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(20, 235);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(390, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // labelMotherName
            // 
            this.labelMotherName.AutoSize = true;
            this.labelMotherName.Location = new System.Drawing.Point(420, 198);
            this.labelMotherName.Name = "labelMotherName";
            this.labelMotherName.Size = new System.Drawing.Size(45, 16);
            this.labelMotherName.TabIndex = 9;
            this.labelMotherName.Text = "اسم الأم:";
            // 
            // txtMotherName
            // 
            this.txtMotherName.Location = new System.Drawing.Point(20, 195);
            this.txtMotherName.Name = "txtMotherName";
            this.txtMotherName.Size = new System.Drawing.Size(390, 22);
            this.txtMotherName.TabIndex = 8;
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Location = new System.Drawing.Point(420, 158);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(49, 16);
            this.labelFatherName.TabIndex = 7;
            this.labelFatherName.Text = "اسم الأب:";
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(20, 155);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(390, 22);
            this.txtFatherName.TabIndex = 6;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(420, 118);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(43, 16);
            this.labelBirthDate.TabIndex = 5;
            this.labelBirthDate.Text = "المواليد:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(20, 113);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(390, 22);
            this.dtpBirthDate.TabIndex = 4;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(420, 78);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(75, 16);
            this.labelFullName.TabIndex = 3;
            this.labelFullName.Text = "الاسم بالكامل:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(20, 71);
            this.txtFullName.Multiline = true;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(390, 30);
            this.txtFullName.TabIndex = 2;
            // 
            // labelNationalId
            // 
            this.labelNationalId.AutoSize = true;
            this.labelNationalId.Location = new System.Drawing.Point(420, 35);
            this.labelNationalId.Name = "labelNationalId";
            this.labelNationalId.Size = new System.Drawing.Size(69, 16);
            this.labelNationalId.TabIndex = 1;
            this.labelNationalId.Text = "الرقم الوطني:";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point(20, 31);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(394, 22);
            this.txtNationalID.TabIndex = 0;
            this.txtNationalID.TextChanged += new System.EventHandler(this.txtNationalID_TextChanged);
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblTotalCaption);
            this.groupBoxStats.Controls.Add(this.lblTotalMembers);
            this.groupBoxStats.Controls.Add(this.labelFemales);
            this.groupBoxStats.Controls.Add(this.numFemales);
            this.groupBoxStats.Controls.Add(this.labelMales);
            this.groupBoxStats.Controls.Add(this.numMales);
            this.groupBoxStats.Location = new System.Drawing.Point(590, 12);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(200, 160);
            this.groupBoxStats.TabIndex = 1;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "مجموعة الإحصائيات";
            // 
            // lblTotalCaption
            // 
            this.lblTotalCaption.AutoSize = true;
            this.lblTotalCaption.Location = new System.Drawing.Point(110, 120);
            this.lblTotalCaption.Name = "lblTotalCaption";
            this.lblTotalCaption.Size = new System.Drawing.Size(80, 16);
            this.lblTotalCaption.TabIndex = 5;
            this.lblTotalCaption.Text = "إجمالي الأسرة:";
            // 
            // lblTotalMembers
            // 
            this.lblTotalMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalMembers.Location = new System.Drawing.Point(20, 116);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(80, 23);
            this.lblTotalMembers.TabIndex = 4;
            this.lblTotalMembers.Text = "0";
            this.lblTotalMembers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFemales
            // 
            this.labelFemales.AutoSize = true;
            this.labelFemales.Location = new System.Drawing.Point(110, 75);
            this.labelFemales.Name = "labelFemales";
            this.labelFemales.Size = new System.Drawing.Size(58, 16);
            this.labelFemales.TabIndex = 3;
            this.labelFemales.Text = "عدد البنات:";
            // 
            // numFemales
            // 
            this.numFemales.Location = new System.Drawing.Point(20, 72);
            this.numFemales.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numFemales.Name = "numFemales";
            this.numFemales.Size = new System.Drawing.Size(80, 22);
            this.numFemales.TabIndex = 2;
            this.numFemales.ValueChanged += new System.EventHandler(this.NumChildren_ValueChanged);
            // 
            // labelMales
            // 
            this.labelMales.AutoSize = true;
            this.labelMales.Location = new System.Drawing.Point(110, 35);
            this.labelMales.Name = "labelMales";
            this.labelMales.Size = new System.Drawing.Size(58, 16);
            this.labelMales.TabIndex = 1;
            this.labelMales.Text = "عدد الأبناء:";
            // 
            // numMales
            // 
            this.numMales.Location = new System.Drawing.Point(20, 32);
            this.numMales.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numMales.Name = "numMales";
            this.numMales.Size = new System.Drawing.Size(80, 22);
            this.numMales.TabIndex = 0;
            this.numMales.ValueChanged += new System.EventHandler(this.NumChildren_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(590, 190);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // dgvParents
            // 
            this.dgvParents.AllowUserToAddRows = false;
            this.dgvParents.AllowUserToDeleteRows = false;
            this.dgvParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNationalID,
            this.colFullName,
            this.colPhone});
            this.dgvParents.Location = new System.Drawing.Point(590, 220);
            this.dgvParents.MultiSelect = false;
            this.dgvParents.Name = "dgvParents";
            this.dgvParents.ReadOnly = true;
            this.dgvParents.RowHeadersVisible = false;
            this.dgvParents.RowHeadersWidth = 51;
            this.dgvParents.RowTemplate.Height = 24;
            this.dgvParents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParents.Size = new System.Drawing.Size(360, 200);
            this.dgvParents.TabIndex = 3;
            this.dgvParents.SelectionChanged += new System.EventHandler(this.DgvParents_SelectionChanged);
            // 
            // colNationalID
            // 
            this.colNationalID.HeaderText = "الرقم الوطني";
            this.colNationalID.MinimumWidth = 6;
            this.colNationalID.Name = "colNationalID";
            this.colNationalID.ReadOnly = true;
            this.colNationalID.Width = 120;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "الاسم";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 200;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "الهاتف";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Visible = false;
            this.colPhone.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 389);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnOpenChildren
            // 
            this.btnOpenChildren.Enabled = false;
            this.btnOpenChildren.Location = new System.Drawing.Point(232, 389);
            this.btnOpenChildren.Name = "btnOpenChildren";
            this.btnOpenChildren.Size = new System.Drawing.Size(140, 30);
            this.btnOpenChildren.TabIndex = 6;
            this.btnOpenChildren.Text = "فتح شاشة الأبناء";
            this.btnOpenChildren.UseVisualStyleBackColor = true;
            this.btnOpenChildren.Click += new System.EventHandler(this.BtnOpenChildren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 440);
            this.Controls.Add(this.btnOpenChildren);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvParents);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.groupBoxData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFemales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label labelNationalId;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Label labelMotherName;
        private System.Windows.Forms.TextBox txtMotherName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelBloodType;
        private System.Windows.Forms.ComboBox cmbBloodType;
        private System.Windows.Forms.Label labelWorkPlace;
        private System.Windows.Forms.TextBox txtWorkPlace;

        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.NumericUpDown numMales;
        private System.Windows.Forms.Label labelMales;
        private System.Windows.Forms.NumericUpDown numFemales;
        private System.Windows.Forms.Label labelFemales;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Label lblTotalCaption;

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvParents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNationalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOpenChildren;
    }
}