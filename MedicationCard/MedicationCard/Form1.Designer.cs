namespace MedicationCard
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectExcel = new Button();
            btnPrint = new Button();
            txtMemberIdSearch = new TextBox();
            btnSearch = new Button();
            Txtname = new TextBox();
            Txtage = new TextBox();
            Txtphone = new TextBox();
            Pic = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TxtmemberId = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            Txtnotes = new TextBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)Pic).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectExcel
            // 
            btnSelectExcel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectExcel.Location = new Point(156, 283);
            btnSelectExcel.Margin = new Padding(3, 2, 3, 2);
            btnSelectExcel.Name = "btnSelectExcel";
            btnSelectExcel.Size = new Size(165, 40);
            btnSelectExcel.TabIndex = 0;
            btnSelectExcel.Text = "اختر ملف الاكسل";
            btnSelectExcel.UseVisualStyleBackColor = true;
            btnSelectExcel.Click += btnSelectExcel_Click;
            // 
            // btnPrint
            // 
            btnPrint.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.Location = new Point(339, 283);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(184, 40);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "طباعة";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // txtMemberIdSearch
            // 
            txtMemberIdSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMemberIdSearch.Location = new Point(268, 22);
            txtMemberIdSearch.Name = "txtMemberIdSearch";
            txtMemberIdSearch.RightToLeft = RightToLeft.No;
            txtMemberIdSearch.Size = new Size(248, 27);
            txtMemberIdSearch.TabIndex = 3;
            txtMemberIdSearch.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(35, 14);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(203, 40);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Txtname
            // 
            Txtname.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txtname.Location = new Point(156, 127);
            Txtname.Name = "Txtname";
            Txtname.ReadOnly = true;
            Txtname.RightToLeft = RightToLeft.Yes;
            Txtname.Size = new Size(248, 27);
            Txtname.TabIndex = 5;
            Txtname.TextAlign = HorizontalAlignment.Center;
            // 
            // Txtage
            // 
            Txtage.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txtage.Location = new Point(156, 160);
            Txtage.Name = "Txtage";
            Txtage.ReadOnly = true;
            Txtage.RightToLeft = RightToLeft.Yes;
            Txtage.Size = new Size(248, 27);
            Txtage.TabIndex = 6;
            Txtage.TextAlign = HorizontalAlignment.Center;
            // 
            // Txtphone
            // 
            Txtphone.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txtphone.Location = new Point(156, 195);
            Txtphone.Name = "Txtphone";
            Txtphone.ReadOnly = true;
            Txtphone.RightToLeft = RightToLeft.Yes;
            Txtphone.Size = new Size(248, 27);
            Txtphone.TabIndex = 7;
            Txtphone.TextAlign = HorizontalAlignment.Center;
            // 
            // Pic
            // 
            Pic.Dock = DockStyle.Fill;
            Pic.Location = new Point(0, 0);
            Pic.Name = "Pic";
            Pic.Size = new Size(111, 126);
            Pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Pic.TabIndex = 8;
            Pic.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 132);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 9;
            label1.Text = "الاسم";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(114, 165);
            label2.Name = "label2";
            label2.Size = new Size(38, 19);
            label2.TabIndex = 10;
            label2.Text = "العمر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 200);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 11;
            label3.Text = "الهاتف";
            // 
            // TxtmemberId
            // 
            TxtmemberId.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtmemberId.Location = new Point(156, 94);
            TxtmemberId.Name = "TxtmemberId";
            TxtmemberId.ReadOnly = true;
            TxtmemberId.RightToLeft = RightToLeft.No;
            TxtmemberId.Size = new Size(248, 27);
            TxtmemberId.TabIndex = 12;
            TxtmemberId.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(75, 99);
            label4.Name = "label4";
            label4.Size = new Size(78, 19);
            label4.TabIndex = 13;
            label4.Text = "رقم العضوية";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtMemberIdSearch);
            panel1.Controls.Add(btnSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 73);
            panel1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(522, 26);
            label5.Name = "label5";
            label5.Size = new Size(124, 19);
            label5.TabIndex = 14;
            label5.Text = " بحث برقم العضوية ";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(91, 233);
            label6.Name = "label6";
            label6.Size = new Size(62, 19);
            label6.TabIndex = 16;
            label6.Text = "ملاحظات";
            // 
            // Txtnotes
            // 
            Txtnotes.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Txtnotes.Location = new Point(156, 228);
            Txtnotes.Name = "Txtnotes";
            Txtnotes.ReadOnly = true;
            Txtnotes.RightToLeft = RightToLeft.Yes;
            Txtnotes.Size = new Size(366, 27);
            Txtnotes.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Pic);
            panel2.Location = new Point(410, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(113, 128);
            panel2.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(Txtnotes);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(TxtmemberId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txtphone);
            Controls.Add(Txtage);
            Controls.Add(Txtname);
            Controls.Add(btnPrint);
            Controls.Add(btnSelectExcel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "شاشة بطاقة صرف ادوية (الامراض المزمنة)";
            ((System.ComponentModel.ISupportInitialize)Pic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectExcel;
        private Button btnPrint;
        private TextBox txtMemberIdSearch;
        private Button btnSearch;
        private TextBox Txtname;
        private TextBox Txtage;
        private TextBox Txtphone;
        private PictureBox Pic;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtmemberId;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private TextBox Txtnotes;
        private Panel panel2;
    }
}
