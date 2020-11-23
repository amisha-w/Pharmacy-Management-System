using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PharmacyManagement
{
    
    public partial class Bill : Form
    {
        private static int current_med_cost = 0, n = 0, total_cost=0;
        List<ComboBoxItem> comboBoxItems = new List<ComboBoxItem>();
        public Bill()
        {
            InitializeComponent();
            try
            {
                MySqlDataReader res = Database.Read("meds");
                DataTable dt = new DataTable();
                dt.Load(res);
                foreach(DataRow row in  dt.Rows)
                {
                    comboBoxItems.Add(new ComboBoxItem(row["MedicineName"].ToString(),Int32.Parse(row["Quantity"].ToString())));
                }
                med.DisplayMember = "name";
                med.ValueMember = "qty";
                med.DataSource = comboBoxItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured!");
            }
        }
        public static Bitmap bitmap;
        private void printBtn_Click(object sender, EventArgs e)
        {
            //Panel panel = new Panel();
            //this.Controls.Add(panel);

            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            myGraphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(this.Location);
            myGraphics.CopyFromScreen(point.X, point.Y, 0, 0, s);
            //printDocument1.Print();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home f = new Home();
            f.Show();
            this.Close();
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
            workbook.SaveAs("Bill.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            app.Quit();
            MessageBox.Show("Exported as Bill.xls", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(quantity.Text=="" || Int32.Parse(quantity.Text)>Int32.Parse(med.SelectedValue.ToString()))
            {
                MessageBox.Show("Insufficient medicine stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                int qty = Int32.Parse(quantity.Text);
                n++;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(datagrid);
                row.Cells[0].Value = n;
                row.Cells[1].Value = med.Text;
                row.Cells[2].Value = quantity.Text;
                row.Cells[3].Value = current_med_cost;
                row.Cells[4].Value = current_med_cost * Int32.Parse(quantity.Text);
                total_cost += current_med_cost * Int32.Parse(quantity.Text);
                datagrid.Rows.Add(row);
                tCost.Text = CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol + total_cost.ToString();
                foreach(ComboBoxItem cb in comboBoxItems)
                {
                    if(cb.name.Equals(med.Text))
                    {
                        cb.qty -= Int32.Parse(quantity.Text);
                        Database.SellMed(med.Text, cb.qty);
                        stock.Text = cb.qty.ToString();
                        break;
                    }
                }
                med.DataSource = comboBoxItems;
            }
        }

        private void med_SelectedIndexChanged(object sender, EventArgs e)
        {
            stock.Text = med.SelectedValue.ToString();
            current_med_cost = Database.GetMedCost(med.Text);
        }
    }
    public class ComboBoxItem
    {
        public string name { get; set; }
        public int qty { get; set; }

        public ComboBoxItem(string name, int qty)
        {
            this.name = name;
            this.qty = qty;
        }

    }
}
