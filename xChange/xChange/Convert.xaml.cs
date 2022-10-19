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
    public partial class Convert : ContentPage
    {
        public Convert()
        {
            InitializeComponent();
        }
        
        private void unos_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue)) return;

            if (!double.TryParse(e.NewTextValue, out double value))
            {
                ((Entry)sender).Text = e.OldTextValue;
            }        
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double value;
                value = 0;               
                value = double.Parse(unos.Text);

                switch (picker.SelectedItem)
                {
                    case ("BAM"):
                        break;
                    case ("USD"):
                        value *= 1.553956;
                        break;
                    case ("CAD"):
                        value *= 1.385296;
                        break;
                    case ("AUD"):
                        value *= 1.293886;
                        break;
                    case ("AUS"):
                        value *= 1.553956;
                        break;
                    case ("CNY"):
                        value *= 0.262364;
                        break;
                    case ("CHF"):
                        value *= 1.850399;
                        break;
                    case ("CZK"):
                        value *= 0.079712;
                        break;
                    case ("DKK"):
                        value *= 0.271683;
                        break;
                    case ("EUR"):
                        value *= 1.955830;
                        break;
                    case ("GBP"):
                        value *= 2.395075;
                        break;
                    case ("HRK"):
                        value *= 0.26;
                        break;
                    case ("HUF"):
                        value *= 0.0056;
                        break;
                    case ("JPY"):
                        value *= 0.015;
                        break;
                    case ("NOK"):
                        value *= 0.201932;
                        break;
                    case ("SEK"):
                        value *= 0.203873;
                        break;
                    case ("RSD"):
                        value *= 0.017;
                        break;
                    case (null):
                        value = 0.00;
                        break;
                }

                switch (picker2.SelectedItem)
                {
                    case ("BAM"):
                        cur.Text = "The Bosnia and Herzegovina convertible mark is the currency of Bosnia and Herzegovina. It is divided into 100 Pfenigs or Fenings, and locally abbreviated KM.";
                        break;
                    case ("USD"):
                        value /= 1.553956;
                        cur.Text = "The United States dollar is the official currency of the United States and its territories per the Coinage Act of 1792.";
                        break;
                    case ("CAD"):
                        value /= 1.385296;
                        cur.Text = "The Canadian dollar is the currency of Canada. It is abbreviated with the dollar sign $, or sometimes CA$, Can$ or C$. It is divided into 100 cents";
                        break;
                    case ("AUD"):
                        value /= 1.293886;
                        cur.Text = "The Australian dollar (sign: $; code: AUD) is the currency of Australia, including its external territories: Christmas Island, Cocos Islands, and Norfolk Island.";
                        break;                 
                    case ("CNY"):
                        value /= 0.262364;
                        cur.Text = "The yuan is the basic unit of the renminbi, but the word is also used to refer to the Chinese currency generally, especially in international contexts.";
                        break;
                    case ("CHF"):
                        value /= 1.850399;
                        cur.Text = "The Swiss franc is the currency and legal tender of Switzerland and Liechtenstein. It is also legal tender in the Italian exclave of Campione d'Italia.";
                        break;
                    case ("CZK"):
                        value /= 0.079712;
                        cur.Text = "The koruna is the currency of the Czech Republic since 1993. Czech Republic is legally bound to adopt the euro currency in the future.";
                        break;
                    case ("DKK"):
                        value /= 0.271683;
                        cur.Text = "The krone is the official currency of Denmark, Greenland, and the Faroe Islands, introduced on 1 January 1875.";
                        break;
                    case ("EUR"):
                        value /= 1.955830;
                        cur.Text = "The euro is the official currency of 19 of the 27 member states of the European Union. The euro is divided into 100 cents.";
                        break;
                    case ("GBP"):
                        value /= 2.395075;
                        cur.Text = "The pound sterling is the official currency of the United Kingdom, Jersey, Guernsey, the Isle of Man, Gibraltar, South Georgia and the South Sandwich Islands.";
                        break;
                    case ("HRK"):
                        value /= 0.26;
                        cur.Text = "The kuna is the currency of Croatia, in use since 1994. It is subdivided into 100 lipa. The kuna is convertible and is considered a stable currency.";
                        break;
                    case ("HUF"):
                        value /= 0.0056;
                        cur.Text = "The forint is the currency of Hungary. It was formerly divided into 100 fillér, but fillér coins are no longer in circulation.";
                        break;
                    case ("JPY"):
                        value /= 0.015;
                        cur.Text = "The yen is the official currency of Japan. It is the third most traded currency in the foreign exchange market after the United States dollar and the Euro.";
                        break;
                    case ("NOK"):
                        value /= 0.201932;
                        cur.Text = "The krone is the currency of Norway and its dependent territories. It is subdivided into 100 øre, which have existed only electronically since 2012.";
                        break;
                    case ("SEK"):
                        value /= 0.203873;
                        cur.Text = "The Swedish krona is sometimes referred to as the Swedish crown, as krona literally means crown in Swedish.";
                        break;
                    case ("RSD"):
                        value /= 0.017;
                        cur.Text = "The Serbian dinar is the official currency of Serbia. The Serbian dinar replaced the Yugoslav dinar in 2003";
                        break;
                    case (null):
                        value = 0.00;
                        break;
                }
                value = Math.Round(value, 2, MidpointRounding.AwayFromZero); 
                result.Text = value.ToString();
                res.Text = unos.Text + " " + picker.SelectedItem + 
                    " = " + value + " " + picker2.SelectedItem;
            }
            catch (Exception)
            {

            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            unos.Text = string.Empty;
            picker.SelectedIndex = -1;
            picker2.SelectedIndex = -1;
            result.Text = "0";
            cur.Text = "";
            res.Text = "";
        }

       
    }
}