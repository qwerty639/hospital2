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

namespace HOSPITAL.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для PacientGridPage.xaml
    /// </summary>
    public partial class PacientGridPage : Page
    {
        public PacientGridPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPacientPage());
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbView.ItemsSource = dbContext.db.PATIENT.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PATIENT DeletePatient = (PATIENT)dbView.SelectedItem;
            dbContext.db.PATIENT.Remove(DeletePatient);
            dbContext.db.SaveChanges();
            Page_Loaded(null, null);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            PATIENT EditPatient = (PATIENT)dbView.SelectedItem;
            if (EditPatient != null)
            {
                NavigationService.Navigate(new EditPacientPage(EditPatient));
            }

            else
            {
                MessageBox.Show("Данные не выбраны", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
