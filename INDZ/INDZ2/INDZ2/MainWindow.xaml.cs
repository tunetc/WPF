using System.Windows;
using System.Windows.Controls;

namespace INDZ2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            Window1 secondWindow = new Window1(this);
            secondWindow.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                UpdateRadioButtonContent(textBox);
            }
        }

        private void UpdateRadioButtonContent(TextBox textBox)
        {
            Window1 secondWindow = Application.Current.Windows.OfType<Window1>().FirstOrDefault();
            if (secondWindow != null)
            {
                if (textBox == TextBox1)
                {
                    secondWindow.RadioButton1.Content = textBox.Text;
                }
                else if (textBox == TextBox2)
                {
                    secondWindow.RadioButton2.Content = textBox.Text;
                }
                else if (textBox == TextBox3)
                {
                    secondWindow.RadioButton3.Content = textBox.Text;
                }
                else if (textBox == TextBox4)
                {
                    secondWindow.RadioButton4.Content = textBox.Text;
                }
                else if (textBox == TextBox5)
                {
                    secondWindow.RadioButton5.Content = textBox.Text;
                }
                else if (textBox == TextBox6)
                {
                    secondWindow.RadioButton6.Content = textBox.Text;
                }
            }
        }

        public void ResetTextBoxStyles()
        {
            TextBox1.FontWeight = FontWeights.Normal;
            TextBox2.FontWeight = FontWeights.Normal;
            TextBox3.FontWeight = FontWeights.Normal;
            TextBox4.FontWeight = FontWeights.Normal;
            TextBox5.FontWeight = FontWeights.Normal;
            TextBox6.FontWeight = FontWeights.Normal;
        }
    }
}
