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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String texto = enResposta.Text;
            if (string.IsNullOrEmpty(texto))
            {
                return; // Não faz nada se o texto estiver vazio ou null
            }

            if (texto.ToUpper() == "PIANO")
            {
                Navigation.PushAsync(new Page3());
            }
            else
            {
                DisplayAlert("A Esfinge fala:", "Seus miolos são apetitosos. Vou devora-los", "OK");
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}