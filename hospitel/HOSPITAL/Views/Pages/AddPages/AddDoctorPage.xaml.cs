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
    /// Логика взаимодействия для AddDoctorPage.xaml
    /// </summary>
    public partial class AddDoctorPage : Page
    {
        public AddDoctorPage()
        {
            InitializeComponent();
            cmbSkill.ItemsSource = dbContext.db.SKILLTABLE.Select(item => item.Skill).ToList();
            cmbSpecialization.ItemsSource = dbContext.db.SPECIALIZATIONTABLE.Select(item => item.Specialization).ToList();
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DOCTOR newDoctor = new DOCTOR();

            var a = dbContext.db.SKILLTABLE.FirstOrDefault(item => item.Skill == cmbSkill.Text);
            var b = dbContext.db.SPECIALIZATIONTABLE.FirstOrDefault(item => item.Specialization == cmbSpecialization.Text);

            newDoctor.Doctorname = txbDoctorname.Text;
            newDoctor.Post = txbPost.Text;

            newDoctor.Idskill = a.Id;
            newDoctor.Idspecialization = b.Id;

            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            dbContext.db.DOCTOR.Add(newDoctor);

            dbContext.db.SaveChanges();
            
        }

        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DoctorGridPage());
        }

       
    }
}
