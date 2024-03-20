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
    /// Логика взаимодействия для wndServicess.xaml
    /// </summary>
    public partial class wndServicess : Window
    {

        BeautySalEntities4 context = new BeautySalEntities4();

        public wndServicess()
        {
            InitializeComponent();
            dgServicess.ItemsSource = context.Servicess.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Servicess service = new Servicess() { ServiceName = tbServiceName.Text, Cost = decimal.Parse(tbCost.Text), Duration = int.Parse(tbDuration.Text) };

            context.Servicess.Add(service);
            context.SaveChanges();
            dgServicess.ItemsSource = context.Servicess.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dgServicess.SelectedItem != null)
            {
                context.Servicess.Remove(dgServicess.SelectedItem as Servicess);
                context.SaveChanges();
                dgServicess.ItemsSource = context.Servicess.ToList();
            }

        }


        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (dgServicess.SelectedItem != null)
            {
                var service = dgServicess.SelectedItem as Servicess;
                service.ServiceName = tbServiceName.Text;
                service.Cost = decimal.Parse(tbCost.Text);
                service.Duration = int.Parse(tbDuration.Text);
                context.SaveChanges();
                dgServicess.ItemsSource = context.Servicess.ToList();
            }
        }
    }
}

