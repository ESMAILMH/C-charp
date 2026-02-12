namespace WindowsFormsApp1.test_form
{
    partial class main_from
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ملفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جمعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.طرحToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ضربToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قسمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.دليلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اغلاقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ملفToolStripMenuItem,
            this.دليلToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(585, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ملفToolStripMenuItem
            // 
            this.ملفToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.جمعToolStripMenuItem,
            this.طرحToolStripMenuItem,
            this.ضربToolStripMenuItem,
            this.قسمةToolStripMenuItem});
            this.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem";
            this.ملفToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ملفToolStripMenuItem.Text = "ملف";
            // 
            // جمعToolStripMenuItem
            // 
            this.جمعToolStripMenuItem.Name = "جمعToolStripMenuItem";
            this.جمعToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.جمعToolStripMenuItem.Text = "جمع";
            this.جمعToolStripMenuItem.Click += new System.EventHandler(this.جمعToolStripMenuItem_Click);
            // 
            // طرحToolStripMenuItem
            // 
            this.طرحToolStripMenuItem.Name = "طرحToolStripMenuItem";
            this.طرحToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.طرحToolStripMenuItem.Text = "طرح";
            // 
            // ضربToolStripMenuItem
            // 
            this.ضربToolStripMenuItem.Name = "ضربToolStripMenuItem";
            this.ضربToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.ضربToolStripMenuItem.Text = "ضرب";
            // 
            // قسمةToolStripMenuItem
            // 
            this.قسمةToolStripMenuItem.Name = "قسمةToolStripMenuItem";
            this.قسمةToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.قسمةToolStripMenuItem.Text = "قسمة";
            // 
            // دليلToolStripMenuItem
            // 
            this.دليلToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اغلاقToolStripMenuItem});
            this.دليلToolStripMenuItem.Name = "دليلToolStripMenuItem";
            this.دليلToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.دليلToolStripMenuItem.Text = "دليل";
            // 
            // اغلاقToolStripMenuItem
            // 
            this.اغلاقToolStripMenuItem.Name = "اغلاقToolStripMenuItem";
            this.اغلاقToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.اغلاقToolStripMenuItem.Text = "اغلاق";
            this.اغلاقToolStripMenuItem.Click += new System.EventHandler(this.اغلاقToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old Antic Bold", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(91, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 83);
            this.label1.TabIndex = 1;
            this.label1.Text = "منظومة اختبار حسابية بسيطة ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // main_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main_from";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "main_form";
            this.Load += new System.EventHandler(this.main_from_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ملفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جمعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem طرحToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ضربToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قسمةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دليلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اغلاقToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}