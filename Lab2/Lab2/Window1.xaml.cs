using System.Windows;
using System.Windows.Controls;

namespace Lab2
{
    public partial class Window1 : Window
    {
        int count;
        public Window1()
        {
            
            InitializeComponent();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsVisible)
                return;
            e.Cancel = true;
            if (MessageBox.Show("Закрити підпорядковане вікно?", "Підтвердження",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question, MessageBoxResult.No) == MessageBoxResult.Yes)
                Hide();
        }
        private void Window_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            (Owner.FindName("button1") as Button).Content = IsVisible ?
                "Закрити підпорядковане вікно" : "Відкрити підпорядковане вікно";
            if (IsVisible)
            {
                textBlock.Text = "Вікно відкрите " + (++count) + "-й раз.";
            }
        }
    }
}
