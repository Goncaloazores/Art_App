using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Art
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        Timer myTimer = new Timer(TimerCallback, null, 0, 1000);

        public Page1 (int id)

		{
          
			InitializeComponent ();

            lblTitle.Text = id.ToString();








            //1º) fazer pedido async ou não - pedido à API com os detalhes da Obra/Leilão/etc..
            //receber uma string json


            //myleilao = //resultado da api, a partir do id



            //2º) preencher a estrutura com a info do pedido
        }


        private static void TimerCallback(Object o)
        {
            
        }

    }
}