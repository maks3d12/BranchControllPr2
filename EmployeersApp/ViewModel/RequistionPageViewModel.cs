using EmployeersApp.ViewModel.MVVMHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeersApp.ViewModel
{
    internal class RequistionPageViewModel: BindingHelper
    {
        public BindableCommand AddCommand { get; set; }

    }
}
