using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace RiskFormalization.Models
{
    public class PlanningItems: BindableBase
    {
        public PlanningItems(string description, bool softening, bool adoption, bool avoidance, bool transfer)
        {
            Description = description;
            Softening = softening;
            Adoption = adoption;
            Avoidance = avoidance;
            Transfer = transfer;
        }

        private string _description;

        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private bool _softening;

        public bool Softening
        {
            get => _softening;
            set => SetProperty(ref _softening, value);
        }

        private bool _adoption;

        public bool Adoption
        {
            get => _adoption;
            set => SetProperty(ref _adoption, value);
        }

        private bool _avoidance;

        public bool Avoidance
        {
            get => _avoidance;
            set => SetProperty(ref _avoidance, value);
        }

        private bool _transfer;

        public bool Transfer
        {
            get => _transfer;
            set => SetProperty(ref _transfer, value);
        }
    }
}
