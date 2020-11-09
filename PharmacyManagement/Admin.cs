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
    
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            MySqlDataReader res = Database.Read("users");
            DataTable dt = new DataTable();
            dt.Load(res);
            datagrid.DataSource = dt;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f = new Home(1);
            f.Show();
            this.Close();
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            username.Text = datagrid.SelectedRows[0].Cells[0].Value.ToString();
            password.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                MessageBox.Show("Please enter Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.DeleteUser(username.Text);
                updateDataGrid();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddUser(1, username.Text, password.Text);
                updateDataGrid();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Missing data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddUser(0,username.Text,password.Text);
                updateDataGrid();
            }
        }
    }
    
}
