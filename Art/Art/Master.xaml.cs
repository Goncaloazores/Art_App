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
	public partial class Master : ContentPage
    {
       
        
        public Master()
        {
            InitializeComponent();


            MylistView.ItemsSource = new List<string>
            {
                "History",
                "Log out"
            };

            


        }



        private async Task MylistView_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            var listView = sender as ListView;

            if (e.SelectedItem == null)
            {

                return;

            }
            var item = e.SelectedItem;

            switch (item)
            {
                case  "History":
                    await App.NavigateMasterDetail(new History());
                    break;

            }

            listView.SelectedItem = null;
        }
    }
   }
