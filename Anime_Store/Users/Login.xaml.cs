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

namespace Anime_Store.Users
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            btn_SignUpButton.Click += SignUpButton_Click;
            log_ExitButton.Click += ExitButton_Click;
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            this.Close();
        }

        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void log_ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
