using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Lab5
{
    public partial class MainWindow : Window
    {
        private Brush backgr;
        private Brush foregr;
        private Brush bordbr;
        private Thickness bordth;

        public MainWindow()
        {
            InitializeComponent();
            grid1.AddHandler(TextBox.TextChangedEvent, new TextChangedEventHandler(textBox_TextChanged));
            backgr = textBox1.Background;
            foregr = textBox1.Foreground;
            bordbr = textBox1.BorderBrush;
            bordth = textBox1.BorderThickness;
            textBox1.Focus();
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = e.Source as TextBox;
            if (tb == null)
                return;
            tb.Foreground = Brushes.White;
            tb.Background = Brushes.Green;
            tb.Select(tb.Text.Length, 0);
        }

        private void textBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = e.Source as TextBox;
            if (tb == null) return;
            tb.Foreground = foregr;
            tb.Background = backgr;
        }

        private void radioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (radioButton1.IsChecked == true)
            {
                int tabIndex = 0;
                for (int row = 0; row < 4; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        TextBox tb = GetTextBoxAt(row, col);
                        if (tb != null)
                        {
                            tb.TabIndex = tabIndex++;
                        }
                    }
                }
            }
            else if (radioButton2.IsChecked == true)
            {
                int tabIndex = 0;
                for (int col = 0; col < 3; col++)
                {
                    for (int row = 0; row < 4; row++)
                    {
                        TextBox tb = GetTextBoxAt(row, col);
                        if (tb != null)
                        {
                            tb.TabIndex = tabIndex++;
                        }
                    }
                }
            }
        }

        private TextBox GetTextBoxAt(int row, int col)
        {
            foreach (UIElement element in grid1.Children)
            {
                if (Grid.GetRow(element) == row && Grid.GetColumn(element) == col && element is TextBox)
                {
                    return element as TextBox;
                }
            }
            return null;
        }

        private void grid1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.F2:
                    radioButton1.IsChecked = true;
                    break;
                case Key.F3:
                    radioButton2.IsChecked = true;
                    break;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = e.Source as TextBox;
            if (tb.Text == "")
            {
                tb.BorderBrush = Brushes.Red;
                tb.BorderThickness = new Thickness(1.01);
                tb.ToolTip = "Поле не може бути порожнім";
            }
            else
            {
                tb.BorderBrush = bordbr;
                tb.BorderThickness = bordth;
                tb.ToolTip = null;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool res = false;
            foreach (var element in grid1.Children)
            {
                TextBox tb = element as TextBox;
                if (tb != null && tb.BorderBrush == Brushes.Red)
                {
                    res = true;
                    break;
                }
            }
            e.Cancel = res;
        }
    }
}
