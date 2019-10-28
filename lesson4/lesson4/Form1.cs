using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            for (int i = 100; i < 1000; i++)
            {
                int flag = i;
                int sum = flag % 10;
                flag /= 10; // flag = flag / 10
                sum += flag % 10; // sum = sum + flag % 10
                sum += flag / 10;
                richTextBox1.Text += i.ToString() + "-" + sum.ToString() + "\n";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 1000; i < 4000; i++)
            {
                richTextBox1.Text += i.ToString() + "-" + (i / 100 + i % 100).ToString() + "\n";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            int a = 5;
            int[] arr = new int[10];
            arr[0] = 3;
            arr[1] = 6;
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
                richTextBox1.Text += "arr[" + i.ToString() + "]=" + arr[i].ToString() + "\n";
            }
            int[] mass = new int[13];
            Random R = new Random();
            for (int i = 0; i < 13; i++)
            {
                mass[i] = R.Next(100,1000);
                richTextBox1.Text += "mass[" + i.ToString() + "]=" + mass[i].ToString() + "\n";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Random R = new Random();
            int Count = R.Next(1, 5), SUMMA = 0;
            int[] MAS = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                MAS[i] = R.Next(-100,100);
                SUMMA += MAS[i];
                richTextBox1.Text += MAS[i].ToString() + "\n";
            }
            richTextBox1.Text += "\n" + SUMMA.ToString();

        }
    }
}
