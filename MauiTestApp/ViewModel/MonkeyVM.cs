using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiTestApp.Services;
using MauiTestApp.View;

namespace MauiTestApp.ViewModel
{
    public partial class MonkeyVM : BaseVM
    {
        MonkeyService monkeyService;

        public ObservableCollection<Monkey> Monkeys { get; } = new();

        public MonkeyVM(MonkeyService monkeyService)
        {
            Title = "Monkey Around With MAUI";
            this.monkeyService = monkeyService;
        }

        [ICommand]
        async Task GetMonkeysAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;

                var monkeys = await monkeyService.GetMonkeys();

                if (Monkeys.Count != 0)                
                    Monkeys.Clear();

                foreach(var monkey in monkeys)            
                    Monkeys.Add(monkey);              

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                await Shell.Current.DisplayAlert("Error!", $"Unable to get monkeys: {ex.Message}", "Ok");

            }
            finally
            {
                IsBusy = false;
            }
        }

        [ICommand]
        async Task GoToDetailsAsync(Monkey monkey)
        {
            if (monkey is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}", true, new Dictionary<String, object>
            {
                {"Monkey", monkey }
            });       
        }
    }
}
