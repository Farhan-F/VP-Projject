using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Real_Estate_Software
{
    public partial class show_All_for_load : Form
    {
        //declaring varirables;
        string nameofprop, category, located, address, rented;
       

           
         //method to assign values to variables from datagridview
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                nameofprop = row.Cells[1].Value.ToString();
                category = row.Cells[2].Value.ToString();
                located = row.Cells[3].Value.ToString();
                address = row.Cells[4].Value.ToString();
                rented = nameofprop + " " + category + " " + located + " " + address;
               
            }
            // making object of rentproperty2 form which will invoke form that will take data of tenant
            RentProperty2 obj_rentProp2 = new RentProperty2(rented);
            obj_rentProp2.ShowDialog();
          
           
            this.Dispose();
          
        }

        int count = 0;


        //papolating form with data 
        private void show_All_for_load_Load(object sender, EventArgs e)
        {
            string[] category_choice = { "Flat", "Bunglow", "Shop", "Plot", "Land", "Other" };
            this.comboBox_ShowAll.Text = "Please select any one";
            this.comboBox_ShowAll.Items.AddRange(category_choice);

            string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand();

            command.CommandText = "Select * from AddProperty_Table";


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

        public show_All_for_load()
        {
            InitializeComponent();
        }

       //filtering data with category filetring option.
        private void comboBox_ShowAll_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                {      ++count;
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
    }
}
