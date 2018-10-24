using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace RiskFormalization.Models
{
    public class RiskCost: BindableBase
    {
        public RiskCost(string description, double value)
        {
            Description = description;
            Value = value;
        }

        private string _description;

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private double _value;

        public double Value
        {
            get => _value;
            set => SetProperty(ref _value, value);
        }
    }
}
