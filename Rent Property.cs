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
    public partial class Rent_Property : Form
    {


        public Rent_Property(string ctchrnted)
        {

            InitializeComponent();
          
        }

     // method for loading show available properties

        private void btn_LoadProperty_Click(object sender, EventArgs e)
        {
            show_All_for_load obj_LoadProp = new show_All_for_load();
            obj_LoadProp.ShowDialog();

        }
        

        
    }

}

