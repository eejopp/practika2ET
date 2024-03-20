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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace prac1EF
{
    /// <summary>
    /// Логика взаимодействия для wndBookings.xaml
    /// </summary>
    public partial class wndBookings : Window
    {
        BeautySalEntities5 context = new BeautySalEntities5();

        public wndBookings()
        {
            InitializeComponent();
            dgBooking.ItemsSource = context.Bookings.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Bookings bookings = new Bookings() { Servicess_ID = int.Parse(tbServiceID.Text), Client_ID = int.Parse(tbClientID.Text) };

            context.Bookings.Add(bookings);
            context.SaveChanges();
            dgBooking.ItemsSource = context.Bookings.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgBooking.SelectedItem != null)
            {
                context.Bookings.Remove(dgBooking.SelectedItem as Bookings);
                context.SaveChanges();
                dgBooking.ItemsSource = context.Bookings.ToList();                
            }

        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgBooking.SelectedItem != null)
            {
                var bookings = (dgBooking.SelectedItem as Bookings);
                bookings.Client_ID=int.Parse(tbClientID.Text);
                bookings.Servicess_ID=int.Parse(tbServiceID.Text);
                context.SaveChanges();
                dgBooking.ItemsSource = context.Bookings.ToList();
            }
        }
    }
}

