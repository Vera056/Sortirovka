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
using System.Windows.Shapes;

namespace Сортировка
{
    /// <summary>
    /// Логика взаимодействия для Кабинеты.xaml
    /// </summary>
    public partial class Кабинеты : Window
    {
        public Кабинеты()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Вход вход = new Вход();
            вход.Show();
            Close();
        }

        private void Button_Click_MONKEY(object sender, RoutedEventArgs e)
        {
            Hide();
            Организация организация = new Организация();
            организация.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Кабинет_1 кабинет_1 = new Кабинет_1();
            кабинет_1.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            Кабинет_2 кабинет_2 = new Кабинет_2();
            кабинет_2.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Hide();
            Кабинет_3 кабинет_3 = new Кабинет_3();
            кабинет_3.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Hide();
            бд бд = new бд();
            бд.Show();
            Close();
        }
    }
}
