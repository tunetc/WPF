using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace INZ3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Label_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length > 0 && Path.GetExtension(files[0]).ToLower() == ".txt")
                {
                    Label label = sender as Label;
                    TextBox associatedTextBox = GetAssociatedTextBox(label);
                    if (associatedTextBox != null)
                    {
                        label.Content = Path.GetFileName(files[0]);
                        associatedTextBox.Text = File.ReadAllText(files[0]);
                    }
                }
            }
        }

        private TextBox GetAssociatedTextBox(Label label)
        {
            if (label == Label1) return TextBox1;
            if (label == Label2) return TextBox2;
            if (label == Label3) return TextBox3;
            return null;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            TextBox focusedTextBox = Keyboard.FocusedElement as TextBox;
            if (focusedTextBox != null)
            {
                Label associatedLabel = GetAssociatedLabel(focusedTextBox);
                if (associatedLabel != null && associatedLabel.Content.ToString() != "No file")
                {
                    File.WriteAllText(associatedLabel.Content.ToString(), focusedTextBox.Text);
                }
            }
        }

        private Label GetAssociatedLabel(TextBox textBox)
        {
            if (textBox == TextBox1) return Label1;
            if (textBox == TextBox2) return Label2;
            if (textBox == TextBox3) return Label3;
            return null;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox focusedTextBox = Keyboard.FocusedElement as TextBox;
            if (focusedTextBox != null)
            {
                Label associatedLabel = GetAssociatedLabel(focusedTextBox);
                if (associatedLabel != null)
                {
                    focusedTextBox.Clear();
                    associatedLabel.Content = "No file";
                }
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
