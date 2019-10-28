using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7
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
            Random rand = new Random();
            int[,] arr = new int[5, 5]; // создаем двумерный массив 5x5
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rand.Next(10, 100);
                    richTextBox1.Text += arr[i,j] + " ";
                }
                richTextBox1.Text += "\n";
            }
            int summa = 0, flag = 4;
            for (int i = 0; i < 5; i++)
            {
                summa += arr[i, i];
            }
            richTextBox1.Text += "Сумма элементов левой диагонали равна " + summa;
            summa = 0;
            for (int i = 0; i < 5; i++)
            {
                summa += arr[i,flag];
                flag--;
            }
            richTextBox1.Text += "\nСумма элементов правой диагонали равна " + summa;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.Length.ToString(); // .Length - длина строки
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.Substring(0,3); 
            // обрезаем строку. 2 перегрузки:
            // 1) 1 параметр. От данной позиции до конца строки
            // 2) 2 параметра. От какой позиции и до какой позициии обрезаем
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            //textBox2.Text = str.TrimStart(' ');  // указываем символ, удялаем все данные символы в начале строки
            //textBox2.Text = str.TrimEnd(' '); // указываем символ, удялаем все данные символы в конце строки
            textBox2.Text = str.Trim(' '); // указываем символ, удялаем все данные символы в начале и конце строки
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.Replace('т', 'ы'); // заменяем один символ на другой
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.ToLower().Replace("я ем","ты ешь"); // заменяем какую-то последовательность букв другой
            // Если хотим удалить пробелы во всей строке, то .Replace(" ","");
            // ToLower() - в нижний регистр
            // ToUpper() - в верхний регистр
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.Text = str.Remove(2,3); // Вырезаем из строки
            // 2 перегрузки
            // 1) 1 параметр. От данной позиции до конца строки
            // 2) 2 параметр. От какой позиции и до какой позициии вырезаем
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            // из "Я ем спрагетти" получить "Я спагетти"
            // использовать только Substring
            string str = textBox1.Text;
            textBox2.Text = str.Substring(0,2) + str.Substring(5);
            // первым сабстрингом получили "Я ", вторым сабстрингом получили "спагетти". Сложили это
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            string str = "Красноперов;Илья;Александрович;м;24.04.97";
            string[] AboutPerson = str.Split(';'); // разбить строку по указанному символу и записать это в массив
            // указываться может любой символ
            // массив станет такой размерностью, сколько элементов в него запишется
            // размерность - кол-во элементов в массиве
            List<string> list = new List<string>(); // создаем Лист
            list.Add("Красноперов"); // добавление элементов в лист
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Random rand = new Random();
            List<int> list = new List<int>(); // создаем Лист целых чисел
            int LCount = rand.Next(1, 20); // переменная будет отвечать за кол-во элементов в листе
            for (int i = 0; i < LCount; i++)
            {
                list.Add(rand.Next(10,100));  // добавляем элемент в лист с рандомным значением
                richTextBox1.Text += list[i].ToString() + " "; // выводим в rtb1
            }
            //list.RemoveAt(0); // Удаление элемента с нужным индексом
            richTextBox1.Text += "\n";
            for (int i = 0; i < list.Count; i++) //почему используем list.Count а не переменную LCount
                // представим что элементов в листе 10, последний индекс будет 9
                // если мы удалим 3 элемента, их в листе станет 7, последний индекс будет равен 6
                // используя переменную LCount мы бы обращались и к 7 и к 8 и к 9  индексам, которых уже не существует
                // list.Count возвращает нам всегда актуальное значение кол-ва элементов в листе
            {
                if (list[i] > 50)
                {
                    list.RemoveAt(i); // Удаление элемента с нужным индексом
                    i--; // возможно помните с занятия для чего эта строчка
                    // удалили элемент с индексом 0
                    // весь массив сдвинулся на 1 в лево
                    // теперь есть другой элемент с индексом 0, который тоже нужно проверить, 
                    // но мы в цикле увеличивали i, тем самым пропускали элементы
                }
            }
            for (int i = 0; i < list.Count; i++) // запомните, данный цикл вам выводит все элементы листа
            {
                richTextBox1.Text += list[i].ToString() + " ";
            }
            
        }
    }
}
