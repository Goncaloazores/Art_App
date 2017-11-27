using Art.Models;
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
	public partial class Compra : ContentPage
	{
        static Grid grid_compra;

        public Compra ()
		{
			InitializeComponent ();

            grid_compra = mygrid;

            Cell_Compra cell_c = null;

            var my_data_compra = new Stack<compra>();
		}
	}
}