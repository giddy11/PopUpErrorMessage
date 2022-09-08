using win = System.Windows;

namespace CCSAWpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : win.Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, win.RoutedEventArgs e)
        {
            win.MessageBox.Show("Clicked!");
        }
    }
}
