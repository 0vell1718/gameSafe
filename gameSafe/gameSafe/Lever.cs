using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameSafe
{
    class Lever
    {
        public Button btn;
        public Position pos;
        public int i;
        public int j;

        public Lever(Button btn, Position pos, int i, int j)
        {
            this.btn = btn;
            this.pos = pos;
            this.i = i;
            this.j = j;
            btnSize();
        }

        private void btnSize()
        {
            if (pos == Position.Horizontal)
            {
                btn.Size = new Size(50, 10);
                btn.Location = new Point(50 * i, j * 50);
            }
            else if (pos == Position.Vertical)
            {
                btn.Size = new Size(10, 50);
                btn.Location = new Point(50 * i + 25, j * 50 - 25);
            }
        }

        public void changeBtn()
        {
            //MessageBox.Show(i + " " + j);
            if (pos == Position.Horizontal)
            {
                btn.Size = new Size(10, 50);
                btn.Location = new Point(50 * i + 25, j * 50 - 25);
                pos = Position.Vertical;
            }
            else if (pos == Position.Vertical)
            {
                btn.Size = new Size(50, 10);
                btn.Location = new Point(50 * i, j * 50);
                pos = Position.Horizontal;
            }
        }
    }
}
