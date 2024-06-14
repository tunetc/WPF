using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Lab9
{
    public partial class MainWindow : Window
    {
        private SaveFileDialog saveFileDialog = new SaveFileDialog();
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private bool Modified { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            textBox1.Focus();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            Modified = false;
        }

        private void SaveToFile(string path)
        {
            File.WriteAllText(path, textBox1.Text, Encoding.Default);
            Modified = false;
        }

        private bool TextSaved()
        {
            if (Modified)
            {
                var result = MessageBox.Show("Зберегти зміни у файлі?", "Підтвердження",
                    MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    save0_Executed(null, null);
                    return !Modified;
                }
                else if (result == MessageBoxResult.Cancel)
                {
                    return false;
                }
            }
            return true;
        }

        private void exit0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void save0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string path = saveFileDialog.FileName;
            if (string.IsNullOrEmpty(path))
            {
                saveAs0_Executed(sender, e);
            }
            else
            {
                SaveToFile(path);
            }
        }

        private void new0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (TextSaved())
            {
                textBox1.Clear();
                Title = "Text Editor (v 1.0)";
                saveFileDialog.FileName = string.Empty;
                Modified = false;
            }
        }

        private void open0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (TextSaved())
            {
                openFileDialog.FileName = string.Empty;
                if (openFileDialog.ShowDialog() == true)
                {
                    string path = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(path, Encoding.Default);
                    Title = "Text Editor (v 1.0) - " + path;
                    saveFileDialog.FileName = path;
                    Modified = false;
                }
            }
        }

        private void saveAs0_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var oldPath = saveFileDialog.FileName;
            saveFileDialog.FileName = System.IO.Path.GetFileName(saveFileDialog.FileName);
            if (saveFileDialog.ShowDialog() == true)
            {
                string path = saveFileDialog.FileName;
                SaveToFile(path);
                Title = "Text Editor (v 1.0) - " + path;
            }
            else
            {
                saveFileDialog.FileName = oldPath;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = !TextSaved();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Modified = true;
        }

        private void save0_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = Modified;
        }
    }
}
