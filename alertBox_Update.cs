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
    //form for updating the property table
    public partial class alertBox_Update : Form
    {
        public alertBox_Update()
        {
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    //button for making updates in property table
        private void btn_Yes_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

