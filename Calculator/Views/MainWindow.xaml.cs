using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string CopyPaste = null;
        static char[] operators = { '+', '-', '*', '/', '%' };
        double rez = 0, x = 0, y = 0;

        public MainWindow()
        {

            InitializeComponent();
        }
        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "1";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "2";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "3";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "4";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "5";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "6";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "7";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "8";
            y = Convert.ToDouble(textBox2.Text);
        }

        private void deleteString_btn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox2.Text;
            buf = buf.Remove(buf.Length - 1);
            textBox1.Text = "";
            textBox2.Text = buf;
        }

        private void deleteInput_btn_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "0";
        }

        private void deleteAll_btn_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "0";
        }

        private void revrseBtn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox2.Text;
            double a = 1/Convert.ToDouble( buf);
            
            textBox2.Text = Convert.ToString(a);
        }

        private void degree2_btn_Click(object sender, RoutedEventArgs e)
        {
            
            double a = Math.Pow(Convert.ToDouble(textBox2.Text),2);
            
            textBox2.Text = Convert.ToString(a);
        }

        private void degree3_btn_Click(object sender, RoutedEventArgs e)
        {
            double a = Math.Pow(Convert.ToDouble(textBox2.Text), 3);

            textBox2.Text = Convert.ToString(a);
        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '*' /*|| buf[buf.Length - 1] == '*'*/ || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBox1.Text = buf + "/";
                }
            }
            if (y == 0 && buf != "")
            {
                textBox1.Text += "/";
            }
            else
            {
                textBox1.Text += Convert.ToString(y) + "/";
            }
            if (y == 0)
            {
                textBox2.Text = "Ошибка";
            }
            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x / y;
            }

            textBox2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBox2.Text);
            y = 1;
        }

        private void multiplyBtn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/'  || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBox1.Text = buf + "*";
                }
            }
            if (y == 0 && buf != "")
            {
                textBox1.Text += "*";
            }
            else
            {
                textBox1.Text += Convert.ToString(y) + "*";
            }
           

            if (x == 0)
            {
                rez = y;
            }
            else
            {
                rez = x * y;
            }

            
            x = rez;
            y = 0;
            textBox2.Text = Convert.ToString(rez);
        }

        private void minusBtn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBox1.Text = buf + "-";
                }

            }

            if (y == 0 && buf != "")
            {
                textBox1.Text += "-";
            }

            else
            {
                textBox1.Text += Convert.ToString(y) + "-";
            }

            if (x == 0)
            {
                rez = y - x;
            }
            else
            {
                rez = x - y;
            }
            textBox2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBox2.Text);
            y = 0;
        }

        private void plusBtn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox1.Text;

            if (buf != "")
            {
                if (buf[buf.Length - 1] == '+' || buf[buf.Length - 1] == '-' || buf[buf.Length - 1] == '/' || buf[buf.Length - 1] == '*' || buf[buf.Length - 1] == '%')
                {
                    buf = buf.Remove(buf.Length - 1);

                    textBox1.Text = buf + "+";
                }
            }

            if (y == 0 && buf != "")
            {
                textBox1.Text += "+";
            }

            else
            {
                textBox1.Text += Convert.ToString(y) + "+";
            }

            rez = y + x;
            textBox2.Text = Convert.ToString(rez);
            x = Convert.ToDouble(textBox2.Text);
            y = 0;
        }

        private void plusMinus_btn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox2.Text;
            double a = (-1) * Convert.ToDouble(buf);

            textBox2.Text = Convert.ToString(a);
        }

        private void commaBtn_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text +=",";
        }

        private void resultBtn_Click(object sender, RoutedEventArgs e)
        {
            string buf = textBox1.Text;

            if (buf[buf.Length - 1] == '+')
            {
                y = Convert.ToDouble(textBox2.Text);
                rez = x + y;
                textBox2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '-')
            {
                y = Convert.ToDouble(textBox2.Text);
                rez = x - y;
                textBox2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '*')
            {
                y = Convert.ToDouble(textBox2.Text);
                rez = x * y;
                textBox2.Text = Convert.ToString(rez);
            }
            if (buf[buf.Length - 1] == '/')
            {
                y = Convert.ToDouble(textBox2.Text);
                rez = x / y;
                textBox2.Text = Convert.ToString(rez);
            }
            //rez = 0;
            //x = 0; y = 0;
            x = rez;
            y = 0;
            textBox1.Text = Convert.ToString(rez);
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "9";
            y = Convert.ToDouble(textBox2.Text);
        }
        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (y == 0)
            {
                textBox2.Text = null;
                y = 1;
            }
            textBox2.Text += "0";
            y = Convert.ToDouble(textBox2.Text);
        }
    }
}
