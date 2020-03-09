namespace Bài_6_Kết_nối_CSDL__SQL_
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
            this.DGV = new System.Windows.Forms.DataGridView();
            this.TB_MaSP = new System.Windows.Forms.TextBox();
            this.TB_TenSP = new System.Windows.Forms.TextBox();
            this.TB_DonGia = new System.Windows.Forms.TextBox();
            this.CB_XuatSu = new System.Windows.Forms.ComboBox();
            this.NUD_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BT_Them = new System.Windows.Forms.Button();
            this.BT_Sua = new System.Windows.Forms.Button();
            this.BT_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(37, 236);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersWidth = 20;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(766, 237);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // TB_MaSP
            // 
            this.TB_MaSP.Location = new System.Drawing.Point(203, 33);
            this.TB_MaSP.Name = "TB_MaSP";
            this.TB_MaSP.Size = new System.Drawing.Size(147, 20);
            this.TB_MaSP.TabIndex = 1;
            // 
            // TB_TenSP
            // 
            this.TB_TenSP.Location = new System.Drawing.Point(203, 59);
            this.TB_TenSP.Name = "TB_TenSP";
            this.TB_TenSP.Size = new System.Drawing.Size(147, 20);
            this.TB_TenSP.TabIndex = 2;
            // 
            // TB_DonGia
            // 
            this.TB_DonGia.Location = new System.Drawing.Point(203, 112);
            this.TB_DonGia.Name = "TB_DonGia";
            this.TB_DonGia.Size = new System.Drawing.Size(147, 20);
            this.TB_DonGia.TabIndex = 3;
            // 
            // CB_XuatSu
            // 
            this.CB_XuatSu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_XuatSu.FormattingEnabled = true;
            this.CB_XuatSu.Items.AddRange(new object[] {
            "Việt Nam",
            "Trung Quốc",
            "Mỹ",
            "Hàn Quốc"});
            this.CB_XuatSu.Location = new System.Drawing.Point(203, 85);
            this.CB_XuatSu.Name = "CB_XuatSu";
            this.CB_XuatSu.Size = new System.Drawing.Size(147, 21);
            this.CB_XuatSu.TabIndex = 4;
            // 
            // NUD_SoLuong
            // 
            this.NUD_SoLuong.Location = new System.Drawing.Point(203, 139);
            this.NUD_SoLuong.Name = "NUD_SoLuong";
            this.NUD_SoLuong.Size = new System.Drawing.Size(147, 20);
            this.NUD_SoLuong.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Xuất sứ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số lượng";
            // 
            // BT_Them
            // 
            this.BT_Them.Location = new System.Drawing.Point(113, 182);
            this.BT_Them.Name = "BT_Them";
            this.BT_Them.Size = new System.Drawing.Size(75, 23);
            this.BT_Them.TabIndex = 7;
            this.BT_Them.Text = "Thêm";
            this.BT_Them.UseVisualStyleBackColor = true;
            this.BT_Them.Click += new System.EventHandler(this.BT_Them_Click);
            // 
            // BT_Sua
            // 
            this.BT_Sua.Location = new System.Drawing.Point(194, 182);
            this.BT_Sua.Name = "BT_Sua";
            this.BT_Sua.Size = new System.Drawing.Size(75, 23);
            this.BT_Sua.TabIndex = 7;
            this.BT_Sua.Text = "Sửa";
            this.BT_Sua.UseVisualStyleBackColor = true;
            this.BT_Sua.Click += new System.EventHandler(this.BT_Sua_Click);
            // 
            // BT_Xoa
            // 
            this.BT_Xoa.Location = new System.Drawing.Point(275, 182);
            this.BT_Xoa.Name = "BT_Xoa";
            this.BT_Xoa.Size = new System.Drawing.Size(75, 23);
            this.BT_Xoa.TabIndex = 7;
            this.BT_Xoa.Text = "Xóa";
            this.BT_Xoa.UseVisualStyleBackColor = true;
            this.BT_Xoa.Click += new System.EventHandler(this.BT_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 500);
            this.Controls.Add(this.BT_Xoa);
            this.Controls.Add(this.BT_Sua);
            this.Controls.Add(this.BT_Them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_SoLuong);
            this.Controls.Add(this.CB_XuatSu);
            this.Controls.Add(this.TB_DonGia);
            this.Controls.Add(this.TB_TenSP);
            this.Controls.Add(this.TB_MaSP);
            this.Controls.Add(this.DGV);
            this.Name = "Form1";
            this.Text = "Quản lý điện thoại + SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox TB_MaSP;
        private System.Windows.Forms.TextBox TB_TenSP;
        private System.Windows.Forms.TextBox TB_DonGia;
        private System.Windows.Forms.ComboBox CB_XuatSu;
        private System.Windows.Forms.NumericUpDown NUD_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BT_Them;
        private System.Windows.Forms.Button BT_Sua;
        private System.Windows.Forms.Button BT_Xoa;
    }
}

