
namespace Real_Estate_Software
{
    partial class update_alert
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
            this.cmbobox_update = new System.Windows.Forms.ComboBox();
            this.rb_Address = new System.Windows.Forms.RadioButton();
            this.rb_Located = new System.Windows.Forms.RadioButton();
            this.txtbox_update = new System.Windows.Forms.TextBox();
            this.rb_Category = new System.Windows.Forms.RadioButton();
            this.rb_Name = new System.Windows.Forms.RadioButton();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_txtbox = new System.Windows.Forms.Label();
            this.lbl_cmbobox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbobox_update
            // 
            this.cmbobox_update.FormattingEnabled = true;
            this.cmbobox_update.Location = new System.Drawing.Point(248, 219);
            this.cmbobox_update.Name = "cmbobox_update";
            this.cmbobox_update.Size = new System.Drawing.Size(388, 28);
            this.cmbobox_update.TabIndex = 25;
            // 
            // rb_Address
            // 
            this.rb_Address.AutoSize = true;
            this.rb_Address.Location = new System.Drawing.Point(594, 91);
            this.rb_Address.Name = "rb_Address";
            this.rb_Address.Size = new System.Drawing.Size(150, 24);
            this.rb_Address.TabIndex = 24;
            this.rb_Address.TabStop = true;
            this.rb_Address.Text = "Update Address";
            this.rb_Address.UseVisualStyleBackColor = true;
            this.rb_Address.CheckedChanged += new System.EventHandler(this.rb_Address_CheckedChanged);
            // 
            // rb_Located
            // 
            this.rb_Located.AutoSize = true;
            this.rb_Located.Location = new System.Drawing.Point(424, 91);
            this.rb_Located.Name = "rb_Located";
            this.rb_Located.Size = new System.Drawing.Size(152, 24);
            this.rb_Located.TabIndex = 23;
            this.rb_Located.TabStop = true;
            this.rb_Located.Text = "Update Location";
            this.rb_Located.UseVisualStyleBackColor = true;
            this.rb_Located.CheckedChanged += new System.EventHandler(this.rb_Located_CheckedChanged);
            // 
            // txtbox_update
            // 
            this.txtbox_update.Location = new System.Drawing.Point(248, 164);
            this.txtbox_update.Name = "txtbox_update";
            this.txtbox_update.Size = new System.Drawing.Size(388, 26);
            this.txtbox_update.TabIndex = 22;
            // 
            // rb_Category
            // 
            this.rb_Category.AutoSize = true;
            this.rb_Category.Location = new System.Drawing.Point(248, 91);
            this.rb_Category.Name = "rb_Category";
            this.rb_Category.Size = new System.Drawing.Size(155, 24);
            this.rb_Category.TabIndex = 21;
            this.rb_Category.TabStop = true;
            this.rb_Category.Text = "Update Category";
            this.rb_Category.UseVisualStyleBackColor = true;
            this.rb_Category.CheckedChanged += new System.EventHandler(this.rb_Category_CheckedChanged);
            // 
            // rb_Name
            // 
            this.rb_Name.AutoSize = true;
            this.rb_Name.Location = new System.Drawing.Point(94, 89);
            this.rb_Name.Name = "rb_Name";
            this.rb_Name.Size = new System.Drawing.Size(133, 24);
            this.rb_Name.TabIndex = 20;
            this.rb_Name.TabStop = true;
            this.rb_Name.Text = "Update Name";
            this.rb_Name.UseVisualStyleBackColor = true;
            this.rb_Name.CheckedChanged += new System.EventHandler(this.rb_Name_CheckedChanged);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(212, 317);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 47);
            this.btn_Save.TabIndex = 26;
            this.btn_Save.Text = "Update";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(501, 308);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(135, 56);
            this.btn_Cancel.TabIndex = 27;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_txtbox
            // 
            this.lbl_txtbox.AutoSize = true;
            this.lbl_txtbox.Location = new System.Drawing.Point(78, 164);
            this.lbl_txtbox.Name = "lbl_txtbox";
            this.lbl_txtbox.Size = new System.Drawing.Size(94, 20);
            this.lbl_txtbox.TabIndex = 28;
            this.lbl_txtbox.Text = "Enter Name";
            // 
            // lbl_cmbobox
            // 
            this.lbl_cmbobox.AutoSize = true;
            this.lbl_cmbobox.Location = new System.Drawing.Point(78, 227);
            this.lbl_cmbobox.Name = "lbl_cmbobox";
            this.lbl_cmbobox.Size = new System.Drawing.Size(142, 20);
            this.lbl_cmbobox.TabIndex = 29;
            this.lbl_cmbobox.Text = "Select your  choice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Please Select from below";
            // 
            // update_alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cmbobox);
            this.Controls.Add(this.lbl_txtbox);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmbobox_update);
            this.Controls.Add(this.rb_Address);
            this.Controls.Add(this.rb_Located);
            this.Controls.Add(this.txtbox_update);
            this.Controls.Add(this.rb_Category);
            this.Controls.Add(this.rb_Name);
            this.Name = "update_alert";
            this.Text = "update_alert";
            this.Load += new System.EventHandler(this.update_alert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbobox_update;
        private System.Windows.Forms.RadioButton rb_Address;
        private System.Windows.Forms.RadioButton rb_Located;
        private System.Windows.Forms.TextBox txtbox_update;
        private System.Windows.Forms.RadioButton rb_Category;
        private System.Windows.Forms.RadioButton rb_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_txtbox;
        private System.Windows.Forms.Label lbl_cmbobox;
        private System.Windows.Forms.Label label1;
    }
}