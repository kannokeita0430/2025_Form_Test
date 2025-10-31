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
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;



        public Form1()
        {
            InitializeComponent();


            for (int j = 0; j < BOARD_SIZE_X ; j++)
            {
                for (int i = 0; i < BOARD_SIZE_Y ; i++)
                {
                    // インスタンスの生成
                    TestButton testButton = 
                        new TestButton( new Point(BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j),
                                        new Size(BUTTON_SIZE_X , BUTTON_SIZE_Y ), "Hello");

                    

                    // コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }

        }

        
        private void テストボタン_Click(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }
    }
}
    