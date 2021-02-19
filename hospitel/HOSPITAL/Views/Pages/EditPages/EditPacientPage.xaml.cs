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

namespace HOSPITAL.Views.Pages.EditPages
{
    /// <summary>
    /// Логика взаимодействия для EditPacientPage.xaml
    /// </summary>
    public partial class EditPacientPage : Page
    {
        private PATIENT selecteditem;
        public EditPacientPage(PATIENT selecteditem)
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            txbFullname.Text = selecteditem.Fullname;
            dpDateofbirth.SelectedDate = selecteditem.Dateofbirth;
            cmbStatus.ItemsSource = dbContext.db.STATUSTABLE.Select(item => item.Status).ToList();
            cmbPosition.ItemsSource = dbContext.db.POSITIONTABLE.Select(item => item.Position).ToList();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PacientGridPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editer = dbContext.db.PATIENT.FirstOrDefault(item => item.Id == selecteditem.Id);
            var editer1 = dbContext.db.PATIENT.FirstOrDefault(item => item.Id == selecteditem.Id);
            editer.STATUSTABLE.Status = cmbStatus.Text;
            editer.POSITIONTABLE.Position = cmbPosition.Text;
            //var a = dbContext.db.STATUSTABLE.FirstOrDefault(item => item.Status == cmbStatus.Text);
            //var b = dbContext.db.POSITIONTABLE.FirstOrDefault(item => item.Position == cmbPosition.Text);
            editer.Fullname = txbFullname.Text;
            editer1.Dateofbirth = Convert.ToDateTime(dpDateofbirth.SelectedDate);

            MessageBox.Show("Данные отредактированы","Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            dbContext.db.SaveChanges();
        }
    }
}
