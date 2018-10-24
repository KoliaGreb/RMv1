using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace RiskFormalization.Models
{
    public class ItemSet<T>: BindableBase
    {
        public ItemSet(string description, T k1, T k2, T k3, T k4, T k5, T k6, T k7, T k8, T k9, T k10, double sumCoeff = 1.0, double finalCostMain = 1.0, RiskCost cost=null, bool isMainRow=false, ProbabilityCaption caption=ProbabilityCaption.Middle)
        {
            Description = description;
            K1 = k1;
            K2 = k2;
            K3 = k3;
            K4 = k4;
            K5 = k5;
            K6 = k6;
            K7 = k7;
            K8 = k8;
            K9 = k9;
            K10 = k10;

            Sum = Add(K1, K2, K3, K4, K5, K6, K7, K8, K9, K10);
            Average = Sum / 10.0;
            IsMainRow = isMainRow;
            if (IsMainRow)
            {
                Probability = Math.Round(sumCoeff, 2);
            }
            else
            {
                Probability = Math.Round(Sum / sumCoeff, 2);
            }

            if (Probability < 0.1)
            {
                ProbabilityCaption = ProbabilityCaption.VeryLow;
            }
            else if(Probability >= 0.1 && Probability < 0.25)
            {
                ProbabilityCaption = ProbabilityCaption.Low;
            }
            else if (Probability >= 0.25 && Probability < 0.5)
            {
                ProbabilityCaption = ProbabilityCaption.Middle;
            }
            else if (Probability >= 0.5 && Probability < 0.75)
            {
                ProbabilityCaption = ProbabilityCaption.High;
            }
            else
            {
                ProbabilityCaption = ProbabilityCaption.VeryHigh;
            }

            if (cost != null)
            {
                RiskCost = cost.Value;

                if (!IsMainRow)
                { 
                    FinalCost = RiskCost + Sum;
                }
                else
                {
                    FinalCost = finalCostMain;
                }
            }
            else
            {
                RiskCost = -1.0;
            }
        }

        private string _description;

        public string Description
        {
            get => _description;
            set
            {
                SetProperty(ref _description, value);
                Update();
            }
        }

        private double _riskCost;
        public double RiskCost
        {
            get => _riskCost;
            set
            {
                SetProperty(ref _riskCost, value);
                Update();
            }
        }

        private T _k1;
        public T K1
        {
            get => _k1;
            set
            {
                SetProperty(ref _k1, value);
                Update();
            }
        }

        private T _k2;
        public T K2
        {
            get => _k2;
            set
            {
                SetProperty(ref _k2, value);
                Update();
            }
        }

        private T _k3;
        public T K3
        {
            get => _k3;
            set
            {
                SetProperty(ref _k3, value);
                Update();
            }
        }

        private T _k4;
        public T K4
        {
            get => _k4;
            set
            {
                SetProperty(ref _k4, value);
                Update();
            }
        }

        private T _k5;
        public T K5
        {
            get => _k5;
            set
            {
                SetProperty(ref _k5, value);
                Update();
            }
        }

        private T _k6;
        public T K6
        {
            get => _k6;
            set
            {
                SetProperty(ref _k6, value);
                Update();
            }
        }

        private T _k7;
        public T K7
        {
            get => _k7;
            set
            {
                SetProperty(ref _k7, value);
                Update();
            }
        }

        private T _k8;
        public T K8
        {
            get => _k8;
            set
            {
                SetProperty(ref _k8, value);
                Update();
            }
        }

        private T _k9;
        public T K9
        {
            get => _k9;
            set
            {
                SetProperty(ref _k9, value);
                Update();
            }
        }

        private T _k10;
        public T K10
        {
            get => _k10;
            set
            {
                SetProperty(ref _k10, value);
                Update();
            }
        }

        private double _average;
        public double Average
        {
            get => _average;
            set => SetProperty(ref _average, value);
        }

        private double _sum;
        public double Sum
        {
            get => _sum;
            set => SetProperty(ref _sum, value);
        }

        private double _finalCost;
        public double FinalCost
        {
            get => _finalCost;
            set => SetProperty(ref _finalCost, value);
        }

        private double _probability;
        public double Probability
        {
            get => _probability;
            set => SetProperty(ref _probability, value);
        }
        public ProbabilityCaption ProbabilityCaption { get; set; }
        public CostResultCaption CostResult { get; set; }

        public bool IsMainRow { get; set; }

        static double Add(T k1, T k2, T k3, T k4, T k5, T k6, T k7, T k8, T k9, T k10)
        {
            dynamic k1x = k1, k2x = k2, k3x = k3, k4x = k4, k5x = k5, k6x = k6, k7x = k7, k8x = k8, k9x = k9, k10x = k10;
            return k1x + k2x + k3x + k4x + k5x + k6x + k7x + k8x + k9x + k10x;
        }

        private void Update()
        {
            Sum = Add(K1, K2, K3, K4, K5, K6, K7, K8, K9, K10);
            Average = Sum / 10.0;
            if (!IsMainRow)
            {
                FinalCost = RiskCost + Sum;
            }
        }
    }
    public enum ProbabilityCaption
    {
        VeryLow,
        Low,
        Middle,
        High,
        VeryHigh
    }

    public enum CostResultCaption
    {
        None,
        Low,
        Middle,
        High
    }
}
