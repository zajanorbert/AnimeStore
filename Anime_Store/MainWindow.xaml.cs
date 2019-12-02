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

namespace Anime_Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Users.Login login;
        public MainWindow()
        {
            InitializeComponent();
            LogoutButton.Visibility = Visibility.Hidden;
            
        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            login = new Users.Login();
            login.Show();
            login.Closed += Login_Closed;
        }

        private void Login_Closed(object sender, EventArgs e)
        {
            LogoutButton.Visibility = Visibility.Visible;
            AccountButton.Content = login.log_UserName.Text;
            AccountButton.Click -= AccountButton_Click;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LogoutButton.Visibility = Visibility.Hidden;
            AccountButton.Content = "Login";
            AccountButton.Click += AccountButton_Click;
        }

        private void SetTitleBarBackground()
        {
           
        }
    }
}
