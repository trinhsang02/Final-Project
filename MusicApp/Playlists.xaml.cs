using MahApps.Metro.IconPacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Windows;

namespace MusicApp
{
    /// <summary>
    /// Interaction logic for Playlists.xaml
    /// </summary>
    public partial class Playlists : Window
    {
        public Playlists()
        {
            InitializeComponent();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
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
