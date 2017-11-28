using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms.Platform.Android;

namespace Art
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalhes_leilao : ContentPage
	{
        Timer myTimer = new Timer(TimerCallback, null, 0, 1000);

        //public string titulo { get; set; }
        //public double valor { get; set; }
        //public DateTime data_fim { get; set; }
        //public Image image { get; set; }

        public Detalhes_leilao(int ID, string titulo, double valor, DateTime data_fim, string image)

        {

            InitializeComponent();
           


            AbsoluteLayout peakLayout = new AbsoluteLayout { HeightRequest = 250, BackgroundColor = Color.Black };

            // Set Detail View Title

            var title = new Label
            {
                Text = titulo.ToString(),
                FontSize = 24,
                FontFamily = "Verdana",
                TextColor = Color.White,

            };
            //Set Detail View Title Description
            var price = new Label
            {
                Text = valor.ToString(),
                BackgroundColor = Color.Red.MultiplyAlpha(.25f),
                TextColor = Color.FromHex("#ddd"),
                FontFamily = "AvenirNextCondensed-Medium"
            };

            //Set data fim  no
            var data = new Label
            {
                FontSize = 15,
                Text = "Data Fim - " + data_fim,
                TextColor = Color.FromHex("#ddd"),
                FontFamily = "Tahoma"
            };

            
               


            // Set Detail View Title Image

            var imagem = new Image()
            {
                Source = null,
                Aspect = Aspect.AspectFill,
            };

            var overlay = new BoxView()
            {
                Color = Color.Black.MultiplyAlpha(.5f)
            };

            //Add controls into Layout
          

            AbsoluteLayout.SetLayoutFlags(imagem, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(imagem, new Rectangle(0f, 0f, 1f, 1f));

            AbsoluteLayout.SetLayoutFlags(title, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(title, new Rectangle(0.1, 0.80, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            AbsoluteLayout.SetLayoutFlags(price, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(price, new Rectangle(0.1, 0.92, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            AbsoluteLayout.SetLayoutFlags(data, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(data, new Rectangle(0.99, 0.90, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            //Add  all controls into Main Layout
            peakLayout.Children.Add(imagem);
            peakLayout.Children.Add(title);
            peakLayout.Children.Add(price);
            peakLayout.Children.Add(data);
            

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.FromHex("#333"),
                Children = { peakLayout}

            };

                     //lblTitle.Text = id.ToString();


    }

       



        //1º) fazer pedido async ou não - pedido à API com os detalhes da Obra/Leilão/etc..
        //receber uma string json


        //private async void Iniciar(int id)
        //    {
        //        try
        //        {
        //            var leiloes = new HttpClient();

        //            leiloes.DefaultRequestHeaders.Add("token", "Done"); //consegue me dizer se a ligação é segura ou não

        //            leiloes.BaseAddress = new Uri("http://localhost:49642/"); //endreço web

        //            var resp = await leiloes.GetAsync("api/Auction/" + id.ToString()); // -> api/VitirineProd/Get

        //                if (resp.IsSuccessStatusCode)
        //                {
        //                     var respStr = await resp.Content.ReadAsStringAsync();

        //                    var l = JsonConvert.DeserializeObject<InfoLeilao>(respStr);
        //                     this.titulo = l.titulo;
        //                     this.valor = l.valor;
        //                     this.data_fim = l.data_fim;
        //                     this.image = l.image;
                            
        //                }
                       
        //            }
                    

        //     catch (Exception ex)
        //         {
        //            await this.DisplayAlert("Aviso", ex.Message, "ok");
                    
        //         }
            



        //    }




        //    //myleilao = //resultado da api, a partir do id



        //    //2º) preencher a estrutura com a info do pedido

        //    public class InfoLeilao
        //    {
        //        public int ID { get; set; }
        //        public int ID_Obra { get; set; }
        //        public int ID_Estado { get; set; }
        //        public string titulo { get; set; }
        //        public DateTime data_fim { get; set; }
        //        public double valor { get; set; }
        //        public Image image { get; set; }

        //    }
        


        private static void TimerCallback(Object o)
        {
            
        }

    }
}