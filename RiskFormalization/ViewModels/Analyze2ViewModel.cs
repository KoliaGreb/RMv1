using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using RiskFormalization.Models;
using RiskFormalization.Views;

namespace RiskFormalization.ViewModels
{
    public class Analyze2ViewModel: BaseViewModel
    {
        public Analyze2ViewModel()
        {
            Header = "Визначення збитків";
            Id = 6;
            AnalyzeOpenCostResultCommand = new DelegateCommand<object>(OnAnalyzeOpenCostResultCommandExecute);

            StartMoney = new ObservableCollection<RiskCost>()
            {
                new RiskCost("Множина настання технічних ризикових подій", 330.0),
                new RiskCost("Множина настання вартісних ризикових подій", 250.0),
                new RiskCost("Множина настання планових ризикових подій", 320.0),
                new RiskCost("Множина настання ризикових подій реалізації процесу управління програмним проектом", 360.0)
            };

            ExpertCoeffListForCost = new ObservableCollection<ItemSet<double>>()
            {
                new ItemSet<double>("Множина настання технічних ризикових подій", 8, 7, 10, 7, 9, 8, 7, 9, 8, 7, isMainRow:true),
                new ItemSet<double>("Множина настання вартісних ризикових подій", 7, 7, 9, 8, 8, 6, 9, 10, 8, 7, isMainRow:true),
                new ItemSet<double>("Множина настання планових ризикових подій", 8, 9, 6, 6, 7, 10, 9, 8, 10, 6, isMainRow:true),
                new ItemSet<double>("Множина настання ризиків процесу управління", 10, 10, 8, 10, 8, 8, 10, 8, 9, 8, isMainRow:true)
            };

            Random random = new Random();

            // вартість збитків
            ExpertMarksList1 = new ObservableCollection<ItemSet<double>>()
            {
                ExpertCoeffListForCost[0],


                new ItemSet<double>("затримки у постачанні обладнання, необхідного для підтримки процесу розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("затримки у постачанні інструментальних засобів, необхідних для підтримки процесу розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("небажання команди виконавців використовувати інструментальні засоби для підтримки процесу розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("формування запитів на більш потужні інструментальні засоби розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("відмова команди виконавців від CASE-засобів розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("неефективність програмного коду, згенерованого CASE-засобами розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("неможливість інтеграції CASE-засобів з іншими інструментальними засобами для підтримки процесу розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("недостатня продуктивність баз(и) даних для підтримки процесу розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("програмні компоненти, які використовують повторно в ПЗ, мають дефекти та обмежені функціональні можливості",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("швидкість виявлення дефектів у програмному коді є нижчою від раніше запланованих термінів",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),
                new ItemSet<double>("поява дефектних системних компонент, які використовують для розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[0].Sum),

                ExpertCoeffListForCost[1],

                new ItemSet<double>("недо(пере)оцінювання витрат на реалізацію програмного проекту (надмірно низька вартість)",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[1].Sum),
                new ItemSet<double>("фінансові ускладнення у компанії-замовника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[1].Sum),
                new ItemSet<double>("фінансові ускладнення у компанії-розробника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[1].Sum),
                new ItemSet<double>("змен(збіль)шення бюджету програмного проекта з ініціативи компанії-замовника ПЗ під час його реалізації",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[1].Sum),
                new ItemSet<double>("висока вартість виконання повторних робіт, необхідних для зміни вимог до ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[1].Sum),
                new ItemSet<double>("реорганізація структурних підрозділів у компанії-замовника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[1].Sum),
                new ItemSet<double>("реорганізація команди виконавців у компанії-розробника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[1].Sum),

                ExpertCoeffListForCost[2],

                new ItemSet<double>("зміни графіка виконання робіт з боку замовника чи розробника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("порушення графіка виконання робіт з боку компанії-розробника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("потреба зміни користувацьких вимог до ПЗ з боку компанії-замовника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("потреба зміни функціональних вимог до ПЗ з боку компанії-розробника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("потреба виконання великої кількості повторних робіт, необхідних для зміни вимог до ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("недо(пере)оцінювання тривалості етапів реалізації програмного проекту з боку компанії-замовника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("остаточний розмір ПЗ значно перевищує (менший від) заплановані(их) його характеристики",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("поява на ринку аналогічного ПЗ до виходу замовленого",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),
                new ItemSet<double>("поява на ринку більш конкурентоздатного ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[2].Sum),

                ExpertCoeffListForCost[3],

                new ItemSet<double>("низький моральний стан персоналу команди виконавців ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("низька взаємодія між членами команди виконавців ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("пасивність керівника (менеджера) програмного проекту",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("незадоволеність замовника результатами етапів реалізації програмного проекту",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("незадоволеність замовника результатами етапів реалізації програмного проекту",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("недостатня кількість фахівців у команді виконавців ПЗ з необхідним професійним рівнем",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("хвороба провідного виконавця в найкритичніший момент розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("одночасна хвороба декількох виконавців підчас розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("неможливість організації необхідного навчання персоналу команди виконавців ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("зміна пріоритетів у процесі управління програмним проектом",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("недо(пере)оцінювання необхідної кількості розробників (підрядників і субпідрядників) на етапах життєвого циклу розроблення ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("недостатнє (надмірне) документування результатів на етапах реалізації програмного проекту",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("нереалістичне прогнозування результатів на етапах реалізації програмного проекту",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),
                new ItemSet<double>("недостатній професійний рівень представників від компанії-замовника ПЗ",
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2), Math.Round(random.NextDouble(),2),
                    Math.Round(random.NextDouble(),2), ExpertCoeffListForCost[3].Sum),

            };
        }

        private void OnAnalyzeOpenCostResultCommandExecute(object obj)
        {
            ExpertResultMarksList1 = new ObservableCollection<ItemSet<double>>();
            ItemSet<double> currentExpertCoeff = ExpertMarksList1[0];
            List<ItemSet<double>> markForList1 = new List<ItemSet<double>>();
            List<ItemSet<double>> markForList2 = new List<ItemSet<double>>();
            List<ItemSet<double>> markForList3 = new List<ItemSet<double>>();
            List<ItemSet<double>> markForList4 = new List<ItemSet<double>>();
            List<int> indexList = new List<int>();
            int k = 0;
            for (int i = 0; i < ExpertMarksList1.Count; i++)
            {
                if (ExpertMarksList1[i].IsMainRow)
                {
                    currentExpertCoeff = ExpertMarksList1[i];
                    k++;
                    indexList.Add(i);
                }
                else
                {
                    ExpertResultMarksList1.Add
                    (
                        new ItemSet<double>
                        (
                            ExpertMarksList1[i].Description,
                            currentExpertCoeff.K1 * ExpertMarksList1[i].K1,
                            currentExpertCoeff.K2 * ExpertMarksList1[i].K2,
                            currentExpertCoeff.K3 * ExpertMarksList1[i].K3,
                            currentExpertCoeff.K4 * ExpertMarksList1[i].K4,
                            currentExpertCoeff.K5 * ExpertMarksList1[i].K5,
                            currentExpertCoeff.K6 * ExpertMarksList1[i].K6,
                            currentExpertCoeff.K7 * ExpertMarksList1[i].K7,
                            currentExpertCoeff.K8 * ExpertMarksList1[i].K8,
                            currentExpertCoeff.K9 * ExpertMarksList1[i].K9,
                            currentExpertCoeff.K10 * ExpertMarksList1[i].K10,
                            currentExpertCoeff.Sum
                        )
                    );

                    ItemSet<double> itemSet = ExpertResultMarksList1.LastOrDefault();
                    switch (k)
                    {
                        case 1:
                            markForList1.Add(itemSet);
                            break;

                        case 2:
                            markForList2.Add(itemSet);
                            break;

                        case 3:
                            markForList3.Add(itemSet);
                            break;

                        case 4:
                            markForList4.Add(itemSet);
                            break;
                    }
                }
            }

            List<double> sum = new List<double>();
            foreach (ItemSet<double> itemSet in ExpertResultMarksList1)
            {
                sum.Add(itemSet.Sum);
            }

            var diapason=(sum.Max() - sum.Min()) / 3.0;
            var startRange1 = sum.Min() + diapason;
            var startRange2 = sum.Min() + diapason + diapason;

            foreach (ItemSet<double> itemSet in markForList1)
            {
                itemSet.RiskCost = Math.Round(StartMoney[0].Value / markForList1.Count, 2);
                if (itemSet.Sum < startRange1)
                {
                    itemSet.CostResult = CostResultCaption.Low;
                }
                else if(itemSet.Sum > startRange2)
                {
                    itemSet.CostResult = CostResultCaption.High;
                }
                else
                {
                    itemSet.CostResult = CostResultCaption.Middle;
                }
            }
            foreach (ItemSet<double> itemSet in markForList2)
            {
                itemSet.RiskCost = Math.Round(StartMoney[1].Value / markForList2.Count, 2);
                if (itemSet.Sum < startRange1)
                {
                    itemSet.CostResult = CostResultCaption.Low;
                }
                else if (itemSet.Sum > startRange2)
                {
                    itemSet.CostResult = CostResultCaption.High;
                }
                else
                {
                    itemSet.CostResult = CostResultCaption.Middle;
                }
            }
            foreach (ItemSet<double> itemSet in markForList3)
            {
                itemSet.RiskCost = Math.Round(StartMoney[2].Value / markForList3.Count, 2);
                if (itemSet.Sum < startRange1)
                {
                    itemSet.CostResult = CostResultCaption.Low;
                }
                else if (itemSet.Sum > startRange2)
                {
                    itemSet.CostResult = CostResultCaption.High;
                }
                else
                {
                    itemSet.CostResult = CostResultCaption.Middle;
                }
            }
            foreach (ItemSet<double> itemSet in markForList4)
            {
                itemSet.RiskCost = Math.Round(StartMoney[3].Value / markForList4.Count, 2);
                if (itemSet.Sum < startRange1)
                {
                    itemSet.CostResult = CostResultCaption.Low;
                }
                else if (itemSet.Sum > startRange2)
                {
                    itemSet.CostResult = CostResultCaption.High;
                }
                else
                {
                    itemSet.CostResult = CostResultCaption.Middle;
                }
            }

            for (int i = 0; i < indexList.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        ExpertResultMarksList1.Insert(indexList[i],
                            new ItemSet<double>
                            (
                                ExpertMarksList1[indexList[i]].Description,
                                Math.Round(markForList1.Sum(x => x.K1) / markForList1.Count / ExpertMarksList1[indexList[i]].K1, 2),
                                Math.Round(markForList1.Sum(x => x.K2) / markForList1.Count / ExpertMarksList1[indexList[i]].K2, 2),
                                Math.Round(markForList1.Sum(x => x.K3) / markForList1.Count / ExpertMarksList1[indexList[i]].K3, 2),
                                Math.Round(markForList1.Sum(x => x.K4) / markForList1.Count / ExpertMarksList1[indexList[i]].K4, 2),
                                Math.Round(markForList1.Sum(x => x.K5) / markForList1.Count / ExpertMarksList1[indexList[i]].K5, 2),
                                Math.Round(markForList1.Sum(x => x.K6) / markForList1.Count / ExpertMarksList1[indexList[i]].K6, 2),
                                Math.Round(markForList1.Sum(x => x.K7) / markForList1.Count / ExpertMarksList1[indexList[i]].K7, 2),
                                Math.Round(markForList1.Sum(x => x.K8) / markForList1.Count / ExpertMarksList1[indexList[i]].K8, 2),
                                Math.Round(markForList1.Sum(x => x.K9) / markForList1.Count / ExpertMarksList1[indexList[i]].K9, 2),
                                Math.Round(markForList1.Sum(x => x.K10) / markForList1.Count / ExpertMarksList1[indexList[i]].K10, 2),
                                markForList1.Sum(x => x.Probability) / markForList1.Count,
                                isMainRow: true, cost: StartMoney[0], finalCostMain:markForList1.Sum(x=>x.FinalCost)
                            )
                        );
                        break;
                    case 1:
                        ExpertResultMarksList1.Insert(indexList[i],
                            new ItemSet<double>
                            (
                                ExpertMarksList1[indexList[i]].Description,
                                Math.Round(markForList2.Sum(x => x.K1) / markForList2.Count / ExpertMarksList1[indexList[i]].K1, 2),
                                Math.Round(markForList2.Sum(x => x.K2) / markForList2.Count / ExpertMarksList1[indexList[i]].K2, 2),
                                Math.Round(markForList2.Sum(x => x.K3) / markForList2.Count / ExpertMarksList1[indexList[i]].K3, 2),
                                Math.Round(markForList2.Sum(x => x.K4) / markForList2.Count / ExpertMarksList1[indexList[i]].K4, 2),
                                Math.Round(markForList2.Sum(x => x.K5) / markForList2.Count / ExpertMarksList1[indexList[i]].K5, 2),
                                Math.Round(markForList2.Sum(x => x.K6) / markForList2.Count / ExpertMarksList1[indexList[i]].K6, 2),
                                Math.Round(markForList2.Sum(x => x.K7) / markForList2.Count / ExpertMarksList1[indexList[i]].K7, 2),
                                Math.Round(markForList2.Sum(x => x.K8) / markForList2.Count / ExpertMarksList1[indexList[i]].K8, 2),
                                Math.Round(markForList2.Sum(x => x.K9) / markForList2.Count / ExpertMarksList1[indexList[i]].K9, 2),
                                Math.Round(markForList2.Sum(x => x.K10) / markForList2.Count / ExpertMarksList1[indexList[i]].K10, 2),
                                markForList2.Sum(x => x.Probability) / markForList2.Count,
                                isMainRow: true, cost:StartMoney[1], finalCostMain: markForList2.Sum(x => x.FinalCost)
                            )
                        );
                        break;
                    case 2:
                        ExpertResultMarksList1.Insert(indexList[i],
                            new ItemSet<double>
                            (
                                ExpertMarksList1[indexList[i]].Description,
                                Math.Round(markForList3.Sum(x => x.K1) / markForList3.Count / ExpertMarksList1[indexList[i]].K1, 2),
                                Math.Round(markForList3.Sum(x => x.K2) / markForList3.Count / ExpertMarksList1[indexList[i]].K2, 2),
                                Math.Round(markForList3.Sum(x => x.K3) / markForList3.Count / ExpertMarksList1[indexList[i]].K3, 2),
                                Math.Round(markForList3.Sum(x => x.K4) / markForList3.Count / ExpertMarksList1[indexList[i]].K4, 2),
                                Math.Round(markForList3.Sum(x => x.K5) / markForList3.Count / ExpertMarksList1[indexList[i]].K5, 2),
                                Math.Round(markForList3.Sum(x => x.K6) / markForList3.Count / ExpertMarksList1[indexList[i]].K6, 2),
                                Math.Round(markForList3.Sum(x => x.K7) / markForList3.Count / ExpertMarksList1[indexList[i]].K7, 2),
                                Math.Round(markForList3.Sum(x => x.K8) / markForList3.Count / ExpertMarksList1[indexList[i]].K8, 2),
                                Math.Round(markForList3.Sum(x => x.K9) / markForList3.Count / ExpertMarksList1[indexList[i]].K9, 2),
                                Math.Round(markForList3.Sum(x => x.K10) / markForList3.Count / ExpertMarksList1[indexList[i]].K10, 2),
                                markForList3.Sum(x => x.Probability) / markForList3.Count,
                                isMainRow: true, cost: StartMoney[2], finalCostMain: markForList3.Sum(x => x.FinalCost)
                            )
                        );
                        break;
                    case 3:
                        ExpertResultMarksList1.Insert(indexList[i],
                            new ItemSet<double>
                            (
                                ExpertMarksList1[indexList[i]].Description,
                                Math.Round(markForList4.Sum(x => x.K1) / markForList4.Count / ExpertMarksList1[indexList[i]].K1, 2),
                                Math.Round(markForList4.Sum(x => x.K2) / markForList4.Count / ExpertMarksList1[indexList[i]].K2, 2),
                                Math.Round(markForList4.Sum(x => x.K3) / markForList4.Count / ExpertMarksList1[indexList[i]].K3, 2),
                                Math.Round(markForList4.Sum(x => x.K4) / markForList4.Count / ExpertMarksList1[indexList[i]].K4, 2),
                                Math.Round(markForList4.Sum(x => x.K5) / markForList4.Count / ExpertMarksList1[indexList[i]].K5, 2),
                                Math.Round(markForList4.Sum(x => x.K6) / markForList4.Count / ExpertMarksList1[indexList[i]].K6, 2),
                                Math.Round(markForList4.Sum(x => x.K7) / markForList4.Count / ExpertMarksList1[indexList[i]].K7, 2),
                                Math.Round(markForList4.Sum(x => x.K8) / markForList4.Count / ExpertMarksList1[indexList[i]].K8, 2),
                                Math.Round(markForList4.Sum(x => x.K9) / markForList4.Count / ExpertMarksList1[indexList[i]].K9, 2),
                                Math.Round(markForList4.Sum(x => x.K10) / markForList4.Count / ExpertMarksList1[indexList[i]].K10, 2),
                                markForList4.Sum(x => x.Probability) / markForList4.Count,
                                isMainRow: true, cost: StartMoney[3], finalCostMain: markForList4.Sum(x => x.FinalCost)
                            )
                        );
                        break;
                }
            }
            
            Analyze2ResultView analyze2ResultView = new Analyze2ResultView(ExpertResultMarksList1, StartMoney);
            analyze2ResultView.Show();
        }
        
        public ICommand AnalyzeOpenCostResultCommand { get; set; }
                
        private ObservableCollection<ItemSet<double>> _expertCoeffListForCost;

        public ObservableCollection<ItemSet<double>> ExpertCoeffListForCost
        {
            get => _expertCoeffListForCost;
            set => SetProperty(ref _expertCoeffListForCost, value);
        }

        public ObservableCollection<ItemSet<double>> ExpertMarksList1 { get; set; }
        public ObservableCollection<ItemSet<double>> ExpertResultMarksList1 { get; set; }

        public ObservableCollection<RiskCost> StartMoney { get; set; }
    }
}
