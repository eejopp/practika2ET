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

namespace prac1EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BeautySalEntities3 context = new BeautySalEntities3();
        
        public MainWindow()
        {
            InitializeComponent();
            dgSalon.ItemsSource = context.Clients.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients() { ClientsAddress = tbClientAdress.Text, ClientsName = tbClientName.Text, ClientsSurname = tbClientSurname.Text, Email = tbClientEmail.Text, PhoneNumber = tbClientPhoneNumber.Text };
            context.Clients.Add(clients);
            context.SaveChanges();
            dgSalon.ItemsSource = context.Clients.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgSalon.SelectedItem != null)
            {
                context.Clients.Remove(dgSalon.SelectedItem as Clients);
                context.SaveChanges();
                dgSalon.ItemsSource=context.Clients.ToList();
            }

        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgSalon.SelectedItem != null)
            {
                var clients = dgSalon.SelectedItem as Clients;
                clients.Email = tbClientEmail.Text;
                clients.PhoneNumber = tbClientPhoneNumber.Text;
                clients.ClientsSurname = tbClientSurname.Text;
                clients.ClientsName = tbClientName.Text;
                clients.ClientsAddress = tbClientAdress.Text;
                context.SaveChanges();
                dgSalon.ItemsSource = context.Clients.ToList();
            }
        }

    }
}
