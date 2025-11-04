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
        /// <summary>
        /// on の時の色
        /// </summary>
        public Color _onColor = Color.Blue;

        /// <summary>
        /// off の時の色
        /// </summary>
        public Color _offColor = Color.Lavender;

        /// <summary>
        /// 現在が on か off か
        /// </summary>
        public bool _enable;

        private Form1 _form1;

        public TestButton(Form1 form1, Point position, Size size, string text)
        {
            // Form1の参照を保管
            _form1 = form1;
            Location = position;
            Size = size;
            Text = text;
            Click += ClickEvent;

            SetEnable(false);
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
        

    // 自分で作成することも可
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(1, 2).SetEnable(true);
　　    }
    }
}

