
namespace Real_Estate_Software
{
    partial class Add_Property
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Located = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.textBox_PropertyName = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxLocated = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(265, 349);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(172, 60);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(42, 349);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(172, 60);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(38, 58);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(114, 20);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Property Name";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(38, 121);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(73, 20);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category";
            // 
            // lbl_Located
            // 
            this.lbl_Located.AutoSize = true;
            this.lbl_Located.Location = new System.Drawing.Point(38, 186);
            this.lbl_Located.Name = "lbl_Located";
            this.lbl_Located.Size = new System.Drawing.Size(67, 20);
            this.lbl_Located.TabIndex = 4;
            this.lbl_Located.Text = "Located";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(38, 251);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(68, 20);
            this.lbl_Address.TabIndex = 5;
            this.lbl_Address.Text = "Address";
            // 
            // textBox_PropertyName
            // 
            this.textBox_PropertyName.Location = new System.Drawing.Point(177, 55);
            this.textBox_PropertyName.Name = "textBox_PropertyName";
            this.textBox_PropertyName.Size = new System.Drawing.Size(260, 26);
            this.textBox_PropertyName.TabIndex = 6;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(177, 251);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(260, 26);
            this.textBox_Address.TabIndex = 9;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(177, 113);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(260, 28);
            this.comboBoxCategory.TabIndex = 10;
            // 
            // comboBoxLocated
            // 
            this.comboBoxLocated.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocated.FormattingEnabled = true;
            this.comboBoxLocated.Location = new System.Drawing.Point(177, 183);
            this.comboBoxLocated.Name = "comboBoxLocated";
            this.comboBoxLocated.Size = new System.Drawing.Size(260, 28);
            this.comboBoxLocated.TabIndex = 11;
            // 
            // Add_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 509);
            this.Controls.Add(this.comboBoxLocated);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_PropertyName);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Located);
            this.Controls.Add(this.lbl_Category);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Cancel);
            this.Name = "Add_Property";
            this.Text = "Add Property";
            this.Load += new System.EventHandler(this.Add_Property_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Located;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox textBox_PropertyName;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxLocated;
    }
}