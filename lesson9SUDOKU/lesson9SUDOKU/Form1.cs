using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson9SUDOKU
{
    public partial class Form1 : Form
    {
        TextBox tb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // size 50 56
            // start loc 13 13
            // x на 56
            // y на 62
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int IndexOfTb = 0, y = 17;

            for (int i = 0; i < 9; i++)
            {
                int x = 16;
                for (int j = 0; j < 9; j++)
                {
                    tb = new TextBox()
                    {
                        Name = "textBox" + IndexOfTb,
                        Size = new Size(51, 51),
                        Location = new Point(x, y),
                        TextAlign = HorizontalAlignment.Center,
                        Multiline = true,
                        BorderStyle = BorderStyle.None,
                        Font = new Font("Microsoft Sans Serif",32)
                        //Text = "textBox" + IndexOfTb
                    };
                    tb.TextChanged += tb_TextChanged;
                    tb.KeyPress += tb_KeyPress;
                    Controls.Add(tb);
                    IndexOfTb++;
                    if ((j + 1) % 3 == 0)
                        x += 57;
                    else
                        x += 53;
                }
                if ((i + 1) % 3 == 0)
                    y += 56;
                else
                    y += 53;
            }
            pictureBox1.SendToBack();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            tb = sender as TextBox;
            if (tb.Text.Length > 1)
            {
                tb.Text = tb.Text.Substring(0, 1);
            }
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
