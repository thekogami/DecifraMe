using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DecifraMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String texto = enResposta.Text;
            if(texto.ToUpper() == "SILENCIO")
            {
                Navigation.PushAsync(new Page2());
            }
            else
            {
                DisplayAlert("A Esfinge fala:", "seus miolos são apetitosos. Vou devora-los", "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}