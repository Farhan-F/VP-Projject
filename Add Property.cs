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
    public partial class Add_Property : Form
    {

        //global variables   for add property form
        string PropertyName, address;
        string located = "", category = "";
      
        int key = 0;
        int warning = 1;
        int result;


        // Method for button confirm
        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            CheckingMAx();
            // database insertion method
            InsertData();

            //using try catch method for assigning text to variables
            try
            {
                //assigning the variables the text
                PropertyName = this.textBox_PropertyName.Text;
                address = this.textBox_Address.Text;

                //checking if category box or located box is null
                //if it's null then user need to enter the values
                if (comboBoxCategory.SelectedItem == null || comboBoxLocated.SelectedItem == null)
                {
                    MessageBox.Show("please Select one option");


                }
                //if category box or located box is not null then this block will work
                else
                {
                    category = this.comboBoxCategory.SelectedItem.ToString();
                    located = this.comboBoxLocated.SelectedItem.ToString();
                }
            }
            //if any error occurs then message will be shown
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }



        }
        //Closing the Add property dialog box
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
           
           
        }



        public Add_Property()
        {
            InitializeComponent();
            //Adding option to category combobox in add property form.

            string[] category_choice = { "Flat", "Bunglow", "Shop", "Plot", "Land", "Other" };
            this.comboBoxCategory.Text = "Please select any one";
            this.comboBoxCategory.Items.AddRange(category_choice);

            //Adding option to Located combobox in add property form.

            string[] located_choice = { "Sukkur", "Karachi", "Village", "Other" };
            this.comboBoxLocated.Text = "Please select any one";
            this.comboBoxLocated.Items.AddRange(located_choice);
          
          
        }

        //Method for writing data into  database


        public void InsertData()
        {

            if (textBox_PropertyName.Text != "" && comboBoxLocated.SelectedItem != null && comboBoxCategory != null && textBox_Address.Text != "")
            {
                try
                {
                    
                    //query for inserting data into add property  table
                    string query = "insert into dbo.AddProperty_Table(ID,Name,Category,Located,Address) values('" + key + "','" + this.textBox_PropertyName.Text + "','" + this.comboBoxCategory.SelectedItem.ToString() + "','" + this.comboBoxLocated.SelectedItem.ToString() + "','" + this.textBox_Address.Text + "');";

                    // string
                    string connectionString = ConfigurationManager.ConnectionStrings["cAstring"].ConnectionString;

                    //creating connetion object
                    SqlConnection connection = new SqlConnection(connectionString);

                    //creating command object
                    SqlCommand command = new SqlCommand();

                    //assigning connection object to connection property command object
                    command.Connection = connection;

                    // assigning query to command text of command object
                    command.CommandText = query;
                    connection.Open();
                    command.ExecuteNonQuery();

                    // closing the connection
                    connection.Close();

                    //showing message if  record added.
                    MessageBox.Show("The record has been added into the database");

                    warning = 1;
                    key = key + 1;
                }
                //exception if any error has been  occured
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }

                // if any field is not filled then this block will work and message will be displayed
            }
            else if (warning == 1)
            {
                warning = 0;
                MessageBox.Show("please fill all fields");
            }
        }

        
       

        private void Add_Property_Load(object sender, EventArgs e)
        {

        }

       //checking database to know how many records are there.
     
        public void CheckingDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAstring"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select count(*) as total from dbo.AddProperty_Table";
            connection.Open();
             result = (int)command.ExecuteScalar();
            connection.Close();
        }



        //this fucntion will will help in assigning automatic serial number which will be  also primary key for database
        //using max value to find max number so that it can assign Max+1 key to other record
        public void CheckingMAx()
        {
            try {
                string connectionString = ConfigurationManager.ConnectionStrings["cAstring"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "Select MAX(ID) as MAX_ITEMS from AddProperty_Table";
                connection.Open();
                key = (int)command.ExecuteScalar();
                connection.Close();


                key = key + 1;


              
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }
            
        }

    }
}
