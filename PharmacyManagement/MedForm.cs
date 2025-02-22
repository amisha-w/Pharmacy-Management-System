﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagement
{
    public partial class MedForm : Form
    {
        public MedForm()
        {
            InitializeComponent();
            updateDataGrid();
            try
            {
                MySqlDataReader res = Database.Read("comp");
                DataTable dt = new DataTable();
                dt.Load(res);
                companyComboBox.DisplayMember = "comp_name";
                companyComboBox.ValueMember = "comp_id";
                companyComboBox.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
            }
        }

        private void updateDataGrid()
        {
            MySqlDataReader res = Database.Read("meds");
            DataTable dt = new DataTable();
            dt.Load(res);
            datagrid.DataSource = dt;
            datagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(mnameTxt.Text=="" || bpriceTxt.Text=="" || spriceTxt.Text=="" || qtyTxt.Text=="" || companyComboBox.SelectedItem==null)
            {
                MessageBox.Show("Missing data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddMedicine(0,mnameTxt.Text, Int32.Parse(bpriceTxt.Text), Int32.Parse(spriceTxt.Text), Int32.Parse(qtyTxt.Text), datepicker.Text, companyComboBox.Text);
                updateDataGrid();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (mnameTxt.Text == "" || bpriceTxt.Text == "" || spriceTxt.Text == "" || qtyTxt.Text == "" || companyComboBox.SelectedItem == null)
            {
                MessageBox.Show("Missing data! Make sure all fields are filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.AddMedicine(1, mnameTxt.Text, Int32.Parse(bpriceTxt.Text), Int32.Parse(spriceTxt.Text), Int32.Parse(qtyTxt.Text), datepicker.Text, companyComboBox.Text);
                updateDataGrid();
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f = new Home();
            f.Show();
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(mnameTxt.Text=="")
            {
                MessageBox.Show("Please enter a medicine name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Database.DeleteMed(mnameTxt.Text);
                updateDataGrid();
            }
            
        }

        
        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mnameTxt.Text = datagrid.SelectedRows[0].Cells[0].Value.ToString();
            bpriceTxt.Text = datagrid.SelectedRows[0].Cells[1].Value.ToString();
            spriceTxt.Text = datagrid.SelectedRows[0].Cells[2].Value.ToString();
            qtyTxt.Text = datagrid.SelectedRows[0].Cells[3].Value.ToString();
            companyComboBox.Text = datagrid.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Pharmacy_Bill";

            for (int i = 1; i < datagrid.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = datagrid.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < datagrid.Rows.Count - 1; i++)
            {
                for (int j = 0; j < datagrid.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = datagrid.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs("MedInfo.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
            MessageBox.Show("Exported as MedInfo.xls", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
