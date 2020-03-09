namespace Bài_2
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
            this.TB_So = new System.Windows.Forms.TextBox();
            this.BT_SCP = new System.Windows.Forms.Button();
            this.BT_SNT = new System.Windows.Forms.Button();
            this.BT_SHC = new System.Windows.Forms.Button();
            this.BT_SDX = new System.Windows.Forms.Button();
            this.LB_KQ = new System.Windows.Forms.Label();
            this.BT_SAS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số cần kiểm tra";
            // 
            // TB_So
            // 
            this.TB_So.Location = new System.Drawing.Point(163, 52);
            this.TB_So.Name = "TB_So";
            this.TB_So.Size = new System.Drawing.Size(100, 20);
            this.TB_So.TabIndex = 1;
            // 
            // BT_SCP
            // 
            this.BT_SCP.Location = new System.Drawing.Point(23, 163);
            this.BT_SCP.Name = "BT_SCP";
            this.BT_SCP.Size = new System.Drawing.Size(110, 23);
            this.BT_SCP.TabIndex = 2;
            this.BT_SCP.Text = "Số chính phương";
            this.BT_SCP.UseVisualStyleBackColor = true;
            this.BT_SCP.Click += new System.EventHandler(this.BT_SCP_Click);
            // 
            // BT_SNT
            // 
            this.BT_SNT.Location = new System.Drawing.Point(139, 163);
            this.BT_SNT.Name = "BT_SNT";
            this.BT_SNT.Size = new System.Drawing.Size(110, 23);
            this.BT_SNT.TabIndex = 3;
            this.BT_SNT.Text = " Số nguyên tố";
            this.BT_SNT.UseVisualStyleBackColor = true;
            this.BT_SNT.Click += new System.EventHandler(this.BT_SNT_Click);
            // 
            // BT_SHC
            // 
            this.BT_SHC.Location = new System.Drawing.Point(255, 163);
            this.BT_SHC.Name = "BT_SHC";
            this.BT_SHC.Size = new System.Drawing.Size(110, 23);
            this.BT_SHC.TabIndex = 4;
            this.BT_SHC.Text = " Số hoàn chỉnh";
            this.BT_SHC.UseVisualStyleBackColor = true;
            this.BT_SHC.Click += new System.EventHandler(this.BT_SHC_Click);
            // 
            // BT_SDX
            // 
            this.BT_SDX.Location = new System.Drawing.Point(371, 163);
            this.BT_SDX.Name = "BT_SDX";
            this.BT_SDX.Size = new System.Drawing.Size(110, 23);
            this.BT_SDX.TabIndex = 5;
            this.BT_SDX.Text = "Số đối xứng";
            this.BT_SDX.UseVisualStyleBackColor = true;
            this.BT_SDX.Click += new System.EventHandler(this.BT_SDX_Click);
            // 
            // LB_KQ
            // 
            this.LB_KQ.AutoSize = true;
            this.LB_KQ.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_KQ.Location = new System.Drawing.Point(37, 95);
            this.LB_KQ.Name = "LB_KQ";
            this.LB_KQ.Size = new System.Drawing.Size(179, 37);
            this.LB_KQ.TabIndex = 6;
            this.LB_KQ.Text = "Kết quả: ";
            // 
            // BT_SAS
            // 
            this.BT_SAS.Location = new System.Drawing.Point(487, 163);
            this.BT_SAS.Name = "BT_SAS";
            this.BT_SAS.Size = new System.Drawing.Size(110, 23);
            this.BT_SAS.TabIndex = 7;
            this.BT_SAS.Text = "Số Amstrong";
            this.BT_SAS.UseVisualStyleBackColor = true;
            this.BT_SAS.Click += new System.EventHandler(this.BT_SAS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 220);
            this.Controls.Add(this.BT_SAS);
            this.Controls.Add(this.LB_KQ);
            this.Controls.Add(this.BT_SDX);
            this.Controls.Add(this.BT_SHC);
            this.Controls.Add(this.BT_SNT);
            this.Controls.Add(this.BT_SCP);
            this.Controls.Add(this.TB_So);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kiểm tra số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_So;
        private System.Windows.Forms.Button BT_SCP;
        private System.Windows.Forms.Button BT_SNT;
        private System.Windows.Forms.Button BT_SHC;
        private System.Windows.Forms.Button BT_SDX;
        private System.Windows.Forms.Label LB_KQ;
        private System.Windows.Forms.Button BT_SAS;
    }
}

