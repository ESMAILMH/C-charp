namespace WindowsFormsApp1.fproject
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_pssword = new System.Windows.Forms.TextBox();
            this.btn_showPassword = new System.Windows.Forms.Button();
            this.pnltop = new System.Windows.Forms.Panel();
            this.lbltop = new System.Windows.Forms.Label();
            this.pnlcontent = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnltop.SuspendLayout();
            this.pnlcontent.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Wide Latin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.btn_cancel.Location = new System.Drawing.Point(324, 16);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(142, 37);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Wide Latin", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.btn_login.Location = new System.Drawing.Point(132, 13);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(129, 37);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.lbl_user.Location = new System.Drawing.Point(41, 28);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(150, 25);
            this.lbl_user.TabIndex = 11;
            this.lbl_user.Text = "User_name";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(216, 24);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(294, 31);
            this.txt_name.TabIndex = 10;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.lbl_password.Location = new System.Drawing.Point(58, 79);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(140, 25);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "password";
            // 
            // txt_pssword
            // 
            this.txt_pssword.Font = new System.Drawing.Font("Leelawadee UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pssword.Location = new System.Drawing.Point(216, 75);
            this.txt_pssword.Name = "txt_pssword";
            this.txt_pssword.PasswordChar = '*';
            this.txt_pssword.Size = new System.Drawing.Size(250, 31);
            this.txt_pssword.TabIndex = 13;
            // 
            // btn_showPassword
            // 
            this.btn_showPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_showPassword.BackgroundImage")));
            this.btn_showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_showPassword.FlatAppearance.BorderSize = 0;
            this.btn_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showPassword.Location = new System.Drawing.Point(472, 75);
            this.btn_showPassword.Name = "btn_showPassword";
            this.btn_showPassword.Size = new System.Drawing.Size(38, 31);
            this.btn_showPassword.TabIndex = 19;
            this.btn_showPassword.UseVisualStyleBackColor = true;
            this.btn_showPassword.Click += new System.EventHandler(this.btn_showPassword_Click);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lbltop);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(611, 61);
            this.pnltop.TabIndex = 20;
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.Font = new System.Drawing.Font("Castellar", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(180)))), ((int)(((byte)(137)))));
            this.lbltop.Location = new System.Drawing.Point(135, 9);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(301, 40);
            this.lbltop.TabIndex = 0;
            this.lbltop.Text = "My Password";
            // 
            // pnlcontent
            // 
            this.pnlcontent.Controls.Add(this.btn_showPassword);
            this.pnlcontent.Controls.Add(this.lbl_password);
            this.pnlcontent.Controls.Add(this.txt_pssword);
            this.pnlcontent.Controls.Add(this.lbl_user);
            this.pnlcontent.Controls.Add(this.txt_name);
            this.pnlcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcontent.Location = new System.Drawing.Point(0, 61);
            this.pnlcontent.Name = "pnlcontent";
            this.pnlcontent.Size = new System.Drawing.Size(611, 229);
            this.pnlcontent.TabIndex = 21;
            this.pnlcontent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlcontent_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.btn_cancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(611, 63);
            this.panel2.TabIndex = 22;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(611, 290);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlcontent);
            this.Controls.Add(this.pnltop);
            this.Name = "frm_login";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frm_login_Load);
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlcontent.ResumeLayout(false);
            this.pnlcontent.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_pssword;
        private System.Windows.Forms.Button btn_showPassword;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Panel pnlcontent;
        private System.Windows.Forms.Panel panel2;
    }
}