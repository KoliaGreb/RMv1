using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using RiskFormalization.Models;

namespace RiskFormalization.ViewModels
{
    public class PlanningViewModel : BaseViewModel
    {
        public PlanningViewModel()
        {
            Header = "Планування ризиків";
            Id = 7;
            CollectionPlanningItems = new ObservableCollection<PlanningItems>()
            {
                new PlanningItems("попереднє навчання членів проектного колективу", false, false, false, false),
                new PlanningItems("узгодження детального переліку вимог до ПЗ із замовником", false, false, false, false),
                new PlanningItems("внесення узгодженого переліку вимог до ПЗ замовника в договір", false, false, false, false),
                new PlanningItems("точне слідування вимогам замовника з узгодженого переліку вимог до ПЗ", false, false, false, false),
                new PlanningItems("попередні дослідження ринку", false, false, false, false),
                new PlanningItems("експертна оцінка програмного проекту досвідченим стороннім консультантом", false, false, false, false),
                new PlanningItems("консультації досвідченого стороннього консультанта", false, false, false, false),
                new PlanningItems("тренінг з вивчення необхідних інструментів розроблення ПЗ", false, false, false, false),
                new PlanningItems("укладання договору страхування", false, false, false, false),
                new PlanningItems("використання 'шаблонних' рішень з вдалих попередніх проектів при управлінні програмним проектом", false, false, false, false),
                new PlanningItems("підготовка документів, які показують важливість даного проекту для досягнення фінансових цілей компанії-розробника", false, false, false, false),
                new PlanningItems("реорганізація роботи проектного колективу так, щоб обов'язки та робота членів колективу перекривали один одного", false, false, false, false),
                new PlanningItems("придбання (замовлення) частини компонент розроблюваного ПЗ", false, false, false, false),
                new PlanningItems("заміна потенційно дефектних компонент розроблюваного ПЗ придбаними компонентами, які гарантують якість виконання роботи", false, false, false, false),
                new PlanningItems("придбання більш продуктивної бази даних", false, false, false, false),
                new PlanningItems("використання генератора програмного коду", false, false, false, false),
                new PlanningItems("реорганізація роботи проектного колективу залежно від рівня труднощів виконання завдань та професійних рівнів розробників", false, false, false, false),
                new PlanningItems("повторне використання придатних компонент ПЗ, які були розроблені для інших програмних проектів", false, false, false, false),
                new PlanningItems("аналіз доцільності розроблення даного ПЗ", false, false, false, false),
            };
        }

        public ObservableCollection<PlanningItems> CollectionPlanningItems { get; set; }
    }
}
