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
    public partial class Remove_Property : Form
    {
      
        public Remove_Property()
        {
            InitializeComponent();

            
           
        }

        private void Remove_Property_Load(object sender, EventArgs e)
        {
            //papolating category with choices/options
            string[] category_choice = { "Flat", "Bunglow", "Shop", "Plot", "Land", "All","Other" };
            this.comboBox_ShowAll.Text = "Please select any one";
            this.comboBox_ShowAll.Items.AddRange(category_choice);
           

        }
        //method for filtering the records as per category
        private void comboBox_ShowAll_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (comboBox_ShowAll.SelectedItem.ToString() == "Flat")
            {
               
            
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Flat'";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
               
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];

            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Bunglow")
            {
            
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table Where Category LIKE 'Bunglow'";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
              
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Shop")
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
                
               
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Plot")
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
                
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Land")
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
               

                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "Other")
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
               
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
            else if (comboBox_ShowAll.SelectedItem.ToString() == "All")
            {
                this.dataGridView1.DataSource = null;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "Select * from AddProperty_Table;";


                DataSet ds = new DataSet();

                command.Connection = connection;


                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command.CommandText, connection);
                adapter.Fill(ds);
               
                connection.Close();
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

       
      
        //mehtod for removing/deleting the record
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int last = dataGridView1.Rows.Count-1;
            if (e.RowIndex != -1 && e.RowIndex!= last)
            {
                try {
                    lbl_SelectCategory.Text = last.ToString();
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string pass = row.Cells["ID"].Value.ToString();
                    int passed = int.Parse(pass);

                    this.lbl_SelectCategory.Text = pass;
                    string categoryPass = row.Cells[2].Value.ToString();
                    AlertBox obj_alertbox = new AlertBox(passed, categoryPass);
                    obj_alertbox.ShowDialog();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
               
            }
        }

       
    }
}
