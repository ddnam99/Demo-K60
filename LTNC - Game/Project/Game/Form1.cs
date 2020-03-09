using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Cars = new[] { PB_Car1, PB_Car2, PB_Car3, PB_Car4 };

            Coins = new[] { PB_Coin1, PB_Coin2, PB_Coin3, PB_Coin4 };

            RoadMarkings = new[] { PB_RoadMarking1, PB_RoadMarking2, PB_RoadMarking3, PB_RoadMarking4 };
        }

        private Random Rand = new Random();

        private Image[] CarImages = { Properties.Resources.CarIMG1, Properties.Resources.CarIMG2, Properties.Resources.CarIMG3 };
        private PictureBox[] Cars, Coins, RoadMarkings;
        private int RouteHeight = 290, RouteWidth = 240;
        private int MovingDistance = 15;

        private Image RandomCarImage() => CarImages[Rand.Next(CarImages.Length)];

        private void BT_Start_Click(object sender, EventArgs e)
        {
            TimerRoadMarkings.Start();
            TimerCars.Start();
            TimerCoins.Start();
        }

        private void ResetGame()
        {
            PB_MyCar.Location = new Point() { X = PB_MyCar.Location.X, Y = 210 };
            foreach (var i in Coins)
                i.Visible = false;

            foreach (var i in Cars)
                i.Location = new Point() { X = i.Location.X, Y = i.Location.Y - 140 };

            TB_TheNumberOfVehiclesDoesNotCollide.Text = "0";
            TB_Scores.Text = "0";
        }

        /// <summary>
        /// Di chuyển các xe chạy ngược chiều. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCars_Tick(object sender, EventArgs e)
        {
            foreach (var i in Cars)
            {
                var TocDo = Convert.ToInt32(i.Tag);
                i.Location = new Point() { X = i.Location.X, Y = i.Location.Y + TocDo };

                if (i.Location.Y >= (PN_Route.Location.Y + RouteHeight))
                {
                    i.Location = new Point() { X = i.Location.X, Y = PN_Route.Location.Y - i.Size.Height };

                    if ((Rand.Next(100) % 3) == 1) i.Visible = false;
                    else
                    {
                        i.Tag = (Rand.Next(5) + 3);
                        i.Image = RandomCarImage();
                        i.Visible = true;
                    }

                    TB_TheNumberOfVehiclesDoesNotCollide.Text = (Convert.ToInt32(TB_TheNumberOfVehiclesDoesNotCollide.Text) + 1).ToString();
                }
            }
        }

        /// <summary>
        /// Di chuyển vạch kẻ đường.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerRoadMarkings_Tick(object sender, EventArgs e)
        {
            foreach (var i in RoadMarkings)
            {
                i.Location = new Point() { X = i.Location.X, Y = i.Location.Y + 2 };
                if (i.Location.Y >= (PN_Route.Location.Y + RouteHeight))
                    i.Location = new Point() { X = i.Location.X, Y = PN_Route.Location.Y - i.Size.Height };
            }
        }

        /// <summary>
        /// Di chuyển coins.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCoins_Tick(object sender, EventArgs e)
        {
            foreach (var i in Coins)
            {
                var TocDo = Convert.ToInt32(i.Tag);
                i.Location = new Point() { X = i.Location.X, Y = i.Location.Y + TocDo };

                if (i.Location.Y >= (PN_Route.Location.Y + RouteHeight))
                {
                    i.Tag = (Rand.Next(5) + 3);
                    i.Visible = (Rand.Next(100) % 3 == 1);
                    i.Image = i.Visible ? Properties.Resources.Coin : null;
                    i.Location = new Point() { X = i.Location.X, Y = PN_Route.Location.Y - i.Size.Height };
                }
            }
        }

        private void PB_Coin_Move(object sender, EventArgs e)
        {
            PictureBox PB_Coin = sender as PictureBox;

            if (CheckCollide(PB_Coin, PB_MyCar))
            {
                PB_Coin.Visible = false;
                if (PB_Coin.Image != null) TB_Scores.Text = (Convert.ToInt32(TB_Scores.Text) + 1).ToString();
            }
        }

        private void PB_Car_Move(object sender, EventArgs e)
        {
            PictureBox PB_Car = sender as PictureBox;

            if (CheckCollide(PB_MyCar, PB_Car))
            {
                TimerCars.Stop();
                TimerCoins.Stop();
                TimerRoadMarkings.Stop();

                if (MessageBox.Show(String.Format("Số ô tô đã tránh: {0}\nĐiểm: {1}", TB_TheNumberOfVehiclesDoesNotCollide.Text, TB_Scores.Text), "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    ResetGame();
            }
        }

        /// <summary>
        /// Kiểm tra Item có va chạm với Control hay không.
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        private bool CheckCollide(Control control, Control Item)
        {
            if (Item.Visible)
            {
                Point[] TheCornersOfControl = GetTheCornersOfItem(control),
                    TheCornersOfItem = GetTheCornersOfItem(Item);

                foreach (var i in TheCornersOfControl)
                    if (TheCornersOfItem[0].X < i.X && i.X < TheCornersOfItem[3].X)
                        if (TheCornersOfItem[0].Y < i.Y && i.Y < TheCornersOfItem[3].Y)
                            return true;
            }

            return false;
        }

        /// <summary>
        /// Lấy tọa độ các góc của xe. Thứ tự: Đầu xe trái, đầu xe phải, đuôi xe trái, đuôi xe phải.
        /// </summary>
        /// <param name="Item"></param>
        /// <returns></returns>
        private Point[] GetTheCornersOfItem(Control Item)
        {
            return new[]
            {
                new Point()
                {
                    X = Item.Location.X,
                    Y = Item.Location.Y
                },
                new Point()
                {
                    X = Item.Location.X + Item.Size.Width,
                    Y = Item.Location.Y
                },
                new Point()
                {
                    X = Item.Location.X,
                    Y = Item.Location.Y + Item.Size.Height
                },
                new Point()
                {
                    X = Item.Location.X + Item.Size.Width,
                    Y = Item.Location.Y + Item.Size.Height
                }
            };
        }

        /// <summary>
        /// Bắt sự kiện người dùng nhấn phím điều hướng để di chuyển MyCar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Event_KeyUp(object sender, KeyEventArgs e)
        {
            Point[] TheCornersOfMyCar = GetTheCornersOfItem(PB_MyCar);

            if (e.KeyCode == Keys.Left)
            {
                if (TheCornersOfMyCar[0].X - MovingDistance > PN_Route.Location.X)
                    PB_MyCar.Location = new Point() { X = PB_MyCar.Location.X - MovingDistance, Y = PB_MyCar.Location.Y };
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (TheCornersOfMyCar[1].X + MovingDistance < PN_Route.Location.X + RouteWidth)
                    PB_MyCar.Location = new Point() { X = PB_MyCar.Location.X + MovingDistance, Y = PB_MyCar.Location.Y };
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (TheCornersOfMyCar[0].Y - MovingDistance > PN_Route.Location.Y)
                    PB_MyCar.Location = new Point() { X = PB_MyCar.Location.X, Y = PB_MyCar.Location.Y - MovingDistance };
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (TheCornersOfMyCar[2].Y + MovingDistance < PN_Route.Location.Y + RouteHeight)
                    PB_MyCar.Location = new Point() { X = PB_MyCar.Location.X, Y = PB_MyCar.Location.Y + MovingDistance };
            }
        }
    }
}