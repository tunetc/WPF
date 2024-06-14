using System.Windows;

namespace INDZ1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnChangeScale_Click(object sender, RoutedEventArgs e)
        {
            Window1 scaleWindow = new Window1();
            if (scaleWindow.ShowDialog() == true)
            {
                int newScale = scaleWindow.NewScale;
                this.Width = 400 * newScale / 100;
                this.Height = 300 * newScale / 100;
            }
        }
    }
}