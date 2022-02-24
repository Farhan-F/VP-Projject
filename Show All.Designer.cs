
namespace Real_Estate_Software
{
    partial class Show_All
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
            this.lbl_SelectCategory = new System.Windows.Forms.Label();
            this.comboBox_ShowAll = new System.Windows.Forms.ComboBox();
            this.lbl_records = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SelectCategory
            // 
            this.lbl_SelectCategory.AutoSize = true;
            this.lbl_SelectCategory.Location = new System.Drawing.Point(33, 36);
            this.lbl_SelectCategory.Name = "lbl_SelectCategory";
            this.lbl_SelectCategory.Size = new System.Drawing.Size(126, 20);
            this.lbl_SelectCategory.TabIndex = 0;
            this.lbl_SelectCategory.Text = "Select  Category";
            // 
            // comboBox_ShowAll
            // 
            this.comboBox_ShowAll.FormattingEnabled = true;
            this.comboBox_ShowAll.Location = new System.Drawing.Point(177, 33);
            this.comboBox_ShowAll.Name = "comboBox_ShowAll";
            this.comboBox_ShowAll.Size = new System.Drawing.Size(375, 28);
            this.comboBox_ShowAll.TabIndex = 1;
            this.comboBox_ShowAll.SelectedIndexChanged += new System.EventHandler(this.comboBox_ShowAll_SelectedIndexChanged);
            // 
            // lbl_records
            // 
            this.lbl_records.AutoSize = true;
            this.lbl_records.Location = new System.Drawing.Point(33, 622);
            this.lbl_records.Name = "lbl_records";
            this.lbl_records.Size = new System.Drawing.Size(170, 20);
            this.lbl_records.TabIndex = 16;
            this.lbl_records.Text = "Total# of Records are: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(757, 484);
            this.dataGridView1.TabIndex = 18;
          
            // 
            // Show_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 742);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_records);
            this.Controls.Add(this.comboBox_ShowAll);
            this.Controls.Add(this.lbl_SelectCategory);
            this.Name = "Show_All";
            this.Text = "Show All";
            this.Load += new System.EventHandler(this.Show_All_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelectCategory;
        private System.Windows.Forms.ComboBox comboBox_ShowAll;
        private System.Windows.Forms.Label lbl_records;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}