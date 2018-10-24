using System.Windows.Controls;
using RiskFormalization.ViewModels;

namespace RiskFormalization.Views
{
    /// <summary>
    /// Interaction logic for RiskIdentifyView.xaml
    /// </summary>
    public partial class RiskIdentifyView : UserControl
    {
        public RiskIdentifyView()
        {
            DataContext = new RiskIdentifyViewModel();
            InitializeComponent();
        }
    }
}
