namespace Bài_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ChieuCao = new System.Windows.Forms.TextBox();
            this.BT_Tinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập chiều cao của bạn";
            // 
            // TB_ChieuCao
            // 
            this.TB_ChieuCao.Location = new System.Drawing.Point(168, 48);
            this.TB_ChieuCao.Name = "TB_ChieuCao";
            this.TB_ChieuCao.Size = new System.Drawing.Size(208, 20);
            this.TB_ChieuCao.TabIndex = 1;
            // 
            // BT_Tinh
            // 
            this.BT_Tinh.Location = new System.Drawing.Point(280, 86);
            this.BT_Tinh.Name = "BT_Tinh";
            this.BT_Tinh.Size = new System.Drawing.Size(96, 23);
            this.BT_Tinh.TabIndex = 2;
            this.BT_Tinh.Text = "Tính chiều cao";
            this.BT_Tinh.UseVisualStyleBackColor = true;
            this.BT_Tinh.Click += new System.EventHandler(this.BT_Tinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 152);
            this.Controls.Add(this.BT_Tinh);
            this.Controls.Add(this.TB_ChieuCao);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bài 1: Tính chiều cao =))";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ChieuCao;
        private System.Windows.Forms.Button BT_Tinh;
    }
}

