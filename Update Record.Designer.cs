
namespace Real_Estate_Software
{
    partial class Update_Record
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_ShowAll = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_Filter_SlctCategory = new System.Windows.Forms.Label();
            this.lbl_records = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_ShowAll
            // 
            this.comboBox_ShowAll.FormattingEnabled = true;
            this.comboBox_ShowAll.Location = new System.Drawing.Point(167, 26);
            this.comboBox_ShowAll.Name = "comboBox_ShowAll";
            this.comboBox_ShowAll.Size = new System.Drawing.Size(356, 28);
            this.comboBox_ShowAll.TabIndex = 0;
            this.comboBox_ShowAll.SelectedIndexChanged += new System.EventHandler(this.comboBox_ShowAll_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(834, 550);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_Filter_SlctCategory
            // 
            this.lbl_Filter_SlctCategory.AutoSize = true;
            this.lbl_Filter_SlctCategory.Location = new System.Drawing.Point(31, 31);
            this.lbl_Filter_SlctCategory.Name = "lbl_Filter_SlctCategory";
            this.lbl_Filter_SlctCategory.Size = new System.Drawing.Size(122, 20);
            this.lbl_Filter_SlctCategory.TabIndex = 6;
            this.lbl_Filter_SlctCategory.Text = "Select Category";
            // 
            // lbl_records
            // 
            this.lbl_records.AutoSize = true;
            this.lbl_records.Location = new System.Drawing.Point(51, 673);
            this.lbl_records.Name = "lbl_records";
            this.lbl_records.Size = new System.Drawing.Size(0, 20);
            this.lbl_records.TabIndex = 7;
            // 
            // Update_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 689);
            this.Controls.Add(this.lbl_records);
            this.Controls.Add(this.lbl_Filter_SlctCategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_ShowAll);
            this.Name = "Update_Record";
            this.Text = "Update_Record";
            this.Load += new System.EventHandler(this.Update_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ShowAll;
        private System.Windows.Forms.CheckBox cbID;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbCategory;
        private System.Windows.Forms.CheckBox cbLocated;
        private System.Windows.Forms.Label lbl_Filter_SlctCategory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_records;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}