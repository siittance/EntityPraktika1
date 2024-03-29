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

namespace EntityPrakt1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            clientiki clientiki = new clientiki();
            clientiki.Show();
            Close();
        }

        private void click2(object sender, RoutedEventArgs e)
        {
            Pitomci pitomec = new Pitomci();
            pitomec.Show();
            Close();
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            zakazi Zakaz = new zakazi();
            Zakaz.Show();
            Close();
        }
    }
}
