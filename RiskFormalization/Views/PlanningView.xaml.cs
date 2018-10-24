using System.Windows.Controls;
using RiskFormalization.ViewModels;

namespace RiskFormalization.Views
{
    /// <summary>
    /// Interaction logic for RiskEventIdentifyView.xaml
    /// </summary>
    public partial class PlanningView : UserControl
    {
        public PlanningView()
        {
            DataContext = new PlanningViewModel();
            InitializeComponent();
        }
    }
}
