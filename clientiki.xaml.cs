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
    /// Логика взаимодействия для clientiki.xaml
    /// </summary>
    public partial class clientiki : Window
    {
        PetShopEntities context = new PetShopEntities();
        public clientiki()
        {
            InitializeComponent();
            GridDataClients.ItemsSource = context.Clients.ToList();
        }

        private void bye(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
