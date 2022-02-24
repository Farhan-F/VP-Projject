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
    //form for updating the records of tenants.
    public partial class Modify_Tenant_Info : Form
    {
        int id, rentamount;
        string phone,cnic;
        bool flag = false;
        public Modify_Tenant_Info()
        {
            InitializeComponent();
        }

        //method for updating records
        //this method supports records searching option too
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (rbName.Checked == true)
            {
                try
                {
                    int count = 0;
                
                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = "select * from RentTable where Name like '" + this.textBox6.Text + "%'";

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
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (rbCnic.Checked == true)
            {
                try
                {
                    int count = 0;
                   
                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = "select * from RentTable where CNIC like '" + this.textBox6.Text + "%'";

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
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (rbPhone.Checked == true)
            {
                try
                {
                    int count = 0;
                  
                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = "select * from RentTable where Phone like '" + this.textBox6.Text + "%'";

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
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Modify_Tenant_Info_Load(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
               
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();

                command.CommandText = "select * from RentTable ;";

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            this.txtbox_Name.Text = row.Cells[1].Value.ToString();
            this.txtBox_CNIC.Text = row.Cells[2].Value.ToString();
            this.txtBox_Phone.Text = row.Cells[3].Value.ToString();
            this.txtBox_Rent.Text = row.Cells[4].Value.ToString();
            this.textBox_Address.Text = row.Cells[5].Value.ToString();
            id = Convert.ToInt32(row.Cells[0].Value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            formatcheck();
            if (flag == true)
            try
            {
                    flag = false;
                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();
               
                command.Connection = connection;
                command.CommandText = "update  RentTable set name ='" + this.txtbox_Name.Text + "',CNIC='" + this.txtBox_CNIC.Text + "',Phone='" + this.txtBox_Phone.Text + "',Rent='" + this.txtBox_Rent.Text + "' where ID =" + id+ ";";
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //method for checking text pattern of fields such as cnic phone and rent amount
        public void formatcheck()
        {
            bool f1 = false, f2 = false, f3 = false;
            string patternCNIC = @"^[0-9+]{5}-[0-9+]{7}-[0-9]{1}$";

            String patternnumeric = @"^[0-9]+[0-9]*$";

            string nbrptrn = @"^((\+92)|(0092))-{0,1}\d{3}-{0,1}\d{7}$|^\d{11}$|^\d{4}-\d{7}$";

            Regex rgxnumber = new Regex(nbrptrn);

            Match m = rgxnumber.Match(this.txtBox_Phone.Text);


            if (m.Success)
            {
                phone = this.txtBox_Phone.Text;
                f1 = true;
            }
            else
            {
                MessageBox.Show("Please Enter correct format number");
            }

            Regex rgxrent = new Regex(patternnumeric);
            Match m1 = rgxrent.Match(this.txtBox_Rent.Text);

            if (m1.Success)
            {
                rentamount = Convert.ToInt32(this.txtBox_Rent.Text);
                f2 = true;
            }

            Regex rgxCnic = new Regex(patternCNIC);
            Match mcnic = rgxCnic.Match(this.txtBox_CNIC.Text);
            if (mcnic.Success)
            {
                cnic = this.txtBox_CNIC.Text;
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
    }
}
