using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskFormalization.Models;

namespace RiskFormalization.ViewModels
{
    public class Analyze2ResultViewModel
    {
        public Analyze2ResultViewModel(ObservableCollection<ItemSet<double>> result, ObservableCollection<RiskCost> startMoney)
        {
            Result = result;
            StartMoney = startMoney;
        }

        public ObservableCollection<ItemSet<double>> Result { get; set; }

        public ObservableCollection<RiskCost> StartMoney { get; set; }
    }
}
