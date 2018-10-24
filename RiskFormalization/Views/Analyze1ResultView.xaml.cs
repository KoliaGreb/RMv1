using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using RiskFormalization.Models;
using RiskFormalization.ViewModels;

namespace RiskFormalization.Views
{
    /// <summary>
    /// Interaction logic for Analyze1ResultView.xaml
    /// </summary>
    public partial class Analyze1ResultView : Window
    {
        public Analyze1ResultView(ObservableCollection<ItemSet<double>> result)
        {
            DataContext=new Analyze1ResultViewModel(result);
            InitializeComponent();
        }


        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            PropertyDescriptor propertyDescriptor = (PropertyDescriptor)e.PropertyDescriptor;
            e.Column.Header = propertyDescriptor.DisplayName;
            if (propertyDescriptor.DisplayName == "IsMainRow")
            {
                e.Cancel = true;
            }

            if (propertyDescriptor.DisplayName == "Sum")
            {
                e.Cancel = true;
            }

            if (propertyDescriptor.DisplayName == "Average")
            {
                e.Cancel = true;
            }

            if (propertyDescriptor.DisplayName == "RiskCost")
            {
                e.Cancel = true;
            }

            if (propertyDescriptor.DisplayName == "FinalCost")
            {
                e.Cancel = true;
            }

            if (propertyDescriptor.DisplayName == "CostResult")
            {
                e.Cancel = true;
            }
        }
    }
}
