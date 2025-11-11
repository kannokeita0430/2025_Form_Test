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
        // aita様の助言アリ
        // ランダム関数
        private static Random random = new Random();
        // 論理値を格納する変数
        private bool Boolrand;


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
            // aita様の助言アリ
            // 0 or 1を返す関数を作る
            // 0 = true , 1 = false
            Boolrand = random.Next(0, 2) == 0;


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

            // Random random = new Random();
            // ()の中ランダムにできるといいね
            // aita様の助言アリ
            SetEnable(Boolrand);

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

        //  お試し2個目
        // public TestButton()
        // {
        //     Random random = new Random();
        //     SetEnable(true);
        // }
        
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


            // クリアはこの先

            // aita様の助言アリ
            // 判定の基準を保管 
            bool nandemo =  _form1.GetTestButton(0, 0)._enable;
            // 全部そろってるかどうか状態を頬間
            bool hantei = true;
            
            for( int i = 0; i < 3 ; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    if (nandemo != _form1.GetTestButton(i, j)._enable)
                    {
                        hantei = !hantei;
                        break;
                    }
            
                }
            
                if (!hantei)
                {
                    break;
                }
            }
                  
            if (hantei)
            {
                MessageBox.Show("クリア");
                Application.Exit();
            }
        }
    }
}

