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
    /// Логика взаимодействия для TherapyGridPage.xaml
    /// </summary>
    public partial class TherapyGridPage : Page
    {
        public TherapyGridPage()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTherapyPage());
        }

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbView.ItemsSource = dbContext.db.THERAPY.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            THERAPY DeleteTherapy = (THERAPY)dbView.SelectedItem;
            dbContext.db.THERAPY.Remove(DeleteTherapy);
            dbContext.db.SaveChanges();
            Page_Loaded(null, null);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            THERAPY EditTherapy = (THERAPY)dbView.SelectedItem;
            if (EditTherapy != null)
            {
                NavigationService.Navigate(new EditTherapyPage(EditTherapy));
            }

            else
            {
                MessageBox.Show("Данные добавлены", "Уведомление",MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
