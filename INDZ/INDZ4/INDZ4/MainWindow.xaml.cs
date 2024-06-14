using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace INDZ4
{
    public partial class MainWindow : Window
    {
        private System.Timers.Timer _timer;
        private int _timeLeft;
        private int _score;
        private string _currentLetter;
        private Random _random;
        private List<int> _bestResults;

        public MainWindow()
        {
            InitializeComponent();
            _random = new Random();
            _bestResults = new List<int>();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            if (_timer != null && _timer.Enabled)
            {
                _timer.Stop();
            }
            _score = 0;
            ScoreTextBox.Text = _score.ToString();
            GenerateNewLetter();
            _timer = new System.Timers.Timer(100);
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();
        }

        private void SetTime_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                _timeLeft = int.Parse(button.Tag.ToString()) * 10;
                TimeTextBox.Text = (_timeLeft / 10.0).ToString("0.0");
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (_timeLeft > 0)
            {
                _timeLeft--;
                Dispatcher.Invoke(() => TimeTextBox.Text = (_timeLeft / 10.0).ToString("0.0"));
            }
            else
            {
                _timer.Stop();
                Dispatcher.Invoke(() =>
                {
                    MessageBox.Show("Time's up! Your score: " + _score);
                    SaveBestResult(_score);
                });
            }
        }

        private void GenerateNewLetter()
        {
            _currentLetter = ((char)_random.Next(97, 123)).ToString();
            Dispatcher.Invoke(() => (this.Content as Grid).Children.OfType<Label>().First().Content = _currentLetter);
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString().ToLower() == _currentLetter)
            {
                _score++;
            }
            else
            {
                _score--;
            }
            Dispatcher.Invoke(() => ScoreTextBox.Text = _score.ToString());
            GenerateNewLetter();
        }


        private void SaveBestResult(int score)
        {
            _bestResults.Add(score);
            _bestResults = _bestResults.OrderByDescending(x => x).Take(10).ToList();
            BestResultsListBox.ItemsSource = _bestResults;
        }
    }
}
