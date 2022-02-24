using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Real_Estate_Software
{
    public partial class Update_Record : Form
    {
        public Update_Record()
        {
            InitializeComponent();


        }

        private void Update_Record_Load(object sender, EventArgs e)
        {
            string[] category_choice = { "Flat", "Bunglow", "Shop", "Plot", "Land", "All", "Other" };
            comboBox_ShowAll.Items.AddRange(category_choice);
            


        }

        private void comboBox_ShowAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;

            if (comboBox_ShowAll.SelectedItem.ToString() == "Flat")
            {

                this.dataGridView1.DataSource = null;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Flat'";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ++count;
                }
                reader.Close();
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
                lbl_records.Text = "Total# of Records are: " + count.ToString();
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Bunglow")
            {
                this.dataGridView1.DataSource = null;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Bunglow'";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ++count;
                }
                reader.Close();
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
                lbl_records.Text = "Total# of Records are: " + count.ToString();
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Shop")
            {
                this.dataGridView1.DataSource = null;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Shop'";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   ++count;
                }
                reader.Close();
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
                lbl_records.Text = "Total# of Records are: " + count.ToString();
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Plot")
            {
                this.dataGridView1.DataSource = null;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Plot'";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ++count;
                }
                reader.Close();
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
                lbl_records.Text = "Total# of Records are: " + count.ToString();
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Land")
            {
                this.dataGridView1.DataSource = null;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Land'";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ++count;
                }
                reader.Close();
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
              
                lbl_records.Text = "Total# of Records are: " + count.ToString();
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "All")
            {
                this.dataGridView1.DataSource = null;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table ";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   ++count;
                }
                reader.Close();
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
                lbl_records.Text = "Total# of Records are: " + count.ToString();
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Other")

            {

                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();
                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Other'";

                command.Connection = connection;


                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                ++count;
                }
                reader.Close();
                connection.Close();
                lbl_records.Text = "Total# of Records are: " + count.ToString();


            }






         

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
           

            int last = dataGridView1.Rows.Count - 1;
            if (e.RowIndex != -1 && e.RowIndex != last)
            {
                try
                {
                    lbl_Filter_SlctCategory.Text = last.ToString();
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string pass = row.Cells["ID"].Value.ToString();
                    int passed = int.Parse(pass);

                    this.lbl_Filter_SlctCategory.Text = pass;
                    string categoryPass = row.Cells[2].Value.ToString();
                    update_alert obj_update_alert = new update_alert(categoryPass, passed, rowindex);
                    obj_update_alert.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }

            }


        }
    }
}

