namespace Bài_3_Delegate
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
            this.BT_KT = new System.Windows.Forms.Button();
            this.TB_So = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_So = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_KQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BT_KT
            // 
            this.BT_KT.Location = new System.Drawing.Point(267, 97);
            this.BT_KT.Name = "BT_KT";
            this.BT_KT.Size = new System.Drawing.Size(75, 23);
            this.BT_KT.TabIndex = 0;
            this.BT_KT.Text = "Kiểm tra";
            this.BT_KT.UseVisualStyleBackColor = true;
            this.BT_KT.Click += new System.EventHandler(this.BT_KT_Click);
            // 
            // TB_So
            // 
            this.TB_So.Location = new System.Drawing.Point(183, 44);
            this.TB_So.Name = "TB_So";
            this.TB_So.Size = new System.Drawing.Size(159, 20);
            this.TB_So.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số cần kiểm tra";
            // 
            // CB_So
            // 
            this.CB_So.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_So.FormattingEnabled = true;
            this.CB_So.Items.AddRange(new object[] {
            "Số chính phương",
            "Số nguyên tố",
            "Số hoàn chỉnh",
            "Số đối xứng",
            "Số Amstrong"});
            this.CB_So.Location = new System.Drawing.Point(183, 70);
            this.CB_So.Name = "CB_So";
            this.CB_So.Size = new System.Drawing.Size(159, 21);
            this.CB_So.TabIndex = 3;
            this.CB_So.SelectedIndexChanged += new System.EventHandler(this.CB_So_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn loại số cần kiểm tra";
            // 
            // LB_KQ
            // 
            this.LB_KQ.AutoSize = true;
            this.LB_KQ.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_KQ.Location = new System.Drawing.Point(54, 158);
            this.LB_KQ.Name = "LB_KQ";
            this.LB_KQ.Size = new System.Drawing.Size(120, 32);
            this.LB_KQ.TabIndex = 4;
            this.LB_KQ.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 241);
            this.Controls.Add(this.LB_KQ);
            this.Controls.Add(this.CB_So);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_So);
            this.Controls.Add(this.BT_KT);
            this.Name = "Form1";
            this.Text = "Kiểm tra số + Delegate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_KT;
        private System.Windows.Forms.TextBox TB_So;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_So;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LB_KQ;
    }
}

