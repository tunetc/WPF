using System.Windows;
using System.Windows.Controls;

namespace INDZ2
{
    public partial class Window1 : Window
    {
        private MainWindow _mainWindow;

        public Window1(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null)
            {
                UpdateTextBoxes(radioButton.Content.ToString());
            }
        }

        private void UpdateTextBoxes(string selectedNumber)
        {
            _mainWindow.ResetTextBoxStyles();

            switch (selectedNumber)
            {
                case "1":
                    _mainWindow.TextBox1.FontWeight = FontWeights.Bold;
                    break;
                case "2":
                    _mainWindow.TextBox2.FontWeight = FontWeights.Bold;
                    break;
                case "3":
                    _mainWindow.TextBox3.FontWeight = FontWeights.Bold;
                    break;
                case "4":
                    _mainWindow.TextBox4.FontWeight = FontWeights.Bold;
                    break;
                case "5":
                    _mainWindow.TextBox5.FontWeight = FontWeights.Bold;
                    break;
                case "6":
                    _mainWindow.TextBox6.FontWeight = FontWeights.Bold;
                    break;
            }
        }
    }
}
