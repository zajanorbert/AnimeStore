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

        }



    }
}
