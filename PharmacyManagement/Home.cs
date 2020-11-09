using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class Home : Form
    {
        int admin = 0;
        public Home(int admin)
        {
            InitializeComponent();
            this.admin = admin;
            if(!PharmacyManagement.User.isAdmin())
            {
                adminBtn.Visible = false;
            }
        }

        public Home()
        {
            InitializeComponent();
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            EmpForm f = new EmpForm();
            f.Show();
            this.Hide();
        }

        private void comBtn_Click(object sender, EventArgs e)
        {
            
            CompForm f = new CompForm();
            f.Show();
            this.Hide();
        }

        private void medBtn_Click(object sender, EventArgs e)
        {
            MedForm f = new MedForm();
            f.Show();
            this.Hide();
        }

        private void bilBtn_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            f.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            if(User.isAdmin())
            {
                new Admin().Show();
                this.Hide();
                
            }
        }
    }
}
