namespace Authentication_Project
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tv_signup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_confirmpassword = new System.Windows.Forms.TextBox();
            this.bt_signup = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authentication Project";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Good Luck Hacking! :)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.Location = new System.Drawing.Point(345, 100);
            this.tb_username.MaxLength = 10;
            this.tb_username.Name = "tb_username";
            this.tb_username.ShortcutsEnabled = false;
            this.tb_username.Size = new System.Drawing.Size(147, 22);
            this.tb_username.TabIndex = 2;
            this.tb_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // tv_signup
            // 
            this.tv_signup.BackColor = System.Drawing.Color.Transparent;
            this.tv_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold);
            this.tv_signup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tv_signup.Location = new System.Drawing.Point(363, 47);
            this.tv_signup.Name = "tv_signup";
            this.tv_signup.Size = new System.Drawing.Size(129, 50);
            this.tv_signup.TabIndex = 3;
            this.tv_signup.Text = "Sign Up";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(210, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "username";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(210, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "password";
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Location = new System.Drawing.Point(345, 148);
            this.tb_password.MaxLength = 30;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.ShortcutsEnabled = false;
            this.tb_password.Size = new System.Drawing.Size(147, 22);
            this.tb_password.TabIndex = 5;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.password_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(163, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "confirm password";
            // 
            // tb_confirmpassword
            // 
            this.tb_confirmpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_confirmpassword.Location = new System.Drawing.Point(345, 206);
            this.tb_confirmpassword.MaxLength = 30;
            this.tb_confirmpassword.Name = "tb_confirmpassword";
            this.tb_confirmpassword.PasswordChar = '*';
            this.tb_confirmpassword.ShortcutsEnabled = false;
            this.tb_confirmpassword.Size = new System.Drawing.Size(147, 22);
            this.tb_confirmpassword.TabIndex = 7;
            this.tb_confirmpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmpassword_KeyPress);
            // 
            // bt_signup
            // 
            this.bt_signup.BackColor = System.Drawing.SystemColors.Window;
            this.bt_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.bt_signup.Location = new System.Drawing.Point(299, 259);
            this.bt_signup.Name = "bt_signup";
            this.bt_signup.Size = new System.Drawing.Size(206, 66);
            this.bt_signup.TabIndex = 9;
            this.bt_signup.Text = "Sign Up!";
            this.bt_signup.UseVisualStyleBackColor = false;
            this.bt_signup.Click += new System.EventHandler(this.bt_signup_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.SystemColors.Window;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(269, 346);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(259, 46);
            this.bt_login.TabIndex = 10;
            this.bt_login.Text = "Already have an account?";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Authentication_Project.Properties.Resources.background_auth;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_signup);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_confirmpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tv_signup);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Text = "Authentication Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label tv_signup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_confirmpassword;
        private System.Windows.Forms.Button bt_signup;
        private System.Windows.Forms.Button bt_login;
    }
}

