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

namespace prac1EF
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnBookings_Click(object sender, RoutedEventArgs e)
        {
            wndBookings wndBookings = new wndBookings();
            wndBookings.Show();
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void btnServicess_Click(object sender, RoutedEventArgs e)
        {
             wndServicess servicess =new wndServicess();
            servicess.Show();
            
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var window = new bookingsWindow();
        //    window.bookings.ItemsSource = bookings.GetData();
        //    window.Show();
        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    var window = new clientsWindow();
        //    window.clients.ItemsSource = clients.GetData();
        //    window.Show();
        //}

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    var window = new servicessWindow();
        //    window.servicess.ItemsSource = servicess.GetData();
        //    window.Show();
        //}
    }
}
