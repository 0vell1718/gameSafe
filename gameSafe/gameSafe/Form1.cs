using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameSafe
{
    public partial class Form1 : Form
    {
        List<Lever> levers;
        int N;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            levers = new List<Lever>();
        }

        public void AddLever()
        {
            int r = rnd.Next(1, 3);
            Position pos = Position.Horizontal;

            if (r == 2)
                pos = Position.Vertical;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 10);
                    btn.Location = new Point(50 * i, 50 * j);
                    Controls.Add(btn);
                    levers.Add(new Lever(btn, pos));
                }
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt32(infoTbx.Text);
                Controls.Remove(infoTbx);
                Controls.Remove(infoLbl);
                Controls.Remove(infoBtn);
                AddLever();
            }
            catch
            {
                MessageBox.Show("Введите целое значение!");
            }          
        }
    }

    public class Lever
    {
        Button btn;
        Position pos;

        public Lever(Button btn, Position pos)
        {
            this.btn = btn;
            this.pos = pos;
        }
    }

    public enum Position
    {
        Horizontal,
        Vertical
    }
}
