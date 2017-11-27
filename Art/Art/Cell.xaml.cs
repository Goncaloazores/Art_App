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
        public string titulo { get; set; }
        public DateTime data_fim { get; set; }
        public double valor { get; set; }
        public string image { get; set; }


        public Cell (InfoLeilao leilota)
        {


            this.ID = leilota.ID;
			InitializeComponent ();
            lblTitle.Text = leilota.titulo;
            this.titulo = leilota.titulo;
            this.valor = leilota.valor;
            timer = leilota.data_fim;
            this.data_fim = leilota.data_fim;
            endDate = leilota.data_fim;

            //Image.Source = leilota.image;
            //image = leilota.image;
           


        }

        
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            var imageSender = (Image)sender;
            // Do something
            Navigation.PushAsync(new Detalhes_leilao(this.ID));

        }

        //Timer


        public void actualizaLabel()
        {
            this.lblDate.Text = timer.AddSeconds(-1).ToString();
       }


        

    }
}