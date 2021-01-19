namespace Authentication_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tv_login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.bt_signin = new System.Windows.Forms.Button();
            this.bt_signup = new System.Windows.Forms.Button();
            this.math_problem = new System.Windows.Forms.Label();
            this.tb_mathproblem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tv_login
            // 
            this.tv_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tv_login.BackColor = System.Drawing.Color.Transparent;
            this.tv_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_login.ForeColor = System.Drawing.Color.White;
            this.tv_login.Location = new System.Drawing.Point(287, 28);
            this.tv_login.Name = "tv_login";
            this.tv_login.Size = new System.Drawing.Size(218, 43);
            this.tv_login.TabIndex = 0;
            this.tv_login.Text = "Login";
            this.tv_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(245, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "password";
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Location = new System.Drawing.Point(380, 139);
            this.tb_password.MaxLength = 30;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.ShortcutsEnabled = false;
            this.tb_password.Size = new System.Drawing.Size(147, 22);
            this.tb_password.TabIndex = 9;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(245, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 50);
            this.label3.TabIndex = 8;
            this.label3.Text = "username";
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.Location = new System.Drawing.Point(380, 91);
            this.tb_username.MaxLength = 10;
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(147, 22);
            this.tb_username.TabIndex = 7;
            this.tb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // bt_signin
            // 
            this.bt_signin.BackColor = System.Drawing.SystemColors.Window;
            this.bt_signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.bt_signin.Location = new System.Drawing.Point(336, 279);
            this.bt_signin.Name = "bt_signin";
            this.bt_signin.Size = new System.Drawing.Size(206, 66);
            this.bt_signin.TabIndex = 11;
            this.bt_signin.Text = "Sign in";
            this.bt_signin.UseVisualStyleBackColor = false;
            this.bt_signin.Click += new System.EventHandler(this.bt_signin_Click);
            // 
            // bt_signup
            // 
            this.bt_signup.BackColor = System.Drawing.SystemColors.Window;
            this.bt_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_signup.Location = new System.Drawing.Point(336, 376);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(206, 46);
            this.bt_signup.TabIndex = 12;
            this.bt_signup.Text = "Sign Up!";
            this.bt_signup.UseVisualStyleBackColor = false;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // math_problem
            // 
            this.math_problem.BackColor = System.Drawing.Color.Transparent;
            this.math_problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.math_problem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.math_problem.Location = new System.Drawing.Point(245, 200);
            this.math_problem.Name = "math_problem";
            this.math_problem.Size = new System.Drawing.Size(129, 50);
            this.math_problem.TabIndex = 14;
            this.math_problem.Text = "math_problem";
            this.math_problem.Visible = true;
            // 
            // tb_mathproblem
            // 
            this.tb_mathproblem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mathproblem.Location = new System.Drawing.Point(394, 200);
            this.tb_mathproblem.MaxLength = 2;
            this.tb_mathproblem.Name = "tb_mathproblem";
            this.tb_mathproblem.ShortcutsEnabled = false;
            this.tb_mathproblem.Size = new System.Drawing.Size(147, 22);
            this.tb_mathproblem.TabIndex = 13;
            this.tb_mathproblem.Visible = true;
            this.tb_mathproblem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Captcha_KeyPress);

            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Authentication_Project.Properties.Resources.background_auth;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.math_problem);
            this.Controls.Add(this.tb_mathproblem);
            this.Controls.Add(this.bt_signup);
            this.Controls.Add(this.bt_signin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tv_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tv_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Button bt_signin;
        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.Label math_problem;
        private System.Windows.Forms.TextBox tb_mathproblem;
    }
}