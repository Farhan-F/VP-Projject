
namespace Real_Estate_Software
{
    partial class RentProperty2
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
            this.txtbox_rent = new System.Windows.Forms.TextBox();
            this.txtbox_Phone = new System.Windows.Forms.TextBox();
            this.txtbox_CNIC = new System.Windows.Forms.TextBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_rent
            // 
            this.txtbox_rent.Location = new System.Drawing.Point(349, 312);
            this.txtbox_rent.Name = "txtbox_rent";
            this.txtbox_rent.Size = new System.Drawing.Size(279, 26);
            this.txtbox_rent.TabIndex = 16;
            // 
            // txtbox_Phone
            // 
            this.txtbox_Phone.Location = new System.Drawing.Point(349, 244);
            this.txtbox_Phone.Name = "txtbox_Phone";
            this.txtbox_Phone.Size = new System.Drawing.Size(279, 26);
            this.txtbox_Phone.TabIndex = 15;
            // 
            // txtbox_CNIC
            // 
            this.txtbox_CNIC.Location = new System.Drawing.Point(349, 177);
            this.txtbox_CNIC.Name = "txtbox_CNIC";
            this.txtbox_CNIC.Size = new System.Drawing.Size(279, 26);
            this.txtbox_CNIC.TabIndex = 14;
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(349, 113);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(279, 26);
            this.txtBox_name.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Rent / Amount";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(173, 247);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(55, 20);
            this.Phone.TabIndex = 11;
            this.Phone.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tenant CNIC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tenant Name";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(413, 379);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(164, 49);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(196, 379);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(164, 49);
            this.btn_Confirm.TabIndex = 17;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // RentProperty2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txtbox_rent);
            this.Controls.Add(this.txtbox_Phone);
            this.Controls.Add(this.txtbox_CNIC);
            this.Controls.Add(this.txtBox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RentProperty2";
            this.Text = "RentProperty2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_rent;
        private System.Windows.Forms.TextBox txtbox_Phone;
        private System.Windows.Forms.TextBox txtbox_CNIC;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
    }
}