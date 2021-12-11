
namespace Fly_Buy_new
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_bx_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bx_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_submit = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_create_account = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_bx_username
            // 
            this.txt_bx_username.Animated = true;
            this.txt_bx_username.AutoRoundedCorners = true;
            this.txt_bx_username.BorderRadius = 19;
            this.txt_bx_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bx_username.DefaultText = "User Name";
            this.txt_bx_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bx_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bx_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bx_username.DisabledState.Parent = this.txt_bx_username;
            this.txt_bx_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bx_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bx_username.FocusedState.Parent = this.txt_bx_username;
            this.txt_bx_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bx_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bx_username.HoverState.Parent = this.txt_bx_username;
            this.txt_bx_username.Location = new System.Drawing.Point(45, 205);
            this.txt_bx_username.Name = "txt_bx_username";
            this.txt_bx_username.PasswordChar = '\0';
            this.txt_bx_username.PlaceholderText = "";
            this.txt_bx_username.SelectedText = "";
            this.txt_bx_username.SelectionStart = 9;
            this.txt_bx_username.ShadowDecoration.Parent = this.txt_bx_username;
            this.txt_bx_username.Size = new System.Drawing.Size(268, 41);
            this.txt_bx_username.TabIndex = 3;
            this.txt_bx_username.Click += new System.EventHandler(this.txt_bx_username_Click);
            // 
            // txt_bx_password
            // 
            this.txt_bx_password.Animated = true;
            this.txt_bx_password.AutoRoundedCorners = true;
            this.txt_bx_password.BorderRadius = 19;
            this.txt_bx_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bx_password.DefaultText = "Password";
            this.txt_bx_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bx_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bx_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bx_password.DisabledState.Parent = this.txt_bx_password;
            this.txt_bx_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bx_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bx_password.FocusedState.Parent = this.txt_bx_password;
            this.txt_bx_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bx_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bx_password.HoverState.Parent = this.txt_bx_password;
            this.txt_bx_password.Location = new System.Drawing.Point(45, 252);
            this.txt_bx_password.Name = "txt_bx_password";
            this.txt_bx_password.PasswordChar = '\0';
            this.txt_bx_password.PlaceholderText = "";
            this.txt_bx_password.SelectedText = "";
            this.txt_bx_password.SelectionStart = 8;
            this.txt_bx_password.ShadowDecoration.Parent = this.txt_bx_password;
            this.txt_bx_password.Size = new System.Drawing.Size(268, 41);
            this.txt_bx_password.TabIndex = 4;
            this.txt_bx_password.Click += new System.EventHandler(this.txt_bx_password_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Animated = true;
            this.btn_submit.AutoRoundedCorners = true;
            this.btn_submit.BorderRadius = 21;
            this.btn_submit.CheckedState.Parent = this.btn_submit;
            this.btn_submit.CustomImages.Parent = this.btn_submit;
            this.btn_submit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_submit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_submit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_submit.DisabledState.Parent = this.btn_submit;
            this.btn_submit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.White;
            this.btn_submit.HoverState.Parent = this.btn_submit;
            this.btn_submit.Location = new System.Drawing.Point(89, 299);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.ShadowDecoration.Parent = this.btn_submit;
            this.btn_submit.Size = new System.Drawing.Size(180, 45);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            // 
            // lbl_create_account
            // 
            this.lbl_create_account.AutoSize = true;
            this.lbl_create_account.Location = new System.Drawing.Point(131, 378);
            this.lbl_create_account.Name = "lbl_create_account";
            this.lbl_create_account.Size = new System.Drawing.Size(99, 19);
            this.lbl_create_account.TabIndex = 6;
            this.lbl_create_account.Text = "Create Account";
            this.lbl_create_account.Click += new System.EventHandler(this.lbl_create_account_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Fly_Buy_new.Properties.Resources.reshot_illustration_secure_credit_card_SUBYW3HTFQ_4e0e8;
            this.pictureBox1.Location = new System.Drawing.Point(89, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_create_account);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_bx_password);
            this.Controls.Add(this.txt_bx_username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Opacity = 0D;
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2TextBox txt_bx_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_bx_password;
        private Guna.UI2.WinForms.Guna2Button btn_submit;
        private MetroFramework.Controls.MetroLabel lbl_create_account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}