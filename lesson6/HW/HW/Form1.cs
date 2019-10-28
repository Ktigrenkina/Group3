using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class Form1 : Form
    {
        int[,] mass;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Random random = new Random();
            mass = new int[5,3];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mass[i,j] = random.Next(1,100);
                    richTextBox1.Text += mass[i, j].ToString() + "   ";
                }
                richTextBox1.Text += "\n";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int summa = 0, max = 1, flag = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    summa += mass[i, j];
                }
                if (summa > max)
                {
                    max = summa;
                    flag = i;
                }
                summa = 0;
            }
            // Максимальная сумма элементов находится в ??? строке
            // 25 13 67
            richTextBox2.Text = "Максимальная сумма элементов находится в " + (flag + 1).ToString() + " строке\n";
            for (int j = 0; j < 3; j++)
            {
                richTextBox2.Text += mass[flag, j].ToString() + "   ";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int summa = 0, max = 1, flag = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    summa += mass[j, i];
                }
                if (summa > max)
                {
                    max = summa;
                    flag = i;
                }
                summa = 0;
            }
            richTextBox3.Text = "Максимальная сумма элементов находится в " + (flag + 1).ToString() + " строке\n";
            for (int j = 0; j < 5; j++)
            {
                richTextBox3.Text += mass[j, flag].ToString() + "\n";
            }
        }
    }
}
