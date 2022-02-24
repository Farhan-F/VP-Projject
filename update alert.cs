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
    public partial class update_alert : Form
    {
        //declaring variables.
      string Category;
        int pass, rowindex ;
        public update_alert(string catchCategory, int catchPass, int catchrowIndex)
        {
            //catching data being passed from update property form
            InitializeComponent();
    Category = catchCategory;
        pass = catchPass;
            rowindex = catchrowIndex;
        }
        //method for disposing form
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //form load method for disabling the combobox so that user can only select not enter any data when relevant  checkbox is not selected 
        private void update_alert_Load(object sender, EventArgs e)
        {
            this.txtbox_update.Enabled = false;
            this.cmbobox_update.Enabled = false;
            
        }
        //checking if user selected the checkbox or not. if selected then flag = true otherwise false;
        private void rb_Name_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Name.Checked == true)
            {
                this.txtbox_update.Enabled = true;
            }
            else
            {
                this.txtbox_update.Enabled = false;
            }
        }

        //method for if user selected radio  button category
        private void rb_Category_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rb_Category.Checked==true)
            {
                this.cmbobox_update.Items.Clear();
                string[] category_choice = { "Flat", "Bunglow", "Shop", "Plot", "Land", "All", "Other" };
                this.cmbobox_update.Items.AddRange(category_choice);
                this.cmbobox_update.Enabled = true;
            }
            else
            {
                this.cmbobox_update.Enabled = false;
            }
        }
        //method for if user selected radio button loaction
        private void rb_Located_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Located.Checked == true)
            {
                this.cmbobox_update.Items.Clear();
                string[] located_choice = { "Sukkur", "Karachi", "Village", "Other" };
                this.cmbobox_update.Items.AddRange(located_choice);
                this.cmbobox_update.Enabled = true;
            }
            else
            {
                this.cmbobox_update.Enabled = false;
            }
        }
        //method for if user selected checkbox address
        private void rb_Address_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Address.Checked == true)
            {
                this.txtbox_update.Enabled = true;
            }
            else
            {
                this.txtbox_update.Enabled = false;
            }
        }
        //method for updating the records corresponding to selected radio button
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (rb_Name.Checked == true)
            {
                try
                {
                    string updateText;
                    updateText = this.txtbox_update.Text;

                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "update  AddProperty_Table set name ='" + updateText + "' where ID =" + pass + ";";
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
            else if (rb_Address.Checked == true)
            {
                try {
                    string updateText;
                    updateText = this.txtbox_update.Text;

                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "update  AddProperty_Table set address ='" + updateText + "' where ID =" + pass + ";";
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Record Updated Successfully");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else if (rb_Category.Checked == true)
            {
                try
                {
                    string choice = this.cmbobox_update.SelectedItem.ToString();

                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "update  AddProperty_Table set category ='" + choice + "' where ID =" + pass + ";";
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
            else if (rb_Located.Checked == true)
            {
                try {
                    string choice = this.cmbobox_update.SelectedItem.ToString();

                    string connectionstring = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
                    SqlConnection connection = new SqlConnection(connectionstring);
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "update  AddProperty_Table set Located ='" + choice + "' where ID =" + pass + ";";
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
        }
    }
}
