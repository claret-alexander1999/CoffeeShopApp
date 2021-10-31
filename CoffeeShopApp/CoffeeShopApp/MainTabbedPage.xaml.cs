using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShopApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();
        }

        private async void EspressoButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EspressoPage());
        }

        private async void HotDrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HotDrinksPage());

        }

        private async void ColdDrinksButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ColdDrinksPage());

        }

        private async void QuickBitesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuickBitesPage());

        }
    }
}