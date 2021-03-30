using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public string val1 = "";//Первое число ввода
        public string val2 = "";//Второе число ввода;
        Button button;//Для ввода в метод подсчета

        
        //Метод вставляющий в конец строки число
        public void InCalc(Button button, TextBox textBox)
        {
            //Присваевам переменной длину строки
            var n = textBox.Text.Length;
            //Вводить не больше 18 символов
            if (n < 18)
            {
                //Вводим в TextBox числа согласно наименования клавиши
                textBox.Text = textBox.Text.Insert(n, button.Text);
                //ActiveControl = textBox;
            }


            //return richTextBox.Text;
        }

        // Обработчик кнопки 7 по клику
        private void Seven_Click(object sender, EventArgs e)
        {
            InCalc(Seven, this.OutCalc);//Вводим согласно метода
             
  

        }
        // Обработчик кнопки 1 по клику
        private void One_Click(object sender, EventArgs e)
        {
            InCalc(One, this.OutCalc);//Вводим согласно метода

        }
        // Обработчик кнопки 2 по клику
        private void Two_Click(object sender, EventArgs e)
        {
            InCalc(Two, this.OutCalc);//Вводим согласно метода
        }
        // Обработчик кнопки 3 по клику
        private void three_Click(object sender, EventArgs e)
        {
            InCalc(three, this.OutCalc);//Вводим согласно метода
        }
        // Обработчик кнопки 4 по клику
        private void four_Click(object sender, EventArgs e)
        {
            InCalc(four, this.OutCalc);//Вводим согласно метода
        }
        // Обработчик кнопки 5 по клику
        private void five_Click(object sender, EventArgs e)
        {
            InCalc(five, this.OutCalc);//Вводим согласно метода
        }
        // Обработчик кнопки 6 по клику
        private void Six_Click(object sender, EventArgs e)
        {
            InCalc(Six, this.OutCalc);//Вводим согласно метода
        }
        // Обработчик кнопки 8 по клику
        private void Eight_Click(object sender, EventArgs e)
        {
            InCalc(Eight, this.OutCalc);//Вводим согласно метода
        }
        // Обработчик кнопки 9 по клику
        private void Nine_Click(object sender, EventArgs e)
        {
             
            InCalc(Nine, this.OutCalc);
        }
        // Обработчик кнопки 0 по клику
        private void Zero_Click(object sender, EventArgs e)
        {
            InCalc(Zero, this.OutCalc);
        }
        // Обработчик кнопки точка по клику
        private void Point_Click(object sender, EventArgs e)
        {
            InCalc(Point, this.OutCalc);
        }
        //Обработчик кнопки стиреть
        private void ClearAll_Click(object sender, EventArgs e)
        {
            this.OutCalc.Clear();
            val1 = "";
            val2 = "";
        }

 
        private void Share_Click(object sender, EventArgs e)
        {
            val1 = this.OutCalc.Text.Trim();//Присваеваем первое значение
            button = this.Share;            //Присваеваем для метода calculator
            ClearValue.ClerText(this.OutCalc);//Очищаем TexBox
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            val1 = this.OutCalc.Text.Trim();
            button = this.Multiply;
            ClearValue.ClerText(this.OutCalc);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            val1 = this.OutCalc.Text.Trim();
            button = this.Minus;
            ClearValue.ClerText(this.OutCalc);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            val1 = this.OutCalc.Text.Trim();
            button = this.Plus;
            ClearValue.ClerText(this.OutCalc);
        }

        private void Equally_Click(object sender, EventArgs e)
        {
            if (val1 != "")
            {
                 val2 = this.OutCalc.Text.Trim();
                 ClearValue.ClerText(this.OutCalc);
                 
                 this.OutCalc.Text = Calculator.calculator(button, val1, val2);

            }

        }

        //Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Калькулятор";

            this.ActiveControl = OutCalc;
        }

        //Метод обработки ввода в TextBox только цифр
        private void OutCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
             
            //Реагирование только на цифры, запятая. 
            if (!Char.IsDigit(num) && (num != 44))
            {
               
                e.Handled = true;
            }

            //Нажатие кнопки умножения
            if (string.Compare(num.ToString(),"*") == 0)//Сравнение строки
            {
                Multiply.PerformClick();//Запускаем метод нажатия на кнопку
            }
            //Нажатие деления
            if (string.Compare(num.ToString(), "/") == 0)//Сравнение строки
            {
                Share.PerformClick();
            }
            //Нажатие вычитания
            if (string.Compare(num.ToString(), "-") == 0)//Сравнение строки
            {
                Minus.PerformClick();
            }
            //Нажатие сложения
            if (string.Compare(num.ToString(), "+") == 0)//Сравнение строки
            {
                Plus.PerformClick();
            }
            //Нажатия Enter
            if (num == 13)
            {

                Equally.PerformClick();
            }

 

        }
    }
}
