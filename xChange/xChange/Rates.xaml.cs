using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net;
using System.ComponentModel;
using Xamarin.Forms.PlatformConfiguration;
using System.Net.Http;
using System.Globalization;

namespace xChange
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class CurrencyExchangeItem
    {
        public string Country { get; set; }
        public string NumCode { get; set; }
        public string AlphaCode { get; set; }
        public string Units { get; set; }
        public string Buy { get; set; }
        public string Middle { get; set; }
        public string Sell { get; set; }
    }

    public class RatesList{
        public List<CurrencyExchangeItem> CurrencyExchangeItems { get; set; }
    }
    public partial class Rates : ContentPage
    {
        public async Task DisplayData()
        {
            DateTime dateTime = DateTime.Today;
            DateTime dateTimeNow = DateTime.Now;
            var day = dateTime.Day.ToString();
            var month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(dateTime.Month).ToString();
            var year = dateTime.Year.ToString();
            var link = "https://www.cbbh.ba/CurrencyExchange/GetJson?date=" + month + "%2F" + day + "%2F" + year + "%2000%3A00%3A00";
           
            var uri = new Uri(link);
            HttpClient myClient = new HttpClient();
            string json = string.Empty;
            var response = await myClient.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                json = await response.Content.ReadAsStringAsync();
                string jsonFileName = "exchangeRates.json";
                RatesList Rates = new RatesList();
                var assembly = typeof(Rates).GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    json = await response.Content.ReadAsStringAsync();
                    json = json.Substring(0, json.Length - 70);
                    json = json.Insert(json.Length, "}");
                    Rates = JsonConvert.DeserializeObject<RatesList>(json);
                }
                listRates.ItemsSource = Rates.CurrencyExchangeItems;
                dateaccesed.Text = dateTimeNow.ToString();
            }
            else
            {
                string jsonFileName = "exchangeRates.json";
                RatesList Rates = new RatesList();
                var assembly = typeof(MainPage).GetTypeInfo().Assembly;
                Stream stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.{jsonFileName}");
                using (var reader = new System.IO.StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                    json = json.Substring(0, json.Length - 70);
                    json = json.Insert(json.Length, "}");
                    Rates = JsonConvert.DeserializeObject<RatesList>(json);
                }
                listRates.ItemsSource = Rates.CurrencyExchangeItems;
                dateaccesed.Text = dateTimeNow.ToString();
            }


        }
        async void call()
        {
            await (DisplayData());
        }

        public Rates()
        {
            InitializeComponent();
            
            call();
            
        }
       
    }
}