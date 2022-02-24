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
    //this form will work as alertbox for deleting the record from Add property table to remove the record
    public partial class AlertBox : Form
    {

       
        string categoryholding;
        int passed_ID;
        bool flag = true;
        public AlertBox(int id, string categorypassing)
        {
            InitializeComponent();
          
            passed_ID = id;
            categoryholding = categorypassing;
           
            Remove_Property obj_Rmv_Property = new Remove_Property( );
        }

       //Button for deleting record from property table
        private void btnOk_Click(object sender, EventArgs e)
        {
            Remove_Property obj_Remv_property = new Remove_Property();

            try
            {

                string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                SqlConnection connection1 = new SqlConnection(connectionstring);
                SqlCommand command = new SqlCommand();
                command.Connection = connection1;
                //  command.CommandText = "Select ID as IDs from ID";


                command.CommandText = "Delete from dbo.AddProperty_Table where ID = " + passed_ID + ";";
                connection1.Open();
                command.ExecuteNonQuery();
                obj_Remv_property.dataGridView1.Update();
                obj_Remv_property.dataGridView1.Refresh();
                
                connection1.Close();

                MessageBox.Show("Record Deleted Successfully");

                flag = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            this.Dispose();
        }
        
        //button for disposing form
        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
           
         
        }
    }
}
