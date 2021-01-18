using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication_Project
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            this.FormClosing += Start_FormClosing;
        }

       


        private void username_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[A-Za-z0-9_\b]+$"))
            {
                e.Handled = true;
            }
        }
        private void password_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[A-Za-z0-9\b!@#$%^&*]+$"))
            {
                e.Handled = true;
            }
        }
        private void confirmpassword_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[A-Za-z0-9\b!@#$%^&*]+$"))
            {
                e.Handled = true;
            }
        }
        private void bt_signup_Click(object sender, EventArgs e)
        {
            if (tb_username.Text.Equals("") || tb_password.Text.Equals("") || tb_confirmpassword.Text.Equals(""))
            {
                MessageBox.Show("One or more of the fields is empty!");
                return;
            }
            if (tb_username.Text.Length < 5)
            {
                MessageBox.Show("username is shorter than 6 chars");
                return;
            }
            if (tb_password.Text.Length < 6)
            {
                MessageBox.Show("Password is shorter than 6 chars");
                return;
            }
 
            if (!tb_confirmpassword.Text.Equals(tb_password.Text))
            {
                MessageBox.Show("Passwords don't match");
                return;
            }

            string cn_string = Properties.Settings.Default.DatabaseConnectionString;
            SqlConnection cn_connection = new SqlConnection(cn_string);

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

            string sql_Text = "Select * from users where username= @username";


            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.AddWithValue("@username", this.tb_username.Text); 
            SqlDataReader dr = cmd_Command.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("username already exists","Error");
                    return;
                }
                else
                {
            dr.Close();
            String pw = DataEncrypt.Create_Salt(tb_username.Text, tb_password.Text);
            String pwmd5 =DataEncrypt.Create_MD5(pw);
            sql_Text = "INSERT INTO users(username, password, blocked) " +
               "Values('" + tb_username.Text + "', '" + pwmd5 + "', '" + 0 + "')";



            cmd_Command = new SqlCommand(sql_Text, cn_connection);
                
              cmd_Command.ExecuteNonQuery();
          MessageBox.Show("Successfully completed!");

                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {        
            this.Hide();

            Form start = new Login(); 

            start.Show();  

        }
        void Start_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
