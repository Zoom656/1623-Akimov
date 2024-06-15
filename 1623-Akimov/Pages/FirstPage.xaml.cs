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

namespace _1623_Akimov.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void menuAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthPage());
        }

        private void menuReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegPage());
        }

        private void menuUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPage());
        }

        private void menuUserEdit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserEditPage());
        }

        private void menuPartn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PartnerPage());
        }

        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void menuFon1_Click(object sender, RoutedEventArgs e)
        {
            fon1.Source = new BitmapImage(new Uri("../Resources/yandex.jpg", UriKind.Relative));
        }

        private void menuFon2_Click(object sender, RoutedEventArgs e)
        {
            fon1.Source = new BitmapImage(new Uri("../Resources/yandex.png", UriKind.Relative));
        }
    }
}
