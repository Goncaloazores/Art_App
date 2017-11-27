
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Art
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Leilao : ContentPage
    {
        Timer myTimer;
        static Grid myGrid;
        Stack<InfoLeilao> myData = new Stack<InfoLeilao>();


        public Leilao()
        {
            InitializeComponent();

            myGrid = grid;
            //grid.RowDefinitions = new RowDefinitionCollection();
            //grid.ColumnDefinitions = new ColumnDefinitionCollection();

            //for (int MyCount = 0; MyCount < 5; MyCount++)
            //{

            //    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //}
            Cell cell = null;
           



            #region API
            //cenas da api
            Iniciar();


            //for (int i = 50; i > 0; i--)
            //{

            //    //l = new leilao((i * col + j), (i * col + j).ToString(), i, j);

            //    myData.Push(new leilao());

            //}
            

            int col = 3;
            int row = myData.Count() / col + 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (i * col + j <= 49)
                    {

                        myGrid.Children.Add(new Cell(myData.Pop()), j, i);


                    }
                }
            }
            #endregion

            #region GRID

            #endregion

            //evento

            //void btnDirectory_Clicked(object sender, EventArgs e)
            //{

            //    Navigation.PushAsync(new Page1(((leilao)sender).ID));
            //}
            //myTimer = new Timer(TimerCallback, null, 0, 1000);

        }

        private async void Iniciar()
        {
            try
            {
                var leiloes = new HttpClient();

                leiloes.DefaultRequestHeaders.Add("token", "Done"); //consegue me dizer se a ligação é segura ou não

                leiloes.BaseAddress = new Uri("http://localhost:49642/"); //endreço web

                var resp = await leiloes.GetAsync("api/Auction/"); // -> api/VitirineProd/Get

                if (resp.IsSuccessStatusCode)
                {
                    var respStr = await resp.Content.ReadAsStringAsync();

                    var l = JsonConvert.DeserializeObject<List<InfoLeilao>>(respStr);

                    foreach (InfoLeilao item in l)
                    {
                        this.myData.Push(new InfoLeilao()
                        {
                            ID = item.ID,
                            titulo = item.titulo,
                            data_fim = item.data_fim,
                            valor = item.valor,
                            
                        });
                    }
                }
            }


            catch (Exception ex)
            {
                await this.DisplayAlert("Aviso", ex.Message, "ok");

            }



            //static void TimerCallback(Object o)
            // {
            //     foreach (Cell item in myGrid.Children)

            //     {

            //         item.actualizaLabel();


            //     }


            // }



        }
     
    }
    public class InfoLeilao
    {
        public int ID { get; set; }
        public int ID_Obra { get; set; }
        public int ID_Estado { get; set; }
        public string titulo { get; set; }
        public DateTime data_fim { get; set; }
        public double valor { get; set; }
        public Image image { get; set; }

    }
}