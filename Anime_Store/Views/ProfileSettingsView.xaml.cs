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

namespace Anime_Store.Views
{
    /// <summary>
    /// Interaction logic for ProfileSettingView.xaml
    /// </summary>
    public partial class ProfileSettingView : UserControl
    {
        public ProfileSettingView()
        {
            InitializeComponent();
        }
        //Image Events
        private void ImageChangerButton_Click(object sender, RoutedEventArgs e)
        {

        }
        //Description Events
        private void ChangeDescriptionButton_Click(object sender, RoutedEventArgs e)
        {
            
            DescriptionTextBlock.Visibility = Visibility.Hidden;
            DescriptionTextBox.Visibility = Visibility.Visible;
            SaveDescriptionButton.Visibility = Visibility.Visible;
            BackFromDescriptionButton.Visibility = Visibility.Visible;
            ChangeDescriptionButton.Visibility = Visibility.Hidden;

        }

        private void SaveDescriptionButton_Click(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock.Visibility = Visibility.Visible;
            DescriptionTextBox.Visibility = Visibility.Hidden;
            SaveDescriptionButton.Visibility = Visibility.Hidden;
            BackFromDescriptionButton.Visibility = Visibility.Hidden;
            ChangeDescriptionButton.Visibility = Visibility.Visible;
            DescriptionTextBlock.Text = DescriptionTextBox.Text;
        }

        private void BackFromDescriptionButton_Click(object sender, RoutedEventArgs e)
        {
            DescriptionTextBlock.Visibility = Visibility.Visible;
            DescriptionTextBox.Visibility = Visibility.Hidden;
            SaveDescriptionButton.Visibility = Visibility.Hidden;
            BackFromDescriptionButton.Visibility = Visibility.Hidden;
            ChangeDescriptionButton.Visibility = Visibility.Visible;
            DescriptionTextBox.Text = null;  

        }
        //Password Events
        private void ChangePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPasswordPasswordBox.Password = null;
            NewPasswordPasswordBox.Password = null;
            RepeatNewPasswordPasswordBox.Password = null;
            ChangePasswordButton.Visibility = Visibility.Hidden;
            CurrentPasswordLabel.Visibility = Visibility.Visible;
            CurrentPasswordPasswordBox.Visibility = Visibility.Visible;
            NewPasswordLabel.Visibility = Visibility.Visible;
            NewPasswordPasswordBox.Visibility = Visibility.Visible;
            RepeatNewPasswordLabel.Visibility = Visibility.Visible;
            RepeatNewPasswordPasswordBox.Visibility = Visibility.Visible;
            SavePasswordButton.Visibility = Visibility.Visible;
            BackFromPasswordChangeButton.Visibility = Visibility.Visible;

        }

        private void SavePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewPasswordPasswordBox.Password == RepeatNewPasswordPasswordBox.Password)
            {
                ChangePasswordButton.Visibility = Visibility.Visible;
                CurrentPasswordLabel.Visibility = Visibility.Hidden;
                CurrentPasswordPasswordBox.Visibility = Visibility.Hidden;
                NewPasswordLabel.Visibility = Visibility.Hidden;
                NewPasswordPasswordBox.Visibility = Visibility.Hidden;
                RepeatNewPasswordLabel.Visibility = Visibility.Hidden;
                RepeatNewPasswordPasswordBox.Visibility = Visibility.Hidden;
                SavePasswordButton.Visibility = Visibility.Hidden;
                BackFromPasswordChangeButton.Visibility = Visibility.Hidden;
                MessageBox.Show("Password has been changed succesfuly");
            } else
            {
                PasswordsDoesntMatchLabel.Visibility = Visibility.Visible;
            }
        }
        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordsDoesntMatchLabel.Visibility = Visibility.Hidden;
        }

        private void BackFromPasswordChangeButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePasswordButton.Visibility = Visibility.Visible;
            CurrentPasswordLabel.Visibility = Visibility.Hidden;
            CurrentPasswordPasswordBox.Visibility = Visibility.Hidden;
            NewPasswordLabel.Visibility = Visibility.Hidden;
            NewPasswordPasswordBox.Visibility = Visibility.Hidden;
            RepeatNewPasswordLabel.Visibility = Visibility.Hidden;
            RepeatNewPasswordPasswordBox.Visibility = Visibility.Hidden;
            SavePasswordButton.Visibility = Visibility.Hidden;
            BackFromPasswordChangeButton.Visibility = Visibility.Hidden;
            PasswordsDoesntMatchLabel.Visibility = Visibility.Hidden;
        }
    }
}
