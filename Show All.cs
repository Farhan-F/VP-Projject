﻿using System;
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
    public partial class Show_All : Form
    {
        string nameofprop, category, located, address;
        int count = 0;

       
        public Show_All()
        {
            InitializeComponent();
          
        }
        //papolating the form with data on form load
        private void Show_All_Load(object sender, EventArgs e)
        {
            string[] category_choice = { "Flat", "Bunglow", "Shop", "Plot", "Land","Other" };
            this.comboBox_ShowAll.Text = "Please select any one";
            this.comboBox_ShowAll.Items.AddRange(category_choice);



           
                this.dataGridView1.DataSource = null;
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
        //filtering the data with category filtering option
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
