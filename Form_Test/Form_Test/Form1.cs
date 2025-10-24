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
        public Form1()
        {
            InitializeComponent();


            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 6; i++)
                {
                    // インスタンスの生成
                    TestButton testButton = new TestButton();

                    // ボタンの位置を設定
                    testButton.Location = new Point(50 * i, 50 * j);

                    // ボタンの大きさを設定
                    testButton.Size = new Size(50, 50);

                    // ボタン内のテキスト設定
                    testButton.Text = "";

                    // Clicl Event にhogehogeClick関数を追加
                    testButton.MouseHover += hogehogeClick;

                    // コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }

        }

        // 自分で作成することも可
        private void hogehogeClick(object sender, EventArgs e)
        {
            MessageBox.Show("ゆっくりしていってね");
        }
        private void テストボタン_Click(object sender, EventArgs e)
        {
            MessageBox.Show("こんにちは");
        }
    }
}
    