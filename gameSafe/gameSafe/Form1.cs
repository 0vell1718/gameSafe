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
        List<Lever> levers = new List<Lever>();
        Random rnd = new Random();
        int N;

        public Form1()
        {
            InitializeComponent();
        }

        public void AddLever()
        {
            //int r = rnd.Next(1, 3);
            Position pos = Position.Horizontal;

            //if (r == 2)
            //    pos = Position.Vertical;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(50, 10);
                    btn.Location = new Point(50 * i, 50 * j);
                    Lever lv = new Lever(btn, pos, i, j);
                    levers.Add(lv);
                    Controls.Add(btn);
                    btn.Click += new EventHandler(btnClick);
                }
            }
        }

        void btnClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            foreach (Lever item in levers)
            {
                if (item.btn == bt)
                {
                    foreach (Lever changeLever in levers)
                    {
                        if (changeLever.i == item.i || changeLever.j == item.j)
                            changeLever.changeBtn();
                    }
                    return;
                }
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                N = Convert.ToInt32(infoTbx.Text);
                if (N > 1 && N <= 10)
                {
                    Controls.Remove(infoTbx);
                    Controls.Remove(infoLbl);
                    Controls.Remove(infoBtn);

                    AddLever();
                }
                else
                    MessageBox.Show("Введите N в диапазоне от 1 до 10");
            }
            catch
            {
                MessageBox.Show("Введите целое число!");
            }          
        }


    }

    public class Lever
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
        }

        public void changeBtn()
        {
            //MessageBox.Show(i + " " + j);
            if(pos == Position.Horizontal)
            {
                btn.Size = new Size(10, 50);
                btn.Location = new Point(50 * i + 25, j * 50 - 25);
                pos = Position.Vertical;
            }
            else if(pos == Position.Vertical)
            {
                btn.Size = new Size(50, 10);
                btn.Location = new Point(50 * i, j * 50);
                pos = Position.Horizontal;
            }
        }
    }

    public enum Position
    {
        Horizontal,
        Vertical
    }
}
