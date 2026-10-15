using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace todo_wpf.Pages
{
    public partial class StopwatchPage : Page
    {
        private int stopWatchVal = 0;
        private bool timeStart = false;

        private string initialText = "Start";
        private readonly DispatcherTimer timer;

        public StopwatchPage()
        {
            InitializeComponent();

            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            timer.Tick += Timer_Tick;
            btnReset.Visibility = Visibility.Hidden;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            stopWatchVal++;
            tbStopWatch.Text = stopWatchVal.ToString();
        }

        private void btnToggle_Click(object sender, RoutedEventArgs e)
        {
            timeStart = !timeStart;

            if (timeStart)
            {
                btnToggle.Content = "Stop";
                btnReset.Visibility = Visibility.Visible;
                timer.Start();
            }
            else
            {
                btnToggle.Content = initialText;
                timer.Stop();
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            timeStart = false;
            timer.Stop();

            stopWatchVal = 0;
            tbStopWatch.Text = stopWatchVal.ToString();

            btnToggle.Content = initialText;
            btnReset.Visibility = Visibility.Hidden;
        }
    }
}
