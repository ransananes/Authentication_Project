﻿using System;
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
    public partial class Login : Form
    {
        string cn_string = Properties.Settings.Default.DatabaseConnectionString;
        int answer;
        public Login()
        {
            InitializeComponent();
            this.FormClosing += Login_FormClosing;
            GenerateCaptcha();
        }

        private void bt_signup_Click(object sender, EventArgs e)
        {      
            this.Hide();

            Form start = new Start();  

            start.Show();

        }
        void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void bt_signin_Click(object sender, EventArgs e)
        {
            if (tb_username.Text.Equals("") || tb_password.Text.Equals("") || tb_mathproblem.Text.Equals(""))
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
            if (!tb_mathproblem.Text.Equals(answer.ToString()))
            {
                MessageBox.Show("Wrong Captcha Answer");
                GenerateCaptcha();
                
                return;
            }
            int blocked = 0;
            string cn_string = Properties.Settings.Default.DatabaseConnectionString;
            SqlConnection cn_connection = new SqlConnection(cn_string);
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
             String sql_Text = "Select * from users where username= @username";
            SqlCommand cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.AddWithValue("@username", this.tb_username.Text);
            SqlDataReader dr = cmd_Command.ExecuteReader();
            if (dr.Read())
            {
                blocked = Int32.Parse(dr["blocked"].ToString());
                cn_connection.Close();
            } 
            // Check if numoftries > 5, and block the account
            if(blocked >= 5)
            {

                MessageBox.Show("This account is disabled due to multiple requests to sign in! please contact the administrator \n or just edit the database :)");
                return;           
            }
            //  Encryt data and Grant Access 
            dr.Close();
            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
            String aftersalt = DataEncrypt.Create_Salt(tb_username.Text, tb_password.Text);
            aftersalt = DataEncrypt.Create_MD5(aftersalt);
            sql_Text = "SELECT count (*) from users where username=@user and password=@pwd";
            cmd_Command = new SqlCommand(sql_Text, cn_connection);
            cmd_Command.Parameters.AddWithValue("@user", tb_username.Text);
            cmd_Command.Parameters.AddWithValue("@pwd", aftersalt);
            if (cmd_Command.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("GRANTED ACCESS", "Access");
                sql_Text = "update users set blocked='" + 0 + "' where username='" + tb_username.Text + "';";
                cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("username or password are invalid", "Error");
                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
                sql_Text = "Select * from users where username= @username";
                cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.AddWithValue("@username", this.tb_username.Text);
                dr = cmd_Command.ExecuteReader();
                if (dr.Read())
                {
                    blocked = Int32.Parse(dr["blocked"].ToString());
                }
                    dr.Close();



                //          "Update info set id='"+txtId.Text+"', name='"+txtName.Text+"' where id='"+listBox1.SelectedItem.ToString()+"' and name= '"+listBox2.SelectedItem.ToString()+"'";
                sql_Text = "update users set blocked='" + (blocked + 1) + "' where username='" + tb_username.Text + "';";
                //"UPDATE users SET blocked='" + blocked++ + "' where username='" + tb_username.Text + "'";
                cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.ExecuteNonQuery();



                sql_Text = "Select * from users where username= @username";
                cmd_Command = new SqlCommand(sql_Text, cn_connection);
                cmd_Command.Parameters.AddWithValue("@username", this.tb_username.Text);
                dr = cmd_Command.ExecuteReader();
                if (dr.Read())
                {
                     blocked = Int32.Parse(dr["blocked"].ToString());
                    dr.Close();
                }
            }
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
        private void Captcha_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"^[0-9\b]+$"))
            {
                e.Handled = true;
            }

        }
        private void GenerateCaptcha()
        {
            tb_mathproblem.Text = "";
            Random rnd = new Random();
            var number1 = rnd.Next(5, 10);
            var number2 = rnd.Next(1, 5);
            var operation = rnd.Next(1, 3);
            string operatorString;
            switch (operation)
            {
                case 1:
                    answer = number1 + number2;
                    operatorString = "+";
                    break;
                case 2:
                    answer = number1 - number2;
                    operatorString = "-";
                    break;
                default:
                    answer = 0;
                    operatorString = "?";
                    break;
            }
           math_problem.Text = number1 + " " +operatorString + " " + number2;
        }
    }
}
