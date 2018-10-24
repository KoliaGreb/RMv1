using System.Windows.Controls;
using RiskFormalization.ViewModels;

namespace RiskFormalization.Views
{
    /// <summary>
    /// Interaction logic for RiskEventIdentifyView.xaml
    /// </summary>
    public partial class RiskEventIdentifyView : UserControl
    {
        public RiskEventIdentifyView()
        {
            DataContext = new RiskEventIdentifyViewModel();
            InitializeComponent();
        }
    }
}
