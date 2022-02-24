
namespace Real_Estate_Software
{
    partial class remove_tenant_alert_box
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
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(326, 140);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(159, 49);
            this.btn_no.TabIndex = 5;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            // 
            // btn_Yes
            // 
            this.btn_Yes.Location = new System.Drawing.Point(109, 140);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(160, 49);
            this.btn_Yes.TabIndex = 4;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Msg.Location = new System.Drawing.Point(77, 60);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(482, 32);
            this.lbl_Msg.TabIndex = 3;
            this.lbl_Msg.Text = "Do You Want To Delete The Record?";
            // 
            // remove_tenant_alert_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 276);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.lbl_Msg);
            this.Name = "remove_tenant_alert_box";
            this.Text = "remove_tenant_alert_box";
            this.Load += new System.EventHandler(this.remove_tenant_alert_box_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Label lbl_Msg;
    }
}