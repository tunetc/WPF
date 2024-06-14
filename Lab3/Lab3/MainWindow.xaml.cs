using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                label1.Content = button.Content;
            }
            label2.Content = "=";
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            double x = 0, x1, x2;
            if (!double.TryParse(textBox1.Text, out x1) || !double.TryParse(textBox2.Text, out x2))
            {
                label2.Content = "= ERROR";
                return;
            }
            switch (label1.Content as string)
            {
                case "+": x = x1 + x2; break;
                case "-": x = x1 - x2; break;
                case "*": x = x1 * x2; break;
                case "/": x = x1 / x2; break;
            }
            label2.Content = "=" + x;
        }

        private void Window_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = e.Text[0];
            switch (c)
            {
                case '+': button1_Click(button1, null); break;
                case '-': button1_Click(button2, null); break;
                case '*': button1_Click(button3, null); break;
                case '/': button1_Click(button4, null); break;
            }
            e.Handled = !(char.IsDigit(c) || c == '-' || c == '\b' || c ==
                System.Globalization.CultureInfo.CurrentCulture.NumberFormat.
                NumberDecimalSeparator[0]);
        }
    }
}
