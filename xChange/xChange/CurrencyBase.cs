using Xamarin.Forms.Xaml;

namespace xChange
{
    [XamlCompilation(XamlCompilationOptions.Compile), XamlFilePath("Currency.xaml")]
    public class CurrencyBase
    {

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent()
        {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Currency));
        }
    }
}