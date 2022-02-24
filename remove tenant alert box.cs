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
    public partial class remove_tenant_alert_box : Form
    {
        int idcatch;
        public remove_tenant_alert_box(int id)
        {
            idcatch = id;
            InitializeComponent();
        }

        
        private void remove_tenant_alert_box_Load(object sender, EventArgs e)
        {

        }
        //method for removing tenant from renttable records
        private void btn_Yes_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection1 = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();
                command.Connection = connection1;
               


                command.CommandText = "Delete from RentTable where ID = " + idcatch + ";";
                connection1.Open();
                command.ExecuteNonQuery();


                connection1.Close();

                MessageBox.Show("Record Deleted Successfully");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            this.Dispose();
        }
    }

}
