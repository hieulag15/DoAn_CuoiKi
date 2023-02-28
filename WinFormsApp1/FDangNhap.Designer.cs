namespace WinFormsApp1
{
    partial class FDangNhap
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblWin = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.errorProviderUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPass = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(700, 755);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(264, 85);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWin.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblWin.Location = new System.Drawing.Point(349, 137);
            this.lblWin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(623, 109);
            this.lblWin.TabIndex = 13;
            this.lblWin.Text = "NGÂN HÀNG";
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.Location = new System.Drawing.Point(451, 565);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(730, 79);
            this.txtPass.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(451, 384);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(730, 79);
            this.txtUser.TabIndex = 11;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblPass.Location = new System.Drawing.Point(50, 559);
            this.lblPass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(315, 73);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Passwrord:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblUser.Location = new System.Drawing.Point(50, 371);
            this.lblUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(336, 73);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User Name:";
            // 
            // errorProviderUser
            // 
            this.errorProviderUser.BlinkRate = 300;
            this.errorProviderUser.ContainerControl = this;
            // 
            // errorProviderPass
            // 
            this.errorProviderPass.BlinkRate = 300;
            this.errorProviderPass.ContainerControl = this;
            // 
            // FDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 926);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FDangNhap";
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnLogin;
        private Label lblWin;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label lblPass;
        private Label lblUser;
        private ErrorProvider errorProviderUser;
        private ErrorProvider errorProviderPass;
    }
}