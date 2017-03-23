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

        public void AddLevers()
        {
            clearLevers();

            try
            {
                N = Convert.ToInt32(infoTbx.Text);
                if (N < 2 || N > 10)
                {
                    MessageBox.Show("Введите N в диапазоне от 2 до 10");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введите целое число!");
                return;
            }

            int r = rnd.Next(1, 3);
            Position pos;
            if (r == 1)
                pos = Position.Horizontal;
            else
                pos = Position.Vertical;

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Button btn = new Button();
                    Lever lv = new Lever(btn, pos, i, j);
                    levers.Add(lv);
                    Controls.Add(btn);
                    btn.Click += new EventHandler(btnClick);
                }
            }

            сreateGameLevel();
        }

        public void clearLevers()
        {
            foreach (Lever item in levers)
            {
                Controls.Remove(item.btn);
            }
            levers.Clear();
        }

        public void сreateGameLevel()
        {
            int difficultyLevel = comboBox1.SelectedIndex + 1;
            
            for(int i=0; i < comboBox1.SelectedIndex + 1; i++)
            {
                int n = rnd.Next(0, levers.Count() + 1);
                Lever changeLever = levers[n];
                changeLever.btn.PerformClick();
            }       
        }

        public bool onePosition()
        {
            Lever lv = levers.First();
            foreach (Lever item in levers)
            {
                if (lv.pos != item.pos)
                    return false;
            }
            return true;
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
                    if (onePosition())
                        Win();
                    return;
                }
            }        
        }

        public void Win()
        {
            string message = "Поздравляем, Вы открыли сейф! Начать новую игру(OK) или выйти(Отмена)?";
            string caption = "Победа!";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                clearLevers();
                infoTbx.SelectAll();
            }
            else if(result == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            AddLevers(); 
        }
    }
}
