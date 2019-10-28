using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdProgramm
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
            for (int i = 0; i < 5; i++) // начальное значение; до какого крутим; как увеличиваем;
            {
                richTextBox1.Text += i.ToString() + " ";
            }
            richTextBox1.Text += "\n";
            int j = 0;
            while (j < 5) // пока условие выполняется
            {
                richTextBox1.Text += j.ToString() + " ";
                j++;
            }
            richTextBox1.Text += "\n";
            j = 0;
            do
            {
                richTextBox1.Text += j.ToString() + " ";
                j++;
            }
            while (j < 5);
            richTextBox1.Text += "\n";
            int left = Convert.ToInt32(textBox1.Text),
                right = Convert.ToInt32(textBox2.Text),
                akrobat;
            for (int i = left; i < right; i++)
            {
                akrobat = i % 3;
                if (akrobat == 0)
                {
                    richTextBox1.Text += i.ToString() + ",";
                }
            }
            int summ = 0;
            for(int i = 2; i < 1001; i+=2)
            {
                summ += i;
            }
            richTextBox1.Text = summ.ToString();
        }
    }
}
