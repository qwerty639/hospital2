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
    /// Логика взаимодействия для EditDoctorPage.xaml
    /// </summary>
    public partial class EditDoctorPage : Page
    {
        private DOCTOR selecteditem;
        public EditDoctorPage(DOCTOR selecteditem)
        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            txbDoctorname.Text = selecteditem.Doctorname;
            txbPost.Text = selecteditem.Post;
            cmbSkill.ItemsSource = dbContext.db.SKILLTABLE.Select(item => item.Skill).ToList();
            cmbSpecialization.ItemsSource = dbContext.db.SPECIALIZATIONTABLE.Select(item => item.Specialization).ToList();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DoctorGridPage());
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editer = dbContext.db.DOCTOR.FirstOrDefault(item => item.Id == selecteditem.Id);
            var editer1 = dbContext.db.DOCTOR.FirstOrDefault(item => item.Id == selecteditem.Id);
            editer.SKILLTABLE.Skill = cmbSkill.Text;
            editer.SPECIALIZATIONTABLE.Specialization = cmbSpecialization.Text;
            editer.Doctorname = txbDoctorname.Text;
            editer1.Post = txbPost.Text;

            MessageBox.Show("Данные отредактированы","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
        }
    }
}
