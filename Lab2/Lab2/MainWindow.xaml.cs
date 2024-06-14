using System.Windows;

namespace Lab2
{
    public partial class MainWindow : Window
    {
        private Window1 win1;
        private Window2 win2;

        public MainWindow()
        {
            InitializeComponent();
            win1 = new Window1();
            win2 = new Window2();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            win1.Owner = this;
            win2.Owner = this;
            win1.Left = this.Left + this.ActualWidth - 10;
            win1.Top = this.Top + this.ActualHeight - 10;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (win1.IsVisible)
            {
                win1.Owner = this;
                win1.Close();
            }
            else
            {
                win1.Owner = this;
                win1.Show();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            win2.Owner = this;
            win2.ShowDialog();
            if (win2.DialogRes)
            {
                win2.button22_Click(null, null);
            }
        }
    }
}
