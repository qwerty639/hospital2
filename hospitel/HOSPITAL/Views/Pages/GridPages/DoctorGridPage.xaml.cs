using HOSPITAL.Context;
using HOSPITAL.Model;
using HOSPITAL.Views.Pages.EditPages;
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

namespace HOSPITAL.Views.Pages.GridPages
{
    /// <summary>
    /// Логика взаимодействия для DoctorGridPage.xaml
    /// </summary>
    public partial class DoctorGridPage : Page
    {
        public DoctorGridPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddDoctorPage());
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbView.ItemsSource = dbContext.db.DOCTOR.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DOCTOR DeleteDoctor = (DOCTOR)dbView.SelectedItem;
            dbContext.db.DOCTOR.Remove(DeleteDoctor);
            dbContext.db.SaveChanges();
            Page_Loaded(null, null);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            DOCTOR EditDoctor = (DOCTOR)dbView.SelectedItem;
            if (EditDoctor != null)
            {
                NavigationService.Navigate(new EditDoctorPage(EditDoctor));
            }
            else
            {
                MessageBox.Show("Данные не выбраны", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
