using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Real_Estate_Software
{
    public partial class Show_Rented_Properties : Form
    {
        public Show_Rented_Properties()
        {
            InitializeComponent();
        }
        // form load method for papolating the form rented properties with data from rent table;
        private void Show_Rented_Properties_Load(object sender, EventArgs e)
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

    }
}


