using MahApps.Metro.IconPacks;
using System;
using System.Windows;
using System.Windows.Input;


namespace MusicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown (object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton==MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
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
    }
}
