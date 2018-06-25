using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab1
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Экземпляр класса эмулирующего  работу калькулятора
        /// </summary>
        Calc Device = new Calc();
        /// <summary>
        /// Переменная, хранящая номер операции
        /// </summary>
        public int operation = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
        /// <summary>
        /// Обработчик щёлчка по кнопке суммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Adding_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                if (textBox1.Text != "")
                {
                    Device.st_op1 = textBox1.Text;
                    if (Device.check1())
                    {
                        operation = 1;
                    }
                    else
                    {
                        Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                        Device.st_op1 = "";
                    }
                    textBox1.Text = "";

                }
                else
                    Error.Text = "Введите первое число!";
                textBox1.Focus();
            }
            else
            {
                Error.Text = "Операция уже выбранная!";
                textBox1.Focus();
            }


        }

        /// <summary>
        /// Обработчик щелчка по кнопке результата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Result_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Device.st_op2 = textBox1.Text;
                if (Device.check2())
                {
                    switch (operation)
                    {
                        case 0:
                            {
                                Error.Text = "Выберите операцию!!"; break;
                            }
                        case 1:
                            {
                                Device.Add();
                                operation = 0;
                                string tmp = Device.result.ToString("G4").Replace(',', '.');
                                textBox1.Text = tmp; break;
                            }
                        case 2:
                            {
                                Device.Sub();
                                operation = 0;
                                string tmp = Device.result.ToString("G4").Replace(',', '.');
                                textBox1.Text = tmp; break;
                            }
                        case 3:
                            {
                                Device.Mul();
                                operation = 0;
                                string tmp = Device.result.ToString("G4").Replace(',', '.');
                                textBox1.Text = tmp; break;
                            }
                        case 4:
                            {
                                operation = 0;
                                if (Device.Div())
                                {
                                    string tmp = Device.result.ToString("G4").Replace(',', '.');
                                    textBox1.Text = tmp; break;
                                }
                                else
                                {
                                    Error.Text = "Попытка деления на ноль!!!"; break;
                                }
                            }


                    }
                }
                else 
                {
                    Device.st_op2 = "";
                    Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            else
                Error.Text = "Введите второе число!";
        }

    
        /// <summary>
        /// Обработчик события щелчка по кнопке Вычитания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sub_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                if (textBox1.Text != "")
                {
                    Device.st_op1 = textBox1.Text;
                    if (Device.check1())
                    {
                        operation = 2;
                    }
                    else
                    {
                        Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                        Device.st_op1 = "";
                    }
                    textBox1.Text = "";

                }
                else
                    Error.Text = "Введите первое число!";
                textBox1.Focus();
            }
            else 
            {
                Error.Text = "Операция уже выбранная!";
                textBox1.Focus();
            }
        }
        /// <summary>
        /// Обработчик события щелчка по кнопке Умножения 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mul_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                if (textBox1.Text != "")
                {
                    Device.st_op1 = textBox1.Text;
                    if (Device.check1())
                    {
                        operation = 3;
                    }
                    else
                    {
                        Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                        Device.st_op1 = "";
                    }
                    textBox1.Text = "";

                }
                else
                    Error.Text = "Введите первое число!";
                textBox1.Focus();
            }
            else 
            {
                Error.Text = "Операция уже выбранная!";
                textBox1.Focus();
            }
        }
        /// <summary>
        /// Обработчик первого появления формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
        /// <summary>
        /// Обработчик события щелчка по кнопке деления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Divine_Click(object sender, EventArgs e)
        {
            if (operation == 0)
            {
                if (textBox1.Text != "")
                {
                    Device.st_op1 = textBox1.Text;
                    if (Device.check1())
                    {
                        operation = 4;
                    }
                    else
                    {
                        Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                        Device.st_op1 = "";
                    }
                    textBox1.Text = "";

                }
                else
                    Error.Text = "Введите первое число!";
                textBox1.Focus();
            }
            else 
            {
                Error.Text = "Операция уже выбранная!";
                textBox1.Focus();
            }

        }
        /// <summary>
        /// Обработчик, контролирующий работу клавиши Delete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                textBox1.Text = "";
            }
        }
        /// <summary>
        /// Обработчик, контролирующий ввод данных с клавиатуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Error.Text = "";
            string pattern2  = @"^[\+-]?\d{1,9}.?\d{0,5}[eE][\+-]?\d{1,2}$";
            string pattern = @"^[\+-]{0,1}[0-9]*(\d[.]){0,1}[0-9]{0,5}$";
            if (e.KeyChar == (char)Keys.Back)
            {
                if(Regex.IsMatch(textBox1.Text, pattern2))
                {
                    Error.Text = "Этот формат не для форматирования!!!";
                    e.KeyChar = (char)Keys.None;
                }
                else
                {
                        if ( textBox1.SelectionStart>1)
                        {
                         textBox1.Select(textBox1.SelectionStart, 0);
                        }
                }
            }
            else
            {
                string number = textBox1.Text + e.KeyChar;
                if (!Regex.IsMatch(number, pattern))
                {
                    e.KeyChar = (char)Keys.None;
                }
            }
        }
        /// <summary>
        /// Обработчик события щелчка по кнопке взятие корня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HalfPow_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Device.st_op1 = textBox1.Text;
                if (Device.check1())
                {
                    if (Device.SquareRoot())
                    {
                        string tmp = Device.result.ToString("G4").Replace(',', '.');
                        textBox1.Text = tmp;
                    }
                    else
                    {
                        Error.Text = "Попытка взятия корня из отрицательного числа!!!";
                    }
                }
                else
                {
                    Device.st_op1 = "";
                    Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                    textBox1.Text = "";
                    textBox1.Focus();
                }

            }
            else
                Error.Text = "Введите Операнд!";

        }
        /// <summary>
        /// Обработчик события щелчка по кнопке взятия косинуса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Device.st_op1 = textBox1.Text;
                if (Device.check1())
                {
                    Device.Cosinus();
                    string tmp = Device.result.ToString("G4").Replace(',', '.');
                    textBox1.Text = tmp;
                }
                else
                {
                    Device.st_op1 = "";
                    Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                    textBox1.Text = "";
                    textBox1.Focus();
                }
            }
            else
                Error.Text = "Введите операнд!";
        }
        /// <summary>
        /// Обработчик события щелчка по кнопке взятие обратного к данному
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reverse_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Device.st_op1 = textBox1.Text;
                if (Device.check1())
                {
                    if (Device.Reverse())
                    {
                        string tmp = Device.result.ToString("G4").Replace(',', '.');
                        textBox1.Text = tmp;
                    }
                    else
                    {
                        Error.Text = "Попытка деления на ноль!!!";
                    }
                }
                else 
                {
                    Device.st_op1 = "";
                    Error.Text = "Некоректный размер операнда  или форма!!! Введите заново!";
                    textBox1.Text = "";
                    textBox1.Focus();
                }

            }
            else
                Error.Text = "Введите Операнд!";
        }
        /// <summary>
        /// Обработчик события щелчка по кнопке выхода из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Обработчик события щелчка по кнопке очистки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }
    }
}
