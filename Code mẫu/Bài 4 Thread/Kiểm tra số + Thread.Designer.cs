namespace Bài_4_Thread
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
            this.BT_SAS = new System.Windows.Forms.Button();
            this.BT_SDX = new System.Windows.Forms.Button();
            this.BT_SHC = new System.Windows.Forms.Button();
            this.BT_SNT = new System.Windows.Forms.Button();
            this.BT_SCP = new System.Windows.Forms.Button();
            this.TB_So = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTB_SCP = new System.Windows.Forms.RichTextBox();
            this.RTB_SNT = new System.Windows.Forms.RichTextBox();
            this.RTB_SHC = new System.Windows.Forms.RichTextBox();
            this.RTB_SDX = new System.Windows.Forms.RichTextBox();
            this.RTB_SAS = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BT_SAS
            // 
            this.BT_SAS.Location = new System.Drawing.Point(523, 98);
            this.BT_SAS.Name = "BT_SAS";
            this.BT_SAS.Size = new System.Drawing.Size(110, 23);
            this.BT_SAS.TabIndex = 15;
            this.BT_SAS.Text = "Số Amstrong";
            this.BT_SAS.UseVisualStyleBackColor = true;
            this.BT_SAS.Click += new System.EventHandler(this.BT_SAS_Click);
            // 
            // BT_SDX
            // 
            this.BT_SDX.Location = new System.Drawing.Point(407, 98);
            this.BT_SDX.Name = "BT_SDX";
            this.BT_SDX.Size = new System.Drawing.Size(110, 23);
            this.BT_SDX.TabIndex = 13;
            this.BT_SDX.Text = "Số đối xứng";
            this.BT_SDX.UseVisualStyleBackColor = true;
            this.BT_SDX.Click += new System.EventHandler(this.BT_SDX_Click);
            // 
            // BT_SHC
            // 
            this.BT_SHC.Location = new System.Drawing.Point(291, 98);
            this.BT_SHC.Name = "BT_SHC";
            this.BT_SHC.Size = new System.Drawing.Size(110, 23);
            this.BT_SHC.TabIndex = 12;
            this.BT_SHC.Text = " Số hoàn chỉnh";
            this.BT_SHC.UseVisualStyleBackColor = true;
            this.BT_SHC.Click += new System.EventHandler(this.BT_SHC_Click);
            // 
            // BT_SNT
            // 
            this.BT_SNT.Location = new System.Drawing.Point(175, 98);
            this.BT_SNT.Name = "BT_SNT";
            this.BT_SNT.Size = new System.Drawing.Size(110, 23);
            this.BT_SNT.TabIndex = 11;
            this.BT_SNT.Text = " Số nguyên tố";
            this.BT_SNT.UseVisualStyleBackColor = true;
            this.BT_SNT.Click += new System.EventHandler(this.BT_SNT_Click);
            // 
            // BT_SCP
            // 
            this.BT_SCP.Location = new System.Drawing.Point(59, 98);
            this.BT_SCP.Name = "BT_SCP";
            this.BT_SCP.Size = new System.Drawing.Size(110, 23);
            this.BT_SCP.TabIndex = 10;
            this.BT_SCP.Text = "Số chính phương";
            this.BT_SCP.UseVisualStyleBackColor = true;
            this.BT_SCP.Click += new System.EventHandler(this.BT_SCP_Click);
            // 
            // TB_So
            // 
            this.TB_So.Location = new System.Drawing.Point(175, 58);
            this.TB_So.Name = "TB_So";
            this.TB_So.Size = new System.Drawing.Size(110, 20);
            this.TB_So.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập số cần kiểm tra";
            // 
            // RTB_SCP
            // 
            this.RTB_SCP.Location = new System.Drawing.Point(59, 127);
            this.RTB_SCP.Name = "RTB_SCP";
            this.RTB_SCP.Size = new System.Drawing.Size(110, 196);
            this.RTB_SCP.TabIndex = 17;
            this.RTB_SCP.Text = "";
            // 
            // RTB_SNT
            // 
            this.RTB_SNT.Location = new System.Drawing.Point(175, 127);
            this.RTB_SNT.Name = "RTB_SNT";
            this.RTB_SNT.Size = new System.Drawing.Size(110, 196);
            this.RTB_SNT.TabIndex = 17;
            this.RTB_SNT.Text = "";
            // 
            // RTB_SHC
            // 
            this.RTB_SHC.Location = new System.Drawing.Point(291, 127);
            this.RTB_SHC.Name = "RTB_SHC";
            this.RTB_SHC.Size = new System.Drawing.Size(110, 196);
            this.RTB_SHC.TabIndex = 17;
            this.RTB_SHC.Text = "";
            // 
            // RTB_SDX
            // 
            this.RTB_SDX.Location = new System.Drawing.Point(407, 127);
            this.RTB_SDX.Name = "RTB_SDX";
            this.RTB_SDX.Size = new System.Drawing.Size(110, 196);
            this.RTB_SDX.TabIndex = 17;
            this.RTB_SDX.Text = "";
            // 
            // RTB_SAS
            // 
            this.RTB_SAS.Location = new System.Drawing.Point(523, 127);
            this.RTB_SAS.Name = "RTB_SAS";
            this.RTB_SAS.Size = new System.Drawing.Size(110, 196);
            this.RTB_SAS.TabIndex = 17;
            this.RTB_SAS.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 356);
            this.Controls.Add(this.RTB_SAS);
            this.Controls.Add(this.RTB_SDX);
            this.Controls.Add(this.RTB_SHC);
            this.Controls.Add(this.RTB_SNT);
            this.Controls.Add(this.RTB_SCP);
            this.Controls.Add(this.BT_SAS);
            this.Controls.Add(this.BT_SDX);
            this.Controls.Add(this.BT_SHC);
            this.Controls.Add(this.BT_SNT);
            this.Controls.Add(this.BT_SCP);
            this.Controls.Add(this.TB_So);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kiểm tra số + Thread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_SAS;
        private System.Windows.Forms.Button BT_SDX;
        private System.Windows.Forms.Button BT_SHC;
        private System.Windows.Forms.Button BT_SNT;
        private System.Windows.Forms.Button BT_SCP;
        private System.Windows.Forms.TextBox TB_So;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RTB_SCP;
        private System.Windows.Forms.RichTextBox RTB_SNT;
        private System.Windows.Forms.RichTextBox RTB_SHC;
        private System.Windows.Forms.RichTextBox RTB_SDX;
        private System.Windows.Forms.RichTextBox RTB_SAS;
    }
}

