using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Art
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cell : ContentView
	{
        int secs = 0;
        DateTime endDate;
        DateTime timer;
        public int ID { get; set; }
        
        public Cell (leilao leilota)
        {


            this.ID = leilota.ID;
			InitializeComponent ();
            lblTitle.Text = leilota.titulo;
            timer = leilota.data_fim;
            endDate = leilota.data_fim;
            Image.Source = leilota.image;
            btnRedirect.Clicked += redirect_Clicked;


        }

        private void redirect_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1(this.ID));
        }

        //Timer


        public void actualizaLabel()
        {
            this.lblDate.Text = timer.AddSeconds(-1).ToString();
       }
    }
}