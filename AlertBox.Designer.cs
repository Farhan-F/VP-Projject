
namespace Real_Estate_Software
{
    partial class AlertBox
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
            this.lbl_Msg = new System.Windows.Forms.Label();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Msg
            // 
            this.lbl_Msg.AutoSize = true;
            this.lbl_Msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Msg.Location = new System.Drawing.Point(40, 68);
            this.lbl_Msg.Name = "lbl_Msg";
            this.lbl_Msg.Size = new System.Drawing.Size(482, 32);
            this.lbl_Msg.TabIndex = 0;
            this.lbl_Msg.Text = "Do You Want To Delete The Record?";
            // 
            // btn_Yes
            // 
            this.btn_Yes.Location = new System.Drawing.Point(101, 140);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(122, 46);
            this.btn_Yes.TabIndex = 1;
            this.btn_Yes.Text = "Yes";
            this.btn_Yes.UseVisualStyleBackColor = true;
            this.btn_Yes.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btn_no
            // 
            this.btn_no.Location = new System.Drawing.Point(280, 140);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(138, 46);
            this.btn_no.TabIndex = 2;
            this.btn_no.Text = "No";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // AlertBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 252);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_Yes);
            this.Controls.Add(this.lbl_Msg);
            this.Name = "AlertBox";
            this.Text = "AlertBox";
            this.Load += new System.EventHandler(this.AlertBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Msg;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Button btn_no;
    }
}