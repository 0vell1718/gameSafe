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
        int width;
        int height;
        int padding;

        public Lever(Button btn, int width, int height, int padding, Position pos, int i, int j)
        {
            this.btn = btn;
            this.width = width;
            this.height = height;
            this.padding = padding;
            this.pos = pos;
            this.i = i;
            this.j = j;
            btnSize();
        }

        private void btnSize()
        {
            if (pos == Position.Horizontal)
            {
                btn.Size = new Size(width, height);

                btn.Location = new Point(width * i + padding, j * width + padding);
            }
            else if (pos == Position.Vertical)
            {
                btn.Size = new Size(height, width);
                btn.Location = new Point(width * i + padding + (width - padding) / 2, j * width + padding - (width - padding) / 2);
            }
        }

        public void changeBtn()
        {
            if (pos == Position.Horizontal)
            {
                btn.Size = new Size(height, width);
                btn.Location = new Point(width * i + padding + (width - padding) / 2, j * width + padding - (width - padding) / 2);
                pos = Position.Vertical;
            }
            else if (pos == Position.Vertical)
            {
                btn.Size = new Size(width, height);
                btn.Location = new Point(width * i + padding, j * width + padding);
                pos = Position.Horizontal;
            }
        }
    }
}
