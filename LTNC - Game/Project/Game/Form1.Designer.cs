namespace Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PN_Route = new System.Windows.Forms.Panel();
            this.PB_MyCar = new System.Windows.Forms.PictureBox();
            this.PB_Car4 = new System.Windows.Forms.PictureBox();
            this.PB_Car3 = new System.Windows.Forms.PictureBox();
            this.PB_Car2 = new System.Windows.Forms.PictureBox();
            this.PB_Car1 = new System.Windows.Forms.PictureBox();
            this.PB_Coin4 = new System.Windows.Forms.PictureBox();
            this.PB_Coin3 = new System.Windows.Forms.PictureBox();
            this.PB_Coin2 = new System.Windows.Forms.PictureBox();
            this.PB_Coin1 = new System.Windows.Forms.PictureBox();
            this.PB_RoadMarking4 = new System.Windows.Forms.PictureBox();
            this.PB_RoadMarking3 = new System.Windows.Forms.PictureBox();
            this.PB_RoadMarking2 = new System.Windows.Forms.PictureBox();
            this.PB_RoadMarking1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_Scores = new System.Windows.Forms.Label();
            this.TB_TheNumberOfVehiclesDoesNotCollide = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_BatDau = new System.Windows.Forms.Button();
            this.TimerCars = new System.Windows.Forms.Timer(this.components);
            this.TimerRoadMarkings = new System.Windows.Forms.Timer(this.components);
            this.TimerCoins = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.PN_Route.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PN_Route, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PN_Route
            // 
            this.PN_Route.BackgroundImage = global::Game.Properties.Resources.Route;
            this.PN_Route.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_Route.Controls.Add(this.PB_MyCar);
            this.PN_Route.Controls.Add(this.PB_Car4);
            this.PN_Route.Controls.Add(this.PB_Car3);
            this.PN_Route.Controls.Add(this.PB_Car2);
            this.PN_Route.Controls.Add(this.PB_Car1);
            this.PN_Route.Controls.Add(this.PB_Coin4);
            this.PN_Route.Controls.Add(this.PB_Coin3);
            this.PN_Route.Controls.Add(this.PB_Coin2);
            this.PN_Route.Controls.Add(this.PB_Coin1);
            this.PN_Route.Controls.Add(this.PB_RoadMarking4);
            this.PN_Route.Controls.Add(this.PB_RoadMarking3);
            this.PN_Route.Controls.Add(this.PB_RoadMarking2);
            this.PN_Route.Controls.Add(this.PB_RoadMarking1);
            this.PN_Route.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_Route.Location = new System.Drawing.Point(20, 20);
            this.PN_Route.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Route.Name = "PN_Route";
            this.PN_Route.Size = new System.Drawing.Size(240, 290);
            this.PN_Route.TabIndex = 0;
            // 
            // PB_MyCar
            // 
            this.PB_MyCar.BackColor = System.Drawing.Color.Transparent;
            this.PB_MyCar.Image = global::Game.Properties.Resources.CarIMG;
            this.PB_MyCar.Location = new System.Drawing.Point(144, 214);
            this.PB_MyCar.Name = "PB_MyCar";
            this.PB_MyCar.Size = new System.Drawing.Size(34, 70);
            this.PB_MyCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MyCar.TabIndex = 2;
            this.PB_MyCar.TabStop = false;
            // 
            // PB_Car4
            // 
            this.PB_Car4.BackColor = System.Drawing.Color.Transparent;
            this.PB_Car4.Image = ((System.Drawing.Image)(resources.GetObject("PB_Car4.Image")));
            this.PB_Car4.Location = new System.Drawing.Point(186, 124);
            this.PB_Car4.Name = "PB_Car4";
            this.PB_Car4.Size = new System.Drawing.Size(35, 70);
            this.PB_Car4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Car4.TabIndex = 2;
            this.PB_Car4.TabStop = false;
            this.PB_Car4.Tag = "6";
            this.PB_Car4.Move += new System.EventHandler(this.PB_Car_Move);
            // 
            // PB_Car3
            // 
            this.PB_Car3.BackColor = System.Drawing.Color.Transparent;
            this.PB_Car3.Image = ((System.Drawing.Image)(resources.GetObject("PB_Car3.Image")));
            this.PB_Car3.Location = new System.Drawing.Point(144, 32);
            this.PB_Car3.Name = "PB_Car3";
            this.PB_Car3.Size = new System.Drawing.Size(35, 70);
            this.PB_Car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Car3.TabIndex = 2;
            this.PB_Car3.TabStop = false;
            this.PB_Car3.Tag = "2";
            this.PB_Car3.Move += new System.EventHandler(this.PB_Car_Move);
            // 
            // PB_Car2
            // 
            this.PB_Car2.BackColor = System.Drawing.Color.Transparent;
            this.PB_Car2.Image = ((System.Drawing.Image)(resources.GetObject("PB_Car2.Image")));
            this.PB_Car2.Location = new System.Drawing.Point(59, 92);
            this.PB_Car2.Name = "PB_Car2";
            this.PB_Car2.Size = new System.Drawing.Size(35, 70);
            this.PB_Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Car2.TabIndex = 2;
            this.PB_Car2.TabStop = false;
            this.PB_Car2.Tag = "4";
            this.PB_Car2.Move += new System.EventHandler(this.PB_Car_Move);
            // 
            // PB_Car1
            // 
            this.PB_Car1.BackColor = System.Drawing.Color.Transparent;
            this.PB_Car1.Image = ((System.Drawing.Image)(resources.GetObject("PB_Car1.Image")));
            this.PB_Car1.Location = new System.Drawing.Point(3, 20);
            this.PB_Car1.Name = "PB_Car1";
            this.PB_Car1.Size = new System.Drawing.Size(35, 70);
            this.PB_Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Car1.TabIndex = 2;
            this.PB_Car1.TabStop = false;
            this.PB_Car1.Tag = "3";
            this.PB_Car1.Move += new System.EventHandler(this.PB_Car_Move);
            // 
            // PB_Coin4
            // 
            this.PB_Coin4.BackColor = System.Drawing.Color.Transparent;
            this.PB_Coin4.Location = new System.Drawing.Point(189, 20);
            this.PB_Coin4.Name = "PB_Coin4";
            this.PB_Coin4.Size = new System.Drawing.Size(32, 32);
            this.PB_Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Coin4.TabIndex = 4;
            this.PB_Coin4.TabStop = false;
            this.PB_Coin4.Tag = "2";
            this.PB_Coin4.Visible = false;
            this.PB_Coin4.Move += new System.EventHandler(this.PB_Coin_Move);
            // 
            // PB_Coin3
            // 
            this.PB_Coin3.BackColor = System.Drawing.Color.Transparent;
            this.PB_Coin3.Location = new System.Drawing.Point(148, 139);
            this.PB_Coin3.Name = "PB_Coin3";
            this.PB_Coin3.Size = new System.Drawing.Size(32, 32);
            this.PB_Coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Coin3.TabIndex = 4;
            this.PB_Coin3.TabStop = false;
            this.PB_Coin3.Tag = "4";
            this.PB_Coin3.Visible = false;
            this.PB_Coin3.Move += new System.EventHandler(this.PB_Coin_Move);
            // 
            // PB_Coin2
            // 
            this.PB_Coin2.BackColor = System.Drawing.Color.Transparent;
            this.PB_Coin2.Location = new System.Drawing.Point(6, 121);
            this.PB_Coin2.Name = "PB_Coin2";
            this.PB_Coin2.Size = new System.Drawing.Size(32, 32);
            this.PB_Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Coin2.TabIndex = 4;
            this.PB_Coin2.TabStop = false;
            this.PB_Coin2.Tag = "2";
            this.PB_Coin2.Visible = false;
            this.PB_Coin2.Move += new System.EventHandler(this.PB_Coin_Move);
            // 
            // PB_Coin1
            // 
            this.PB_Coin1.BackColor = System.Drawing.Color.Transparent;
            this.PB_Coin1.Location = new System.Drawing.Point(62, 32);
            this.PB_Coin1.Name = "PB_Coin1";
            this.PB_Coin1.Size = new System.Drawing.Size(32, 32);
            this.PB_Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Coin1.TabIndex = 4;
            this.PB_Coin1.TabStop = false;
            this.PB_Coin1.Tag = "3";
            this.PB_Coin1.Visible = false;
            this.PB_Coin1.Move += new System.EventHandler(this.PB_Coin_Move);
            // 
            // PB_RoadMarking4
            // 
            this.PB_RoadMarking4.BackColor = System.Drawing.Color.Transparent;
            this.PB_RoadMarking4.Image = ((System.Drawing.Image)(resources.GetObject("PB_RoadMarking4.Image")));
            this.PB_RoadMarking4.Location = new System.Drawing.Point(113, 257);
            this.PB_RoadMarking4.Name = "PB_RoadMarking4";
            this.PB_RoadMarking4.Size = new System.Drawing.Size(13, 65);
            this.PB_RoadMarking4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_RoadMarking4.TabIndex = 3;
            this.PB_RoadMarking4.TabStop = false;
            this.PB_RoadMarking4.Tag = "RoadMarkings";
            // 
            // PB_RoadMarking3
            // 
            this.PB_RoadMarking3.BackColor = System.Drawing.Color.Transparent;
            this.PB_RoadMarking3.Image = ((System.Drawing.Image)(resources.GetObject("PB_RoadMarking3.Image")));
            this.PB_RoadMarking3.Location = new System.Drawing.Point(113, 173);
            this.PB_RoadMarking3.Name = "PB_RoadMarking3";
            this.PB_RoadMarking3.Size = new System.Drawing.Size(13, 65);
            this.PB_RoadMarking3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_RoadMarking3.TabIndex = 3;
            this.PB_RoadMarking3.TabStop = false;
            this.PB_RoadMarking3.Tag = "RoadMarkings";
            // 
            // PB_RoadMarking2
            // 
            this.PB_RoadMarking2.BackColor = System.Drawing.Color.Transparent;
            this.PB_RoadMarking2.Image = ((System.Drawing.Image)(resources.GetObject("PB_RoadMarking2.Image")));
            this.PB_RoadMarking2.Location = new System.Drawing.Point(113, 88);
            this.PB_RoadMarking2.Name = "PB_RoadMarking2";
            this.PB_RoadMarking2.Size = new System.Drawing.Size(13, 65);
            this.PB_RoadMarking2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_RoadMarking2.TabIndex = 3;
            this.PB_RoadMarking2.TabStop = false;
            this.PB_RoadMarking2.Tag = "RoadMarkings";
            // 
            // PB_RoadMarking1
            // 
            this.PB_RoadMarking1.BackColor = System.Drawing.Color.Transparent;
            this.PB_RoadMarking1.Image = ((System.Drawing.Image)(resources.GetObject("PB_RoadMarking1.Image")));
            this.PB_RoadMarking1.Location = new System.Drawing.Point(113, 3);
            this.PB_RoadMarking1.Name = "PB_RoadMarking1";
            this.PB_RoadMarking1.Size = new System.Drawing.Size(13, 65);
            this.PB_RoadMarking1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_RoadMarking1.TabIndex = 3;
            this.PB_RoadMarking1.TabStop = false;
            this.PB_RoadMarking1.Tag = "RoadMarkings";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TB_Scores);
            this.panel2.Controls.Add(this.TB_TheNumberOfVehiclesDoesNotCollide);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BT_BatDau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(260, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 290);
            this.panel2.TabIndex = 1;
            // 
            // TB_Scores
            // 
            this.TB_Scores.AutoSize = true;
            this.TB_Scores.Location = new System.Drawing.Point(53, 56);
            this.TB_Scores.Name = "TB_Scores";
            this.TB_Scores.Size = new System.Drawing.Size(13, 13);
            this.TB_Scores.TabIndex = 2;
            this.TB_Scores.Text = "0";
            // 
            // TB_TheNumberOfVehiclesDoesNotCollide
            // 
            this.TB_TheNumberOfVehiclesDoesNotCollide.AutoSize = true;
            this.TB_TheNumberOfVehiclesDoesNotCollide.Location = new System.Drawing.Point(106, 20);
            this.TB_TheNumberOfVehiclesDoesNotCollide.Name = "TB_TheNumberOfVehiclesDoesNotCollide";
            this.TB_TheNumberOfVehiclesDoesNotCollide.Size = new System.Drawing.Size(13, 13);
            this.TB_TheNumberOfVehiclesDoesNotCollide.TabIndex = 2;
            this.TB_TheNumberOfVehiclesDoesNotCollide.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số ô tô đã tránh:";
            // 
            // BT_BatDau
            // 
            this.BT_BatDau.Location = new System.Drawing.Point(34, 257);
            this.BT_BatDau.Name = "BT_BatDau";
            this.BT_BatDau.Size = new System.Drawing.Size(75, 23);
            this.BT_BatDau.TabIndex = 0;
            this.BT_BatDau.Text = "Bắt đầu";
            this.BT_BatDau.UseVisualStyleBackColor = true;
            this.BT_BatDau.Click += new System.EventHandler(this.BT_Start_Click);
            this.BT_BatDau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Event_KeyUp);
            // 
            // TimerCars
            // 
            this.TimerCars.Interval = 60;
            this.TimerCars.Tag = " ";
            this.TimerCars.Tick += new System.EventHandler(this.TimerCars_Tick);
            // 
            // TimerRoadMarkings
            // 
            this.TimerRoadMarkings.Interval = 50;
            this.TimerRoadMarkings.Tick += new System.EventHandler(this.TimerRoadMarkings_Tick);
            // 
            // TimerCoins
            // 
            this.TimerCoins.Interval = 50;
            this.TimerCoins.Tick += new System.EventHandler(this.TimerCoins_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 330);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(444, 369);
            this.MinimumSize = new System.Drawing.Size(444, 369);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PN_Route.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MyCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_RoadMarking1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PN_Route;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_BatDau;
        private System.Windows.Forms.Timer TimerCars;
        private System.Windows.Forms.PictureBox PB_RoadMarking4;
        private System.Windows.Forms.PictureBox PB_RoadMarking3;
        private System.Windows.Forms.PictureBox PB_RoadMarking2;
        private System.Windows.Forms.PictureBox PB_RoadMarking1;
        private System.Windows.Forms.PictureBox PB_Car4;
        private System.Windows.Forms.PictureBox PB_Car3;
        private System.Windows.Forms.PictureBox PB_Car2;
        private System.Windows.Forms.PictureBox PB_Car1;
        private System.Windows.Forms.Timer TimerRoadMarkings;
        private System.Windows.Forms.PictureBox PB_MyCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TB_Scores;
        private System.Windows.Forms.Label TB_TheNumberOfVehiclesDoesNotCollide;
        private System.Windows.Forms.PictureBox PB_Coin4;
        private System.Windows.Forms.PictureBox PB_Coin3;
        private System.Windows.Forms.PictureBox PB_Coin2;
        private System.Windows.Forms.PictureBox PB_Coin1;
        private System.Windows.Forms.Timer TimerCoins;
    }
}

