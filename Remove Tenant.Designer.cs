
namespace Real_Estate_Software
{
    partial class Remove_Tenant
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_records = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbCnic = new System.Windows.Forms.RadioButton();
            this.rbPhone = new System.Windows.Forms.RadioButton();
            this.lbl_filterData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(876, 456);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_records
            // 
            this.lbl_records.AutoSize = true;
            this.lbl_records.Location = new System.Drawing.Point(58, 598);
            this.lbl_records.Name = "lbl_records";
            this.lbl_records.Size = new System.Drawing.Size(0, 20);
            this.lbl_records.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Location = new System.Drawing.Point(175, 69);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(149, 24);
            this.rbName.TabIndex = 3;
            this.rbName.TabStop = true;
            this.rbName.Text = "Search by name";
            this.rbName.UseVisualStyleBackColor = true;
           
            // 
            // rbCnic
            // 
            this.rbCnic.AutoSize = true;
            this.rbCnic.Location = new System.Drawing.Point(340, 69);
            this.rbCnic.Name = "rbCnic";
            this.rbCnic.Size = new System.Drawing.Size(137, 24);
            this.rbCnic.TabIndex = 4;
            this.rbCnic.TabStop = true;
            this.rbCnic.Text = "Search by cnic";
            this.rbCnic.UseVisualStyleBackColor = true;
         
            // 
            // rbPhone
            // 
            this.rbPhone.AutoSize = true;
            this.rbPhone.Location = new System.Drawing.Point(516, 69);
            this.rbPhone.Name = "rbPhone";
            this.rbPhone.Size = new System.Drawing.Size(155, 24);
            this.rbPhone.TabIndex = 5;
            this.rbPhone.TabStop = true;
            this.rbPhone.Text = "search by  phone";
            this.rbPhone.UseVisualStyleBackColor = true;
         
            // 
            // lbl_filterData
            // 
            this.lbl_filterData.AutoSize = true;
            this.lbl_filterData.Location = new System.Drawing.Point(36, 24);
            this.lbl_filterData.Name = "lbl_filterData";
            this.lbl_filterData.Size = new System.Drawing.Size(116, 20);
            this.lbl_filterData.TabIndex = 6;
            this.lbl_filterData.Text = "Search Record";
            // 
            // Remove_Tenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 642);
            this.Controls.Add(this.lbl_filterData);
            this.Controls.Add(this.rbPhone);
            this.Controls.Add(this.rbCnic);
            this.Controls.Add(this.rbName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_records);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Remove_Tenant";
            this.Text = "Remove_Tenant";
            this.Load += new System.EventHandler(this.Remove_Tenant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_records;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbCnic;
        private System.Windows.Forms.RadioButton rbPhone;
        private System.Windows.Forms.Label lbl_filterData;
    }
}