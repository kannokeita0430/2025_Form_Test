using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public class TestButton : Button
    {
        /// <summary>on の時の色</summary>
        public Color _onColor = Color.Blue;

        /// <summary>off の時の色</summary>
        public Color _offColor = Color.Lavender;

        /// <summary>現在が on か off か</summary>
        public bool _enable;

        // Form1 の参照
        private Form1 _form1;

        // 横位置
        private int _x;

        // 縦位置
        private int _y;


        public TestButton(Form1 form1, int x, int y, Size size, string text)
        {
            // Form1の参照を保管
            _form1 = form1;

            // 横位置を保管
            _x = x;

            // 縦位置を保管
            _y = y;

            Location = new Point(x * size.Width, y * size.Height);

            // ボタンの大きさ
            Size = size;

            // ボタン内のテキスト
            Text = text;

            SetEnable(false);

            Click += ClickEvent;

        }

        /// <summary>
        /// onとoffの設定
        /// </summary>
        /// <param name="on"></param>
        public void SetEnable(bool on)
        {
            _enable = on;

            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }

        }

        // ランダムで初めにonになってるのをつくる
        Random random = new random(testButton[0,0]);


        public void Toggle()
        {
            SetEnable(!_enable);
        }

        /// <summary>
        /// 各ボタンがクリックされたときに呼び出される関数
        /// クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickEvent(object sender, EventArgs e)
        {
            // 楽な書き方
            _form1.GetTestButton(_x, _y)?.Toggle();
            _form1.GetTestButton(_x + 1, _y)?.Toggle();
            _form1.GetTestButton(_x - 1, _y)?.Toggle();
            _form1.GetTestButton(_x, _y + 1)?.Toggle();
            _form1.GetTestButton(_x, _y - 1)?.Toggle();

        }

    }
}

