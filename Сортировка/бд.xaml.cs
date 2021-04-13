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
    /// Логика взаимодействия для бд.xaml
    /// </summary>
    public partial class бд : Window
    {
        Сортировка.bd db = new Сортировка.bd();
        Сортировка.Inventory ind = new Сортировка.Inventory();
        public бд()
        {
            InitializeComponent();
            roooms.ItemsSource = ind.name.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Организация организация = new Организация();
            организация.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Hide();
            Кабинеты кабинеты = new Кабинеты();
            кабинеты.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
        
    }
}
