using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAndroid.Model;

namespace XamarinAndroid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class History : ContentPage
	{
		public History ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection _con = new SQLiteConnection(App.DatabaseLocation))
            {
                _con.CreateTable<Posts>();
                var _p = _con.Table<Posts>().ToList();
                postsList.ItemsSource = _p;
            }
        }
    }
}