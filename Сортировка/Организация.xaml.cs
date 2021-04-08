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
    public partial class Организация : Window
    {
        public Организация()
        {
            InitializeComponent();
        }
        int x = 1;
        private void Button_Click_MONKEY(object sender, RoutedEventArgs e)
        {
            
            if (x==20)
            {
                Hide();
                Картинка картинка = new Картинка();
                картинка.Show();
                Close();
            }
            else
            {
                x = x + 1;
            }
            string a = "MONKEY ";
            текст.Items.Add (a);
           
            
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Вход вход = new Вход();
            вход.Show();
            Close();
        }
    }
}
