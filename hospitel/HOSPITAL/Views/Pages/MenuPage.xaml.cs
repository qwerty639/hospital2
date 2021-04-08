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
using HOSPITAL.Views.Pages;
using HOSPITAL.Views.Pages.GridPages;

namespace HOSPITAL.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnGridPacient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PacientGridPage());
        }

        private void btnGridDoctor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DoctorGridPage());
        }

        private void btnGridTherapy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TherapyGridPage());
        }
    }
}
