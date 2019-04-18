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
	public partial class Feedback : ContentPage
	{
		public Feedback ()
		{
			InitializeComponent ();
		}

        private void AddFeedback_Clicked(object sender, EventArgs e)
        {
            Posts _post = new Posts
            {
                Experience = userFeedback.Text
            };
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation))
            {
                connection.CreateTable<Posts>();
                connection.Insert(_post);
            }
            Navigation.PushAsync(new History());
        }
    }
}