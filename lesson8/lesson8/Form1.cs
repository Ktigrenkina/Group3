using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson8
{
    public partial class Form1 : Form
    {
        int CountOfClicks = 0, btCount = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Random R = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 30; i++) 
            {
                list.Add(R.Next(10, 100));
                richTextBox1.Text += list[i] + " ";
            }
            int flag = list.Count; // изначально flag = 30
            for (int i = 0; i < flag; i++)
            {
                if (list[i] < 40)
                {
                    int temp = list[i];
                    list.RemoveAt(i);
                    list.Add(temp);
                    i--; flag--;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                richTextBox2.Text += list[i] + " ";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // 583; 12
            Button bt = sender as Button;
            Random R = new Random();
            int CordX = R.Next(583, 1310),
                CordY = R.Next(12, 512),
                alpha = R.Next(0, 256),
                red = R.Next(0, 256),
                green = R.Next(0, 256),
                blue = R.Next(0, 256);
            bt.Location = new Point(CordX, CordY);
            bt.BackColor = Color.FromArgb(alpha,red,green,blue);
            CountOfClicks++;
            label1.Text = "Попыток поймать кнопку: " + CountOfClicks.ToString();
            // rgb - red green blue
            // argb - alpha red green blue
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int CordX = R.Next(583, 1310),
                CordY = R.Next(12, 512),
                alpha = R.Next(0, 256),
                red = R.Next(0, 256),
                green = R.Next(0, 256),
                blue = R.Next(0, 256),
                width = R.Next(60, 181),
                height = R.Next(60, 181);
            Button bt = new Button()
            {
                Name = "button" + btCount.ToString(),
                Text = "☻",
                Size = new Size(width,height),
                Location = new Point(CordX, CordY),
                BackColor = Color.FromArgb(alpha,red,green,blue)
            };
            bt.Click += Button2_Click;
            Controls.Add(bt);
            btCount++;
        }
    }
}
