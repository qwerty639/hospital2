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

namespace HOSPITAL.Views.Pages.EditPages
{
    /// <summary>
    /// Логика взаимодействия для EditTherapyPage.xaml
    /// </summary>
    public partial class EditTherapyPage : Page
    {
        private THERAPY selecteditem;
        public EditTherapyPage(THERAPY selecteditem)
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            txbDiagnose.Text = selecteditem.Diagnose;
            txbAmbulatory.Text = selecteditem.Ambulatory;
            txbDisability.Text = selecteditem.Disability;
            dpBegintherapy.SelectedDate = selecteditem.Begintherapy;
            cmbFullname.ItemsSource = dbContext.db.PATIENT.Select(item => item.Fullname).ToList();
            cmbDoctorname.ItemsSource = dbContext.db.DOCTOR.Select(item => item.Doctorname).ToList();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editer = dbContext.db.THERAPY.FirstOrDefault(item => item.Id == selecteditem.Id);
            var editer1 = dbContext.db.THERAPY.FirstOrDefault(item => item.Id == selecteditem.Id);

            editer.PATIENT.Fullname = cmbFullname.Text;
            editer.DOCTOR.Doctorname = cmbDoctorname.Text;

            editer.Diagnose = txbDiagnose.Text;
            editer.Ambulatory = txbAmbulatory.Text;
            editer.Disability = Convert.ToInt32(txbDisability.Text);
            editer.Begintherapy = Convert.ToDateTime(dpBegintherapy.SelectedDate);

        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TherapyGridPage());
        }
    }
}
