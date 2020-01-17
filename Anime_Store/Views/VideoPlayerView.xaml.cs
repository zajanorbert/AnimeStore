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
using System.Windows.Threading;

namespace Anime_Store.Views
{
    /// <summary>
    /// Interaction logic for VideoPlayerView.xaml
    /// </summary>
    public partial class VideoPlayerView : UserControl
    {
        DispatcherTimer timer;
        public VideoPlayerView()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SeekSlider.Value = MediaElement1.Position.TotalSeconds;
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.DataContext = new AnimeInfoView();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement1.Play();
            PlayButton.Visibility = Visibility.Hidden;
            PauseButton.Visibility = Visibility.Visible;
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            MediaElement1.Pause();
            PauseButton.Visibility = Visibility.Hidden;
            PlayButton.Visibility = Visibility.Visible;

        }

        private void StopButtun_Click(object sender, RoutedEventArgs e)
        {
            MediaElement1.Stop();
            SeekSlider.Value = 0;
            PauseButton.Visibility = Visibility.Hidden;
            PlayButton.Visibility = Visibility.Visible;
        }

        private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaElement1.Volume = (double)VolumeSlider.Value;
        }

        private void SeekSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            MediaElement1.Position = TimeSpan.FromSeconds(SeekSlider.Value);
        }

        private void Grid_Drop(object sender, DragEventArgs e)
        {
            string filename = (string)((DataObject)e.Data).GetFileDropList()[0];
            MediaElement1.Source = new Uri(filename);
            MediaElement1.LoadedBehavior = MediaState.Manual;
            MediaElement1.UnloadedBehavior = MediaState.Manual;
            MediaElement1.Volume = (double)VolumeSlider.Value;
            MediaElement1.Play();
        }

        private void MediaElement1_MediaOpened(object sender, RoutedEventArgs e)
        {
            TimeSpan ts = MediaElement1.NaturalDuration.TimeSpan;
            SeekSlider.Maximum = ts.TotalSeconds;
            timer.Start();
        }

    }
}
