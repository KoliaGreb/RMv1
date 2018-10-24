using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace RiskFormalization.ViewModels
{
    public class BaseViewModel: BindableBase
    {
        public string Header { get; set; }
        public int Id { get; set; }
    }
}
