using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAndroid
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : TabbedPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

        private void AddNew_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Feedback());
        }
    }
}