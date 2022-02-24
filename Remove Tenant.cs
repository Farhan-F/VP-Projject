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
    public partial class Remove_Tenant : Form
    {
        public Remove_Tenant()
        {
            InitializeComponent();
        }

        //method load for papolating the datagridview when form loads with records from RentTable
        private void Remove_Tenant_Load(object sender, EventArgs e)
        {
            int count = 0;



            this.dataGridView1.DataSource = null;
            string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand command = new SqlCommand();

            command.CommandText = "Select * from RentTable ";


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
        //method for getting id for deleting the relevant record from rent table
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int last = dataGridView1.Rows.Count - 1;
            if (e.RowIndex != -1 && e.RowIndex != last)
            {
                try
                {

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string pass = row.Cells["ID"].Value.ToString();
                    int passed = int.Parse(pass);



                    remove_tenant_alert_box obj_Remv_Tnnt_AB = new remove_tenant_alert_box(passed);
                    obj_Remv_Tnnt_AB.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }

            }
        }

        //method for searching record from rent table
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbName.Checked == true)
            {
                try
                {
                    int count = 0;
                    this.dataGridView1.DataSource = null;
                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = "select * from RentTable where Name like '" + this.textBox1.Text + "%'";

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

                    command.CommandText = "select * from RentTable where CNIC like '" + this.textBox1.Text + "%'";

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
                    this.dataGridView1.DataSource = null;
                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();

                    command.CommandText = "select * from RentTable where Phone like '" + this.textBox1.Text + "%'";

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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }


}
    

