using MahApps.Metro.IconPacks;
using MusicApp.UserControls;
using System;
using System.Windows;
using System.Windows.Input;


namespace MusicApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Border_MouseDown (object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton==MouseButton.Left)
            {
                this.DragMove();
            }
        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PlayPauseIcon.Kind == PackIconMaterialKind.Play)
            {
                PlayPauseIcon.Kind = PackIconMaterialKind.Pause;
                // Thêm mã để bắt đầu phát nhạc tại đây
            }
            else
            {
                PlayPauseIcon.Kind = PackIconMaterialKind.Play;
                // Thêm mã để tạm dừng phát nhạc tại đây
            }
        }

        private void SongsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SongsUserControl();
        }

        private void VideosButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new VideosUserControl();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SettingsUserControl();
        }

    }
}
