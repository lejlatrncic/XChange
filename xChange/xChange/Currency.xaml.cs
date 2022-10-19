using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xChange
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Currency : ContentPage
    {
        public Currency()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            naslov.Text = "Top 10: World's Most Traded Currencies";
            slika1.Source = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/23px-Flag_of_the_United_States.svg.png";
            ter1.Text ="Unites States";
            cur1.Text ="US Dollar";
            sym1.Text ="$";
            cod1.Text ="USD";
            slika2.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Flag_of_Europe.svg/125px-Flag_of_Europe.svg.png";
            ter2.Text ="European Union";
            cur2.Text ="Euro";
            sym2.Text ="€";
            cod2.Text ="EUR";
            slika3.Source = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9e/Flag_of_Japan.svg/23px-Flag_of_Japan.svg.png";
            ter3.Text ="Japan";
            cur3.Text ="Yen";
            sym3.Text = "¥";
            cod3.Text ="JPY";
            slika4.Source = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/23px-Flag_of_the_United_Kingdom.svg.png";
            ter4.Text ="United Kingdom";
            cur4.Text = "Pound Sterling";
            sym4.Text = "£";
            cod4.Text ="GBP";
            slika5.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/88/Flag_of_Australia_%28converted%29.svg/23px-Flag_of_Australia_%28converted%29.svg.png";
            ter5.Text ="Australia";
            cur5.Text ="AU Dollar";
            sym5.Text ="$";
            cod5.Text ="AUD";
            slika6.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d9/Flag_of_Canada_%28Pantone%29.svg/23px-Flag_of_Canada_%28Pantone%29.svg.png";
            ter6.Text ="Canada";
            cur6.Text ="CA Dollar";
            sym6.Text ="$";
            cod6.Text ="CAD";
            slika7.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/16px-Flag_of_Switzerland.svg.png";
            ter7.Text = "Switzerland";
            cur7.Text ="Franc";
            sym7.Text ="Fr.";
            cod7.Text ="CHF";
            slika8.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fa/Flag_of_the_People%27s_Republic_of_China.svg/23px-Flag_of_the_People%27s_Republic_of_China.svg.png";
            ter8.Text ="China";
            cur8.Text ="Yuan";
            sym8.Text = "¥";
            cod8.Text ="CNY";
            slika9.Source = "https://upload.wikimedia.org/wikipedia/en/thumb/4/4c/Flag_of_Sweden.svg/23px-Flag_of_Sweden.svg.png";
            ter9.Text ="Sweden";
            cur9.Text ="Krona";
            sym9.Text ="kr";
            cod9.Text ="SEK";
            slika10.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Flag_of_New_Zealand.svg/23px-Flag_of_New_Zealand.svg.png";
            ter10.Text ="New Zealand";
            cur10.Text ="NZ Dollar";
            sym10.Text ="$";
            cod10.Text ="NZD";
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            naslov.Text = "Top 10: The Highest World Currency";
            slika1.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/aa/Flag_of_Kuwait.svg/23px-Flag_of_Kuwait.svg.png";
            ter1.Text ="Kuwait";
            cur1.Text ="Kuwaiti dinar";
            sym1.Text = "د.ك";
            cod1.Text ="KWD";
            slika2.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2c/Flag_of_Bahrain.svg/23px-Flag_of_Bahrain.svg.png";
            ter2.Text ="Bahrain";
            cur2.Text = "Bahraini dinar";
            sym2.Text = ".د.ب";
            cod2.Text ="BHD";
            slika3.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Flag_of_Oman.svg/23px-Flag_of_Oman.svg.png";
            ter3.Text ="Oman";
            cur3.Text = "Omani rial";
            sym3.Text = "ر.ع.";
            cod3.Text ="OMR";
            slika4.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c0/Flag_of_Jordan.svg/23px-Flag_of_Jordan.svg.png";
            ter4.Text ="Jordan";
            cur4.Text = "Jordanian dinar";
            sym4.Text = "د.ا";
            cod4.Text ="JOD";
            slika5.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Flag_of_Gibraltar.svg/23px-Flag_of_Gibraltar.svg.png";
            ter5.Text ="Gibraltar";
            cur5.Text = "Gibraltar pound";
            sym5.Text = "£";
            cod5.Text ="GIP";
            slika6.Source = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ae/Flag_of_the_United_Kingdom.svg/23px-Flag_of_the_United_Kingdom.svg.png";
            ter6.Text ="United Kingdom";
            cur6.Text = "Pound Sterling";
            sym6.Text ="$";
            cod6.Text ="GBP";
            slika7.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Flag_of_Europe.svg/125px-Flag_of_Europe.svg.png";
            ter7.Text ="European Union";
            cur7.Text ="Euro";
            sym7.Text ="€";
            cod7.Text ="EUR";
            slika8.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0f/Flag_of_the_Cayman_Islands.svg/23px-Flag_of_the_Cayman_Islands.svg.png";
            ter8.Text = "Cayman Islands";
            cur8.Text ="KY Dollar";
            sym8.Text ="$";
            cod8.Text ="KYD";
            slika9.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Flag_of_Switzerland.svg/16px-Flag_of_Switzerland.svg.png";
            ter9.Text ="Switzerland";
            cur9.Text ="Franc";
            sym9.Text ="Fr.";
            cod9.Text ="CHF";
            slika10.Source = "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/23px-Flag_of_the_United_States.svg.png";
            ter10.Text ="United States";
            cur10.Text ="US Dollar";
            sym10.Text ="$";
            cod10.Text ="USD";
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            naslov.Text = "Top 10:The Weakest World Currencies";
            slika1.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/06/Flag_of_Venezuela.svg/125px-Flag_of_Venezuela.svg.png";
            ter1.Text ="Venezuela";
            cur1.Text ="Soberano";
            sym1.Text ="BS.S";
            cod1.Text ="VES";
            slika2.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/ca/Flag_of_Iran.svg/23px-Flag_of_Iran.svg.png";
            ter2.Text ="Iran";
            cur2.Text ="Rial";
            sym2.Text = "﷼";
            cod2.Text ="IRR";
            slika3.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/21/Flag_of_Vietnam.svg/23px-Flag_of_Vietnam.svg.png";
            ter3.Text ="Vietnam";
            cur3.Text = "Đồng";
            sym3.Text = "₫";
            cod3.Text ="VND";
            slika4.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Flag_of_Indonesia.svg/23px-Flag_of_Indonesia.svg.png";
            ter4.Text ="Indonesia";
            cur4.Text ="Rupiah";
            sym4.Text ="Rp";
            cod4.Text ="IDR";
            slika5.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/84/Flag_of_Uzbekistan.svg/23px-Flag_of_Uzbekistan.svg.png";
            ter5.Text ="Uzbekistan";
            cur5.Text = "Soʻm";
            sym5.Text = "soʻm";
            cod5.Text ="UZS";
            slika6.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/ed/Flag_of_Guinea.svg/23px-Flag_of_Guinea.svg.png";
            ter6.Text ="Guinea";
            cur6.Text = "Guinean franc";
            sym6.Text ="Fr";
            cod6.Text ="GNF";
            slika7.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/Flag_of_Sierra_Leone.svg/23px-Flag_of_Sierra_Leone.svg.png";
            ter7.Text ="Sierra Leone";
            cur7.Text = "Leone";
            sym7.Text ="Le";
            cod7.Text ="SLL";
            slika8.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/56/Flag_of_Laos.svg/23px-Flag_of_Laos.svg.png";
            ter8.Text ="Laos";
            cur8.Text ="Lao kip";
            sym8.Text = "₭";
            cod8.Text ="LAK";
            slika9.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/27/Flag_of_Paraguay.svg/23px-Flag_of_Paraguay.svg.png";
            ter9.Text = "Paraguay";
            cur9.Text ="Guarani";
            sym9.Text = "₲";
            cod9.Text ="PYG";
            slika10.Source = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/Flag_of_Cambodia.svg/23px-Flag_of_Cambodia.svg.png";
            ter10.Text ="Cambodia";
            cur10.Text ="Riel";
            sym10.Text = "៛";
            cod10.Text ="KHR";
        }
    }
}