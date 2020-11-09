using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void unameEnter(object sender, EventArgs e)
        {
            if(unameTxt.Text.Equals(@"Username"))
            {
                unameTxt.Text = "Enter username";
            }
        }

        private void unameLeave(object sender, EventArgs e)
        {
            if (unameTxt.Text.Equals(""))
            {
                unameTxt.Text = "Username";
            }
        }

        private void passLeave(object sender, EventArgs e)
        {
            if (passTxt.Text.Equals(""))
            {
                passTxt.Text = "Password";
            }
        }

        private void passEnter(object sender, EventArgs e)
        {
            if (passTxt.Text.Equals(@"Password"))
            {
                passTxt.Text = "";
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            MySqlDataReader res = Database.Read("users");
            DataTable dt = new DataTable();
            dt.Load(res);
            bool username_matched = false;
            foreach(DataRow row in dt.Rows)
            {
                if (row["username"].ToString().Equals(unameTxt.Text))
                {
                        if (row["password"].ToString().Equals(passTxt.Text))
                        {
                            this.Hide();
                            MessageBox.Show("Login Successful.", "Logged in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form form = null;
                        if(unameTxt.Text.Equals("admin"))
                        {
                            PharmacyManagement.User.admin = 1;
                            form = new Home(1);
                        }
                        else
                        {
                            PharmacyManagement.User.admin = 0;
                            form = new Home(0);
                        }
                        PharmacyManagement.User.username = unameTxt.Text;
                        PharmacyManagement.User.password = passTxt.Text;
                        form.Closed += (s, args) => this.Close();
                            form.ShowDialog();
                            username_matched = true;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                }
            }
            if(!username_matched)
            {
                MessageBox.Show("Incorrect Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
    public static class User
    {
        public static int admin = 0;
        public static string username { get; set; }
        public static string password { get; set; }

        public static bool isAdmin()
        {
            if (admin == 1)
                return true;
            return false;
        }
    }
}
