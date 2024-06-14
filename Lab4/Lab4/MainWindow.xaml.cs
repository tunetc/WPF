using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace Lab4
{
    public partial class MainWindow : Window
    {
        DispatcherTimer timer1;
        DateTime startTime, pauseTime;
        TimeSpan pauseSpan;

        public MainWindow()
        {
            InitializeComponent();
            timer1 = new DispatcherTimer();
            timer1.Interval = TimeSpan.FromMilliseconds(1000);
            timer1.Tick += timer1_Tick;
            timer1.Start();
            timer1_Tick(null, null);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if ((bool)checkBox1.IsChecked)
            {
                TimeSpan s = DateTime.Now - startTime - pauseSpan;
                textBlock1.Text = string.Format("{0}:{1:D2}", s.Minutes * 60 + s.Seconds, s.Milliseconds / 100);
            }
            else
            {
                textBlock1.Text = DateTime.Now.ToLongTimeString();
            }
        }

        private void checkBox1_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)checkBox1.IsChecked)
            {
                startTime = DateTime.Now;
                pauseSpan = TimeSpan.Zero;
                timer1.Interval = TimeSpan.FromMilliseconds(100);
            }
            else
            {
                timer1.Interval = TimeSpan.FromMilliseconds(1000);
            }

            timer1_Tick(null, null);
            button1.IsEnabled = button2.IsEnabled = (bool)checkBox1.IsChecked;
            timer1.IsEnabled = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            timer1.IsEnabled = !timer1.IsEnabled;
            if (timer1.IsEnabled) pauseSpan += DateTime.Now - pauseTime;
            else pauseTime = DateTime.Now;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            timer1.IsEnabled = false;
            pauseTime = startTime;
            pauseSpan = TimeSpan.Zero;
            textBlock1.Text = "0:00";
        }

        private void textBlock1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Title = "Таймер";
            if (e.ClickCount == 1)
            {
                if (!button1.IsEnabled)
                    return;
                if (e.ChangedButton == MouseButton.Left)
                    button1_Click(null, null);
                else if (e.ChangedButton == MouseButton.Right)
                    button2_Click(null, null);
            }
            else if (e.ClickCount == 2)
            {
                checkBox1.IsChecked = !(bool)checkBox1.IsChecked;
                checkBox1_Click(null, null);
            }
        }
    }
}
