
namespace Real_Estate_Software
{
    partial class Main_Menu
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
            this.Btn_Add_Property = new System.Windows.Forms.Button();
            this.Btn_Remove_Property = new System.Windows.Forms.Button();
            this.Btn_Rent_Property = new System.Windows.Forms.Button();
            this.Btn_ShowAll_Properties = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_removetenant = new System.Windows.Forms.Button();
            this.btn_modify_tenant_info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Add_Property
            // 
            this.Btn_Add_Property.Location = new System.Drawing.Point(37, 54);
            this.Btn_Add_Property.Name = "Btn_Add_Property";
            this.Btn_Add_Property.Size = new System.Drawing.Size(216, 111);
            this.Btn_Add_Property.TabIndex = 0;
            this.Btn_Add_Property.Text = "Add Property";
            this.Btn_Add_Property.UseVisualStyleBackColor = true;
            this.Btn_Add_Property.Click += new System.EventHandler(this.Btn_Add_Property_Click);
            // 
            // Btn_Remove_Property
            // 
            this.Btn_Remove_Property.Location = new System.Drawing.Point(295, 54);
            this.Btn_Remove_Property.Name = "Btn_Remove_Property";
            this.Btn_Remove_Property.Size = new System.Drawing.Size(216, 111);
            this.Btn_Remove_Property.TabIndex = 1;
            this.Btn_Remove_Property.Text = "Remove Property";
            this.Btn_Remove_Property.UseVisualStyleBackColor = true;
            this.Btn_Remove_Property.Click += new System.EventHandler(this.Btn_Remove_Property_Click);
            // 
            // Btn_Rent_Property
            // 
            this.Btn_Rent_Property.Location = new System.Drawing.Point(562, 54);
            this.Btn_Rent_Property.Name = "Btn_Rent_Property";
            this.Btn_Rent_Property.Size = new System.Drawing.Size(216, 111);
            this.Btn_Rent_Property.TabIndex = 2;
            this.Btn_Rent_Property.Text = "Rent Property";
            this.Btn_Rent_Property.UseVisualStyleBackColor = true;
            this.Btn_Rent_Property.Click += new System.EventHandler(this.Btn_Rent_Property_Click);
            // 
            // Btn_ShowAll_Properties
            // 
            this.Btn_ShowAll_Properties.Location = new System.Drawing.Point(37, 210);
            this.Btn_ShowAll_Properties.Name = "Btn_ShowAll_Properties";
            this.Btn_ShowAll_Properties.Size = new System.Drawing.Size(216, 111);
            this.Btn_ShowAll_Properties.TabIndex = 3;
            this.Btn_ShowAll_Properties.Text = "Show All Properties";
            this.Btn_ShowAll_Properties.UseVisualStyleBackColor = true;
            this.Btn_ShowAll_Properties.Click += new System.EventHandler(this.Btn_ShowAll_Properties_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(562, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 111);
            this.button5.TabIndex = 4;
            this.button5.Text = "Update Records";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.UpdateRecords_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(562, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 111);
            this.button6.TabIndex = 5;
            this.button6.Text = "Show Rented Properties";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_removetenant
            // 
            this.btn_removetenant.Location = new System.Drawing.Point(37, 372);
            this.btn_removetenant.Name = "btn_removetenant";
            this.btn_removetenant.Size = new System.Drawing.Size(216, 111);
            this.btn_removetenant.TabIndex = 6;
            this.btn_removetenant.Text = "Remove Tenant";
            this.btn_removetenant.UseVisualStyleBackColor = true;
            this.btn_removetenant.Click += new System.EventHandler(this.btn_removetenant_Click);
            // 
            // btn_modify_tenant_info
            // 
            this.btn_modify_tenant_info.Location = new System.Drawing.Point(304, 372);
            this.btn_modify_tenant_info.Name = "btn_modify_tenant_info";
            this.btn_modify_tenant_info.Size = new System.Drawing.Size(216, 111);
            this.btn_modify_tenant_info.TabIndex = 7;
            this.btn_modify_tenant_info.Text = "Modify Tenant";
            this.btn_modify_tenant_info.UseVisualStyleBackColor = true;
            this.btn_modify_tenant_info.Click += new System.EventHandler(this.btn_modify_tenant_info_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 555);
            this.Controls.Add(this.btn_modify_tenant_info);
            this.Controls.Add(this.btn_removetenant);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Btn_ShowAll_Properties);
            this.Controls.Add(this.Btn_Rent_Property);
            this.Controls.Add(this.Btn_Remove_Property);
            this.Controls.Add(this.Btn_Add_Property);
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Add_Property;
        private System.Windows.Forms.Button Btn_Remove_Property;
        private System.Windows.Forms.Button Btn_Rent_Property;
        private System.Windows.Forms.Button Btn_ShowAll_Properties;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btn_removetenant;
        private System.Windows.Forms.Button btn_modify_tenant_info;
    }
}

