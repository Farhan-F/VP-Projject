
namespace Real_Estate_Software
{
    partial class Remove_Property
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
            this.lbl_SelectCategory = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_ShowAll
            // 
            this.comboBox_ShowAll.FormattingEnabled = true;
            this.comboBox_ShowAll.Location = new System.Drawing.Point(186, 30);
            this.comboBox_ShowAll.Name = "comboBox_ShowAll";
            this.comboBox_ShowAll.Size = new System.Drawing.Size(375, 28);
            this.comboBox_ShowAll.TabIndex = 16;
            this.comboBox_ShowAll.SelectedIndexChanged += new System.EventHandler(this.comboBox_ShowAll_SelectedIndexChanged);
          
            // 
            // lbl_SelectCategory
            // 
            this.lbl_SelectCategory.AutoSize = true;
            this.lbl_SelectCategory.Location = new System.Drawing.Point(42, 33);
            this.lbl_SelectCategory.Name = "lbl_SelectCategory";
            this.lbl_SelectCategory.Size = new System.Drawing.Size(126, 20);
            this.lbl_SelectCategory.TabIndex = 15;
            this.lbl_SelectCategory.Text = "Select  Category";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(46, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(731, 444);
            this.listBox1.TabIndex = 17;
          
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(731, 444);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Remove_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 584);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox_ShowAll);
            this.Controls.Add(this.lbl_SelectCategory);
            this.Name = "Remove_Property";
            this.Text = "Remove Property";
            this.Load += new System.EventHandler(this.Remove_Property_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_ShowAll;
        private System.Windows.Forms.Label lbl_SelectCategory;
        private System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}