﻿using MahApps.Metro.IconPacks;
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

        private void SongsButton_Click(object sender, RoutedEventArgs e)
        {
            // Tạo một thể hiện của SongsWindow
            SongsWindow songsWindow = new SongsWindow();
            // Hiển thị SongsWindow
            songsWindow.Show();
            // Đóng cửa sổ hiện tại
            this.Close();
        }

        private void VideosButton_Click(object sender, RoutedEventArgs e)
        {
            // Tạo một thể hiện của VideosWindow
            VideosWindow videosWindow = new VideosWindow();
            // Hiển thị VideosWindow
            videosWindow.Show();
            // Đóng cửa sổ hiện tại
            this.Close();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // Tạo một thể hiện của SettingsWindow
            SettingsWindow settingsWindow = new SettingsWindow();
            // Hiển thị SettingsWindow
            settingsWindow.Show();
            // Đóng cửa sổ hiện tại
            this.Close();
        }


    }
}
