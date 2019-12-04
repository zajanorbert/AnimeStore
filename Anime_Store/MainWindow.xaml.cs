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
using Anime_Store.ViewModels;

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
            DataContext = new AnimeListViewModel();
            LogoutButton.Visibility = Visibility.Hidden;
            AccountButton.Visibility = Visibility.Hidden;
            LogInButton.Visibility = Visibility.Visible;
            sendAutoText();
            Autotxt.TextChanged += Search.Autotxt_TextChanged;
            lbSuggestion.SelectionChanged += Search.lbSuggestion_SelectionChanged;
            

        }

        private void AccountButton_Click(object sender, RoutedEventArgs e)
        {
            AccountWindow account = new AccountWindow();
            account.Show();
            
        }

        private void Login_Closed(object sender, EventArgs e)
        {
            LogoutButton.Visibility = Visibility.Visible;
            AccountButton.Visibility = Visibility.Visible;
            LogInButton.Visibility = Visibility.Hidden;
            AccountButton.Content = login.log_UserName.Text;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LogoutButton.Visibility = Visibility.Hidden;
            AccountButton.Visibility = Visibility.Hidden;
            LogInButton.Visibility = Visibility.Visible;
        }

        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            login = new Users.Login();
            login.Show();
            login.Closed += Login_Closed;
        }

        /// <summary>
        /// Sends the text information for the Search class.
        /// </summary>
        private void sendAutoText()
        {
            Search.getAutoText(Autotxt, lbSuggestion);
        }
        public void AnimeinfoButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AnimeInfoViewModel();
        }

        private void AnimeButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new AnimeListViewModel();
        }
    }
}
