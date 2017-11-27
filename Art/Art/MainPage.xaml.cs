using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Art
{
	public partial class MainPage : MasterDetailPage
	{
      

		public MainPage()
		{
			InitializeComponent();



            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());


            App.MasterDetail = this;

            TabbedPage mytab = new TabbedPage
            {
                 
                Children =
                {
                    
                    new Leilao(),
                    new Compra()
                }
            };

            //this.Detail = mytab;
        }
	}
}
