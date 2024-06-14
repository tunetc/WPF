using System.Windows;

namespace Lab2
{
    public partial class Window2 : Window
    {
        bool dialogRes;
        public bool DialogRes
        {
            get { return dialogRes; }
        }
        public Window2()
        {
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (IsVisible)
            {
                dialogRes = false;
            }
        }
        private void button21_Click(object sender, RoutedEventArgs e)
        {
            dialogRes = true;
            Close();
        }
        public void button22_Click(object sender, RoutedEventArgs e)
        {
            Owner.Title = textBox1.Text;
            Owner.OwnedWindows[0].Title = textBox2.Text;
        }
    }
}
