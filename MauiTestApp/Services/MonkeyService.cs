using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.Services
{
    public class MonkeyService
    {
        HttpClient httpClient;
        public MonkeyService()
        {
            httpClient = new HttpClient();
        }


        List<Monkey> monkeyList = new ();
        public async Task<List<Monkey>> GetMonkeys()
        {
            if (monkeyList?.Count > 0)            
                return monkeyList;

            var url = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/MonkeysApp/monkeydata.json";
            var response = await httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>> ();
            }
           

            return monkeyList;
        }
    }
}
