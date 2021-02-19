using HOSPITAL.Context;
using HOSPITAL.Model;
using HOSPITAL.Views.Pages.GridPages;
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
    /// Логика взаимодействия для AddTherapyPage.xaml
    /// </summary>
    public partial class AddTherapyPage : Page
    {
        public AddTherapyPage()
        {
            InitializeComponent();
            cmbFullname.ItemsSource = dbContext.db.PATIENT.Select(item => item.Fullname).ToList();
            cmbDoctorname.ItemsSource = dbContext.db.DOCTOR.Select(item => item.Doctorname).ToList();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            THERAPY newTherapy = new THERAPY();

            var a = dbContext.db.PATIENT.FirstOrDefault(item => item.Fullname == cmbFullname.Text);
            var b = dbContext.db.DOCTOR.FirstOrDefault(item => item.Doctorname == cmbDoctorname.Text);
            newTherapy.Diagnose = txbDiagnose.Text;
            newTherapy.Ambulatory = txbAmbulatory.Text;
            newTherapy.Disability = Convert.ToInt32(txbDisability.Text);
            newTherapy.Begintherapy = Convert.ToDateTime(dpBegintherapy.SelectedDate);

            newTherapy.Idpatient = a.Id;
            newTherapy.Iddoctor = b.Id;

            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            dbContext.db.THERAPY.Add(newTherapy);

            dbContext.db.SaveChanges();
        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TherapyGridPage());
        }
    }
}
