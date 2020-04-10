using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Keyboard
{
    public partial class Form1 : Form
    {
        //Tạo Dictionary (Từ điển) lưu Key tương ứng với Button nào để dễ dang truy xuất button khi nhấn phím
        private Dictionary<Keys, Button> KeysDict = new Dictionary<Keys, Button>();

        public Form1()
        {
            InitializeComponent();

            var keysConverter = new KeysConverter();
            foreach (var i in Controls)
                if (i is Button)
                {
                    // Mặc định i là dạng Control vì vậy ta cần ép kiểu i về Button để dễ xử lý hơn
                    var button = i as Button;
                    // Thêm (Key, Value) vào Dictionary
                    KeysDict.Add((Keys)keysConverter.ConvertFrom(button.Text), button);
                }
        }

        #region Key Event
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra phím vừa nhấn có trong Dictionary không
            if (KeysDict.ContainsKey(e.KeyCode))
            {
                // Lấy Button ra bằng cách tra KeyCode trong Dictionary
                var button = KeysDict[e.KeyCode];

                button.BackColor = Color.Orange;
                Button_Click(button, e);
            }

            if (e.KeyCode == Keys.Space) e.Handled = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeysDict.ContainsKey(e.KeyCode))
            {
                var button = KeysDict[e.KeyCode];

                button.BackColor = Color.Empty;
            }
        }
        #endregion

        #region Mouse Event
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;

            button.BackColor = Color.Green;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;

            button.BackColor = Color.Empty;
        }
        #endregion

        private void Button_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            switch (button.Text)
            {
                case "Back":
                    if (!string.IsNullOrEmpty(textbox.Text))
                        textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
                    break;
                case "Space":
                    textbox.Text += " ";
                    break;
                default:
                    textbox.Text += button.Text;
                    break;
            }
        }
    }
}