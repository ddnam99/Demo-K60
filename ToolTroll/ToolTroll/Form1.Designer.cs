namespace ToolTroll
{
    partial class Form1
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
            this.TB_Nhap = new System.Windows.Forms.TextBox();
            this.BT_Tinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Nhap
            // 
            this.TB_Nhap.Location = new System.Drawing.Point(30, 82);
            this.TB_Nhap.Name = "TB_Nhap";
            this.TB_Nhap.Size = new System.Drawing.Size(264, 20);
            this.TB_Nhap.TabIndex = 0;
            // 
            // BT_Tinh
            // 
            this.BT_Tinh.Location = new System.Drawing.Point(300, 80);
            this.BT_Tinh.Name = "BT_Tinh";
            this.BT_Tinh.Size = new System.Drawing.Size(75, 23);
            this.BT_Tinh.TabIndex = 1;
            this.BT_Tinh.Text = "Tính";
            this.BT_Tinh.UseVisualStyleBackColor = true;
            this.BT_Tinh.Click += new System.EventHandler(this.BT_Tinh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập chiều cao của bạn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Tinh);
            this.Controls.Add(this.TB_Nhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Nhap;
        private System.Windows.Forms.Button BT_Tinh;
        private System.Windows.Forms.Label label1;
    }
}

