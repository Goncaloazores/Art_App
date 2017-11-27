using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Art
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class History : ContentPage
	{
        List<String> leiloes = new List<String>
        {
            "Leilao 1", "Leilao 2"
        };

        public History ()
		{
			InitializeComponent ();

            historylist.ItemsSource = leiloes;

            if (Device.RuntimePlatform == Device.Android)
            {
                //Fixes an android bug where the search bar would be hidden
                SearchBar.HeightRequest = 40.0;
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var texto = SearchBar.Text;
            historylist.ItemsSource = leiloes.Where(
                  x => x.ToLower().Contains(texto.ToLower()));
        }

}
}