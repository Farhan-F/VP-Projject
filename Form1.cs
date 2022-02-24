using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Software
{
   
    public partial class Main_Menu : Form
    {
        string rented;
        public Main_Menu()
        {
            InitializeComponent();
        }
        
        
        //making objects of every forms so that we can invoke them through object to achieve the desired results
        private void Btn_Add_Property_Click(object sender, EventArgs e)
        {
       
            Add_Property obj_AddProperty = new Add_Property();
            obj_AddProperty.ShowDialog();
        }

        private void Btn_ShowAll_Properties_Click(object sender, EventArgs e)
        {
            Show_All obj_show_All = new Show_All();
            obj_show_All.ShowDialog();
        }
    //passing an argument through constructor.
        private void Btn_Rent_Property_Click(object sender, EventArgs e)
        {
            Rent_Property obj_rent_property = new Rent_Property(  rented );
            obj_rent_property.ShowDialog();
        }

        private void Btn_Remove_Property_Click(object sender, EventArgs e)
        {
         
            Remove_Property obj_Remove_Property = new Remove_Property();
            obj_Remove_Property.ShowDialog();
                
                }

        private void UpdateRecords_Click(object sender, EventArgs e)
        {
            Update_Record obj_UpdateRecord = new Update_Record();
            obj_UpdateRecord.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Show_Rented_Properties obj_showRentedProp = new Show_Rented_Properties();
            obj_showRentedProp.ShowDialog();
        }

        private void btn_removetenant_Click(object sender, EventArgs e)
        {
            Remove_Tenant obj_remvTenant = new Remove_Tenant();
            obj_remvTenant.ShowDialog();
        }

        private void btn_modify_tenant_info_Click(object sender, EventArgs e)
        {
            Modify_Tenant_Info obj_MdfyTnntinfo = new Modify_Tenant_Info();
            obj_MdfyTnntinfo.ShowDialog();
        }
    }
}
