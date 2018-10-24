using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;

namespace RiskFormalization.ViewModels
{
    public class MainWindowsViewModel: BindableBase
    {
        public MainWindowsViewModel()
        {
            ItemBaseViewModels = new ObservableCollection<BaseViewModel>();
            RiskIdentifyViewModel oneView = new RiskIdentifyViewModel();
            ItemBaseViewModels.Add(oneView);

            RiskIdentifyCommand = new DelegateCommand<object>(OnRiskIdentifyCommandExecute);
            RiskEventIdentifyCommand = new DelegateCommand<object>(OnRiskEventIdentifyCommandExecute);
            OpenPlanningCommand = new DelegateCommand<object>(OnOpenPlanningCommandExecute);
            Analyze1Command = new DelegateCommand<object>(OnAnalyze1CommandExecute);
            CostValueCommand = new DelegateCommand<object>(OnCostValueCommandExecute);
        }

        private void OnOpenPlanningCommandExecute(object obj)
        {
            PlanningViewModel planningViewModel = new PlanningViewModel();
            if (!ItemBaseViewModels.Any(x => x.Id == planningViewModel.Id))
            {
                ItemBaseViewModels.Add(planningViewModel);
                SelectedBaseViewModel = planningViewModel;
            }
            else
            {
                var firstOrDefault = ItemBaseViewModels.FirstOrDefault(x => x.Id == planningViewModel.Id);
                SelectedBaseViewModel = firstOrDefault;
            }
        }

        private void OnCostValueCommandExecute(object obj)
        {
            Analyze2ViewModel analyze2ViewModel = new Analyze2ViewModel();
            if (!ItemBaseViewModels.Any(x => x.Id == analyze2ViewModel.Id))
            {
                ItemBaseViewModels.Add(analyze2ViewModel);
                SelectedBaseViewModel = analyze2ViewModel;
            }
            else
            {
                var firstOrDefault = ItemBaseViewModels.FirstOrDefault(x => x.Id == analyze2ViewModel.Id);
                SelectedBaseViewModel = firstOrDefault;
            }
        }

        private void OnAnalyze1CommandExecute(object obj)
        {
            Analyze1ViewModel analyze1ViewModel = new Analyze1ViewModel();
            if (!ItemBaseViewModels.Any(x => x.Id == analyze1ViewModel.Id))
            {
                ItemBaseViewModels.Add(analyze1ViewModel);
                SelectedBaseViewModel = analyze1ViewModel;
            }
            else
            {
                var firstOrDefault = ItemBaseViewModels.FirstOrDefault(x => x.Id == analyze1ViewModel.Id);
                SelectedBaseViewModel = firstOrDefault;
            }
        }

        private void OnRiskIdentifyCommandExecute(object obj)
        {
            RiskIdentifyViewModel riskIdentifyViewModelView = new RiskIdentifyViewModel();
            if (!ItemBaseViewModels.Any(x => x.Id == riskIdentifyViewModelView.Id))
            {
                ItemBaseViewModels.Add(riskIdentifyViewModelView);
                SelectedBaseViewModel = riskIdentifyViewModelView;
            }
            else
            {
                var firstOrDefault = ItemBaseViewModels.FirstOrDefault(x => x.Id == riskIdentifyViewModelView.Id);
                SelectedBaseViewModel = firstOrDefault;
            }
        }

        private void OnRiskEventIdentifyCommandExecute(object obj)
        {
            RiskEventIdentifyViewModel riskEventIdentifyViewModel = new RiskEventIdentifyViewModel();
            if (!ItemBaseViewModels.Any(x=>x.Id == riskEventIdentifyViewModel.Id))
            {
                ItemBaseViewModels.Add(riskEventIdentifyViewModel);
                SelectedBaseViewModel = riskEventIdentifyViewModel;
            }
            else
            {
                var firstOrDefault = ItemBaseViewModels.FirstOrDefault(x => x.Id == riskEventIdentifyViewModel.Id);
                SelectedBaseViewModel = firstOrDefault;
            }
        }

        public void AddView(BaseViewModel viewModel)
        {
            ItemBaseViewModels.Add(viewModel);
            SelectedBaseViewModel = viewModel;
        }

        public ICommand RiskIdentifyCommand { get; set; }
        public ICommand RiskEventIdentifyCommand { get; set; }
        public ICommand Analyze1Command { get; set; }
        public ICommand CostValueCommand { get; set; }
        public ICommand OpenPlanningCommand { get; set; }


        public ObservableCollection<BaseViewModel> ItemBaseViewModels { get; set; }

        private BaseViewModel _selectedBaseViewModel;
        public BaseViewModel SelectedBaseViewModel
        {
            get => _selectedBaseViewModel;
            set => SetProperty(ref _selectedBaseViewModel, value);
        }
    }
}
