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
	public partial class Obras : ContentPage
	{
        Timer myTimer;
        static Grid myGrid;

        public Obras ()
		{
			InitializeComponent ();
            
            myGrid = grid;
            //grid.RowDefinitions = new RowDefinitionCollection();
            //grid.ColumnDefinitions = new ColumnDefinitionCollection();

            //for (int MyCount = 0; MyCount < 5; MyCount++)
            //{

            //    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            //    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            //}
            Cell cell = null;
            var myData = new Stack<leilao>();

            #region API
            //cenas da api


            for (int i = 50; i > 0; i--)
            {

                //l = new leilao((i * col + j), (i * col + j).ToString(), i, j);

                myData.Push(new leilao());

            }

            
            int col = 3;
            int row = 50 / col + 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if(i * col + j <= 49)
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
            myTimer = new Timer(TimerCallback, null, 0, 1000);

        }
        static void TimerCallback(Object o)
        {
            foreach (Cell item in myGrid.Children)
               
            {
                
                item.actualizaLabel();
                
            }
            callInv();
            


        }
        public void callInv()
        {
            Invalidate();
        }


    }
}