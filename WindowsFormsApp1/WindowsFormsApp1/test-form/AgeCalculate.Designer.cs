namespace WindowsFormsApp1.test_form
{
    partial class AgeCalculate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeCalculate));
            this.lblname = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.bdPicker = new System.Windows.Forms.DateTimePicker();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblmonth = new System.Windows.Forms.Label();
            this.lblyears = new System.Windows.Forms.Label();
            this.lbldayscount = new System.Windows.Forms.Label();
            this.lblmonthscount = new System.Windows.Forms.Label();
            this.lblyearscount = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnrun = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Simplified Arabic Fixed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblname.Location = new System.Drawing.Point(28, 77);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(166, 28);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "your Name :";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Simplified Arabic Fixed", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblage.Location = new System.Drawing.Point(28, 143);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(222, 28);
            this.lblage.TabIndex = 1;
            this.lblage.Text = "your Birthday :";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(200, 74);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(283, 30);
            this.txtname.TabIndex = 2;
            // 
            // bdPicker
            // 
            this.bdPicker.CalendarFont = new System.Drawing.Font("Akhbar MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bdPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bdPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bdPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdPicker.Location = new System.Drawing.Point(257, 138);
            this.bdPicker.Name = "bdPicker";
            this.bdPicker.Size = new System.Drawing.Size(225, 30);
            this.bdPicker.TabIndex = 3;
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldays.Location = new System.Drawing.Point(510, 71);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(80, 36);
            this.lbldays.TabIndex = 4;
            this.lbldays.Text = "Days:";
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonth.Location = new System.Drawing.Point(510, 132);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(114, 36);
            this.lblmonth.TabIndex = 5;
            this.lblmonth.Text = "Months:";
            // 
            // lblyears
            // 
            this.lblyears.AutoSize = true;
            this.lblyears.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyears.Location = new System.Drawing.Point(510, 191);
            this.lblyears.Name = "lblyears";
            this.lblyears.Size = new System.Drawing.Size(90, 36);
            this.lblyears.TabIndex = 6;
            this.lblyears.Text = "Years:";
            // 
            // lbldayscount
            // 
            this.lbldayscount.AutoSize = true;
            this.lbldayscount.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayscount.Location = new System.Drawing.Point(596, 68);
            this.lbldayscount.Name = "lbldayscount";
            this.lbldayscount.Size = new System.Drawing.Size(0, 36);
            this.lbldayscount.TabIndex = 7;
            // 
            // lblmonthscount
            // 
            this.lblmonthscount.AutoSize = true;
            this.lblmonthscount.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthscount.Location = new System.Drawing.Point(630, 132);
            this.lblmonthscount.Name = "lblmonthscount";
            this.lblmonthscount.Size = new System.Drawing.Size(0, 36);
            this.lblmonthscount.TabIndex = 8;
            // 
            // lblyearscount
            // 
            this.lblyearscount.AutoSize = true;
            this.lblyearscount.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyearscount.Location = new System.Drawing.Point(596, 191);
            this.lblyearscount.Name = "lblyearscount";
            this.lblyearscount.Size = new System.Drawing.Size(0, 36);
            this.lblyearscount.TabIndex = 9;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(41, 204);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 36);
            this.lblresult.TabIndex = 10;
            this.lblresult.Visible = false;
            // 
            // btnrun
            // 
            this.btnrun.BackColor = System.Drawing.Color.Goldenrod;
            this.btnrun.Font = new System.Drawing.Font("Rockwell Extra Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrun.Location = new System.Drawing.Point(183, 8);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(460, 72);
            this.btnrun.TabIndex = 11;
            this.btnrun.Text = "claculate";
            this.btnrun.UseVisualStyleBackColor = false;
            this.btnrun.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnrun);
            this.panel1.Location = new System.Drawing.Point(-9, 357);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 97);
            this.panel1.TabIndex = 12;
            // 
            // AgeCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblyearscount);
            this.Controls.Add(this.lblmonthscount);
            this.Controls.Add(this.lbldayscount);
            this.Controls.Add(this.lblyears);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.lbldays);
            this.Controls.Add(this.bdPicker);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgeCalculate";
            this.Text = "AgeCalculate";
            this.Load += new System.EventHandler(this.AgeCalculate_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DateTimePicker bdPicker;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Label lblyears;
        private System.Windows.Forms.Label lbldayscount;
        private System.Windows.Forms.Label lblmonthscount;
        private System.Windows.Forms.Label lblyearscount;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Panel panel1;
    }
}