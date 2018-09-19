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

namespace Сalculator_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Получаем текст кнопки
            string s = (string)((Button)e.OriginalSource).Content;
            // Добавляем его в текстовое поле
            textBlock.Text += s;
        }

        private void Button_Click_Otvet(object sender, RoutedEventArgs e)
        {
            string s = textBlock.Text;
            if (s.Length == 0)
            { }
            else
            {
                string[] split = s.Split(new Char[] { '+', '-', '/', '*' });
                if (split.Length == 1)
                { }
                else
                {
                    double Fin = Convert.ToDouble(split[0]);
                    double Tin = Convert.ToDouble(split[1]);
                    int temp = s.IndexOf("+", 0);
                    if (temp != -1)
                        textBlock_Otvet.Text = Convert.ToString(Fin + Tin);
                    temp = s.IndexOf("/", 0);
                    if (temp != -1)
                        textBlock_Otvet.Text = Convert.ToString(Fin / Tin);
                    temp = s.IndexOf("*", 0);
                    if (temp != -1)
                        textBlock_Otvet.Text = Convert.ToString(Fin * Tin);
                    temp = s.IndexOf("-", 0);
                    if (temp != -1)
                        textBlock_Otvet.Text = Convert.ToString(Fin - Tin);
                }
            }

        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            string s = (string)((Button)e.OriginalSource).Content;
            if (s == "Clear")
            {
                textBlock.Text = "";
                textBlock_Otvet.Text = "";
            }
            else if (s == "BSpace")
            {
                s = textBlock.Text;
                if (s.Length == 0)
                { }
                else
                {
                    s = s.Substring(0, s.Length - 1);
                    textBlock.Text = s;
                }
            }
                
        }
    }
}
