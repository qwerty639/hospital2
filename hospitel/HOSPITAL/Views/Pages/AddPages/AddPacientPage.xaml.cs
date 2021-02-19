using HOSPITAL.Context;
using HOSPITAL.Model;
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
    /// Логика взаимодействия для AddPacientPage.xaml
    /// </summary>
    public partial class AddPacientPage : Page
    {
        public AddPacientPage()
        {
            InitializeComponent();
            cmbStatus.ItemsSource = dbContext.db.STATUSTABLE.Select(item => item.Status).ToList();
            cmbPosition.ItemsSource = dbContext.db.POSITIONTABLE.Select(item => item.Position).ToList();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PATIENT newPatient = new PATIENT();
 
            var a = dbContext.db.STATUSTABLE.FirstOrDefault(item => item.Status == cmbStatus.Text);
            var b = dbContext.db.POSITIONTABLE.FirstOrDefault(item => item.Position == cmbPosition.Text);

            newPatient.Fullname = txbFullname.Text;
            newPatient.Dateofbirth = Convert.ToDateTime(dpDateofbirth.SelectedDate);

            newPatient.Idstatus = a.Id;
            newPatient.Idposition = b.Id;
            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            dbContext.db.PATIENT.Add(newPatient);

            dbContext.db.SaveChanges();


        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PacientGridPage());
        }
    }
}
