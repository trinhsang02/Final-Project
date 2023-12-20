using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Controls;


namespace MusicApp.UserControls
{
    public partial class SettingsUserControl : UserControl
    {
        public SettingsUserControl()
        {
            InitializeComponent();
        }

        public void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Border_MouseDown(sender, e);
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).Button_Click(sender, e);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            //MainContent.Content = new SongsUserControl();
        }

        private void VideosButton_Click(object sender, RoutedEventArgs e)
        {
            //MainContent.Content = new VideosUserControl();
        }

        private void SongsButton_Click(object sender, RoutedEventArgs e)
        {
            //.Content = new SettingsUserControl();
        }
    }
}

