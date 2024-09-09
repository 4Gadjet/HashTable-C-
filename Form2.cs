using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_Table
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            progressBar1.Maximum = 8;
            progressBar1.Value = 0;
            Random rnd = new Random();
            int question = rnd.Next(0, 10); /*текущий вопрос*/
            
            //НУЖНО СДЕЛАТЬ ОЖИДАНИЕ ПОЛЬЗОВАТЕЛЯ

            switch (question)
            {
                case (1):

                    richTextBox1.Text = ("Сколько стабильных методов решения коллизий известно?" +
                           "\n1) 1" +
                           "\n2) 2" +
                           "\n3) 3" +
                           "\n4) 4");
                    correct_answer = 2;
                    break;

                case (2):

                    richTextBox1.Text = ("Кто официально считается автором хеш-функций?" +
                                       "\n1) Дональд Кнут" +
                                       "\n2) Герман Холлерит" +
                                       "\n3) Стив Морган" +
                                       "\n4) Линус Торвальдс");
                    correct_answer = 1;
                    break;
                case (3):
                    richTextBox1.Text = ("В каком году были описаны хеш-функции?" +
                                       "\n1) 1927" +
                                       "\n2) 1954" +
                                       "\n3) 1956" +
                                       "\n4) 1890");
                    correct_answer = 3;
                    break;
                case (4):
                    richTextBox1.Text = ("Какие объекты могут быть записаны в хеш-таблицы?" +
                                         "\n1) Любые целые и дробные числа" +
                                         "\n2) Буквенные выражения и дробные числа" +
                                         "\n3) Любое значение, хеш-функцию от которого возможно вычислить" +
                                         "\n4) Буквенные выражения и целые числа");
                    correct_answer = 3;
                    break;
                case (5):
                    richTextBox1.Text = ("Каковы основные преимущества хеш-таблиц?" +
                                       "\n1) Функциональность, надежность, легкость применения" +
                                       "\n2) Устойчивость, естественность поведения, использование операции сравнения" +
                                       "\n3) Скорость работы, прямой доступ к элементам" +
                                       "\n4) Полнота реализации, корректность результата, точность");
                    correct_answer = 3;
                    break;
                case (6):
                    richTextBox1.Text = ("Какими бывают хеш-функции?" +
                                       "\n1) Внутренняя и внешняя" +
                                       "\n2) Хорошая и плохая" +
                                       "\n3) Верхняя и нижняя" +
                                       "\n4) Логичная и нелогичная");
                    correct_answer = 2;
                    break;
                case (7):
                    richTextBox1.Text = ("Совпадение ключа у двух разных элементов называется" +
                                       "\n1) Коллизия" +
                                       "\n2) Ревизия" +
                                       "\n3) Случайность" +
                                       "\n4) Баг");
                    correct_answer = 1;
                    break;
                case (8):
                    richTextBox1.Text = ("Минимальная трудоёмкость лучшего случая алгоритмов хеширования?" +
                                       "\n1) v0(x) + vx(t)" +
                                       "\n2) v0 * t + (a * t^2) / 2" +
                                       "\n3) a(p) * a(s)" +
                                       "\n4) O(n)");
                    correct_answer = 4;
                    break;
                case (9):

                    richTextBox1.Text = ("Хеш таблица - ..." +
                                       "\n1) Структура данных" +
                                       "\n2) Словесная информационная модель" +
                                       "\n3) Ассоциативный двусвязный список" +
                                       "\n4) Какая-то крутая штука с майнингом");
                    correct_answer = 1;
                    break;
                case (10):
                    richTextBox1.Text = ("Как называется пара, в основе которой лежит хеш-таблица?" +
                                       "\n1) первый, второй" +
                                       "\n2) аргумент, функция" +
                                       "\n3) ключ, значение" +
                                       "\n4) указатель, порядок");
                    correct_answer = 3;
                    break;
            }
        }

        public int correct_answer = 0;
        public int answer = 0;
        public int Rslt_verno = 0;
        public int Rslt_neverno = 0;

         

        public void Get_Answer()
        {
            if (textBox1.TextLength > 0) { answer = System.Convert.ToInt32(textBox1.Text); }
        }

        public void Check_Answer()
        {
            Get_Answer();
            if (answer == correct_answer)
            {
                Rslt_verno++;
            }
            else
            {
                Rslt_neverno++;
            }

        }

        
        
        private void Testirovanie()
        {
            if (progressBar1.Value != 8)progressBar1.Value++;
            
            if (Rslt_neverno != 3 && Rslt_verno != 5)
            {
                Check_Answer();
            }
            else
            {
                if (Rslt_verno >= 5) { MessageBox.Show("Ваш результат: Отлично!", "Так держать!", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                if (Rslt_verno == 4) { MessageBox.Show("Ваш результат: Хорошо!", "Так держать!", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                if (Rslt_verno == 3) { MessageBox.Show("Ваш результат: Удовлетворительно!", "Лучше повторить материал!", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Close(); }
                if (Rslt_neverno >= 3) { MessageBox.Show("Ваш результат: Плохо!", "Тренируйся еще!", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            }
            Random rnd = new Random();
            int question = rnd.Next(0, 10); /*текущий вопрос*/
            
            //НУЖНО СДЕЛАТЬ ОЖИДАНИЕ ПОЛЬЗОВАТЕЛЯ
            
            switch (question)
            {
                case (1):

                    richTextBox1.Text = ("Сколько стабильных методов решения коллизий известно?" +
                           "\n1) 1" +
                           "\n2) 2" +
                           "\n3) 3" +
                           "\n4) 4");
                    correct_answer = 2;
                    break;

                case (2):

                    richTextBox1.Text = ("Кто официально считается автором хеш-функций?" +
                                       "\n1) Дональд Кнут" +
                                       "\n2) Герман Холлерит" +
                                       "\n3) Стив Морган" +
                                       "\n4) Линус Торвальдс");
                    correct_answer = 1;
                    break;
                case (3):
                    richTextBox1.Text = ("В каком году были описаны хеш-функции?" +
                                       "\n1) 1927" +
                                       "\n2) 1954" +
                                       "\n3) 1956" +
                                       "\n4) 1890");
                    correct_answer = 3;
                    break;
                case (4):
                    richTextBox1.Text = ("Какие объекты могут быть записаны в хеш-таблицы?" +
                                         "\n1) Любые целые и дробные числа" +
                                         "\n2) Буквенные выражения и дробные числа" +
                                         "\n3) Любое значение, хеш-функцию от которого возможно вычислить" +
                                         "\n4) Буквенные выражения и целые числа");
                    correct_answer = 3;
                    break;
                case (5):
                    richTextBox1.Text = ("Каковы основные преимущества хеш-таблиц?" +
                                       "\n1) Функциональность, надежность, легкость применения" +
                                       "\n2) Устойчивость, естественность поведения, использование операции сравнения" +
                                       "\n3) Скорость работы, прямой доступ к элементам" +
                                       "\n4) Полнота реализации, корректность результата, точность");
                    correct_answer = 3;
                    break;
                case (6):
                    richTextBox1.Text = ("Какими бывают хеш-функции?" +
                                       "\n1) Внутренняя и внешняя" +
                                       "\n2) Хорошая и плохая" +
                                       "\n3) Верхняя и нижняя" +
                                       "\n4) Логичная и нелогичная");
                    correct_answer = 2;
                    break;
                case (7):
                    richTextBox1.Text = ("Совпадение ключа у двух разных элементов называется" +
                                       "\n1) Коллизия" +
                                       "\n2) Ревизия" +
                                       "\n3) Случайность" +
                                       "\n4) Баг");
                    correct_answer = 1;
                    break;
                case (8):
                    richTextBox1.Text = ("Минимальная трудоёмкость лучшего случая алгоритмов хеширования?" +
                                       "\n1) v0(x) + vx(t)" +
                                       "\n2) v0 * t + (a * t^2) / 2" +
                                       "\n3) a(p) * a(s)" +
                                       "\n4) O(n)");
                    correct_answer = 4;
                    break;
                case (9):

                    richTextBox1.Text = ("Хеш таблица - ..." +
                                       "\n1) Структура данных" +
                                       "\n2) Словесная информационная модель" +
                                       "\n3) Ассоциативный двусвязный список" +
                                       "\n4) Какая-то крутая штука с майнингом");
                    correct_answer = 1;
                    break;
                case (10):
                    richTextBox1.Text = ("Как называется пара, в основе которой лежит хеш-таблица?" +
                                       "\n1) первый, второй" +
                                       "\n2) аргумент, функция" +
                                       "\n3) ключ, значение" +
                                       "\n4) указатель, порядок");
                    correct_answer = 3;
                    break;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

            Testirovanie();
             //тут короче ответ на вопрос считывать 
        }

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}








/*
 listView1.Items.Add("Сколько стабильных методов решения коллизий известно?"+
                               "\n1) 1"+
                               "\n2) 2"+
                               "\n3) 3"+
                               "\n4) 4");
                        correct_answer = 2;
                        Get_Answer();

                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;
                        break;
                    case (2):

                        listView1.Items.Add("Кто официально считается автором хеш-функций?" +
                                           "\n1) Дональд Кнут" +
                                           "\n2) Герман Холлерит" +
                                           "\n3) Стив Морган" +
                                           "\n4) Линус Торвальдс");
                        correct_answer = 1;
                        Get_Answer();
                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (3):
                        listView1.Items.Add("В каком году были описаны хеш-функции?"+    
                                           "\n1) 1927"+    
                                           "\n2) 1954"+    
                                           "\n3) 1956"+    
                                           "\n4) 1890");
                        correct_answer = 3;
                        Get_Answer();
                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (4):
                        listView1.Items.Add("Какие объекты могут быть записаны в хеш-таблицы?" +    
                                             "\n1) Любые целые и дробные числа"+    
                                             "\n2) Буквенные выражения и дробные числа"+    
                                             "\n3) Любое значение, хеш-функцию от которого возможно вычислить"+    
                                             "\n4) Буквенные выражения и целые числа");
                        correct_answer = 3;
                        Get_Answer();
                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (5):
                        listView1.Items.Add("Каковы основные преимущества хеш-таблиц?" +
                                           "\n1) Функциональность, надежность, легкость применения"+
                                           "\n2) Устойчивость, естественность поведения, использование операции сравнения"+
                                           "\n3) Скорость работы, прямой доступ к элементам"+
                                           "\n4) Полнота реализации, корректность результата, точность");
                        correct_answer = 3;
                        Get_Answer();

                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (6):
                        listView1.Items.Add("Какими бывают хеш-функции?" +
                                           "\n1) Внутренняя и внешняя"+
                                           "\n2) Хорошая и плохая"+
                                           "\n3) Верхняя и нижняя"+
                                           "\n4) Логичная и нелогичная");
                        correct_answer = 2;
                        Get_Answer();

                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (7):
                        listView1.Items.Add("Совпадение ключа у двух разных элементов называется" +
                                           "\n1) Коллизия"+
                                           "\n2) Ревизия"+
                                           "\n3) Случайность"+
                                           "\n4) Баг");
                        correct_answer = 1;
                        Get_Answer();

                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (8):
                        listView1.Items.Add("Минимальная трудоёмкость лучшего случая алгоритмов хеширования?" +
                                           "\n1) v0(x) + vx(t)"+
                                           "\n2) v0 * t + (a * t^2) / 2"+
                                           "\n3) a(p) * a(s)"+
                                           "\n4) O(n)");
                        correct_answer = 4;
                        Get_Answer();

                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (9):

                        listView1.Items.Add("Хеш таблица - ..." +
                                           "\n1) Структура данных"+
                                           "\n2) Словесная информационная модель"+
                                           "\n3) Ассоциативный двусвязный список"+
                                           "\n4) Какая-то крутая штука с майнингом");
                        correct_answer = 1;
                        Get_Answer();

                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                    case (10):
                        listView1.Items.Add("Как называется пара, в основе которой лежит хеш-таблица?" +
                                           "\n1) первый, второй"+
                                           "\n2) аргумент, функция"+
                                           "\n3) ключ, значение"+
                                           "\n4) указатель, порядок");
                        correct_answer = 3;
                        Get_Answer();

                        if (answer == correct_answer)
                        {
                            Rslt_verno++;
                        }
                        else Rslt_neverno++;

                        break;
                }
 
 */