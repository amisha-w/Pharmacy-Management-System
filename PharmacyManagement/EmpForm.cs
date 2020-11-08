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
    public partial class EmpForm : Form
    {
        public EmpForm()
        {
            InitializeComponent();
            updateDataGrid();
        }
        private void updateDataGrid()
        {
            MySqlDataReader res = Database.Read("emp");
            DataTable dt = new DataTable();
            dt.Load(res);
            datagrid.DataSource = dt;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            if (empid.Text == "" || empname.Text == "" || salary.Text=="" || contact.Text == "" || age.Text == "" || genderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Missing data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddEmployee(0,Int32.Parse(empid.Text),empname.Text,genderComboBox.Text,Int32.Parse(salary.Text),contact.Text,Int32.Parse(age.Text));
                updateDataGrid();
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (empid.Text == "" || empname.Text == "" || salary.Text == "" || contact.Text == "" || age.Text == "" || genderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Missing data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddEmployee(1, Int32.Parse(empid.Text), empname.Text, genderComboBox.Text, Int32.Parse(salary.Text), contact.Text, Int32.Parse(age.Text));
                updateDataGrid();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (empid.Text == "")
            {
                MessageBox.Show("Please enter the Employee Id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.DeleteEmp(Int32.Parse(empid.Text));
                updateDataGrid();
            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            empid.Text = datagrid.SelectedRows[0].Cells[0].Value.ToString();
            empname.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
            salary.Text = datagrid.SelectedRows[0].Cells[2].Value.ToString();
            genderComboBox.Text = datagrid.SelectedRows[0].Cells[3].Value.ToString();
            age.Text = datagrid.SelectedRows[0].Cells[4].Value.ToString();
            contact.Text = datagrid.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
