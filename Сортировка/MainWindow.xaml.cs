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

namespace Сортировка
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Вход : Window
    {
        public Вход()
        {
            InitializeComponent();
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Организация организация = new Организация();
            организация.Show();
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(Логин.Text=="1"&& Пароль.Password=="1")
            {
                Hide();
                Кабинеты кабинеты = new Кабинеты();
                кабинеты.Show();
                Close();
            }
        }
    }
}
