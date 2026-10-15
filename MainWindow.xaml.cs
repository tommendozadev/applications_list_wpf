using System.Windows;
using todo_wpf.Pages;

namespace todo_wpf
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void App1_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StopwatchPage());
        }

        private void App2_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TodoListPage());
        }
    }
}
