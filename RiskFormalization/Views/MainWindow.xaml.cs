using System.Windows;
using RiskFormalization.ViewModels;

namespace RiskFormalization.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            DataContext = new MainWindowsViewModel();

            InitializeComponent();
        }

    }
}
