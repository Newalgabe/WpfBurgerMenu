using System.Windows;
using System.Windows.Media.Animation;

namespace WpfApp12
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuPanel.Margin.Left < 0)
            {
                Storyboard openMenuAnimation = this.FindResource("OpenMenuAnimation") as Storyboard;
                Storyboard.SetTarget(openMenuAnimation, MenuPanel);
                openMenuAnimation.Begin();
            }
            else
            {
                Storyboard closeMenuAnimation = this.FindResource("CloseMenuAnimation") as Storyboard;
                Storyboard.SetTarget(closeMenuAnimation, MenuPanel);
                closeMenuAnimation.Begin();
            }
        }
    }
}

