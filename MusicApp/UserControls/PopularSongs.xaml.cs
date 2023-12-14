using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace MusicApp.UserControls
{
    public partial class PopularSongs : UserControl
    {
        public PopularSongs()
        {
            InitializeComponent();
        }
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register
          ("Title", typeof(string), typeof(PopularSongs));

        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }
        public static readonly DependencyProperty TimeProperty = DependencyProperty.Register
          ("Time", typeof(string), typeof(PopularSongs));

        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register
          ("IsActive", typeof(bool), typeof(PopularSongs));

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register
          ("Image", typeof(ImageSource), typeof(PopularSongs));
    }
}
