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

namespace Anime_Store.Views
{
    /// <summary>
    /// Interaction logic for AnimeListView.xaml
    /// </summary>
    public partial class AnimeListView : UserControl
    {
        public AnimeListView()
        {
            InitializeComponent();
        }

        private void AnimeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.DataContext = new AnimeInfoViewModel();
        }

    }
}
