using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        // constをつけると初期化時にのみ値の変更が可能になる
        
        /// <summary>
        /// ボタンの横幅
        /// </summary>
        const int BUTTON_SIZE_X = 100;
        /// <summary>
        /// ボタンの縦幅
        /// </summary>
        const int BUTTON_SIZE_Y = 100;

        /// <summary>
        /// 横に何個か
        /// </summary>
        const int BOARD_SIZE_X = 3;
        /// <summary>
        /// 縦に何個か
        /// </summary>
        const int BOARD_SIZE_Y = 3;

        /// <summary>
        /// TestButton の2次元配列
        /// </summary>
        private TestButton[,] _buttonArray;


        public Form1()
        {
            InitializeComponent();
            _buttonArray = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int j = 0; j < BOARD_SIZE_X ; j++)
            {
                for (int i = 0; i < BOARD_SIZE_Y ; i++)
                {
                    // インスタンスの生成
                    TestButton testButton = 
                        new TestButton (
                        this,
                        new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j),
                         new Size(BUTTON_SIZE_X , BUTTON_SIZE_Y ), "Hello");


                    // 配列にボタンの参照の追加
                    _buttonArray[j, i] = testButton;

                    // コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }

           
        }

        
        public TestButton GetTestButton(int x,int y)
        {
            return _buttonArray[y, x];
        }


        private void テストボタン_Click(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }
    }
}
    