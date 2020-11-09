using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace PharmacyManagement
{
    class Database
    {
        public static MySqlConnection Connection()
        {
            string connection = "datasource=127.0.0.1;port=3306;username=root;password=1234;database=csharp;sslmode=none";
            return (new MySqlConnection(connection));
        }
        public static MySqlDataReader Read(string table)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            if(table.Equals("users"))
                query.CommandText = "SELECT * from `phmanagement_users`";
            else if(table.Equals("meds"))
                query.CommandText = "SELECT * from `phmanagement_`";
            else if (table.Equals("comp"))
                query.CommandText = "SELECT * from `phmanagement_comp`";
            else if (table.Equals("emp"))
                query.CommandText = "SELECT * from `phmanagement_emp`";

            MySqlDataReader dataReader;
            try
            {
                connection.Open();
                dataReader = query.ExecuteReader();
                //connection.Close();
            }
            catch (Exception e)
            {
                dataReader = null;
                MessageBox.Show("Read Error!");
                Debug.WriteLine("DB Read Exception: " + e);
            }
            return dataReader;
        }
        public static int AddMedicine(int update, string mname, int bprice, int sprice, int qty, string expdate, string company)
        {
            MySqlConnection conn = Connection();
            MySqlCommand query = conn.CreateCommand();
            if(update==0)
                query.CommandText = " INSERT INTO `phmanagement_` VALUES(@mname, @bprice, @sprice, @qty, @expdate, @company) ";
            else
                query.CommandText = " UPDATE `phmanagement_` SET `Bprice`=@bprice, `Sprice`=@sprice, `Quantity`=@qty, `ExpDate`=@expdate, `Company`=@company WHERE `phmanagement_`.`MedicineName`=@mname ";

            query.Parameters.AddWithValue("@mname", mname);
            query.Parameters.AddWithValue("@bprice", bprice);
            query.Parameters.AddWithValue("@sprice", sprice);
            query.Parameters.AddWithValue("@qty", qty);
            query.Parameters.AddWithValue("@expdate", expdate);
            query.Parameters.AddWithValue("@company", company);
            int RowsAffected = -1;
            try
            {
                conn.Open();
                RowsAffected = query.ExecuteNonQuery();
                //conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception " + e);
                MessageBox.Show("Update error"+e);
            }
            return RowsAffected;
        }

        public static int AddEmployee(int update, int empid, string empname, string gender, int salary, string contact, int age)
        {
            MySqlConnection conn = Connection();
            MySqlCommand query = conn.CreateCommand();
            if (update == 0)
                query.CommandText = " INSERT INTO `phmanagement_emp` VALUES(@emp_id, @emp_name, @emp_salary, @emp_gender, @emp_age, @emp_contact) ";
            else
                query.CommandText = " UPDATE `phmanagement_emp` SET `emp_name`=@emp_name, `emp_salary`=@emp_salary, `emp_gender`=@emp_gender, `emp_age`=@emp_age, `emp_contact`=@emp_contact WHERE `phmanagement_emp`.`emp_id`=@emp_id ";

            query.Parameters.AddWithValue("@emp_id", empid);
            query.Parameters.AddWithValue("@emp_name", empname);
            query.Parameters.AddWithValue("@emp_gender", gender);
            query.Parameters.AddWithValue("@emp_salary", salary);
            query.Parameters.AddWithValue("@emp_contact", contact);
            query.Parameters.AddWithValue("@emp_age", age);
            int RowsAffected = -1;
            try
            {
                conn.Open();
                RowsAffected = query.ExecuteNonQuery();
                //conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception " + e);
                MessageBox.Show("Update error" + e);
            }
            return RowsAffected;
        }

        public static int AddCompany(int update, int id, string name, string address, string contact)
        {
            MySqlConnection conn = Connection();
            MySqlCommand query = conn.CreateCommand();
            if (update == 0)
                query.CommandText = " INSERT INTO `phmanagement_comp` VALUES(@comp_id, @comp_name, @comp_contact, @comp_address) ";
            else
                query.CommandText = " UPDATE `phmanagement_comp` SET `comp_name`=@comp_name,  `comp_contact`=@comp_contact, `comp_address`=@comp_address WHERE `phmanagement_comp`.`comp_id`=@comp_id ";

            query.Parameters.AddWithValue("@comp_id", id);
            query.Parameters.AddWithValue("@comp_name", name);
            query.Parameters.AddWithValue("@comp_contact", contact);
            query.Parameters.AddWithValue("@comp_address", address);
            int RowsAffected = -1;
            try
            {
                conn.Open();
                RowsAffected = query.ExecuteNonQuery();
                //conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception " + e);
                MessageBox.Show("Update error" + e);
            }
            return RowsAffected;
        }

        public static int AddUser(int update, string username, string password)
        {
            MySqlConnection conn = Connection();
            MySqlCommand query = conn.CreateCommand();
            if (update == 0)
                query.CommandText = " INSERT INTO `phmanagement_users` VALUES(@username, @password) ";
            else
                query.CommandText = " UPDATE `phmanagement_users` SET `password`=@password   WHERE `phmanagement_users`.`username`=@username ";

            query.Parameters.AddWithValue("@username", username);
            query.Parameters.AddWithValue("@password", password);
            int RowsAffected = -1;
            try
            {
                conn.Open();
                RowsAffected = query.ExecuteNonQuery();
                //conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception " + e);
                MessageBox.Show("Update error" + e);
            }
            return RowsAffected;
        }


        public static void DeleteMed(string mname)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "DELETE from `phmanagement_` WHERE MedicineName=@mname ";
            query.Parameters.AddWithValue("@mname", mname);
            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                //connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e);
            }
        }
        public static void DeleteEmp(int id)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "DELETE from `phmanagement_emp` WHERE `emp_id`=@emp_id ";
            query.Parameters.AddWithValue("@emp_id", id);
            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                //connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e);
            }
        }
        public static void DeleteComp(int id)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "DELETE from `phmanagement_comp` WHERE `comp_id`=@comp_id ";
            query.Parameters.AddWithValue("@comp_id", id);
            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                //connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e);
            }
        }

        public static void DeleteUser(string username)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "DELETE from `phmanagement_users` WHERE `username`=@username ";
            query.Parameters.AddWithValue("@username", username);
            try
            {
                connection.Open();
                query.ExecuteNonQuery();
                //connection.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception: " + e);
            }
        }

        public static int GetMedCost(string medname)
        {
            MySqlConnection connection = Connection();
            MySqlCommand query = connection.CreateCommand();
            query.CommandText = "SELECT * from `phmanagement_` WHERE MedicineName=@medname";
            query.Parameters.AddWithValue("@medname", medname);
            MySqlDataReader dataReader;
            try
            {
                connection.Open();
                dataReader = query.ExecuteReader();
                //connection.Close();
            }
            catch (Exception e)
            {
                dataReader = null;
                Debug.WriteLine("DB Read Exception: " + e);
            }
            DataTable dt = new DataTable();
            dt.Load(dataReader);
            int cost = 0;
            foreach(DataRow r in dt.Rows)
            {
                cost = Int32.Parse(r["Sprice"].ToString());
            }
            return cost;
        }

        public static void SellMed(String medname, int qty)
        {
            MySqlConnection conn = Connection();
            MySqlCommand query = conn.CreateCommand();
            query.CommandText = " UPDATE `phmanagement_` SET `Quantity`=@qty WHERE `phmanagement_`.`MedicineName`=@medname ";

            query.Parameters.AddWithValue("@qty", qty);
            query.Parameters.AddWithValue("@medname", medname);
            try
            {
                conn.Open();
                query.ExecuteNonQuery();
                //conn.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Exception " + e);
                MessageBox.Show("Update error" + e);
            }
        }
    }
}