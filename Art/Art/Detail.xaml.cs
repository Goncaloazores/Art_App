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
	public partial class Detail : TabbedPage
	{
        public Detail()
        {
            InitializeComponent();

            this.Children.Add(new Obras());
            this.Children.Add(new Obras());


        }
    }
}