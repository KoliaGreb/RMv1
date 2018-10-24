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
    public class RiskEventIdentifyViewModel : BaseViewModel
    {
        public RiskEventIdentifyViewModel()
        {
            Header = "Ідентифікація ризикових подій";
            Id = 2;
            List1 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "небажання команди виконавців використовувати інструментальні засоби для підтримки процесу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "формування запитів на більш потужні інструментальні засоби розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "відмова команди виконавців від CASE-засобів розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості", IsSelected = false},
                new CheckBoxCustomItem(){Name = "швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів", IsSelected = false},
                new CheckBoxCustomItem(){Name = "поява дефектних системних компонент, які використовують для розроблення ПЗ", IsSelected = false},
            };

            List2 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "недо(пере)оцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)", IsSelected = false},
                new CheckBoxCustomItem(){Name = "фінансові ускладнення у компанії-замовника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "фінансові ускладнення у компанії-розробника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "змен(збіль)шення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації", IsSelected = false},
                new CheckBoxCustomItem(){Name = "висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "реорганізація структурних підрозділів у компанії-замовника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "реорганізація команди виконавців у компанії-розробника ПЗ", IsSelected = false},
            };

            List3 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "зміни графіка виконання робіт з боку замовника чи розробника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "порушення графіка виконання робіт з боку компанії-розробника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "потреба зміни користувацьких вимог до ПЗ з боку компанії-замовника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недо(пере)оцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "остаточний розмір ПЗ значно перевищує (менший від) заплановані(их) його характеристики", IsSelected = false},
                new CheckBoxCustomItem(){Name = "поява на ринку аналогічного ПЗ до виходу замовленого", IsSelected = false},
                new CheckBoxCustomItem(){Name = "поява на ринку більш конкурентоздатного ПЗ", IsSelected = false},
            };

            List4 = new List<CheckBoxCustomItem>()
            {
                new CheckBoxCustomItem(){Name = "низький моральний стан персоналу команди виконавців ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "низька взаємодія між членами команди виконавців ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "пасивність керівника (менеджера) програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недостатня компетентність керівника (менеджера) програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "незадоволеність замовника результатами етапів реалізації програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем", IsSelected = false},
                new CheckBoxCustomItem(){Name = "хвороба провідного виконавця в найкритичніший момент розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "одночасна хвороба декількох виконавців підчас розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "неможливість організації необхідного навчання персоналу команди виконавців ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "зміна пріоритетів у процесі управління програмним проектом", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недо(пере)оцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недостатнє (надмірне) документування результатів на етапах реалізації програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "нереалістичне прогнозування результатів на етапах реалізації програмного проекту", IsSelected = false},
                new CheckBoxCustomItem(){Name = "недостатній професійний рівень представників від компанії-замовника ПЗ", IsSelected = false},
            };

            FindProbabilityCommand = new DelegateCommand<object>(OnFindProbabilityExecute);
            _resultProbability = String.Empty;
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
