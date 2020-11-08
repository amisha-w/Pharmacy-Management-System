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
    public partial class CompForm : Form
    {
        public CompForm()
        {
            InitializeComponent();
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            MySqlDataReader res = Database.Read("comp");
            DataTable dt = new DataTable();
            dt.Load(res);
            datagrid.DataSource = dt;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void add_leave(object sender, EventArgs e)
        {
            if(address.Text=="")
            {
                address.Text = "Address";
            }
        }

        private void add_enter(object sender, EventArgs e)
        {
            if (address.Text == "Address")
            {
                address.Text = "";
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f = new Home();
            f.Show();
            this.Close();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || address.Text == "Address" || address.Text == "" || contact.Text == "" )
            {
                MessageBox.Show("Missing or incorrect data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddCompany(0, Int32.Parse(id.Text), name.Text,  address.Text, contact.Text);
                updateDataGrid();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (id.Text == "" || name.Text == "" || address.Text == "Address" || address.Text == "" || contact.Text == "")
            {
                MessageBox.Show("Missing or incorrect data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddCompany(1, Int32.Parse(id.Text), name.Text, address.Text, contact.Text);
                updateDataGrid();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Please enter the Company Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.DeleteComp(Int32.Parse(id.Text));
                updateDataGrid();
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = datagrid.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
            contact.Text = datagrid.SelectedRows[0].Cells[2].Value.ToString();
            address.Text = datagrid.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
