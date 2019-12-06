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
using System.Windows.Shapes;
using Anime_Store.ViewModels;

namespace Anime_Store
{
    /// <summary>
    /// Interaction logic for AccountWindow.xaml
    /// </summary>
    public partial class AccountWindow : Window
    {
        public AccountWindow()
        {
            InitializeComponent();
            DataContext = new ProfileSettingsViewModel();
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //Not Implemeted
        }

        //View Changers
        private void ProfileSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ProfileSettingsViewModel();
        }

        private void GeneralSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new GeneralSettingsViewModel();
        }

        private void SecuritySettingsButton_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SecuritySettingViewModel();
        }
    }
}
