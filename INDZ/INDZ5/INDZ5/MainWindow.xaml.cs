using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace INDZ5
{
    public partial class MainWindow : Window
    {
        private string currentFileName;
        private bool isTextChanged = false;

        public MainWindow()
        {
            InitializeComponent();
            InputTextBox.TextChanged += InputTextBox_TextChanged;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                currentFileName = openFileDialog.FileName;
                InputTextBox.Text = File.ReadAllText(currentFileName);
                this.Title = System.IO.Path.GetFileName(currentFileName);
                isTextChanged = false;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (currentFileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                {
                    currentFileName = saveFileDialog.FileName;
                }
                else
                {
                    return;
                }
            }

            File.WriteAllText(currentFileName, InputTextBox.Text);
            this.Title = System.IO.Path.GetFileName(currentFileName);
            isTextChanged = false;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (isTextChanged)
            {
                MessageBoxResult result = MessageBox.Show("You have unsaved changes. Do you want to save them?", "Unsaved Changes", MessageBoxButton.YesNoCancel);
                if (result == MessageBoxResult.Yes)
                {
                    Save_Click(sender, e);
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    return;
                }
            }

            Application.Current.Shutdown();
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextBox.SelectedText.Length > 0)
            {
                string selectedText = InputTextBox.SelectedText;
                string conversionType = ((ComboBoxItem)ConversionComboBox.SelectedItem)?.Content.ToString();

                if (conversionType != null)
                {
                    try
                    {
                        string convertedText = ConvertNumber(selectedText, conversionType);
                        InputTextBox.SelectedText = convertedText;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid number format for the selected conversion.", "Conversion Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a conversion type.", "No Conversion Type", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select text to convert.", "No Text Selected", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private string ConvertNumber(string number, string conversionType)
        {
            switch (conversionType)
            {
                case "10→2":
                    return Convert.ToString(int.Parse(number), 2);
                case "2→10":
                    return Convert.ToInt32(number, 2).ToString();
                case "10→16":
                    return Convert.ToString(int.Parse(number), 16).ToUpper();
                case "16→10":
                    return Convert.ToInt32(number, 16).ToString();
                case "2→16":
                    return Convert.ToString(Convert.ToInt32(number, 2), 16).ToUpper();
                case "16→2":
                    return Convert.ToString(Convert.ToInt32(number, 16), 2);
                default:
                    throw new NotSupportedException("Conversion type not supported.");
            }
        }

        private void InputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            isTextChanged = true;
            if (!this.Title.EndsWith("*"))
            {
                this.Title += "*";
            }
        }
    }
}
