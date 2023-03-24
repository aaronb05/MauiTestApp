using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;

namespace MauiTestApp.ViewModel
{

    public partial class BaseVM : ObservableObject
    {

        public BaseVM()
        {
           
        }

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotBusy))]
        bool isBusy;

        [ObservableProperty]
        string title;

        public bool IsNotBusy => !IsBusy;   

    }
}
