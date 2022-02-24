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
using System.Text.RegularExpressions;

namespace Real_Estate_Software
{
    public partial class RentProperty2 : Form
    {
        string cnic, phone;
        string catchrented;
        int rentamount;
        int key = 0;
        int warning = 1;
        int result;
        bool flag = false;
        public RentProperty2(string ctchrnted)
        {
            InitializeComponent();
            catchrented = ctchrnted;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            formatcheck();
            if (flag == true)
            {
                flag = false;
                if (txtBox_name.Text != "" && txtbox_CNIC.Text != null && txtbox_rent.Text != null)
                {
                    CheckingMAx();



                    try
                    {
                        this.label1.Text = catchrented;
                        //query for inserting data into add property  table
                        string query = "insert into dbo.RentTable(ID,Name,CNIC,Phone,Rent,Rented) values('" + key + "','" + this.txtBox_name.Text + "','" + cnic + "','" + this.txtbox_Phone.Text + "','" + this.txtbox_rent.Text + "','" + catchrented + "');";

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
                        key = key + 0001;
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


        }

        //this fucntion will will help in assigning automatic serial number which will be  also primary key for database
        //using max value to find max number so that it can assign Max+1 key to other record  
        public void CheckingMAx()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["cAstring"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "Select MAX(ID) as MAX_ITEMS from RentTable";
                connection.Open();
                key = (int)command.ExecuteScalar();
                connection.Close();


                key = key + 1;


             
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex.Message);
            }

        }
         //checking database to know how many records are there.
        public void CheckingDB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAstring"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "Select count(*) as total from dbo.RentTable";
            connection.Open();
            result = (int)command.ExecuteScalar();
            connection.Close();
        }

        //method for checking correct format of data input such as cnic phone and rent
        public void formatcheck()
        {
            bool f1 = false, f2 = false, f3 = false;
            string patternCNIC = @"^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$";

            String patternnumeric = @"^[0-9]+[0-9]*$";

            string nbrptrn = @"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$";

            Regex rgxnumber = new Regex(nbrptrn);

            Match m = rgxnumber.Match(this.txtbox_Phone.Text);


            if (m.Success)
            {
                phone = this.txtbox_Phone.Text;
                f1 = true;
            }
            else
            {
                MessageBox.Show("Please Enter correct format number");
            }

            Regex rgxrent = new Regex(patternnumeric);
            Match m1 = rgxrent.Match(this.txtbox_rent.Text);

            if (m1.Success)
            {
                rentamount = Convert.ToInt32(this.txtbox_rent.Text);
                f2 = true;
            }

            Regex rgxCnic = new Regex(patternCNIC);
            Match mcnic = rgxCnic.Match(this.txtbox_CNIC.Text);
            if (mcnic.Success)
            {
                cnic = this.txtbox_CNIC.Text;
                f3 = true;
            }
            else
            {
                MessageBox.Show("Please Enter CNIC in Correct format");
            }
            if (f1 == true && f2 == true && f3 == true)
            {
                flag = true;
            }
            if (flag == false)
            {
                MessageBox.Show("Please Enter all data in correct format");
            }
        }
        //method for disposing the form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}

