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

namespace EntityPrakt1
{
    /// <summary>
    /// Логика взаимодействия для zakazi.xaml
    /// </summary>
    public partial class zakazi : Window
    {
        PetShopEntities context = new PetShopEntities();
        public zakazi()
        {
            InitializeComponent();
            GridDataOrders.ItemsSource = context.Orders.ToList();
        }

        private void byebye(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
