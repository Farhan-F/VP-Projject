
namespace Real_Estate_Software
{
    partial class Rent_Property
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
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LoadProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Click button to select property";
            // 
            // btn_LoadProperty
            // 
            this.btn_LoadProperty.Location = new System.Drawing.Point(266, 84);
            this.btn_LoadProperty.Name = "btn_LoadProperty";
            this.btn_LoadProperty.Size = new System.Drawing.Size(288, 40);
            this.btn_LoadProperty.TabIndex = 9;
            this.btn_LoadProperty.Text = "Click to load available properties";
            this.btn_LoadProperty.UseVisualStyleBackColor = true;
            this.btn_LoadProperty.Click += new System.EventHandler(this.btn_LoadProperty_Click);
            // 
            // Rent_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 187);
            this.Controls.Add(this.btn_LoadProperty);
            this.Controls.Add(this.label3);
            this.Name = "Rent_Property";
            this.Text = "Rent Property";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_LoadProperty;
    }
}