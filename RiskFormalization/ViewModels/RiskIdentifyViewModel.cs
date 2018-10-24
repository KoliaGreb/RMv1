using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using RiskFormalization.Models;

namespace RiskFormalization.ViewModels
{
    public class RiskIdentifyViewModel : BaseViewModel
    {
        public RiskIdentifyViewModel()
        {
            Header = "Визначення джерел ризиків";
            Id = 1;
            List1 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "функціональні характеристики ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "характеристики якості ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "характеристики надійності ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "застосовність ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "часова продуктивність ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "супроводжуваність ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "повторне використання компонент ПЗ", IsSelected = false},
            };

            List2 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "обмеження сумарного бюджету на програмний проект", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недоступна вартість реалізації програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "низька ступінь реалізму при оцінюванні витрат на програмний проект", IsSelected = false},
            };

            List3 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "властивості та можливості гнучкості внесення змін до планів життєвого циклу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "можливості порушення встановлених термінів реалізації етапів життєвого циклу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "низька ступінь реалізму при встановленні планів і етапів життєвого циклу розроблення ПЗ", IsSelected = false},
            };

            List4 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "хибна стратегія реалізації програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "неефективне планування проекту розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "неякісне оцінювання програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "прогалини в документуванні етапів реалізації програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "промахи в прогнозуванні результатів реалізації програмного проекту", IsSelected = false},
            };

            FindProbabilityCommand = new DelegateCommand<object>(OnFindProbabilityExecute);
            _resultProbability=String.Empty;
        }

        private void OnFindProbabilityExecute(object obj)
        {
            int totalCount = List1.Count + List2.Count + List3.Count + List4.Count;
            int currentCount = 0;
            int allSelectedCount = 0;
            foreach (CheckBoxCustomItem item in List1)
            {
                if (item.IsSelected)
                {
                    currentCount++;
                    allSelectedCount++;
                }
            }

            string probability1 = ((double)((double)currentCount * 100.0 / (double)totalCount)).ToString("N");
            currentCount = 0;
            foreach (CheckBoxCustomItem item in List2)
            {
                if (item.IsSelected)
                {
                    currentCount++;
                    allSelectedCount++;
                }
            }

            string probability2 = ((double)((double)currentCount * 100.0 / (double)totalCount)).ToString("N");
            currentCount = 0;
            foreach (CheckBoxCustomItem item in List3)
            {
                if (item.IsSelected)
                {
                    currentCount++;
                    allSelectedCount++;
                }
            }

            string probability3 = ((double)((double)currentCount * 100.0 / (double)totalCount)).ToString("N");
            currentCount = 0;
            foreach (CheckBoxCustomItem item in List4)
            {
                if (item.IsSelected)
                {
                    currentCount++;
                    allSelectedCount++;
                }
            }

            string probability4 = ((double)((double)currentCount * 100.0 / (double)totalCount)).ToString("N");
            string probabilityAll = ((double)((double)allSelectedCount * 100.0 / (double)totalCount)).ToString("N");
            ResultProbability = String.Format("Ймовірність появи джерел ризиків:\n - технічні джерела:{0} %\n - вартісні джерела: {1} % \n- планові джерела: {2} % \n- джерела ризиків реалізації процесів і процедур управління програмним проектом: {3} %\n\n Можлива поява сумарних ризиків розроблення ПЗ на підставі специфікації вимог: {4} % ", 
                probability1, probability2, probability3, probability4, probabilityAll); 
        }

        public List<CheckBoxCustomItem> List1 { get; set; }
        public List<CheckBoxCustomItem> List2 { get; set; }
        public List<CheckBoxCustomItem> List3 { get; set; }
        public List<CheckBoxCustomItem> List4 { get; set; }

        private string _resultProbability;
        public string ResultProbability
        {
            get => _resultProbability;
            set => SetProperty(ref _resultProbability, value);
        }

        public ICommand FindProbabilityCommand { get; set; }
    }
}
