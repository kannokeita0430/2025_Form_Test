using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    // 
    // 
    internal class TestButton : Button
    {

        public TestButton(Point position, Size size, string text)
        {
            Location = position;
            Size = size;
            Text = text;
            Click += ClickEvent;

        }


    // 自分で作成することも可
        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("ゆっくりしていってね");
        }
    }
}
