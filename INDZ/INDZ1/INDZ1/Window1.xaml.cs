using System.Windows;

namespace INDZ1
{
    public partial class Window1 : Window
    {
        public int NewScale { get; private set; }

        public Window1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateScale())
            {
                DialogResult = true;
                Close();
            }
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateScale())
            {
                DialogResult = true;
            }
        }

        private bool ValidateScale()
        {
            if (int.TryParse(txtScale.Text, out int scale) && scale >= 10 && scale <= 300)
            {
                NewScale = scale;
                return true;
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть значення від 10 до 300.", "Невірне значення", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
        }
    }
}
