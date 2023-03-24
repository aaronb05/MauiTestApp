using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.ViewModel
{

    [QueryProperty("Monkey", "Monkey")]
    public partial class MonkeyDetailsVM : BaseVM
    {
        public MonkeyDetailsVM()
        {
              

        }


        [ObservableProperty]
        Monkey monkey;


        [ICommand]
        async Task GoBackAsync()
        {
            await Shell.Current.GoToAsync("..");

        }
    }
}
