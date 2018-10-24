using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskFormalization.Models;

namespace RiskFormalization.ViewModels
{
    public class Analyze1ResultViewModel
    {
        public Analyze1ResultViewModel(ObservableCollection<ItemSet<double>> result)
        {
            Result = result;
        }

        public ObservableCollection<ItemSet<double>> Result { get; set; }
    }
}
